using System;
using System.Collections.Generic;
using RestWork.Models;

namespace RestWork.WorkerData
{
    public interface IWorkerData
    {
        List<Worker> GetWorkers();

        Worker GetWorker(Guid Id);
        Worker AddWorker(Worker worker);
        void DeleteWorker(Worker worker);
        Worker EditWorker(Worker worker);
    }
}
