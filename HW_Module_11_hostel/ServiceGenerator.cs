using GeneratorName;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Info.Module;


namespace HW_Module_11_hostel
{
    public enum Sex { man, women }
    public enum FormOfTraining { daytime_education, evening_form_of_training, full_time_education, extramural_studies }

    public class ServiceGenerator
    {
        private Random rand = new Random();
        Generator gen = new Generator();
        protected double MinSalary = 15000;


        public List<Student> students;

        public ServiceGenerator()
        {
            students = new List<Student>();
        }

        public void ServiceGeneratorStudents()
        {
            for (int i = 0; i < 10; i++)
            {
                Student student = new Student();

                if (student.Sex == (Sex.man).ToString())
                {
                    student.FioOfStudent = gen.GenerateDefault(Gender.man);
                }
                else
                    student.FioOfStudent = gen.GenerateDefault(Gender.woman);

                student.Group = (double)rand.Next(10, 100);
                student.AverageScore = (double)rand.Next(0, 12);
                student.IncomePerFamilyMember = rand.Next(15000, 50000);
                student.FormOfTraining = ((FormOfTraining)rand.Next(0, 4)).ToString();

                students.Add(student);
            }
        }

        public void PrintAll(List<Student> students)
        {
            foreach (Student item in students)
            {
                Console.WriteLine();
                Console.WriteLine($"Ф.И.О - {item.FioOfStudent}, группа - {item.Group}, средний балл - {item.AverageScore}, пол - {item.Sex}, форма обучения - {item.FormOfTraining}");
                Console.WriteLine();
            }
        }

        public void CheckToHostel(List<Student> students)
        {
            students = students.OrderBy(o => o.IncomePerFamilyMember).ToList();

            foreach (Student item in students)
            {
                if (item.IncomePerFamilyMember < (MinSalary * 2))
                {
                    Console.WriteLine($"В первую очередь место в общежитии предоставят - {item.FioOfStudent}");
                    students.Add(item);
                }
            }

            foreach (Student item in students)
            {
                students = students.OrderBy(o => o.AverageScore).ToList();

                if(students.Count() < 12)

            }
        }
    }
}