using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Indexators

{
    class Program
    {
        static void Main(string[] args)
        {
            Collage college = new Collage();

            for (int i = 0; i < college.Length; i++)
            {
                for (int j = 0; j < college[i].Length; j++)
                {
                    college[i][j] = "";
                }
            }
        }
    }

    class Collage
    {
        private Dictionary<int, Student> students;

        public Collage()
        {
            students = new Dictionary<int, Student>();

            students.Add(0, new Student());
            students.Add(1, new Student());
        }

        public Student this[int index]
        {
            get => students[index];

            set => students[index] = value;
        }

        public int Length => students.Count;
    }

    class Student
    {
        private string[] friends = new[] { "Vacho", "Andrei", "Milana" };

        public string this[int index]
        {
            get => friends[index];

            set => friends[index] = value;
        }

        public int Length => friends.Length;
    }
}

