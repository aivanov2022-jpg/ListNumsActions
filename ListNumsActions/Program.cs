namespace ListNumsActions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string[] cmd = Console.ReadLine().Split().ToArray();
                string command = cmd[0];
                if (command.ToLower() == "finish")
                {
                    break;
                }
                switch (command)
                {
                    case "ins": int index= int.Parse(cmd[1]);
                        int num = int.Parse(cmd[2]);
                        nums.Insert(index,num);
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", nums));
                        break;

                    case "contains":
                       if (nums.Contains(int.Parse(cmd[1])) == true)
                       {

                            Console.WriteLine("Yes");

                       }
                       else
                       {
                            Console.WriteLine("No");
                       }
                       break;

                    case "delete":
                        int delete = int.Parse(cmd[1]);
                        nums.Remove(delete);
                        break;

                    case "add":
                        nums.Add(int.Parse(cmd[1]) + int.Parse(cmd[2]));


                        break;
                        

                    case "remove":
                        int remove = int.Parse(cmd[1]);
                        nums.RemoveAt(remove);
                        break;
                    case "countOdds":
                        int odd = 0;
                        foreach(var item in nums)
                        {
                            if(item % 2 != 0)
                            {
                                odd++;
                            }

                        }
                        Console.WriteLine(odd);
                        break;


                    case "countl":
                       foreach (var item in nums)
                        {
                            if(item > int.Parse(cmd[1]))
                            {
                                Console.WriteLine(item);
                            }

                        }


                    break;

                    case "countEvens":
                        int even = 0;

                        foreach(var item in nums)
                        {
                            if(item %  2 == 0)
                            {
                                even++;
                            }

                        }
                        Console.WriteLine(even);

                        break;
                    case "sumAll":
                        double sum = 0;
                        foreach(var item in nums)
                        {
                            sum = sum + item;
                        }
                        Console.WriteLine($"{sum / nums.Count:F2}");
                        break;




                }
            }
        }
    }
}
