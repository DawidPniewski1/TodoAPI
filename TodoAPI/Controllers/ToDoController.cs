using Microsoft.AspNetCore.Mvc;
using TodoAPI.services;

namespace TodoAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ToDoController : ControllerBase
    {
        private readonly ToDoService _toDoService;

        public ToDoController(ToDoService toDoService)
        {
            _toDoService = toDoService;
        }


        [HttpGet]
        public  string GetTodos()
        {
            return _toDoService.GetTodos();
        }
    }
}
