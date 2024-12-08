using TestSkill;
using TestSkill.Enum;
using TestSkill.Figure;
namespace Prog
{
    public static class Prog
    {
        public static void Main(string[] args)
        {
            Obj obj = new Obj();

        }
        //public static void Deep(string stringEcho,int deepEcho,int indexStart = 0)
        //{
        //    if (stringEcho.Length > 2)
        //    {
        //        Console.WriteLine("...{0}", stringEcho);
        //        if(indexStart<_arrayColor.Length)
        //        {
        //            ChangeConsoleColor(_arrayColor[indexStart]);  
        //        }
        //        stringEcho = stringEcho.Remove(0, 2);
        //        Deep(stringEcho,deepEcho - 1, indexStart + 1);
        //    }
        //}
        //public static void SortAll(int[] array)
        //{
        //    SortArrayAsc(array);
        //    ShowArray(array);
        //    Console.WriteLine(Environment.NewLine);
        //    SortArrayDesc(array);
        //    ShowArray(array);
        //}
        public static void ShowArray(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
        }
        public static int[] CreateNewArray(int number = 5)
        {
            return new int[number];
        }
        public static int[] SortArrayDesc(int[] arr, int buffer = 0)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length - 1; j++)
                {
                    if (arr[i] > arr[j + 1])
                    {
                        buffer = arr[j + 1];
                        arr[j + 1] = arr[i];
                        arr[i] = buffer;

                    }
                }
            }
            return arr;
        }
        public static int[] SortArrayAsc(int[] arr, int buffer = 0)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length - 1; j++)
                {
                    if (arr[i] < arr[j + 1])
                    {
                        buffer = arr[j + 1];
                        arr[j + 1] = arr[i];
                        arr[i] = buffer;

                    }
                }
            }
            return arr;
        }
        public static void SaveName(string name)
        {
            name = Console.ReadLine()??"Empty";
        }
        public static void ChangeChar(char name)
        {
            name = char.Parse(Console.ReadLine()??"O");
            Console.WriteLine(name.GetHashCode());
        }
        public static void SaveOld(int old)
        {
            old = int.Parse(Console.ReadLine()??"0");
        }
        public static void ChangeNumberInArray(in int[] arr)
        {
            arr[0] = 4;
        }
        public static void ChangeConsoleColor(string? color)
        {
            switch (color)
            {
                case "Red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "Green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case "Yellow":
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case "Cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case "Brown":
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case "Cyber":
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("Unknow color");
                    break;

            }

        }
            //    for(int i = 0; i < _arrayColor.Length; i++)
            //    {
            //        _arrayColor[i] = ShowColor();
            //    }
            //    foreach(string s in _arrayColor)
            //    {
            //        switch (s)
            //        {
            //            case "Red":
            //                Console.BackgroundColor = ConsoleColor.Red;
            //                Console.ForegroundColor = ConsoleColor.Green;
            //                break;
            //            case "Green":
            //                Console.BackgroundColor = ConsoleColor.Green;
            //                Console.ForegroundColor = ConsoleColor.Black;
            //                break;
            //            case "Yellow":
            //                Console.BackgroundColor = ConsoleColor.Yellow;
            //                Console.ForegroundColor = ConsoleColor.Black;
            //                break;
            //            case "Cyan":
            //                Console.BackgroundColor = ConsoleColor.Cyan;
            //                Console.ForegroundColor = ConsoleColor.Black;
            //                break;
            //            case "Brown":
            //                Console.BackgroundColor = ConsoleColor.Gray;
            //                Console.ForegroundColor = ConsoleColor.Black;
            //                break;
            //            case "Cyber":
            //                Console.BackgroundColor = ConsoleColor.Black;
            //                Console.ForegroundColor = ConsoleColor.Green;
            //                break;

            //            default:
            //                Console.ForegroundColor = ConsoleColor.White;
            //                Console.BackgroundColor = ConsoleColor.Black;
            //                Console.WriteLine("Unknow color");
            //                break;

            //        }
            //}
            //Console.WriteLine("What your name?");
            //User.Item1 = Console.ReadLine();
            //Console.WriteLine("What your surname?");
            //User.Item2 = Console.ReadLine();
            //Console.WriteLine("What your Login");
            //User.Item3 = Console.ReadLine();
            //User.Item4 = User.Item3.Length;
            //Console.WriteLine("Have a pet?");
            //User.Item5 = bool.Parse(Console.ReadLine());
            //Console.WriteLine("Years old?");
            //User.Item6 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Write your favorite 3 color");
            //User.Item7 = Console.ReadLine();
            //Console.WriteLine($"Your name {User.Name}\nYou surname {User.Surname}\nYou login {User.Login} and login length {User.LoginLength}\n");
            //Console.WriteLine("{0}",User.havePet ?"You have a pet":"You have not a pet");
            //Console.WriteLine($"Year old {User.Age} and Three favorit color {User.ThreeColor}");
            //// сортировка двумерного массива!
            //int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            //for(int i = 0; i < arr.GetLength(0); i++)
            //{
            //    Console.WriteLine();
            //    for(int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        for (int k = j+1; k < arr.GetLength(1)-1; k++)
            //        {
            //            if (arr[i, j] > arr[i, k])
            //            {
            //                buffer = arr[i, k];
            //                arr[i, k] = arr[i, j];
            //                arr[i, j] = buffer;

            //            }
            //        }
            //    }
            //}
            // for(int i = 0;i<arr.GetLength(0);i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0;j < arr.GetLength(1);j++)
            //    {
            //        Console.Write(arr[i,j]);
            //    }
            //}
            ////int[][] arr = new int[3][];
            //arr[0] = new int[2] { 1, -2 };
            //arr[1] = new int[3] { 1, -2, 3 };
            //arr[2] = new int[5] { -1, 2, 3, 4, 5 };
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
            //        if (arr[i][j] > 0)
            //        {
            //            countPositivNumbers++;
            //        }
            //        else
            //        {
            //            countNegativNumbers++;
            //        }
            //    }
            //}
            //Console.WriteLine($"{countNegativNumbers},{countPositivNumbers}");
            // var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 ,99,100,56,89,11};
            // int buffer;
            //for(int i = 0; i < arr.Length-1; i++)
            // {
            //     for (int j = i; j < arr.Length - 1; j++)
            //     {
            //          if (arr[i] > arr[j + 1])
            //         {
            //         buffer = arr[j + 1];
            //         arr[j + 1] = arr[i];
            //         arr[i] = buffer;
            //         }

            //     }
            // }
            //for(int i = 0;i < arr.Length - 1; i++)
            // {
            //     sum =+ arr[i];
            // }
            //foreach(int a in arr)
            // {

            //     Console.Write($"\t{a}");

            // }
            // Console.WriteLine(sum.ToString());

            //string[] arrayString = new string[3];
            //for(int i = 0; i < arrayString.Length; i++)
            //{
            //    arrayString[i]= Console.ReadLine();
            //}

            //foreach (string s in arrayString)
            //{

            //    switch (s)
            //    {
            //        case "red":
            //            Console.BackgroundColor = ConsoleColor.Red;
            //            Console.ForegroundColor = ConsoleColor.Green;
            //            break;
            //        case "green":
            //            Console.BackgroundColor = ConsoleColor.Green;
            //            Console.ForegroundColor = ConsoleColor.Black;
            //            break;
            //        case "yellow":
            //            Console.BackgroundColor = ConsoleColor.Yellow;
            //            Console.ForegroundColor = ConsoleColor.Black;
            //            break;
            //        case "cyan":
            //            Console.BackgroundColor = ConsoleColor.Cyan;
            //            Console.ForegroundColor = ConsoleColor.Black;
            //            break;
            //        case "brown":
            //            Console.BackgroundColor = ConsoleColor.Gray;
            //            Console.ForegroundColor = ConsoleColor.Black;
            //            break;
            //        case "cyber":
            //            Console.BackgroundColor = ConsoleColor.Black;
            //            Console.ForegroundColor = ConsoleColor.Green;
            //            break;

            //        default:
            //            Console.ForegroundColor = ConsoleColor.White;
            //            Console.BackgroundColor = ConsoleColor.Black;
            //            Console.WriteLine("Введен не понятный цвет");
            //            break;

            //    }
            //    Console.WriteLine("Color");
            //}
        } 
}


