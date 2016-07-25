using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public abstract class User
    {
        private string username;
        private string password;
        private string email;
        private long classID;
        private int userType;
        private HashSet<Task> localTasks = new HashSet<Task>();
        private HashSet<long> doneTasks = new HashSet<long>();

        public User(string username, string password, string email)
        {
            UserName = username;
            Password = password;
            Email = email;

        }
        public User(string username, string password, string email, long classID, int userType, HashSet<long> doneTasks)
        {
            UserName = username;
            Password = password;
            Email = email;
            ClassID = classID;
            UserType = userType;
            DoneTasks = doneTasks;

        }
        public User() { }

        public string UserName
        {
            get { return this.username; }
            set { this.username = value; }
        }

        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public long ClassID
        {
            get { return this.classID; }
            set { this.classID = value; }
        }

        public int UserType
        {
            get { return this.userType; }
            set { this.userType = value; }
        }

        public HashSet<long> DoneTasks
        {
            get
            {
                return doneTasks;
            }
            set
            {
                doneTasks.Clear();
                foreach (int i in value)
                    doneTasks.Add(i);
            }
        }

        public override bool Equals(object obj)
        {
            if (Email.Equals(((User)obj).Email))
                return true;
            return false;
        }

        public void AddUser()
        {
            int userType = 0;
            if (this.GetType() == typeof(SimpleUser))
                userType = 3;
            else if (this.GetType() == typeof(TeacherUser))
                userType = 2;
            else if (this.GetType() == typeof(AdminUser))
                userType = 1;
            else
                return;
            DataBase.Instance.addUser(this, userType);
        }

        public override int GetHashCode()
        {
            return 1;
        }

        public HashSet<Task> LocalTasks
        {
            get { return this.localTasks; }
            set
            {
                localTasks.Clear();
                foreach (Task T in value)
                {
                    this.localTasks.Add(T);
                }
            }

        }

        public bool editProfile(User user, string prevEmail)
        {
            return DataBase.Instance.editProfile(user, prevEmail);
        }



    }
}