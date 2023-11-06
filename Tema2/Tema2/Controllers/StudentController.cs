using Microsoft.AspNetCore.Mvc;

namespace Tema2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        List<Student> studenti = new List<Student>();



        private readonly ILogger<StudentController> _logger;

        public StudentController(ILogger<StudentController> logger)
        {
            _logger = logger;
            Student student1 = new Student(1, "Vaduva", 30);
            Student student2 = new Student(2, "Marian", 50);
            Student student3 = new Student(3, "florin", 20);
            Student student4 = new Student(4, "Marian", 10);
            studenti.Add(student1);
            studenti.Add(student2);
            studenti.Add(student3);
            studenti.Add(student4);
        }

        [HttpGet("students")]
        public List<Student> Get()
        {
            return studenti;
        }
        [HttpDelete(Name = "studentDelete")]

        public List<Student> delete(int id)
        {

            int index = studenti.FindIndex(student => student.id == id);
            studenti.RemoveAt(index);
            return studenti;
        }

        [HttpGet("getAllOrdered")]
        public List<Student> GetOrdered()
        {

            return studenti.OrderBy(student => student.varsta).ToList();
        }

    }
}

