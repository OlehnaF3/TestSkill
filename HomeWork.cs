using TestSkill.Enum;

namespace TestSkill
{
    class HomeWork
    {
        private (string name, string surname, byte age, bool havepet, string[] namesOfPet, byte numberOfFavoriteColor, string[] arrayColor) User;
        /// <summary>
        /// Заполнение кортежа User;
        /// </summary>
        /// <returns></returns>
        public HomeWork()
        {
            User = Foo();
            Writeturple(User);
        }
        private (string name, string surname, byte age, bool havepet, string[] namesOfPet, byte numberOfFavoriteColor, string[] arrayColor) Foo()
        {
            string[]? nameOfPet;
            Console.WriteLine("What you name?");
            string Name = Console.ReadLine()??"Empty";
            Console.WriteLine("What you surname?");
            string Surname = Console.ReadLine()??"Empty";
            Console.WriteLine("How many Age?");
            byte Age = CorretlyInput();
            Console.WriteLine("Do you have a pet? Write \"Yes\" or \"No\"");
            bool havePet = Console.ReadLine() == "Yes" ? true : false;
            if (havePet)
            {
                Console.WriteLine("Write how many pet you have");
                nameOfPet = CreatePetNameArray(CorretlyInput());
            }
            else
            {
                nameOfPet = null;
            }
            Console.WriteLine("Write how many you have favorite color");
            byte numberOfFavoriteColor = CorretlyInput();
            string[] arrayColor = CreateArrayColor(numberOfFavoriteColor);

            return (Name, Surname, Age, havePet, nameOfPet, numberOfFavoriteColor, arrayColor);
        }
        /// <summary>
        /// Вывод на консоль кортежа User!
        /// </summary>
        /// <param name="User"></param>
        public void Writeturple((string name, string surname, byte age, bool havePet, string[] namesOfPet, byte numberOfFavoriteColor, string[] arrayColor) User)
        {
            Console.WriteLine($"You name : \"{User.name}\"\nYou surname : \"{User.surname}\"\nAre you old : \"{User.age}\"\nThe number of favorite colors : \"{User.numberOfFavoriteColor}\"");
            Console.WriteLine("You have pets : \"{0}\"", User.havePet ? "Yes" : "No");
            if (User.havePet)
            {
                foreach (string names in User.namesOfPet)
                {
                    Console.WriteLine("Names of pets : \"{0}\"", names);
                }
            }
            if (User.numberOfFavoriteColor != 0)
            {
                foreach (string color in User.arrayColor)
                {
                    Console.WriteLine("You favorite color : \"{0}\"", color);
                }
            }
            Console.WriteLine();
        }
        private byte CorretlyInput(bool corretly = false, byte s = 0)
        {
            do
            {
                try
                {
                    s = byte.Parse(Console.ReadLine()??"0");
                    if (s == 0)
                    {
                        Console.WriteLine("You can't write 0");
                        corretly = true;
                    }
                    else if (s > 100)
                    {
                        Console.WriteLine("You can't write >100");
                        corretly = true;
                    }
                    else
                    {
                        corretly = false;
                    }

                }

                catch
                {
                    Console.WriteLine("Write correctly number");
                    corretly = true;
                }
            } while (corretly);
            return s;
        }

        private string[] CreatePetNameArray(byte scorePet)
        {
            string[] strings = new string[scorePet];
            for (int i = 0; i < strings.Length; i++)
            {
                Console.WriteLine("Write name {0} pet", i + 1);
                strings[i] = Console.ReadLine()??"Noname";
            }
            return strings;
        }
        private string[] CreateArrayColor(byte numberOfFavoriteColor)
        {
            string[] arrayColor = new string[numberOfFavoriteColor];
            for (int i = 0; i < arrayColor.Length; i++)
            {
                Console.WriteLine("You favorite color {0}", i);
                arrayColor[i] = CheckCorretlyColor();
            }
            return arrayColor;
        }
        private bool CheckColor(string color)
        {
            var colors = System.Enum.GetValues(typeof(EnumColor.Color));

            foreach (var equl in colors)
            {
                if (equl.ToString() == color) return true;
            }
            return false;
        }

        /// <summary>
        /// Проверка на цвет,сравнение идет из EnumColor,Дефолтное количество попыток 3 
        /// </summary>
        /// <param name="color"></param>
        /// <param name="tryscore"></param>
        /// <returns>Возвращает строку</returns>
        private string CheckCorretlyColor(string? color = null, byte tryscore = 3)
        {
            do
            {
                color = Console.ReadLine()??"Empty";
                if (!CheckColor(color))
                {
                    if (tryscore == 0)
                    {
                        break;
                    }
                    Console.WriteLine("Write another color, I do not know what kind of color it is");
                    tryscore--;

                }

            } while (!CheckColor(color));
            return color;
        }
        /// <summary>
        /// Вычесление степеней. Рекурсия!!
        /// </summary>
        /// <param name="number"></param>
        /// <param name="pow"></param>
        /// <returns></returns>
        public int PowerUp(int number, byte pow) => pow <= 0 ? 1 : number * PowerUp(number, --pow);
        /// <summary>
        /// Вычесление факториала. Рекурсия!!
        /// </summary>
        /// <param name="score"></param>
        /// <returns></returns>
        public int Factorial(int score)
        {
            if (score == 0) return 1;
            else
            {
                return score * Factorial(score - 1);
            }
        }
    }
}
