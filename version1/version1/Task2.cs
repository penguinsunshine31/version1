using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace version1
{
    public  class Task2
    {
        class Person
        {
            private int age;
            public string Name { get; set; }

            public Person(int age, string name)
            {
                this.age = age;
                Name = name;
            }

            public string Introduction()
            {
                return $"Hi, I'm {Name} and I'm {age} years old";
            }
        }
        public void task2()
        {
            
            {
                
                Person person = new Person(21, "freddie");

                
                string introduction = person.Introduction();
                Console.WriteLine(introduction);
            }
        }







    }












    }
