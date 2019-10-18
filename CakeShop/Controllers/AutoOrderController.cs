using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CakeShop.Controllers
{
    /**[Route("autoorder")]
    public class AutoOrderController : Controller
    {
        // GET: api/<controller>
       /** public AutoOrderController()
        {

        }
        public IHttpActionResult Put(Order cake)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Not a valid order");
            }

            using (var cto = new CakesOrdered())
            {
                var currentOrders = cto.Cakes.Where(s => s.Order)
            }
        }

        // GET api/<controller>/5
        /**[HttpGet("{id}")]
        public string Get(int id)
        {
            int x = 0;
            if (id == 1)
            {
                x = 1;
            }
            return x.ToString();
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<Action<AutoOrderController>> PostTodoItem(AutoOrderController todoItem)
        {
            _context.AutoOrderController.Add(todoItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTodoItem), new { id = todoItem.Id }, todoItem);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public String Put(int number, [FromBody]string value)
        {
            if (number == 1)
            {
                return "Bueno";
            }
            else
            {
                return value;
            }
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }**/
}
