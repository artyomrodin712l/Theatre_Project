using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_OOP
{
    abstract class XMLinQWorker
    {
        public abstract List<User> SynchronizeUsers();

        public static Genre genre = null;
        public static List<Genre> genres = null;

        public static Author author = null;
        public static List<Author> authors = null;

        public static Perfomance perfomance = null;
        public static List<Perfomance> perfomances = null;

        public static TKT tkt = null;
        public static List<TKT> tkts = null;

        public static Poster poster = null;
        public static List<Poster> posters = null;

        public static Order order = null;
        public static List<Order> orders = null;

        public static PosterView posterView = null;
        public static List<PosterView> posterViews = null;

    }
}
