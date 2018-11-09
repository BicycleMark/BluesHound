using ContentLib;
using DataStructLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestClass]
    public class TestContentLib
    {
       
        [TestMethod]
        public void CreateEvenDBContext()
        {
            using (var db = new EventDBContext())
            {
                db.Database.EnsureCreated();
                Assert.AreNotEqual(db, null);
               
            }
        }
        [TestMethod]
        public async Task TestWebstiteGrabberFromWeb()
        {
            //Arrange 
            HtmlItem iturl = HtmlItemFactory.GetHtmlItem(ContentLib.Constants.LocationType.WEB, "https://theblueshound.com/music-calendar");
            WebStiteGrabber wg = new WebStiteGrabber(iturl);
            string str = await wg.GrabAsync();

            //Assert
            Assert.AreNotEqual(String.Empty, str);
        }
        [TestMethod]
        public async Task TestWebstiteGrabberFromFile()
        {
            //Arrange 

            HtmlItem iturl = HtmlItemFactory.GetHtmlItem(ContentLib.Constants.LocationType.FILE, @"Data\\Events.html");
            WebStiteGrabber wg = new WebStiteGrabber(iturl);
            string str = await wg.GrabAsync();

            //Assert
            Assert.AreNotEqual(String.Empty, str);
        }
    }
}
