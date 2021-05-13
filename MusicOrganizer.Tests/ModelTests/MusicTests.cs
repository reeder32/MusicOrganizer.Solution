using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MusicOrganizer.Models;
using System;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class MusicTests
  {
    [TestMethod]
    public void Music_CreatesInstanceOfMusicObject_Music()
    {
      string newTitle = "Purple Rain";
      Music newRecord = new Music(newTitle);
      Assert.AreEqual(typeof(Music), newRecord.GetType());
    }

    [TestMethod]
    public void Music_AssignTitleToMusicObject_String()
    {
      string newTitle = "Purple Rain";
      Music newRecord = new Music(newTitle);
      Assert.AreEqual(newTitle, newRecord.Title);
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
