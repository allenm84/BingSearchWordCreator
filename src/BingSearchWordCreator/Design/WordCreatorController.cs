using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.Common.References;

namespace BingSearchWordCreator
{
  public class WordCreatorController
  {
    private class Working : IDisposable
    {
      private WordCreatorController controller;
      public Working(WordCreatorController controller)
      {
        this.controller = controller;
        controller.SetIsWorking(true);
      }

      void IDisposable.Dispose()
      {
        controller.SetIsWorking(false);
        controller = null;
      }
    }

    private List<string> words;
    private List<string> generated = new List<string>();
    private int currentIndex = -1;
    private IWordCreatorView mView;

    public WordCreatorController(IWordCreatorView view)
    {
      mView = view;
      mView.Load += new EventHandler(mView_Load);
      mView.Generate.Click += new EventHandler(Generate_Click);
      mView.Next.Click += new EventHandler(Next_Click);
      mView.Previous.Click += new EventHandler(Previous_Click);
    }

    private void SetIsWorking(bool working)
    {
      mView.IndicateWaiting(working);
      mView.AllowUserInput = !working;
    }

    private void UpdateButtons()
    {
      mView.Generate.Enabled = words.Count > 0;
      mView.Next.Enabled = generated.Count > 0 && currentIndex < generated.Count - 1;
      mView.Previous.Enabled = generated.Count > 0 && currentIndex > 0;
    }

    private void UpdateIndex(int dIndex)
    {
      currentIndex += dIndex;
      UpdateDisplay();
      UpdateButtons();
    }

    private void UpdateDisplay()
    {
      var word = generated[currentIndex];
      mView.Count.Text = string.Format("{0} out of {1}", currentIndex + 1, generated.Count);
      mView.Result.Text = word;

      try{ System.Windows.Forms.Clipboard.SetText(word); }
      catch { }
    }

    private void StartLoad()
    {
      LoadDictionary();
    }

    private async void LoadDictionary()
    {
      using (new Working(this))
      {
        await Task.Run(() =>
        {
          mView.AddStatus("Loading dictionary");

          var path = Path.Combine(Dropbox.Location, @"Downloads\Dictionaries\big2Dict.xml");
          var dcs = new DataContractSerializer(typeof(Dictionary<string, int>));
          using (Stream stream = File.OpenRead(path))
          {
            var dict = dcs.ReadObject(stream) as Dictionary<string, int>;
            words = dict.Select(kvp => kvp.Key).OrderBy(s => s).ToList();

            dict.Clear();
            dict = null;
          }

          SaveFile.Load();
          if (SaveFile.Instance.Count == 0)
            SaveFile.Instance.Count = 20;
        });
      }

      mView.Words.Value = SaveFile.Instance.Count;
      mView.AddStatus(string.Format("Load complete; Loaded {0} words", words.Count));
      UpdateButtons();
    }

    private void StartGenerate()
    {
      SaveFile.Instance.Count = (int)mView.Words.Value;
      GenerateWords();
    }

    private async void GenerateWords()
    {
      List<string> selected = new List<string>();
      using (new Working(this))
      {
        await Task.Run(() =>
        {
          int count = SaveFile.Instance.Count, i = 0;
          mView.AddStatus(string.Format("Generating {0} words...", count));

          Random random = new Random(Environment.TickCount);
          HashSet<int> visited = new HashSet<int>();

          while (selected.Count < count)
          {
            i = random.Next(words.Count);
            if (visited.Add(i))
            {
              selected.Add(words[i]);
            }
          }

          SaveFile.Save();
        });
      }

      mView.AddStatus("Generate complete");

      generated.Clear();
      generated.AddRange(selected);

      currentIndex = 0;
      UpdateIndex(0);
    }

    private void mView_Load(object sender, EventArgs e)
    {
      StartLoad();
    }

    private void Previous_Click(object sender, EventArgs e)
    {
      UpdateIndex(-1);
    }

    private void Next_Click(object sender, EventArgs e)
    {
      UpdateIndex(1);
    }

    private void Generate_Click(object sender, EventArgs e)
    {
      StartGenerate();
    }
  }
}
