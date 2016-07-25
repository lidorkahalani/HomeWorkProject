using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{

    public class Task
    {
        private long taskID;
        private long classID;
        private string taskName;
        private DateTime deadline;
        private bool status = false;
       

        public Task(string taskName, DateTime deadline)
        {
            TaskName = taskName;
            Deadline = deadline;
           // taskID = counter++;

        }

        public Task(long taskID,string taskName, DateTime deadline,long classID)
        {
            TaskName = taskName;
            Deadline = deadline;
            //TaskID = counter++;
            TaskID = taskID;
            ClassID = classID;

        }
        public Task(long taskID,string taskName, DateTime deadline, long classID,bool status)
        {
            TaskName = taskName;
            Deadline = deadline;
            TaskID = taskID;
            ClassID = classID;
            Status = status;
        }

        public long ClassID
        {
            get { return this.classID; }
            set { this.classID = value; }
        }

        public long TaskID
        {
            get { return this.taskID; }
            set { this.taskID = value;}
        }

        public string TaskName
        {
            get { return this.taskName; }
            set { this.taskName = value; }
        }

        public bool Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        public DateTime Deadline
        {
            get { return this.deadline; }
            set { this.deadline = value; }
        }

        public override bool Equals(object obj)
        {
            if (TaskName.Equals(((Task)obj).TaskName))
            {
                if (!(classID.Equals(classID.Equals((Task)obj))))
                        return true;
            }
            return false;

        }

        public override int GetHashCode()
        {
            return 1;
        }


    }
}