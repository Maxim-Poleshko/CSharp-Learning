//Реализовать базу данных игроков и методы для работы с ней.
//У игрока может быть порядковый номер, ник, уровень, флаг – забанен ли он(флаг - bool).
//Реализовать возможность добавления игрока, бана игрока по порядковому номеру, разбана игрока по порядковому номеру и удаление игрока.

using a6_OOP_User;
using a6_OOP_UserDB;

class a6_OOP
{
    static void Main(string[] args)
    {
        bool appRunning = true;
        int userInput;

        UserDB userDB = new UserDB();

        while (appRunning)
        {
            Console.WriteLine("Set '1' to add new user\nSet '2' to ban user\nSet '3' to unban user\nSet '4' to delete user\nSet '5' to exit");
            Console.Write("Choose menu option: ");

            switch (userInput = Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    userDB.AddUser();
                    userDB.ShowUsers();
                    userDB.BuetifyOutput();
                    break;

                case 2:
                    userDB.BannUser();
                    userDB.ShowUsers();
                    userDB.BuetifyOutput();
                    break;

                case 3:
                    userDB.UnbanUser();
                    userDB.ShowUsers();
                    userDB.BuetifyOutput();
                    break;

                case 4:
                    userDB.ShowUsers();
                    userDB.DeleteUser();
                    userDB.BuetifyOutput();
                    break;

                case 5:
                    appRunning = false;
                    Console.WriteLine("App has been stopped.");
                    break;

                default:
                    Console.WriteLine("Something went wrong!");
                    appRunning = false;
                    break;
            }
        }
    }
}