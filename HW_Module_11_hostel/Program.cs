using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 2. Для получения места в общежитии формируется список студентов, который включает 
              Ф.И.О. студента,
              группу,
              средний балл,
              доход на члена семьи,
              пол (перечисление),
              форма обучения(перечисление). 
      Общежитие в первую очередь предоставляется тем, у кого доход на члена семьи меньше двух минимальных зарплат, затем остальным в порядке уменьшения среднего балла. Вывести список очередности предоставления мест в общежитии.*/

namespace HW_Module_11_hostel
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceGenerator sg = new ServiceGenerator();
            sg.ServiceGeneratorStudents();
            sg.PrintAll(sg.students);
            sg.CheckToHostel(sg.students);
        }
    }
}
