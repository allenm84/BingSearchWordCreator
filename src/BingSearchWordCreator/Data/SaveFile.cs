using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

namespace BingSearchWordCreator
{
  [DataContract(Name = "SaveFile", Namespace = SaveFile.Namespace)]
  public sealed class SaveFile : IExtensibleDataObject
  {
    public const string Namespace = "http://mapainc.com/programs/paige/bingSearchWordCreator";

    static object syncRoot = new object();
    static SaveFile instance = new SaveFile();
    public static SaveFile Instance { get { lock (syncRoot) { return instance; } } }

    static string filepath;
    static DataContractSerializer serializer;

    static SaveFile()
    {
      serializer = new DataContractSerializer(typeof(SaveFile));
      filepath = Path.Combine(Application.StartupPath, "saved.xml");
    }

    public static void Reset()
    {
      instance = new SaveFile();
      instance.Initialize();
    }

    public static void Load()
    {
      SaveFile other = null;
      if (File.Exists(filepath))
      {
        using (Stream stream = File.OpenRead(filepath))
        {
          other = serializer.ReadObject(stream) as SaveFile;
        }
      }
      instance.Initialize(other);
    }

    public static void Save()
    {
      lock (syncRoot)
      {
        using (Stream stream = File.Create(filepath))
        {
          serializer.WriteObject(stream, instance);
        }
      }
    }

    private SaveFile() { }

    private void Initialize()
    {
      Initialize(null);
    }

    private void Initialize(SaveFile other)
    {
      var type = instance.GetType();
      var properties = type.GetProperties();
      foreach (var property in properties)
      {
        if (property.HasAttribute(typeof(DataMemberAttribute)))
        {
          var oType = property.PropertyType;
          object value = null;

          if (oType == typeof(string)) { value = ""; }
          else { value = Activator.CreateInstance(property.PropertyType); }

          if (other != null)
          {
            var otherValue = property.GetValue(other, null);
            value = otherValue ?? value;
          }

          property.SetValue(instance, value, null);
        }
      }
    }

    public ExtensionDataObject ExtensionData { get; set; }

    [DataMember]
    public int Count { get; set; }
  }
}
