// See https://aka.ms/new-console-template for more information
namespace Tutorial
{
    internal class Student
    {
        private int rno;
        private String Sname;

        Student()
        {
            rno = 20000000;
            Sname = "X";
        }
            
        Student(int rno, string Sname)
        {
            this.rno = rno;
            this.Sname = Sname;
        }

        void display()
        {
            Console.WriteLine("rno is {0} and name is {1}",rno,Sname);
        }

        public static void Main()
        {
            Student student1 = new Student();
            //student1.accept(20301207, "Niloy");
            student1.display();

            Student student2 = new Student(20301208, "Sami");
            //student2.accept(20301208, "Sami");
            student2.display();
        }
    }
}
