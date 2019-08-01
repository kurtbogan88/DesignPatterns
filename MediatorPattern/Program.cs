using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var mediator = new Mediator();
            var teacher = new Teacher(mediator) { Name="murat"  };
            mediator.Teacher = teacher;

            var ogr1 = new Student(mediator) { Name = "ali" };
            var ogr2 = new Student(mediator) { Name = "veli" };
            var ogr3 = new Student(mediator) { Name = "ahmet" };

            mediator.students = new List<Student>()
            {
                 ogr1,ogr2,ogr3
            };

            teacher.SendNewImageUrl("image url");

            Console.ReadLine();
            
        }
    }

    abstract class CourseMember
    {
         protected Mediator Mediator;
        protected CourseMember(Mediator mediator)
        {
            Mediator = mediator;
        }
        public abstract string Name { get; set; }
    }

    class Student : CourseMember
    {
        public Student(Mediator mediator):base(mediator)
        {
        }

        public override string Name { get; set; }

        internal void RecieveImgUrl(string url)
        {
            Console.WriteLine("Receive İmage:{0}", url);
        }

        internal void RecieveAnswer(string answer)
        {
            Console.WriteLine("Answer:{0}", answer);
        }
    }

    class Teacher : CourseMember
    {
        public Teacher(Mediator mediator):base(mediator)
        {
         
        }

        public override string Name { get; set; }

        internal void RecieveQuestion(string question, Student student)
        {
            throw new NotImplementedException();
        }

        public void SendNewImageUrl(string url)
        {
            Console.WriteLine("Resim gönderildi");
            Mediator.UpdateImage(url);
        }

        public void AnswerQuestion(string answer,Student student)
        {
            Console.WriteLine("Asnwered: {0}, student:{1}", answer, student.Name);
            Mediator.SendAnswer(answer, student);
        }
    }

    class Mediator
    {
        public Teacher Teacher;
        public List<Student> students;

        public void UpdateImage(string url)
        {
            foreach (var student in students)
                student.RecieveImgUrl(url);
        }

        public void SendQuestion(string question, Student student)
        {
            Teacher.RecieveQuestion(question, student);
        }

        public void SendAnswer(string answer, Student student)
        {
            student.RecieveAnswer(answer);
        }
    }
}
