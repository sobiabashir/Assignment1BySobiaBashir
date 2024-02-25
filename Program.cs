namespace Assignment1BySobiaBashir
{
    namespace ConsoleApps
    {
        class Program
        {

            static void Main(string[] args)
            {
                Console.Clear();
                Console.WriteLine(" ************************* Welcome to my World! ********************************");
                Console.WriteLine();
                Console.WriteLine("       I will give you information related to the following:");
                Console.WriteLine();
                Console.WriteLine("           1. Pets");
                Console.WriteLine("           2. Ticket Seller");
                Console.WriteLine("           3. Album");
                Console.WriteLine("           4. Employee");
                string selectAction;
                do
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Select one of the following of your interest");
                    Console.WriteLine("Select 1 for Pet :");
                    Console.WriteLine("Select 2 for TicketSeller :");
                    Console.WriteLine("Select 3 for Album :");
                    Console.WriteLine("Select 4 for Employee :");

                    Console.WriteLine("Select 0 for Close the application :");
                    Console.WriteLine();
                    selectAction = Console.ReadLine();
                    selectAction = selectAction.Trim();

                    char choice = selectAction[0];
                    switch (choice)
                    {
                        case '1':
                            Pet petObj = new Pet();
                            petObj.Start();
                            break;
                        case '2':
                            TicketSeller ticketSellerObj = new TicketSeller();
                            ticketSellerObj.Start();
                            break;
                        case '3':
                            AlbumInfo albumInfoObj = new AlbumInfo();
                            albumInfoObj.Start();
                            break;
                        case '4':
                            Employe EmployeeSobia = new Employe(); ;
                            EmployeeSobia.Start();
                            break;
                    }
                } while (selectAction != "0");

            }


        }

    }
}