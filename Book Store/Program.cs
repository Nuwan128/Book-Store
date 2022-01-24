using System;
using System.Collections.Generic;


namespace Book_Store
{

    class Program
    {
        static void Welcome()
        {
            Console.WriteLine("welcome to the store! Here are the books that you can buy\n\t***********************\n");

            Console.WriteLine("\t1.Aba Yaluwo  - Rs 149.50");
            Console.WriteLine("\t2.Gamperaliya - Rs 160.50");
            Console.WriteLine("\t3.Madol Doova - Rs 159.50");
            Console.WriteLine("\t4.Yuganthaya  - Rs 155.50");
            Console.WriteLine("\t5.Senkottan   - Rs 199.50");
            Console.WriteLine("\t6.Ape Gama    - Rs 189.50");
            Console.WriteLine("\t7.Kaliyugaya  - Rs 220.50\n");
        }
        public bool isFinishing = true;
        static void Main(string[] args)
        {
            Program program = new Program();
            Cart cart = new Cart();

            Program.Welcome();

            while (program.isFinishing)
            {
                Console.WriteLine("Do you want to  Shoping(yes/no)?");
                string isFinishingResponse = Console.ReadLine();
                if (isFinishingResponse == "no")
                {
                    program.isFinishing = false;
                }
                else if (isFinishingResponse == "yes")
                {
                    cart.Purchase();
                    cart.RemoveBooks();
                    cart.DisplayCart();
                }
                else
                {
                    Console.WriteLine("---Wrong Input---");
                }
            }
        }
    }
    
    class Book
    {
        public string Title { get; set; }
        public float Price { get; set; }
    }

    class Cart
    {
        
        List<Book> Books = new List<Book>();
        bool isContinue = true;
        public void Purchase()
        {
            while (isContinue)
            {

                Console.WriteLine("Do you want to add books to your Cart(yes/no)?");
                String isContinueResponse = Console.ReadLine();
                if (isContinueResponse == "no")
                {
                    
                    isContinue = false;

                }
                else if (isContinueResponse == "yes")
                {
                    Console.WriteLine("What book do you want(Book_Index)?");
                    var Item = Convert.ToInt64(Console.ReadLine());

                    switch (Item)
                    {
                        case 1:
                            Books.Add(new Book
                            {
                                Title = "Aba Yaluwo",
                                Price = 149.50f
                            });
                            break;

                        case 2:
                            Books.Add(new Book
                            {
                                Title = "Gamperaliya",
                                Price = 160.50f
                            });
                            break;

                        case 3:
                            Books.Add(new Book
                            {
                                Title = "Madol Doova",
                                Price = 159.50f
                            });
                            break;

                        case 4:
                            Books.Add(new Book
                            {
                                Title = "Yuganthaya",
                                Price = 155.50f
                            });
                            break;

                        case 5:
                            Books.Add(new Book
                            {
                                Title = "Senkottan",
                                Price = 199.50f
                            });
                            break;

                        case 6:
                            Books.Add(new Book
                            {
                                Title = "Ape Gama",
                                Price = 189.50f
                            });
                            break;

                        case 7:
                            Books.Add(new Book
                            {
                                Title = "Kaliyugaya",
                                Price = 220.50f
                            });
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("---Wrong Input---");
                }
            }
        }

        public void RemoveBooks()
        {

            bool isContinue = true;
            while (isContinue)
            {
                Console.WriteLine("Do you want to Remove books from your Cart(yes/no)?");
                String isContinueResponse = Console.ReadLine();

                if (isContinueResponse == "no")
                {
                    isContinue = false;
                }
                else if (isContinueResponse == "yes")
                {
                    Console.WriteLine("What book do you remove(Book_Index)?");
                    var RemoveItem = Convert.ToInt64(Console.ReadLine());
                    switch (RemoveItem)
                    {
                        case 1:
                            Books.Remove(Books[0]);
                            break;

                        case 2:
                            Books.Remove(Books[1]);
                            break;

                        case 3:
                            Books.Remove(Books[2]);
                            break;

                        case 4:
                            Books.Remove(Books[3]);
                            break;

                        case 5:
                            Books.Remove(Books[4]);
                            break;

                        case 6:
                            Books.Remove(Books[5]);
                            break;

                        case 7:
                            Books.Remove(Books[6]);
                            break;

                        default:
                            break;
                    }
                }
                else
                    Console.WriteLine("---Wrong Input---");
            }    
        }

        public void DisplayCart()
        {
            float total = 0f;
            if (Books.Count == 0)
            {
                Console.WriteLine("---Empty Cart---");
            }
            else
            {
                foreach (var book in Books)
                {
                    Console.WriteLine($"\t{book.Title}");
                    total += book.Price;
                }
                Console.WriteLine($"\tTotal Price = Rs {total}");
            }
        }
    }
}



