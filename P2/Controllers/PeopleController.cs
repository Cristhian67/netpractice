﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using P2.Services;

namespace P2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private IPeopleService _peopleService;

        public PeopleController ([FromKeyedServices("peopleService")]IPeopleService peopleService) {
                _peopleService = peopleService;
        }
        [HttpGet("all")]
        public List<People> GetPeople() => Repository.People;

        [HttpGet("{id}")]

        public ActionResult<People> Get(int id) 
            { 
            var people = Repository.People.First(p => p.Id == id); 
            if (people == null)
            {
                return NotFound();
            }
            return Ok(people);
        }


        [HttpGet("search/{search}")]
        public List<People> Get(string search) => 
            Repository.People.Where(p => p.Name.ToUpper().Contains(search.ToUpper())).ToList();

        [HttpPost]
        public IActionResult Add(People people) 
        { 
            if (!_peopleService.Validate(people))
            {
                return BadRequest();
            }

            Repository.People.Add(people);

            return NoContent();
        }
            
    }

    public class Repository
    {
        public static List<People> People = new List<People>
        {
            new People()
            {
                Id = 1, Name = "Roderika", Birthdate = new DateTime(1995, 10, 4)
            },
            new People()
            {
                Id = 2, Name = "Mozgus", Birthdate=new DateTime(1992, 3, 22)
            },
            new People()
            {
                Id = 3, Name = "Shierke", Birthdate = new DateTime(2002, 7, 9)
            }
        };

    }

    public class People
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Birthdate { get; set; }
    }
}
