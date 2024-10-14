


namespace Lottesystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Random SpecialNumber = new Random();


            Console.WriteLine("Lotte Kupon");
            List<int> list = new List<int>();
            int pickednumber;
            int specialnumber;

            Lotte(list);



            void Lotte(List<int> lst)
            {
                int currentlyLine = 1;

                for (int j = 0; currentlyLine < 7; j++)
                {
                    Console.WriteLine("");

                    for (int i = 0; i < 7; i++) // forloops geneart 7 random numbers
                    {
                        pickednumber = rnd.Next(1, 36);
                        specialnumber = rnd.Next(1, 36);

                        while (lst.Contains(pickednumber))
                        {
                            pickednumber = rnd.Next(1, 36);


                        }
                        lst.Add(pickednumber);

                        if (pickednumber == specialnumber)
                        {
                            
                            Console.ForegroundColor = ConsoleColor.Green; Console.Write(pickednumber + " ");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            int liste = lst[i];
                            Console.Write(pickednumber + " ");
                        }




                        if (i == 7)
                        {
                            for (int l = 0; l < lst.Count; l++)
                            {
                                lst.Remove(l);
                            }
                            i = 0;
                            currentlyLine++;
                        }
                    }
                  
                }

            }



        }
    }
}

/*
void Lotte(List<int> lst)
{

        for (int i = 0; i < 7; i++)
        {
            pickednumber = rnd.Next(1, 36);

            while (lst.Contains(pickednumber))
            {
                pickednumber = rnd.Next(1, 36);

            }
            lst.Add(pickednumber);

            int liste = lst[i];
            Console.Write(pickednumber + " ");
        }

    Console.WriteLine("");
}






}
}
}
*/