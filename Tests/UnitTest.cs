using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Course_OOP;
namespace Tests
    //BitBucket
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void AuthorCreateTest()
        {
            Author author = new Author();
            Assert.IsNotNull(author);
        }
        [TestMethod]
        public void UserCreateTest()
        {
            User user = new User();
            Assert.AreEqual(user.AccessModifier, User.Access.Guest);
        }
        [TestMethod]
        public void GenreCreateTest()
        {
            Genre genre = new Genre();
            Assert.IsNotNull(genre);
        }
        [TestMethod]
        public void PerfomanceCreateTest()
        {
            Perfomance perfomance = new Perfomance();
            Assert.IsNotNull(perfomance);
        }
        [TestMethod]
        public void PosterCreateTest()
        {
            Poster poster = new Poster();
            Assert.IsNotNull(poster);
        }
        [TestMethod]
        public void OrderCreateTest()
        {
            Order order = new Order();
            Assert.IsNotNull(order);
        }
        [TestMethod]
        public void ReportCreateTest()
        {
            Report report = new Report();
            Assert.IsNotNull(report);
        }
        [TestMethod]
        public void PosterViewCreateTest()
        {
            PosterView posterView = new PosterView();
            Assert.IsNotNull(posterView);
        }
        [TestMethod]
        public void UserExistCreateTest()
        {
            User user = new User();
            Assert.IsNotNull(user);
        }
        [TestMethod]
        public void RegisteredCreateTest()
        {
            User user = new User();
            Assert.AreNotEqual(user.AccessModifier, User.Access.Registered);
        }
        [TestMethod]
        public void AdminCreateTest()
        {
            User user = new User();
            Assert.AreNotEqual(user.AccessModifier, User.Access.Admin);
        }
    }
}
