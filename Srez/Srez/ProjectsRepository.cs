using SQLite;
using Srez.Model;
using System.Collections.Generic;

namespace Srez
{
    public class ProjectsRepository
    {
        SQLiteConnection database;
        public ProjectsRepository(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<User>();
            database.CreateTable<Project>();
            SaveUser(new User
            {
                FIO = "Admin",
                Login = "Admin",
                Password = "Admin",
                Role = 1
            });
        }
        public List<User> GetUsers()
        {
            return database.Table<User>().ToList();
        }
        public User GetUser(int id)
        {
            return database.Get<User>(id);
        }
        public int DeleteUser(int id)
        {
            return database.Delete<User>(id);
        }
        public int SaveUser(User user)
        {
            if (user.id != 0)
            {
                database.Update(user);
                return user.id;
            }
            else
            {
                return database.Insert(user);
            }
        }

        public List<Project> GetProjects()
        {
            if (Core.CurrentUser.Role == 1)
                return database.Table<Project>().ToList();
            else
                return database.Table<Project>().Where(x => x.User_id == Core.CurrentUser.id).ToList();
        }

        public int SaveProject(Project project)
        {
            if(project.id != 0)
            {
                database.Update(project);
                return project.id;
            }
            else
            {
                return database.Insert(project);
            }
        }

        public int DeleteProject(int id)
        {
            return database.Delete<Project>(id);
        }


    }
}
