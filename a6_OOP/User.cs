using System;
namespace a6_OOP_User
{
	public class User
	{
        public string Name { get; private set; }
        public int Id { get; }
        public int Level { get; private set; }
        public bool Banned { get; set; }

        public User(string name, int id, int level, bool banned = false)
        {
            Name = name;
            Id = id;
            Level = level;
            Banned = banned;
        }
    }
}

