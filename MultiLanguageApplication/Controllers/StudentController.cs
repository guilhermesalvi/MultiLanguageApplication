using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using MultiLanguageApplication.Models;
using System;

namespace MultiLanguageApplication.Controllers
{
    [ApiController]
    [Route("api/student")]
    public class StudentController : ControllerBase
    {
        private readonly IStringLocalizer<StudentController> _localizer;

        public StudentController(IStringLocalizer<StudentController> localizer)
        {
            this._localizer = localizer ?? throw new ArgumentNullException(nameof(localizer));
        }

        [HttpPost("")]
        public IActionResult Register(StudentInputModel model)
        {
            return Ok(new
            {
                Succeeded = true,
                Message = this._localizer["Student_Registered"].Value
            });
        }
    }
}
