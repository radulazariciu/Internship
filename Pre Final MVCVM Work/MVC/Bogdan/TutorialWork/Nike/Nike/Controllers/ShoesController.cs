using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Windows.Forms;
using Nike.Models;
using WebGrease.Css.Ast;
using FormCollection = System.Web.Mvc.FormCollection;

namespace Nike.Controllers
{
    public class ShoesController : Controller
    {
        //
        // GET: /Shoes/

        public ActionResult Index()
        {
            var lst = theShoes;
            return View(lst);
        }

        //
        // GET: /Shoes/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Shoes/Create

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Shoe s)
        {
            if (ModelState.IsValid)
            {
                theShoes.Add(s);
                return RedirectToAction("Index");
            }
            else
            {
                return View(s);
            }
        }


        //
        // GET: /Shoes/Edit/5

        public ActionResult Edit(int id)
        {
            var shoe = theShoes.Single(s => s.Id == id);
            return View(shoe);
        }

        //
        // POST: /Shoes/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var shoe = theShoes.Single(s => s.Id == id);
            
            if(TryUpdateModel(shoe))
            {
                return RedirectToAction("Index");
            }
                 return View(shoe);
            }

        //
        // GET: /Shoes/Delete/5

        public ActionResult Delete(int id)
        {
            
            var shoe = theShoes.Single(s => s.Id == id);
            return View(shoe);
        }

        //
        // POST: /Shoes/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        private static List<Shoe> theShoes = new List<Shoe>
        {
            new Shoe
            {
                Id = 0,
                Name = "one",
                Price = 100,
            },

            new Shoe
            {
                Id = 1,
                Name = "two",
                Price = 200,
            }
        };

        public List<Shoe> getShoeList()
        {
            return theShoes;
        }

        public void addShoeToList(Shoe s)
        {
            theShoes.Add(s);
        }
    }
}
