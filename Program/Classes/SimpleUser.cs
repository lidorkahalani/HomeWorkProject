using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class SimpleUser : User, IMarkTask
    {

        public SimpleUser() : base()
        {

        }

        public SimpleUser(string username, string password, string email) : base(username, password, email)
        {


        }

        public SimpleUser(string username, string password, string email, long classID, int userType, HashSet<long> doneTasks) : base(username, password, email, classID, userType, doneTasks)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }

        public SimpleUser getUser(string email, string password)
        {
            if (DataBase.Instance.LogIn(email, password).GetType() == typeof(SimpleUser))
                return DataBase.Instance.LogIn(email, password);
            return new SimpleUser();

        }

        public void getTasks()
        {
            LocalTasks = DataBase.Instance.getMyTasks(ClassID);
            foreach (Task t in LocalTasks)
            {
                if (DoneTasks.Contains(t.TaskID))
                    t.Status = true;
            }
        }

        public bool markTask(bool status, long taskID)
        {
            if(status)
                DoneTasks.Add(taskID);
            else
                DoneTasks.Remove(taskID);

            return DataBase.Instance.markTask(this);
        }


    }
}