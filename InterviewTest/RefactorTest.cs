using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTest
{
    /// <summary>
    /// Refactor the JobService and JobDAO classes:
    /// 
    /// 1.  Create a new interface, named IJobDAO, that contains the same methods as JobDAO.
    /// 2.  AlertDAO should implement the IJobDAO interface
    /// 3.  JobService should have a constructor that accepts IJobDAO
    /// 4.  The RaiseAlert and GetAlertTime methods should use the object passed through the constructor.
    /// </summary>

    public class JobService
    {
        private readonly JobDAO storage = new JobDAO();

        public Guid RaiseAlert()
        {
            return this.storage.AddJob("Some random string");
        }

        public string GetAlertTime(Guid id)
        {
            return this.storage.GetAlert(id);
        }
    }

    public class JobDAO
    {
        private readonly Dictionary<Guid, string> alerts = new Dictionary<Guid, string>();

        public Guid AddJob(string name)
        {
            Guid id = Guid.NewGuid();
            this.alerts.Add(id, name);
            return id;
        }

        public string GetAlert(Guid id)
        {
            return this.alerts[id];
        }
    }
}
