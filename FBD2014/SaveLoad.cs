using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FBD2014
{
   public class SaveLoad
    {
       public static bool SaveXml(object obj, string filename)
       {
           bool result = false;
           using (StreamWriter writer = new StreamWriter(filename))
           {
               //try
               {
                   XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                   ns.Add("", "");
                   System.Windows.Forms.MessageBox.Show(obj.GetType().ToString()) ;
                   XmlSerializer serializer = new XmlSerializer(typeof(FBD2014.Model.BlockModel));
                  // serializer.Serialize(writer, obj, ns);
                  // result = true;
               }
               //catch (Exception e)
               {
                   // Логирование
                  // System.Windows.Forms.MessageBox.Show(e.Message);
               }
               //finally
               {
                   //writer.Close();
               }
           }
           return result;
       }

       public static object LoadXml(Type type, string filename)
       {
           object result = null;
           using (StreamReader reader = new StreamReader(filename))
           {
               try
               {
                   XmlSerializer serializer = new XmlSerializer(type);
                   result = serializer.Deserialize(reader);
               }
               catch (Exception e)
               {
                   System.Windows.Forms.MessageBox.Show(e.Message);
               }
               finally
               {
                   reader.Close();
               }
           }
           return result;
       }
    }
}
