using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Program
{

    public class DataBase
    {
        private static string dBAdress = "Data Source=DataBase.sqlite;Version=3;";
        private SQLiteConnection DBconnection = new SQLiteConnection(dBAdress);
        private static DataBase instance = new DataBase();

        private DataBase()
        {
            if (File.Exists("DataBase.sqlite"))
            {
                DBconnection.Open();

            }
            else
            {
                CreateDataBase();

            }

        }

        public static DataBase Instance { get { return instance; } }

        public void CreateDataBase()
        {
            DBconnection = new SQLiteConnection(dBAdress);
            DBconnection.Open();

            string sql = "CREATE TABLE users (Username TEXT NOT NULL,Password TEXT NOT NULL,Email TEXT PRIMARY KEY NOT NULL,UserType INT NOT NULL,ClassID INT NOT NULL,DoneTasks TEXT)";
            SQLiteCommand command = new SQLiteCommand(sql, DBconnection);
            command.ExecuteNonQuery();
            sql = "INSERT INTO users VALUES('David','abcd1234','d@g.com',1,2,'')";
            command = new SQLiteCommand(sql, DBconnection);
            command.ExecuteNonQuery();
            sql = "INSERT INTO users VALUES('Moseh','abcd1234','m@gs.com',3,2,'')";
            command = new SQLiteCommand(sql, DBconnection);
            command.ExecuteNonQuery();
            sql = "INSERT INTO users VALUES('theKing','1234abcd','king@A.com',1,1,'3,')";
            command = new SQLiteCommand(sql, DBconnection);
            command.ExecuteNonQuery();
            sql = "INSERT INTO users VALUES('HaGoogle','abcd1234','h@g.com',3,0,'')";
            command = new SQLiteCommand(sql, DBconnection);
            command.ExecuteNonQuery();
            sql = "INSERT INTO users VALUES('Moran','usa12345','m@a.com',2,1,'')";
            command = new SQLiteCommand(sql, DBconnection);
            command.ExecuteNonQuery();
            sql = "INSERT INTO users VALUES('lider','abcd1234','a@b.com',3,1,'')";
            command = new SQLiteCommand(sql, DBconnection);
            command.ExecuteNonQuery();
            sql = "INSERT INTO users VALUES('Meitar','abcd1234','m@t.com',3,1,'')";
            command = new SQLiteCommand(sql, DBconnection);
            command.ExecuteNonQuery();
            sql = "INSERT INTO users VALUES('yosef','abcd1234','y@g.com',3,1,'1,2,')";
            command = new SQLiteCommand(sql, DBconnection);
            command.ExecuteNonQuery();
            sql = "INSERT INTO users VALUES('lior','fedd4453','l@b.com',3,1,'')";
            command = new SQLiteCommand(sql, DBconnection);
            command.ExecuteNonQuery();
            sql = "INSERT INTO users VALUES('mor','cfrd3462','m@o.com',3,0,'')";
            command = new SQLiteCommand(sql, DBconnection);
            command.ExecuteNonQuery();

            string sqlTasks = "CREATE TABLE tasks (TaskID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,TaskName TEXT NOT NULL,DeadLine TEXT NOT NULL,ClassID INT NOT NULL,Status INT NOT NULL DEFAULT 0)";
            command = new SQLiteCommand(sqlTasks, DBconnection);
            command.ExecuteNonQuery();
            sql = "INSERT INTO tasks VALUES(0,'Java','12/05/2016',1,0)";
            command = new SQLiteCommand(sql, DBconnection);
            command.ExecuteNonQuery();
            sql = "INSERT INTO tasks VALUES(1,'C# Sprint 2','12/12/2015',1,0)";
            command = new SQLiteCommand(sql, DBconnection);
            command.ExecuteNonQuery();
            sql = "INSERT INTO tasks VALUES(2,'Assembly','17/05/2016',1,0)";
            command = new SQLiteCommand(sql, DBconnection);
            command.ExecuteNonQuery();
            sql = "INSERT INTO tasks VALUES(3,'CSS / JS','27/03/2016',2,0)";
            command = new SQLiteCommand(sql, DBconnection);
            command.ExecuteNonQuery();


        }   // create the SQL Database default values (Tables and values)

        /*************************************Manage Tasks**********************************/

        public bool addTask(string taskName, DateTime deadline, long classID)
        {
            string sql = "INSERT INTO tasks (TaskName, DeadLine, ClassID) Values('" + taskName + "','" + deadline.ToString("dd/MM/yyyy") + "'," + classID.ToString() + ");";
            SQLiteCommand command = new SQLiteCommand(sql, DBconnection);
            if (command.ExecuteNonQuery() > 0)
                return true;
            return false;
        }   //V

        public bool editTask(Task task)
        {
            string sql = "Update tasks SET TaskName='" + task.TaskName + "', DeadLine = '" + task.Deadline.Date.ToString() + "' WHERE TaskID = " + task.TaskID.ToString() + ";";
            SQLiteCommand command = new SQLiteCommand(sql, DBconnection);
            if (command.ExecuteNonQuery() > 0)
                return true;
            return false;
        }     //V

        public bool deleteTask(long taskID, long classID)
        {
            string sql = "DELETE FROM tasks WHERE TaskID= " + taskID.ToString() + " AND ClassID= " + classID.ToString() + ";";
            SQLiteCommand command = new SQLiteCommand(sql, DBconnection);
            command.ExecuteNonQuery();
            if (command.ExecuteNonQuery() == 0)
                return true;
            return false;
        }   //V

        public HashSet<Task> getMyTasks(long classID)
        {
            string sql = "SELECT * FROM tasks WHERE ClassID= '" + classID + "'";
            SQLiteCommand command = new SQLiteCommand(sql, DBconnection);
            SQLiteDataReader reader = command.ExecuteReader();
            HashSet<Task> tempTasks = new HashSet<Task>();
            while (reader.Read())
            {
                long taskID = Int64.Parse(reader["TaskID"].ToString());
                string taskName = reader["TaskName"].ToString();
                DateTime deadline = DateTime.Parse(reader["DeadLine"].ToString());
                bool status = false;
                if (Int32.Parse(reader["Status"].ToString()) == 1)
                    status = true;
                tempTasks.Add(new Task(taskID, taskName, deadline, classID, status));

            }
            return tempTasks;

        }   //V

        public bool markTask(User user)
        {
            string doneTasks = "";
            foreach (long dt in user.DoneTasks)
            {
                doneTasks += dt.ToString() + ',';
            }
            string sql = "UPDATE Users SET DoneTasks = '" + doneTasks + "' WHERE Email = '" + user.Email + "' ;";

            SQLiteCommand command = new SQLiteCommand(sql, DBconnection);
            if (command.ExecuteNonQuery() > 0)
                return true;
            return false;
        }       //V

        public long getMaxClassID()
        {
            string sql = "SELECT MAX(ClassID) FROM users ;";
            SQLiteCommand command = new SQLiteCommand(sql, DBconnection);
            SQLiteDataReader reader = command.ExecuteReader();
            HashSet<Task> tempTasks = new HashSet<Task>();
            if (reader.Read())
            {
                return Int64.Parse(reader["MAX(ClassID)"].ToString());
            }
            return 0;
        }   //V

        /***********************************Manage Users************************************/
        public bool addUser(User user, int userType)
        {
            long classID = 0;
            if (userType == 1)  //if addind admin, classID will be maximum + 1
                classID = getMaxClassID() + 1;
            string sql = "INSERT INTO users (Username, Password, Email, UserType, ClassID) Values('" + user.UserName + "', '" + user.Password + "','" + user.Email + "', " + userType.ToString() + ", " + classID + ");";
            SQLiteCommand command = new SQLiteCommand(sql, DBconnection);
            if (command.ExecuteNonQuery() > 0)
                return true;
            return false;
        }       //V

        public bool addUserToGroup(string email, long classID)
        {
            string sql = "UPDATE users SET ClassID =" + classID.ToString() + " WHERE Email = '" + email + "' ;";
            SQLiteCommand command = new SQLiteCommand(sql, DBconnection);
            command.ExecuteNonQuery();
            if (command.ExecuteNonQuery() > 0)
                return true;
            return false;

        }       //V

        public bool removeUserFromGroup(string email)
        {
            string sql = "Update users SET ClassID =" + 0 + " WHERE Email = '" + email + "' ;";
            SQLiteCommand command = new SQLiteCommand(sql, DBconnection);
            if (command.ExecuteNonQuery() > 0)
                return true;
            return false;
        }   //V

        public HashSet<User> getAllUsers(long classID)
        {
            HashSet<User> temp = new HashSet<User>();
            HashSet<User> tempAll = new HashSet<User>();
            string sql = "SELECT * FROM users WHERE ClassID= " + classID + " ;";
            SQLiteCommand command = new SQLiteCommand(sql, DBconnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string userName = reader["Username"].ToString();
                string email = reader["Email"].ToString();
                string password = reader["Password"].ToString();
                int userType = Int32.Parse(reader["UserType"].ToString());
                HashSet<long> doneTasks = new HashSet<long>();

                string doneTasksText = "";
                if (reader["DoneTasks"] != null && !reader["DoneTasks"].ToString().Equals(""))
                {
                    doneTasksText = reader["DoneTasks"].ToString();
                    string[] arr = doneTasksText.Split(',');
                    foreach (string s in arr)
                    {
                        if(!s.Equals(""))
                            doneTasks.Add(Int64.Parse(s));
                    }
                }

                if (classID == -1)     //if -1 was sent, all users are to be returned
                    tempAll.Add(new SimpleUser(userName, password, email, classID, userType, doneTasks));
                temp.Add(new SimpleUser(userName, password, email, classID, userType, doneTasks));
            }
            if (classID != -1)
            {
                return temp;
            }
            return tempAll;

        }     //V

        public bool editProfile(User user, string prevEmail)
        {
            string sql = "Update users SET Username='" + user.UserName + "', Password = '" + user.Password + "', Email = '" + user.Email + "' WHERE Email = '" + prevEmail + "' ;";
            SQLiteCommand command = new SQLiteCommand(sql, DBconnection);
            if (command.ExecuteNonQuery() > 0)
                return true;
            return false;
        }   //V

        public HashSet<long> getDoneTasks(string email)
        {
            string sql = "SELECT DoneTasks FROM users WHERE Email='" + email + "';";
            SQLiteCommand command = new SQLiteCommand(sql, DBconnection);
            SQLiteDataReader reader = command.ExecuteReader();
            string doneTasksText = "";
            HashSet<long> doneTasks = new HashSet<long>();
            if (reader.Read())
            {
                if (reader["DoneTasks"] != null && !reader["DoneTasks"].ToString().Equals(""))
                    doneTasksText = reader["DoneTasks"].ToString();
                if (doneTasksText == null || doneTasksText.Equals(""))
                {
                    return doneTasks;
                }
                string[] arr = doneTasksText.Split(',');
                foreach (string s in arr)
                {
                    if (!s.Equals(""))
                        doneTasks.Add(Int64.Parse(s));
                }
                return doneTasks;
            }
            return null;
        }       //V

        public HashSet<User> getWhoFinishTaskByID(long taskID, bool status, TeacherUser teacher)
        {
            HashSet<User> users = new HashSet<User>();
            string sql = "SELECT * FROM users WHERE ClassID= " + teacher.ClassID + "  ;";
            SQLiteCommand command = new SQLiteCommand(sql, DBconnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                HashSet<long> doneTasks = getDoneTasks(reader["Email"].ToString());
                if (!status)
                {
                    if (!doneTasks.Contains(taskID))
                    {
                        string userEmail = reader["Email"].ToString();
                        string userName = reader["Username"].ToString();
                        string userPassword = reader["Password"].ToString();
                        long classID = Int64.Parse(reader["ClassID"].ToString());
                        int userType = Int32.Parse(reader["UserType"].ToString());

                        if (userType == 1)
                        {
                            users.Add(new AdminUser(userName, userPassword, userEmail, classID, userType, doneTasks));
                        }
                        else if (userType == 2)
                        {
                            users.Add(new TeacherUser(userName, userPassword, userEmail, classID, userType, doneTasks));
                        }
                        else if (userType == 3)
                        {
                            users.Add(new SimpleUser(userName, userPassword, userEmail, classID, userType, doneTasks));
                        }
                    }
                }
                else
                {
                    if (doneTasks.Contains(taskID))
                    {
                        string userEmail = reader["Email"].ToString();
                        string userName = reader["Username"].ToString();
                        string userPassword = reader["Password"].ToString();
                        long classID = Int64.Parse(reader["ClassID"].ToString());
                        int userType = Int32.Parse(reader["UserType"].ToString());

                        if (userType == 1)
                        {
                            users.Add(new AdminUser(userName, userPassword, userEmail, classID, userType, doneTasks));
                        }
                        else if (userType == 2)
                        {
                            users.Add(new TeacherUser(userName, userPassword, userEmail, classID, userType, doneTasks));
                        }
                        else if (userType == 3)
                        {
                            users.Add(new SimpleUser(userName, userPassword, userEmail, classID, userType, doneTasks));
                        }
                    }
                }
            }
            return users;
        }  //V

        /***********************************Manage Logins*************************************/

        public SimpleUser LogIn(string email, string password)
        {
            string sql = "SELECT * FROM users WHERE Email= '" + email + "'AND Password= '" + password + "'";
            SQLiteCommand command = new SQLiteCommand(sql, DBconnection);   //command executes the SQL Query
            SQLiteDataReader reader = command.ExecuteReader();              //reader receives the result if form of table
            if (reader.Read())  //if Login was Successful - email and password was found and are matching
            {
                string userEmail = reader["Email"].ToString();              //parse the table column "Email" value
                string userName = reader["Username"].ToString();            //parse the table column "Username" value
                string userPassword = reader["Password"].ToString();        //parse the table column "Password" value
                long classID = Int64.Parse(reader["ClassID"].ToString());   //parse the table column "ClassID" value
                int userType = Int32.Parse(reader["UserType"].ToString());  //parse the table column "UserType" value
                HashSet<long> doneTasks = getDoneTasks(userEmail);          //parse the table column "DoneTasks" value

                //return the relevant user
                if (userType == 1)
                {
                    return new AdminUser(userName, userPassword, userEmail, classID, userType, doneTasks);

                }
                else if (userType == 2)
                {
                    return new TeacherUser(userName, userPassword, userEmail, classID, userType, doneTasks);
                }
                else if (userType == 3)
                {
                    return new SimpleUser(userName, userPassword, userEmail, classID, userType, doneTasks);
                }
                else
                    return null;

            }
            else//Login failed - email or password was wrong or not found
                return null;


        }   //V
    }

}