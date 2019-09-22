using System;
using System.Collections.Generic;
using System.Text;

namespace _17._09._2019
{
    class UserList
    {
        //List<int> numbers = new List<int>() { 1, 2, 3, 45 };
        List< User > arrayUser;
        public UserList()
        {
            arrayUser = new List<User>();
        }
        public void AddUser()
        {
            arrayUser.Add(new User());
        }
        public User this[int id]
        {
            get
            {
                if (id > arrayUser.Count)
                    throw new Exception("Invalid index");
                foreach (var n in arrayUser)
                    if (n.Id == id)
                        return n;
                return null;
            }
            set
            {
                if (id > arrayUser.Count)
                    throw new Exception("Invalid index");
                for (int i = 0; i < arrayUser.Count; i++)
                {
                    if (arrayUser[i].Id == id)
                        arrayUser[i] = value;
                }
            }
        }
        public User this[string password]
        {
            get
            {
                foreach (var n in arrayUser)
                    if (n.Password == password)
                        return n;
                return null;
            }
            set
            {
                for (int i = 0; i < arrayUser.Count; i++)
                {
                    if (arrayUser[i].Password == password)
                        arrayUser[i] = value;
                }
            }
        }
        public User this[string login,string password]
        {
            get
            {
                foreach (var n in arrayUser)
                    if (n.Login == login&& n.Password == password)
                        return n;
                return null;
            }
            set
            {
                for (int i = 0; i < arrayUser.Count; i++)
                {
                    if (arrayUser[i].Login == login&& arrayUser[i].Password == password)
                        arrayUser[i] = value;
                }
            }
        }
    }
}
