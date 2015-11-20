using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareUniversityLearningSystem
{
    internal class SULSTest
    {
        public static void Main(string[] args)
        {
            var persons = new List<Person>()
            {
                new Person("Ivan", "Ivanov", 35),
                new Person("Petar", "Petrov", 25),
                new Student("Hristo","Vanchev",34,900012312,4.56),
                new Student("Hristo","Botev",28,900016312,5.26),
                new Trainer("Aleksandar","Georgiev",30),
                new Trainer("Toshko","Todorov",45),
                new JuniorTrainer("Todor","Jivkov",18),
                new JuniorTrainer("Stamat","Rangelov",22),
                new SeniorTrainer("Georgi","Gerorgiev",39),
                new SeniorTrainer("Rumen","Petrov",45),
                new GraduateStudent("Mariya","Ivanova",24,900045456,5.50),
                new GraduateStudent("Spas","Trifonov",23,900064646,4.67),
                new DropoutStudent("Trifon","Ivanov",19,900022323,3.36,"He wants to be footballer."),
                new DropoutStudent("Steve","Jobs",30,900023423,5.99,"Too smart"),
                new CurrentStudent("Stefan","Berov",28,900034325,4.90,"Data Structures"),
                new CurrentStudent("Tihomir","Ivanov",40,900033457,4.13,"OOP"),
                new OnlineStudent("Dobril","Dobrev",32,900003345,5.20,"Advanced C#"),
                new OnlineStudent("Eduard","Borisov",18,900023445,5.03,"Java Script Basics"),
                new OnsiteStudent("Georgi","Dimitrov",60,900000001,3.90,"Theory of Communism",100),
                new OnsiteStudent("Andrei","Penchev",20,90345670,5.70,"Advanced Java",2)
            };

            
        }
    }
}
