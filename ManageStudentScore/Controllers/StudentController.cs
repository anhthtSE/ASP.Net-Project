using ManageStudentScore.Models;
using ManageStudentScore.Repositories.Inferfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ManageStudentScore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public StudentController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var data = await _unitOfWork.StudentRepository.GetAllAsync();
                if (data == null) return NotFound();
                return Ok(data);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        //[HttpPost]
        //public Task<IActionResult> CreateNewStudent(Student student)
        //{
        //    try
        //    {
        //        var newData = new Student
        //        {
        //            ID = new int(),
        //            Name = student.Name,
        //            Score = student.Score,
        //        };
        //    }
        //    catch
        //    {

        //    }
        //}
    }
}
