using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace SwaggerWithNetCore.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class CarController : ControllerBase
  {
    [HttpGet]
    public IEnumerable<Car> Get()
    {
      return GetCars();
    }
    [HttpGet("{id}", Name = "Get")]
    public Car Get(int id)
    {
      return GetCars().Find(e => e.Id == id);
    }
    [HttpPost]
    [Produces("application/json")]
    public Car Post([FromBody] Car car)
   {
      return new Car() { 
                         Id = car.Id, 
                         Brand = car.Brand, 
                         Model = car.Model, 
                         Year = car.Year };
   }
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Car car)
    {
    }
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
    private List<Car> GetCars()
    {
      return new List<Car>() {
                       new Car() { 
                                  Id = 1, 
                                  Brand = "Toyota", 
                                  Model = "Auris", 
                                  Year = 2012},
                       new Car() { 
                                   Id = 2, 
                                   Brand = "BMW", 
                                   Model = "3.20", 
                                   Year = 2019},
                       new Car() { 
                                   Id = 3, 
                                   Brand = "Renault", 
                                   Model = "Clio", 
                                   Year = 2020}
                               };
   }
 }
}