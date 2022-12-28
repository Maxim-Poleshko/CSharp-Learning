using System;
namespace a5_ClassMethodStructInterface_Player
{
	public class Player
	{
        public string Username;
        public int Age;
        public string Sex;

        public Player(string username, int age, string sex)
        {
            Username = username;
            Age = age;
            Sex = sex;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"User: {Username} - age: {Age} - sex: {Sex}");
        }
    }
}

