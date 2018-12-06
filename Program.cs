using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ex03._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Points Calculator");
            Result newExam = new Result();
            newExam.getSubject();

        }

      
    }

    class Result
    {
        private string subject;
        private int level;
        private double percentage;
        private string grade;
        private int points;

        public string getSubject()
        {
            Console.WriteLine("Please enter the exam subject.");
            subject = Convert.ToString(Console.ReadLine()).ToUpper();
            return subject;
        }

        public int getLevel()
        {
            Console.WriteLine("Please enter the level of exam. (Higher = 1, Ordinary = 2, Foundation = 3");
            level = Convert.ToInt32(Console.ReadLine());
            return level;
        }

        public double getPercentage()
        {
            Console.WriteLine("Please enter the percentage achieved in the exam.");
            percentage = Convert.ToDouble(Console.ReadLine());
            return percentage;
        }

        public string getGrade()
        {
            if (percentage <= 9.99)
            {
                grade = "NG";
            }
            else if (percentage >= 10 && percentage <= 24.99)
            {
                grade = "F";
            }
            else if (percentage >= 25 && percentage <= 39.99)
            {
                grade = "E";
            }
            else if (percentage >= 40 && percentage <= 44.99)
            {
                grade = "D3";
            }
            else if (percentage >= 45 && percentage <= 49.99)
            {
                grade = "D2";
            }
            else if (percentage >= 50 && percentage <= 54.99)
            {
                grade = "D1";
            }
            else if (percentage >= 55 && percentage <= 59.99)
            {
                grade = "C3";
            }
            else if (percentage >= 60 && percentage <= 64.99)
            {
                grade = "C2";
            }
            else if (percentage >= 65 && percentage <= 69.99)
            {
                grade = "C1";
            }
            else if (percentage >= 70 && percentage <= 74.99)
            {
                grade = "B3";
            }
            else if (percentage >= 75 && percentage <= 79.99)
            {
                grade = "B2";
            }
            else if (percentage >= 80 && percentage <= 84.99)
            {
                grade = "B1";
            }
            else if (percentage >= 85 && percentage <= 89.99)
            {
                grade = "A2";
            }
            else if (percentage >= 90 && percentage <= 100)
            {
                grade = "A1";
            }

            return grade;
        }

        public int getPoints()
        {
            if (level == 1) //if higher level
               { 
                    switch (getGrade())
                {
                    case "A1":
                        points = 100;
                        break;
                    case "A2":
                        points = 90;
                        break;
                    case "B1":
                        points = 85;
                        break;
                    case "B2":
                        points = 80;
                        break;
                    case "B3":
                        points = 75;
                        break;
                    case "C1":
                        points = 70;
                        break;
                    case "C2":
                        points = 65;
                        break;
                    case "C3":
                        points = 60;
                        break;
                    case "D1":
                        points = 55;
                        break;
                    case "D2":
                        points = 50;
                        break;
                    case "D3":
                        points = 45;
                        break;
                    case "E": case "F": case "NG":
                        points = 0;
                        break;

                }
                }
            else if (level == 2) //ordinary level
               { switch (getGrade())
                {
                    case "A1":
                        points = 60;
                        break;
                    case "A2":
                        points = 50;
                        break;
                    case "B1":
                        points = 45;
                        break;
                    case "B2":
                        points = 40;
                        break;
                    case "B3":
                        points = 35;
                        break;
                    case "C1":
                        points = 30;
                        break;
                    case "C2":
                        points = 25;
                        break;
                    case "C3":
                        points = 20;
                        break;
                    case "D1":
                        points = 15;
                        break;
                    case "D2":
                        points = 10;
                        break;
                    case "D3":
                        points = 5;
                        break;
                    case "E":
                    case "F":
                    case "NG":
                        points = 0;
                        break;

                }
                }
            else if (level == 3) //foundation level
               { switch (getGrade())
                {
                    case "A1":
                        points = 20;
                        break;
                    case "A2":
                        points = 15;
                        break;
                    case "B1":
                        points = 10;
                        break;
                    case "B2":
                        points = 5;
                        break;
                    case "B3": case "C1": case "C2": case "C3": case "D1": case "D2": case "D3": case "E": case "F": case "NG":
                        points = 0;
                        break;

                }
                }
            return points;
        }


        private int getExtraMathPoints()
        {
            if (subject == "MATHS" && level == 1 && percentage >= 40)
                {
               points = points + 25;                 
                    return points;
                }
         }

        public void setSubjectValue(string value)
        {
            this.subject = value;
            
        }

        public int setLevel(int value)
        {
            this.level = value;
        }

        public void setPercentage(double value)
        {
            this.percentage = value;            
        }

    }

}
