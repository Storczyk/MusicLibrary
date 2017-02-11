using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicLibrary.Services;
using MusicLibrary.DAL;
using MusicLibrary.Controllers;
using MusicLibrary.Models;
using System.Collections.Generic;
using Moq;
using System.Web.Http;
using System.Web.Http.Results;

namespace MusicLib.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddAlbum_ShouldAddAlbumToRepository()
        {
            var factoryMock = new Mock<AlbumService>();
            var controller = new Mock<AlbumController>();
            var uowMock = new AlbumRequest();
            var repositoryMock = new Mock<IAlbumRepository>();

            controller.Setup(f => f.AddAlbum(uowMock)).Returns(uowMock.o)

            factoryMock.Setup(f => f.()).Returns(uowMock.Object);
            uowMock.Setup(u => u.ItemRep).Returns(repositoryMock.Object);

            var sut = new MyClass(factoryMock.Object);

            // Act
            var item = new Item();
            sut.addItem(item);


            // Assert
            repositoryMock.Verify(r => r.Insert(item), Times.Once);
            uowMock.Verify(u => u.Commit(), Times.Once);
        }
        [TestMethod]
        public void TestMethod1()
        {
        }
    }

}
