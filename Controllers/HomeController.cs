using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDelicious.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;

        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        public IActionResult Index()
        {
            List<Dish> AllDishes = dbContext.Dish.OrderByDescending(id => id.DishId).ToList();
            return View(AllDishes);
        }


        //querying for one by id, shows all details
        [HttpGet("{id}")]
        
        public IActionResult ShowOne(int id)
        {
            List<Dish> ShowOne = dbContext.Dish.Where(ones => ones.DishId == id).ToList();
            return View(ShowOne);
        }

        [HttpGet("delete/{id}")]
        public IActionResult Delete(int id)
        {
            Dish RetreiveData = dbContext.Dish.SingleOrDefault(dish => dish.DishId == id);
            dbContext.Dish.Remove(RetreiveData);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet("new")]
        public IActionResult AddPage()
        {
            return View();
        }

        public IActionResult AddDish(Dish newDish)
        {
            if(ModelState.IsValid)
            {
                dbContext.Add(newDish);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else{

                return View("AddPage", newDish);
            }
        }

        [HttpGet("edit/{id}")]
        public IActionResult Edit(int id)
        {
            List<Dish> EditDish = dbContext.Dish.Where(dish => dish.DishId == id).ToList();

            return View(EditDish);
        }

        [HttpPost("editdish/{id}")]
        public IActionResult EditDish(Dish editDish, int id)
        {
            // // return RedirectToAction("{id}",editDish);
            // if(ModelState.IsValid)
            // {
                Dish originalDish = dbContext.Dish.FirstOrDefault(dish => dish.DishId == id);
                originalDish.Description = editDish.Description;
                originalDish.Calories = editDish.Calories;
                originalDish.Name = editDish.Name;
                originalDish.UpdatedAt = DateTime.Now;
                dbContext.SaveChanges();
                return RedirectToAction("ShowOne", new{id = id});
            // }
            // else{
            //     return View("Edit", new{id = id});
            // }
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
