using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace Program
{
    public class AdminUser : SimpleUser, IMarkTask, INewTasks
    {

        public AdminUser() { }

        public AdminUser(string username, string password, string email) : base(username, password, email) { }

        public AdminUser(string username, string password, string email, long classID, int userType, HashSet<long> doneTasks) : base(username, password, email, classID, userType, doneTasks)
        {

        }

        /***********************Manage Tasks************************/

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

        /***********************Manage Users************************/
        public bool addUserToGroup(string email)
        {
            return DataBase.Instance.addUserToGroup(email, ClassID);

        }

        public bool removeUserFromGroup(string email)
        {
            return DataBase.Instance.removeUserFromGroup(email);
        }

        public HashSet<User> getAllUsers()
        {
            return DataBase.Instance.getAllUsers(ClassID);
        }

        public AdminUser getAdmin(string email, string password)
        {
            if (DataBase.Instance.LogIn(email, password).GetType() == typeof(AdminUser))
                return (AdminUser)DataBase.Instance.LogIn(email, password);
            return new AdminUser();
        }

        public void addAdmin()
        {
            DataBase.Instance.addUser(this, 1);
        }

    }

}
