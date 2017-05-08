using MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class FilmeController : Controller
    {
        private MovieDBContext movieDb = new MovieDBContext();

        // GET: Filme
        public ViewResult Index(string searchString,int? SelectedGenre)
        {
            var genres = movieDb.Genres.OrderBy(g => g.Name).ToList();
            ViewBag.SelectedGenre = new SelectList(genres, "GenreId", "Name", SelectedGenre);
            int genreID = SelectedGenre.GetValueOrDefault();
            var movies = movieDb.Movies.Where(c => !SelectedGenre.HasValue || c.GenreID == genreID);

            if (!String.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(s => s.Title.Contains(searchString) || s.Director.Contains(searchString));
            }

            return View(movies.ToList());
        }

        // GET: Filme/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Filme/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Filme/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Filme/Edit/5
        public ActionResult Edit(int id)
        {
            Movie filme = movieDb.Movies.Find(id);
            if (filme == null)
            {
                return HttpNotFound();
            }
            ViewBag.GenreId = new SelectList(movieDb.Genres,
           "GenreId", "Name", filme.GenreID);
            return View(filme);
        }

        [HttpPost]
        public ActionResult Edit(Movie album)
        {
            if (ModelState.IsValid)
            {
                movieDb.Entry(album).State = EntityState.Modified;
                movieDb.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.GenreId = new SelectList(movieDb.Genres,
           "GenreId", "Name", album.GenreID);
            return View(album);
        }

        //
        // GET: /Store/Delete/5
        public ActionResult Delete(int id)
        {
            Movie movie = movieDb.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }

            return View(movie);
        }

        //
        // POST: /Store/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            Movie movie = movieDb.Movies.Find(id);
            movieDb.Movies.Remove(movie);
            movieDb.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}