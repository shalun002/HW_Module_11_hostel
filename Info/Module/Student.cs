using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Ф.И.О. студента, группу, средний балл, доход на члена семьи, пол (перечисление), форма обучения(перечисление).*/

namespace Info.Module
{
    public struct Student
    {
        private string _FioOfStudent;

        public string FioOfStudent { get => _FioOfStudent; set => _FioOfStudent = value.Replace("<center><b><font size=7>", "").Replace("</font></b></center>", "").Replace("\n", ""); }
        public double Group { get; set; }
        public double AverageScore { get; set; }
        public int IncomePerFamilyMember { get; set; }
        public string Sex { get; set; }
        public string FormOfTraining { get; set; }
    }
}