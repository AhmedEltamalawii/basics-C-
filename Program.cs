
   namespace Task_Function
{
    internal class Program
    {
        static List<int> list = new List<int>();
        static void displayMenue()
        {
            Console.WriteLine("P - Print numbers");
            Console.WriteLine("A - Add a number");
            Console.WriteLine("M - Display mean of the numbers");
            Console.WriteLine("S - Display the smallest number");
            Console.WriteLine("L - Display the largest number");
            Console.WriteLine("C - Clear list");
            Console.WriteLine("Q - Quit");
            Console.WriteLine("Enter your choiceeeee:");
        }
        static string Selection()
        {
            return Console.ReadLine();

        }
        static void displayNum()
        {

            if (list.Count == 0)
            {
                Console.WriteLine("[] - the list is empty");
            }
            else
            {
                Console.Write("[ ");
                for (int i = 0; i < list.Count; i++)
                {
                    Console.Write($"{list[i]} ");
                }
                Console.WriteLine("]");
            }
        }

        static void addNum()
        {
            Console.WriteLine("Enter value");
            int value = int.Parse(Console.ReadLine());
            list.Add(value);
            Console.WriteLine($"{value} is addeddd.");
        }

        static void clacMean()
        {

            if (list.Count == 0)
            {
                Console.WriteLine("Unable to calculate the mean - no data");
            }
            else
            {
                int sum = 0;
                for (int i = 0; i < list.Count; i++)
                {
                    sum += list[i];
                }

                Console.WriteLine($"Mean: {sum / list.Count}");
            }
        }
        static void minNum()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("Unable to determine the smallest number - list is empty");
            }
            else
            {
                int smallest = list[0];
                for (int i = 0; i < list.Count; i++)
                {
                    if (smallest > list[i]) // 2 3 7 1 -1 0 8 9 3
                    {
                        smallest = list[i];
                    }
                }

                Console.WriteLine($"smallest: {smallest}");
            }
        }
        static void maxNum()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("Unable to determine the largest number - list is empty");
            }
            else
            {
                int largest = list[0];
                for (int i = 0; i < list.Count; i++)
                {
                    if (largest < list[i])
                    {
                        largest = list[i];
                    }
                }

                Console.WriteLine($"largest: {largest}");
            }
        }
        static void Clear()
        {
            list.Clear();
            Console.WriteLine("List is Clear");
        }
        static void Quit()
        {
            Console.WriteLine("Good bye...");
        }
        static void Main(string[] args)
        {
            // List<int> list = new List<int>(); // 2 3 7 1 -1 0 8 9 3
            String selection = "0";
            do
            {

                //selection = char.Parse(Console.ReadLine().ToUpper());
                displayMenue();
                selection = Selection();


                if (selection.ToUpper() == "P")
                {
                    displayNum();

                }
                else if (selection.ToUpper() == "A")
                {
                    addNum();
                }
                else if (selection.ToUpper() == "M")
                {
                    clacMean();
                }
                else if (selection.ToUpper() == "S")
                {
                    minNum();
                }
                else if (selection.ToUpper() == "L")
                {
                    maxNum();
                }
                else if (selection.ToUpper() == "C")
                {
                    Clear();
                }
                else if (selection.ToUpper() == "Q")
                {
                    Quit();
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }

            } while (selection != "Q");
        }
    }
}
