using Microsoft.AspNetCore.Mvc;
using Pet.Api.Domain.ValueObjects;
using Pet.Api.Exercises_Record;
using Pet.Api.PersonDomian.Entities;
using Pet.Api.PersonDomian.ValueObjects;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pet.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExerciseRecordController : ControllerBase
    {
        // GET: api/<ExerciseRecordController>
        [HttpGet]
        public bool Get()//IEnumerable<string>
        {
            return EjerciciosConRecord.CompareTwoObjects();

            //var petName = PetName.Create("Rufo");
            //return petName.ToString();
        }

        [HttpGet("RecordHerencia")]
        //[ActionName("RecordHerencia")]
        public bool RecordHerencia()
        {
            //var resume = new ResumePerson("Lic.", "Pedro", "Molina");

            var resume = ResumePerson.Create("Lic.", "Pedro", "Molina");
            var person = new Person(resume);
            return EjerciciosConRecord.CompareTwoObjects();
        }

        // GET api/<ExerciseRecordController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ExerciseRecordController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ExerciseRecordController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ExerciseRecordController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
