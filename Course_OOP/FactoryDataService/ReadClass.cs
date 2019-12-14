using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Xml.Serialization;

namespace Course_OOP
{
    class ReadClass : Read
    {
        public Object GetObject(Object obj)
        {
            Object objReturn = obj;
            Type type = ((object)obj).GetType();
            //Получаем название файла из объекта
            string str = ((object)obj).ToString();
            string strregex = System.Text.RegularExpressions.Regex.Match(str, @"\[(\S+)\]").Groups[1].Value;
            string filestr = strregex.Substring(strregex.IndexOf(".") + 1) + "s.xml";
            string filePath = Program.XMLfolder + filestr;
            FileInfo file = new FileInfo(filePath);
            long size = 0; if (File.Exists(filePath)) { size = file.Length; }
            if (size > 0)
            {
                XmlSerializer formatter = new XmlSerializer(type);
                FileStream fsL = new FileStream(filePath, FileMode.Open);
                objReturn = formatter.Deserialize(fsL); fsL.Close();
            }
            //If Performance then read Image
            if (type == typeof(List<Perfomance>))
            {
                List<Perfomance> perf = new List<Perfomance>();
                perf =(List<Perfomance>) objReturn;
                foreach (Perfomance perfomance in perf)
                {
                    if (perfomance.Path != null)
                    {
                        if (File.Exists(@perfomance.Path))
                        {
                            perfomance.Picture = Image.FromFile(perfomance.Path);
                        }
                    }
                }
                objReturn = (object)perf;
            }

            return objReturn;
        }
    }
}
