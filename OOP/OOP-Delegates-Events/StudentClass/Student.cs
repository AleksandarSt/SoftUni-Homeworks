using System;

namespace StudentClass
{
    class Student
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private string name;
        private int age;

        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        { 
            get { return this.name; }
            set
            {
                if (value!=this.name&&this.name!=null)
                {
                    this.PropertyChanged(this, 
                            new PropertyChangedEventArgs("Name",this.name, value));
                }

                this.name = value;
            }
        }

        public int Age 
        {
            get { return this.age; }
            set
            {
                if (value != this.age&&this.age!=0)
                {
                    this.PropertyChanged(this,
                            new PropertyChangedEventArgs("Age", this.age.ToString(), value.ToString()));
                }

                this.age = value;
            }
        }

    }
}
