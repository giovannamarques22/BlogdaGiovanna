using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogdaGiovanna.Models;

 namespace BlogdaGiovanna.Controllers 
{
   
    public class PostsController : Controller
    {
        private BlogContext _context = new BlogContext();

        public ActionResult Index()
        {
            var posts =_context.Posts.ToList();

            return View(posts);
        }

        public ActionResult Details(int id)

        {
            var posts = _context.Posts.SingleOrDefault(p => p.id == id);
            if (posts == null)
            {
                return HttpNotFound();
            }

            return View();
        }
       
            public ActionResult Edit(int id)
            {
                return View();
            }

        public ActionResult New()
        {
            return View();
        }


        public ActionResult Delete(int id)
            {
                return View();
            }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteComplete(int id)
        {
            var postiInDb = _context.Posts.Single(p => p.id == id);
            if (postiInDb == null)
                return HttpNotFound();

            _context.Posts.Remove(postiInDb);
            _context.SaveChanges();

            return RedirectToAction("Index", "Posts");
        }

        [HttpPost]
        public ActionResult Save(Post post)
        {
            if(post.id == 0)
            {
                post.DateAdded = DateTime.Now;
                _context.Posts.Add(post);
            }
            else
            {
                var postIndDb = _context.Posts.Single(p => p.id == post.id);
                postIndDb.Title = post.Title;
                postIndDb.DateUpdate = DateTime.Now;
                postIndDb.PostingBody = post.PostingBody;
            }
            _context.SaveChanges();

            return RedirectToAction("Index","Posts");
        }
    }
}
