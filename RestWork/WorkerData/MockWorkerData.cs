using System;
using System.Collections.Generic;
using System.Linq;
using RestWork.Models;

namespace RestWork.WorkerData
{
    public class MockWorkerData : IWorkerData
    {
        private List<Worker> workers = new List<Worker>()
        {
            
        };


        public Worker AddWorker(Worker worker)
        {
            
            worker.Id = Guid.NewGuid();
            workers.Add(worker);
            return worker;
        }

        public void DeleteWorker(Worker worker)
        {
            workers.Remove(worker);
        }

        public Worker EditWorker(Worker worker)
        {
            var existingWorker = GetWorker(worker.Id);
            existingWorker.Name = worker.Name;
            existingWorker.Surname = worker.Surname;
            existingWorker.Role = worker.Role;
            existingWorker.OfficeNum = worker.OfficeNum;
            existingWorker.OfficeDesk = worker.OfficeDesk;
            existingWorker.MobileNum = worker.MobileNum;
            existingWorker.OfficeNum = worker.OfficeNum;

            return existingWorker;
        }

        public Worker GetWorker(Guid Id)
        {
            return workers.SingleOrDefault(x => x.Id == Id);
        }

        public List<Worker> GetWorkers()
        {
            return workers;
        }
    }
}
