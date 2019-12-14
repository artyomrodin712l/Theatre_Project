using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Course_OOP
{
    class WriteClass : Write
    {
        public Object SetObject(Object obj)
        {
            Object objReturn = obj;
            Type type = ((object)obj).GetType();
            //Получаем название файла из объекта
            string str = ((object)obj).ToString();
            string strregex = System.Text.RegularExpressions.Regex.Match(str, @"\[(\S+)\]").Groups[1].Value;
            string filestr = strregex.Substring(strregex.IndexOf(".") + 1) + "s.xml";
            string filePath = Program.XMLfolder + filestr;
            FileInfo file = new FileInfo(filePath);
            FileStream fsS;
            if (file.Exists)
            {
                 fsS = new FileStream(filePath, FileMode.Truncate);
            }
            else
            {
                 fsS = new FileStream(filePath, FileMode.Create);
            }
            XmlSerializer formatter = new XmlSerializer(type);
            formatter.Serialize(fsS, obj); fsS.Close();
            FileStream fsRepeat = new FileStream(filePath, FileMode.Open);
            objReturn = null;
            objReturn = formatter.Deserialize(fsRepeat);
            fsRepeat.Close();
            return objReturn;
        }
    }
}
