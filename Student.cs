using System;

namespace lab4
{
    class Student : IComparable<Student>
    {
        private string nameOfStudent;                 //створюємо закриті поля
        private string secondNameOfStudent;
        private double heightOfStudent;
        private int averageMark;
        private int weight;

        public Student(string name, string secondName, double height, int mark, int weight)     //створюємо конструктор
        {
            this.nameOfStudent = name;
            this.secondNameOfStudent = secondName;
            this.heightOfStudent = height;
            this.averageMark = mark;
            this.weight = weight;
        }

        public string NameOfStudent          //
        {
            get { return nameOfStudent; }
            set { nameOfStudent = value; }
        }
        public string SecondNameOfStudent
        {
            get { return secondNameOfStudent; }
            set { secondNameOfStudent = value; }
        }
        public double HeightOfStudent
        {
            get { return heightOfStudent; }
            set { heightOfStudent = value; }
        }
        public int AverageMark
        {
            get { return averageMark; }
            set { averageMark = value; }
        }
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public int CompareTo(Student p)      //реалізуємо інтерфейс IComparable
        {
            return this.heightOfStudent.CompareTo(p.heightOfStudent);
        }
        
    }
}
