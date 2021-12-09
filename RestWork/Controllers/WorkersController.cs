using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestWork.Models;
using RestWork.WorkerData;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestWork.Controllers
{
    [ApiController]
    public class WorkersController : ControllerBase
    {

        private IWorkerData _workerData;

        public WorkersController(IWorkerData workerData)
        {
            _workerData = workerData;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetWorkers()
        {
            return Ok(_workerData.GetWorkers());
        }

        

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetSingleWorker(Guid id)
        {
            var worker = _workerData.GetWorker(id);

            if(worker != null)
            {
                return Ok(worker);
            }
            return NotFound("worker not here");

        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult GetWorker(Worker worker)
        {
            _workerData.AddWorker(worker);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + worker.Id,
                worker);

        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult DeleteWorker(Guid id)
        {
            var worker = _workerData.GetWorker(id);
            if(worker != null)
            {
                _workerData.DeleteWorker(worker);
                return Ok();
            }
            return NotFound("Didnt find him to delete");

        }

        [HttpPatch]
        [Route("api/[controller]/{id}")]
        public IActionResult EditWorker(Guid id, Worker worker)
        {
            var existingworker = _workerData.GetWorker(id);
            if(existingworker != null)
            {
                worker.Id = existingworker.Id;
                _workerData.EditWorker(worker);
                

            }
            return Ok(worker);
        }


    }
}
