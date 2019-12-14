using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Drawing;

namespace Course_OOP
{
    
    static class Program
    {
        public static User user = null;
        public static List<User> users = null;

        public static Genre genre = null;
        public static List<Genre> genres = null;

        public static Author author = null;
        public static List<Author> authors = null;

        public static Perfomance perfomance = null;
        public static List<Perfomance> perfomances = null;
       
        public static TKT tkt = null;
        public static List<TKT> tkts = null;

        public static Report report = null;
        public static List<Report> reports = null;

        public static Poster poster = null;
        public static List<Poster> posters = null;
     
        public static Order order = null;
        public static List<Order> orders = null;

        public static PosterView posterView = null;
        public static List<PosterView> posterViews = null;

//        public static string XMLfolder = "C://Users//artem//Desktop//ООП//Course_OOP//Course_OOP//source//";
        public static string XMLfolder = @"..\..\source\";
        public static string XMLfolderImage = @"..\..\image\";




        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        public static void LoadAllData()
        {
            
            ConcreteFactoryXML ConcreteFactoryXML = new ConcreteFactoryXML();
            List<User> users = new List<User>();
            Program.users = (List<User>)ConcreteFactoryXML.CreateReadData().GetObject(users);
            List<Genre> genres = new List<Genre>();
            Program.genres = (List<Genre>)ConcreteFactoryXML.CreateReadData().GetObject(genres);
            List<Author> authors = new List<Author>();
            Program.authors = (List<Author>)ConcreteFactoryXML.CreateReadData().GetObject(authors);
            List<Perfomance> perfomances = new List<Perfomance>();
            Program.perfomances = (List<Perfomance>)ConcreteFactoryXML.CreateReadData().GetObject(perfomances);
            List<Poster> posters = new List<Poster>();
            Program.posters = (List<Poster>)ConcreteFactoryXML.CreateReadData().GetObject(posters);
            List<TKT> tkts = new List<TKT>();
            Program.tkts = (List<TKT>)ConcreteFactoryXML.CreateReadData().GetObject(tkts);
            List<Order> orders = new List<Order>();
            Program.orders = (List<Order>)ConcreteFactoryXML.CreateReadData().GetObject(orders);
        }

    }
}
