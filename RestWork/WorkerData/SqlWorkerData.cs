using System;
using System.Collections.Generic;
using System.Linq;
using RestWork.Models;

namespace RestWork.WorkerData
{
    public class SqlWorkerData: IWorkerData
    {
        private WorkerContext _workerContext;

        public SqlWorkerData(WorkerContext workerContext)
        {
            _workerContext = workerContext;
        }

        public Worker AddWorker(Worker worker)
        {
            worker.Id = Guid.NewGuid();
            _workerContext.Workers.Add(worker);
            _workerContext.SaveChanges();
            return worker;
        }

        public void DeleteWorker(Worker worker)
        {
            _workerContext.Workers.Remove(worker);
            _workerContext.SaveChanges();
        }

        public Worker EditWorker(Worker worker)
        {
            var existingWorker = _workerContext.Workers.Find(worker.Id);
            if(existingWorker != null)
            {
                existingWorker.Name = worker.Name;
                existingWorker.Surname = worker.Surname;
                existingWorker.Role = worker.Role;
                existingWorker.OfficeNum = worker.OfficeNum;
                existingWorker.OfficeDesk = worker.OfficeDesk;
                existingWorker.MobileNum = worker.MobileNum;
                existingWorker.Mail = worker.Mail;
                _workerContext.Workers.Update(existingWorker);
                _workerContext.SaveChanges();
            }
            return worker; 
        }

        public Worker GetWorker(Guid Id)
        {
            var worker = _workerContext.Workers.Find(Id);
            return worker;
        }

        public List<Worker> GetWorkers()
        {
           return _workerContext.Workers.ToList();
        }
    }
}
