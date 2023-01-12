using System;
using a6_OOP_User;

namespace a6_OOP_UserDB
{
    public class UserDB
    {
        List<User> users = new List<User>();

        public void AddUser()
        {
            Console.Write("\nSet the username: ");
            string Username = Console.ReadLine();

            Console.Write("Set your level: ");
            int Level = Convert.ToInt32(Console.ReadLine());

            int Id = GetMaxId(users.Count());

            User user = new User(Username, Id, Level, false);
            users.Add(user);
        }

        public void BannUser()
        {
            int idToBannUser;
            Console.Clear();

            if (users.Count() > 0)
            {
                Console.WriteLine("List of available users in DB");
                foreach (var user in users)
                {
                    Console.WriteLine($"{user.Id} {user.Name} {user.Level} {user.Banned}");
                }

                Console.Write("\nWho you want to Ban via ID number: ");
                idToBannUser = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < users.Count(); i++)
                {
                    if (idToBannUser == users[i].Id)
                    {
                        idToBannUser = users.IndexOf(users[i]);
                        users[i].Banned = true;
                    }
                }
            }
            else
            {
                Console.WriteLine("None of user has been added to the list yet.");
            }
        }

        public void UnbanUser()
        {
            int idToUnbanUser;
            bool availableBannedUsers = false;
            Console.Clear();

            Console.WriteLine("List of available banned users in DB");
            foreach (var user in users)
            {
                if (user.Banned)
                {
                    Console.WriteLine($"{user.Id} {user.Name} {user.Level} {user.Banned}");
                    availableBannedUsers = true;
                }
            }

            if (availableBannedUsers == false)
            {
                Console.WriteLine("None of user has been banned yet.");
                Console.WriteLine();
            }
            else
            {
                Console.Write("\nWho you want to Unban via ID number: ");
                idToUnbanUser = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < users.Count(); i++)
                {
                    if (idToUnbanUser == users[i].Id)
                    {
                        idToUnbanUser = users.IndexOf(users[i]);
                        users[i].Banned = false;
                    }
                }
            }
        }

        public void DeleteUser()
        {
            int idToDeleteUser;
            bool finderOfUser = false;

            if (users.Count() > 0)
            {
                Console.Write("\nWho you want to delete via ID number: ");
                idToDeleteUser = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < users.Count(); i++)
                {
                    if (idToDeleteUser == users[i].Id)
                    {
                        idToDeleteUser = users.IndexOf(users[i]);
                        Console.WriteLine($"Deleted: {users[i].Id} {users[i].Name} {users[i].Level} {users[i].Banned}");

                        users.Remove(users[idToDeleteUser]);
                        finderOfUser = true;
                    }
                }
            }

            if (finderOfUser == false)
            {
                Console.WriteLine("None of user has been found.");
            }
        }

        public int GetMaxId(int id)
        {
            foreach (var user in users)
            {
                if (user.Id >= id)
                {
                    id += 1;
                }
            }
            return id;
        }

        public void ShowUsers()
        {
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Id} - {user.Name} - {user.Level} - banned status {user.Banned}");
            }
        }

        public void BuetifyOutput()
        {
            Console.WriteLine();
            Console.ReadLine();
            Console.Clear();
        }
    }
}

