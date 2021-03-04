using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTest
{
    /// <summary>
    /// Refactor the JobService and JobDAO classes:
    /// 
    /// 1.  Create a new interface, named IJobDAO, that contains the same methods as JobDAO.
    /// 2.  JobDAO should implement the IJobDAO interface
    /// 3.  JobService should have a constructor that accepts IJobDAO
    /// 4.  The AddJob and GetJob methods should use the object passed through the constructor.
    /// </summary>

    public class JobService
    {
        private readonly JobDAO storage = new JobDAO();

        public Guid AddJob()
        {
            return this.storage.AddJob("Some random string");
        }

        public string GetJob(Guid id)
        {
            return this.storage.GetJob(id);
        }
    }

    public class JobDAO
    {
        private readonly Dictionary<Guid, string> jobs = new Dictionary<Guid, string>();

        public Guid AddJob(string name)
        {
            Guid id = Guid.NewGuid();
            this.jobs.Add(id, name);
            return id;
        }

        public string GetJob(Guid id)
        {
            return this.jobs[id];
        }
    }
}
