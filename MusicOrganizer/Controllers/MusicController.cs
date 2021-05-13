using Microsoft.AspNetCore.Mvc;
using MusicOrganizer.Models;
using System.Collections.Generic;
using System;

namespace MusicOrganizer.Controllers
{
  public class MusicController : Controller
  {

    [HttpGet("/music")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/music")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/music/new")]

    public ActionResult New(string title)
    {
      Music newMusic = new Music(title);
      return RedirectToAction("Index");
    }

    [HttpGet("/music/{id}")]

    public ActionResult Show(int id)
    {
      Music foundMusic = Music.Find(id);
      return View(foundMusic);
    }
  }
}