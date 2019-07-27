using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEqual
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("zhangsan", "21");
            Student student2 = new Student("zhangsan", "21");//和stu1内容相同，引用不同
            Student stu3 = student1;//和stu1引用相同
            Console.WriteLine("通过相等符号比较内容相同的引用类型：{0}",student1 == student2);
            Console.WriteLine("通过相等符号比较通过赋值引用的引用类型：{0}", student1 == stu3);
            Console.WriteLine("by Equal method:{0}", student1.Equals(student2));
            Console.WriteLine("by Equal two object type method:{0}", student1.Equals(stu3));
            Console.WriteLine("by referenceEqual method:{0}", ReferenceEquals(student1, student2));
            Console.WriteLine("by referenceEqual method:{0}", ReferenceEquals(student1, stu3));
            //对与引用类型只有引用一样才相等，其余都不相等
            int a = 10;
            int b = 10;
            int c = a;
            Console.WriteLine("by == two value type:{0}", a == b);
            Console.WriteLine("by == two value type:{0}", a == c);
            Console.WriteLine("by Equal:{0}", a.Equals(b));
            Console.WriteLine("by Equal:{0}", a.Equals(c));
            Console.WriteLine("by ReferenceEqual：{0}", ReferenceEquals(a, b));//false
            Console.WriteLine("by ReferenceEqual：{0}", ReferenceEquals(a, c));//false
            Teacher teacher = new Teacher("san", "32");
            Teacher teacher2 = new Teacher("san", "32");
            Teacher teacher3 = teacher;
            //Console.WriteLine("by == two value type:{0}", teacher==teacher2);
            //Console.WriteLine("by == two value type:{0}", teacher == teacher3);
            Console.WriteLine("by Equal:{0}", teacher.Equals(teacher2));
            Console.WriteLine("by Equal:{0}", teacher.Equals(teacher3));
            Console.WriteLine("by ReferenceEqual：{0}", ReferenceEquals(teacher, teacher2));//false
            Console.WriteLine("by ReferenceEqual：{0}", ReferenceEquals(teacher, teacher3));//false
            //对于值类型无论==还是Equal方法只要值相等便相等
            string a1 = "bsj";
            string b1 = "bsje";
            string c1 = a1;
            Console.WriteLine("by == two string type:{0}", a1 == b1);
            Console.WriteLine("by == two string type:{0}", a1== c1);
            Console.WriteLine("by Equal:{0}", a1.Equals(b1));
            Console.WriteLine("by Equal:{0}", a1.Equals(c1));
            Console.WriteLine("by ReferenceEqual：{0}", ReferenceEquals(a1, b1));
            Console.WriteLine("by ReferenceEqual：{0}", ReferenceEquals(a1, c1));
            Console.Read();

        }
        public class Student
        {
            public string name;
            public string age;
            public Student(string _name,string _age)
            {
                this.name = _name;
                this.age = _age;
            }
        }
        public struct Teacher
        {
            public string name;
            public string age;
            public Teacher(string name,string age)
            {
                this.name = name;
                this.age = age;
            }
        }
    }
}
