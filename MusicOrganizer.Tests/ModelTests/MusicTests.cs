using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MusicOrganizer.Models;
using System;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class MusicTests : IDisposable
  {

    private static string _titleString = "Purple Rain";
    private Music _newMusic = new Music(_titleString);

    public void Dispose()
    {
      Music.ClearAll();
    }

    [TestMethod]
    public void Music_CreatesInstanceOfMusicObject_Music()
    {
      _titleString = "Purple Rain";
      _newMusic = new Music(_titleString);
      Assert.AreEqual(typeof(Music), _newMusic.GetType());
    }

    [TestMethod]
    public void Music_AssignTitleToMusicObject_String()
    {
      _titleString = "Purple Rain";
      _newMusic = new Music(_titleString);
      Assert.AreEqual(_titleString, _newMusic.Title);
    }

    [TestMethod]
    public void Music_AddMusicToList_List()
    {

      List<Music> newList = new List<Music> { _newMusic };
      CollectionAssert.AreEqual(newList, Music.GetAll());
    }
  }
}

// Test boilerplate
// [TestMethod]
// public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
// {
//   // any necessary logic to prep for test; instantiating new classes, etc.
//   Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
// }
