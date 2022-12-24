using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_E_2_task_4
{
    class User
    {
        string login, name, surname;
        int age;
        readonly string dateOfRegistration;
        
        public User(string login, string name, string surname, int age, string dateOfRegistration)
        {
            this.login = login;
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.dateOfRegistration = dateOfRegistration;
        }

        public string Login
        {
            get
            {
                return login;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
        }

        public string DateOfRegistration
        {
            get
            {
                return dateOfRegistration;
            }
        }

    }
}
