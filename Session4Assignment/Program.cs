namespace Session4Assignment
{
    internal class Program
    {
        //Q3____________________________________________________________________________________________
        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");   
        }

        //Q4____________________________________________________________________________________________
        static void PrintBookTitle(string title)
        {
            Console.WriteLine("Book title: " + title);
        }

        //Q5____________________________________________________________________________________________
        static void AddBonusPages(int pages)
        {
            pages += 50;
        }

        //Q6____________________________________________________________________________________________
        static void ApplyDiscount(double[] prices)
        {
            prices[0] -= 5;
        }

        //Q7____________________________________________________________________________________________
        static void AddBonusPagesByRef(ref int pages)
        {
            pages += 50;
        }

        //Q8____________________________________________________________________________________________
        static void ReplaceArray(ref double[] prices)
        {
            prices = new double[] { 10.0, 12.5, 15.0 };
        }


        //Q9____________________________________________________________________________________________
        static bool TryGetPrice(string title, out double price)
        {
            if (title == "Clean Code")
            {
                price = 25.5;
                return true;
            }
            price = 0;
            return false;
        }

        //Q10, 11________________________________________________________________________________________
        static void PrintBookInfo(string title, int pages = 300)
        {
            Console.WriteLine("Book title: " + title);
            Console.WriteLine("Number of pages: " + pages);
        }

        //Q12____________________________________________________________________________________________
        static void PrintAllTitles(params string[] titles)
        {
            foreach (string title in titles)
            {
                Console.WriteLine("Book title: " + title);
            }
        }

        static void Main(string[] args)
        {
            //Q1____________________________________________________________________________________________
            /*Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print 
            the second price (index 1).*/
            double[] prices = { 25.5, 40.0, 33.75 };
            Console.WriteLine("Q1___________________");
            Console.WriteLine(prices[1]);


            //Q2____________________________________________________________________________________________
            /*Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and 
            shelf 1 has 1, 4 copies. Print the number of copies on shelf 1, slot 0.*/
            int[,] shelfCopies = { { 3, 5 }, { 1, 4 } };
            Console.WriteLine("Q2___________________");
            Console.WriteLine(shelfCopies[1, 0]);


            //Q3____________________________________________________________________________________________
            /*Write a method called PrintWelcomeMessage that takes no parameters and prints 
            "Welcome to the Library!". Call it from Main.*/
            Console.WriteLine("Q3___________________");
            PrintWelcomeMessage();


            //Q4____________________________________________________________________________________________
            /*Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with 
            "Clean Code".*/
            Console.WriteLine("Q4___________________");
            PrintBookTitle("Clean Code");


            //Q5____________________________________________________________________________________________
            /*Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable 
            int pages = 400; and print pages afterward. What do you expect to see, and why?*/

            int pages = 400;
            Console.WriteLine("Q5___________________");
            AddBonusPages(pages);
            Console.WriteLine(pages);
            /*I expect to see 400 
             * because the AddBonusPages method modifies a local copy of the pages variable not the original variable.*/


            //Q6____________________________________________________________________________________________
            /*Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it 
            with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward. What do you expect to 
            see, and why?*/
            double[] prices2 = { 25.5, 40.0 };
            Console.WriteLine("Q6___________________");
            ApplyDiscount(prices2);
            Console.WriteLine(prices2[0]);
            /*I expect to see 20.5 
             * because the ApplyDiscount method modifies the original array passed to it.
             * because arrays are reference types.*/


            //Q7____________________________________________________________________________________________
            /*Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref. 
            Call it and print pages afterward. How is the result different from question 5?*/
            int pages2 = 400;
            Console.WriteLine("Q7___________________");
            AddBonusPagesByRef(ref pages2);
            Console.WriteLine(pages2);
            /*I expect to see 450 
             * because the AddBonusPagesByRef method modifies the original variable passed to it.
             * because the ref keyword passes the variable by reference, not by value.*/


            //Q8____________________________________________________________________________________________
            /*Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a 
            new array { 10.0, 12.5, 15.0 }. Call it with your prices array and print prices.Length 
            afterward.*/
            double[] prices3 = { 25.5, 40.0, 33.75, 47.25 };
            Console.WriteLine("Q8___________________");
            ReplaceArray(ref prices3);
            Console.WriteLine(prices3.Length);


            //Q9____________________________________________________________________________________________
            /*Write a method bool TryGetPrice(string title, out double price) that returns true and sets 
            price to 25.5 if title is "Clean Code", otherwise returns false and sets price to 0. Call it 
            and print the price if found  */
            string title = "Clean Code";
            double price;
            bool found = TryGetPrice(title, out price);
            Console.WriteLine("Q9___________________");
            if (found)
            {
                Console.WriteLine(price);
            }


            //Q10____________________________________________________________________________________________
            /*Write a method PrintBookInfo(string title, int pages = 300) where pages is optional. Call 
            it once with only a title, and once passing both a title and pages. */
            Console.WriteLine("Q10___________________");
            PrintBookInfo("Clean Code");
            PrintBookInfo("Design Patterns", 400);


            //Q11____________________________________________________________________________________________
            /*Using the PrintBookInfo method from the question above, call it by naming the 
            parameters, passing pages before title. */
            Console.WriteLine("Q11___________________");
            PrintBookInfo(pages: 400, title: "Clean Code");


            //Q12____________________________________________________________________________________________
            /*Write a method PrintAllTitles(params string[] titles) that prints each title on its own line. 
            Call it with three book titles.*/
            Console.WriteLine("Q12___________________");
            PrintAllTitles("Clean Code", "Design Patterns", "Refactoring");
        }
    }
}