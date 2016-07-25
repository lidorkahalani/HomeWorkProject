using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class TeacherUser : SimpleUser, INewTasks
    {

        public TeacherUser(string username, string password, string email) : base(username, password, email){}

        public TeacherUser(string username, string password, string email, long classID, int userType, HashSet<long> doneTasks) : base(username, password, email, classID, userType, doneTasks)
        {


        }

        public TeacherUser() : base(){}

        public TeacherUser getTeacher(string email, string password)
        {
            if (DataBase.Instance.LogIn(email, password).GetType() == typeof(TeacherUser))
                return (TeacherUser)DataBase.Instance.LogIn(email, password);
            return new TeacherUser();
        }
         
        public bool addNewTask(string taskName, DateTime deadline)
        {
            getTasks();
            foreach (Task t in LocalTasks)
            {
                if (taskName.Equals(t.TaskName))
                    return false;
            }
            return DataBase.Instance.addTask(taskName, deadline, ClassID);
        }

        public bool deleteTask(long taskID)
        {
            return DataBase.Instance.deleteTask(taskID, ClassID);
        }

        public bool editTask(Task task)
        {
            return DataBase.Instance.editTask(task);
        }

        public HashSet<User> showWhoFinishTaskByID(long TaskID,bool status)
        {
           return DataBase.Instance.getWhoFinishTaskByID(TaskID, status, this);
        }

        public HashSet<User> getAllUsers()
        {
            return DataBase.Instance.getAllUsers(ClassID);
        }
    }
}