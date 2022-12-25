using System;

namespace Homework_E_3_task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number of students");
            int numOfStudents = ReadValue();

            if (numOfStudents == 2)
            {
                Console.WriteLine("Attention! Class will be not full");
                ClassRoom classRoom = new ClassRoom(SendStudent(), SendStudent());
                PrintStudentsInfo(classRoom, numOfStudents);
            } 
            else if (numOfStudents == 3)
            {
                Console.WriteLine("Attention! Class will be not full");
                ClassRoom classRoom = new ClassRoom(SendStudent(), SendStudent(), SendStudent());
                PrintStudentsInfo(classRoom, numOfStudents);
            }
            else if (numOfStudents == 4)
            {
                ClassRoom classRoom = new ClassRoom(SendStudent(), SendStudent(), SendStudent(), SendStudent());
                PrintStudentsInfo(classRoom, numOfStudents);
            }
            else
            {
                Console.WriteLine("Number of students is too big or too low. Number of students set to 4.");
                ClassRoom classRoom = new ClassRoom(SendStudent(), SendStudent(), SendStudent(), SendStudent());
                PrintStudentsInfo(classRoom, numOfStudents);
            }
        }

        private static Pupil CreateStudent(string studentType)
        {
            
            if (studentType.Equals("Great"))
            {
                Pupil exelentPupil = new ExcelentPupil();
                return exelentPupil;
            } 
            else if (studentType.Equals("Good"))
            {
                Pupil goodPupil = new GoodPupil();
                return goodPupil;
            } 
            else if (studentType.Equals("Bad"))
            {
                Pupil badPupil = new BadPupil();
                return badPupil;
            }
            else
            {
                Console.WriteLine("We don`t have such student. Type set to Bad");
                Pupil badPupil = new BadPupil();
                return badPupil;
            }
        }

        private static string ReadStudentType()
        {
            Console.Write("Please enter students type you want to add(Great/Good/Bad): ");
            string studentType = Console.ReadLine();

            return studentType;
        }

        private static Pupil SendStudent()
        {
            return CreateStudent(ReadStudentType());
        }

        private static void PrintStudentsInfo(ClassRoom classRoom, int numberOfStudents)
        {
            if (numberOfStudents == 2)
            {
                Console.WriteLine("Class information:");
                Console.WriteLine("First student:");
                Console.Write("Studing: ");
                classRoom.FirstStudent.Study();
                Console.Write("Reading: ");
                classRoom.FirstStudent.Read();
                Console.Write("Writing: ");
                classRoom.FirstStudent.Write();
                Console.Write("Relaxing: ");
                classRoom.FirstStudent.Relax();
                Console.WriteLine();


                Console.WriteLine("Second student:");
                Console.Write("Studing: ");
                classRoom.SecondStudent.Study();
                Console.Write("Reading: ");
                classRoom.SecondStudent.Read();
                Console.Write("Writing: ");
                classRoom.SecondStudent.Write();
                Console.Write("Relaxing: ");
                classRoom.SecondStudent.Relax();
            } 
            else if (numberOfStudents == 3)
            {
                Console.WriteLine("Class information:");
                Console.WriteLine("First student:");
                Console.Write("Studing: ");
                classRoom.FirstStudent.Study();
                Console.Write("Reading: ");
                classRoom.FirstStudent.Read();
                Console.Write("Writing: ");
                classRoom.FirstStudent.Write();
                Console.Write("Relaxing: ");
                classRoom.FirstStudent.Relax();
                Console.WriteLine();

                Console.WriteLine("Second student:");
                Console.Write("Studing: ");
                classRoom.SecondStudent.Study();
                Console.Write("Reading: ");
                classRoom.SecondStudent.Read();
                Console.Write("Writing: ");
                classRoom.SecondStudent.Write();
                Console.Write("Relaxing: ");
                classRoom.SecondStudent.Relax();
                Console.WriteLine();

                Console.WriteLine("Third student:");
                Console.Write("Studing: ");
                classRoom.ThirdStudent.Study();
                Console.Write("Reading: ");
                classRoom.ThirdStudent.Read();
                Console.Write("Writing: ");
                classRoom.ThirdStudent.Write();
                Console.Write("Relaxing: ");
                classRoom.ThirdStudent.Relax();

            }
            else
            {
                Console.WriteLine("Class information:");
                Console.WriteLine("First student:");
                Console.Write("Studing: ");
                classRoom.FirstStudent.Study();
                Console.Write("Reading: ");
                classRoom.FirstStudent.Read();
                Console.Write("Writing: ");
                classRoom.FirstStudent.Write();
                Console.Write("Relaxing: ");
                classRoom.FirstStudent.Relax();
                Console.WriteLine();

                Console.WriteLine("Second student:");
                Console.Write("Studing: ");
                classRoom.SecondStudent.Study();
                Console.Write("Reading: ");
                classRoom.SecondStudent.Read();
                Console.Write("Writing: ");
                classRoom.SecondStudent.Write();
                Console.Write("Relaxing: ");
                classRoom.SecondStudent.Relax();
                Console.WriteLine();

                Console.WriteLine("Third student:");
                Console.Write("Studing: ");
                classRoom.ThirdStudent.Study();
                Console.Write("Reading: ");
                classRoom.ThirdStudent.Read();
                Console.Write("Writing: ");
                classRoom.ThirdStudent.Write();
                Console.Write("Relaxing: ");
                classRoom.ThirdStudent.Relax();
                Console.WriteLine();

                Console.WriteLine("Fouth student:");
                Console.Write("Studing: ");
                classRoom.FourthStudent.Study();
                Console.Write("Reading: ");
                classRoom.FourthStudent.Read();
                Console.Write("Writing: ");
                classRoom.FourthStudent.Write();
                Console.Write("Relaxing: ");
                classRoom.FourthStudent.Relax();
            }
            
        }

        private static int ReadValue()
        {
            do
            {
                try
                {
                    int number = Convert.ToInt32(Console.ReadLine());
                    return number;
                }
                catch
                {
                    Console.WriteLine("Please enter only int values");
                }
            } while (true);
        }
    }
}
