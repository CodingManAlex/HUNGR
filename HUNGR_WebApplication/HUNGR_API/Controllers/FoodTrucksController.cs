using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HUNGR.API.Classes;
using HUNGR.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HUNGR.API.Controllers
{
    [Route("[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class FoodTrucksController : ControllerBase
    {
        private readonly HUNGRContext db;

        public FoodTrucksController(HUNGRContext context)
        {
            db = context;
            db.Database.EnsureCreated();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllFoodTrucks([FromQuery] FoodTruckQueryParameters queryParameters)
        {
            IQueryable<FoodTruck> foodTrucks = db.FoodTrucks;

            //Return OPEN FoodTrucks
            if(queryParameters.State != null)
            {
                foodTrucks = foodTrucks.Where(
                    ft => ft.State == queryParameters.State.Value);
            }
            //Search Name by Substring
            if (!string.IsNullOrEmpty(queryParameters.Name))
            {
                foodTrucks = foodTrucks.Where(
                    ft => ft.Name.ToLower().Contains(queryParameters.Name.ToLower()));
            }
            //Sorting
            if (!string.IsNullOrEmpty(queryParameters.SortBy))
            {
                if(typeof(FoodTruck).GetProperty(queryParameters.SortBy) != null)
                {
                    foodTrucks = foodTrucks.OrderByCustom(queryParameters.SortBy, queryParameters.SortOrder); 
                }
            }

            return Ok(await foodTrucks.ToArrayAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFoodTruck(int id)
        {
            var foodTruck = await db.FoodTrucks.FindAsync(id);
            if(foodTruck == null)
            {
                return NotFound();
            }
            return Ok(foodTruck);
        }

        //[HttpGet("{state}")]
        //public async Task<IActionResult> GetOpenFoodTrucks(int state)
        //{
        //    var foodTruck = await db.FoodTrucks.FindAsync(state);
        //    if (foodTruck == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(foodTruck);
        //}

        //Pagination example
        //https ://example.com/foodtrucks?size=15&page=2
        //size can be represented as .Take(queryParameter.Size)
        //paging can be represented as .Skip(querParameters.Size * (queryParameters.Page - 1))

        [HttpPost]
        public async Task<ActionResult<FoodTruck>> PostFoodTruck([FromBody]FoodTruck foodTruck)
        {
            db.FoodTrucks.Add(foodTruck);
            await db.SaveChangesAsync();

            return CreatedAtAction(
                "GetFoodTruck",
                new { id = foodTruck.FoodTruckId },
                foodTruck
                );
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutFoodTruck([FromRoute] int id, [FromBody] FoodTruck foodTruck)
        {
            if(id != foodTruck.FoodTruckId)
            {
                return BadRequest();
            }
            db.Entry(foodTruck).State = EntityState.Modified;

            try {
            await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if(db.FoodTrucks.Find(id) == null)
                {
                    return NotFound();
                }

                throw;
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<FoodTruck>> DeleteFoodTruck(int id)
        {
            var foodTruck = await db.FoodTrucks.FindAsync(id);
            if(foodTruck == null)
            {
                return NotFound();
            }

            db.FoodTrucks.Remove(foodTruck);
            await db.SaveChangesAsync();

            return foodTruck;
        }

    }
}
