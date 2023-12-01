using myHw2AnotherTry;
using System;



class MyProgram
{
    static void Main(string[] args)
    {
        /*
       Customer customer1 = new Customer("Talal", "Shafa Badreen",true);
        Order order1 = new Order();
        OrderDetail orderDet1 = new OrderDetail(5, "Applied");
        Item item1ForCustomer1 = new Item(5.3m,"cheese",1.2m);
        Item item2ForCustomer1 = new Item(200.3m, "milk", 6.2m);
        Item item3ForCustomer1 = new Item(20m, "chips", 2.3m);
        Payment customer1Payment = new Payment();
        Cash customer1Cash = new Cash(20);
        Check customer1Check = new Check();
        Credit customer1Credit = new Credit();
        */

        
        Console.Write("Type (1) For ordering :");
        int userChoice = Convert.ToInt32(Console.ReadLine());
        if (userChoice ==1) {

            Console.Write("Please type your (Name) :");
            string name = Console.ReadLine();

            Console.Write("Please type your (Address) :");
            string address = Console.ReadLine();
            Customer customer = new Customer(name,address,true);

            Console.Write("\nType (2) to start Ordering :");
           int userChoice2 = Convert.ToInt32(Console.ReadLine());
            if (userChoice2 == 2)
            {
                Order order = new Order();
                Console.Write("Your Order number is:" + order.NumberOrder + ", been created at " + order.Date + "\nthe status of your order:" + order.Status);

                Console.Write("\n\nType (3) to start Filling your order :");
                int userChoice3  = Convert.ToInt32(Console.ReadLine());
                if(userChoice3 == 3) {
                    string[] item = new string[10];
                    float priceTag, weight,totalWeight = 0.0f;
                    float totalPrice = 0.0f;

                    for (int i = 1; i<=11; i++)
                    {
                        Console.Write($"\nPlease insert the (Item) number {i} into your chart :");
                        item[i] = Console.ReadLine();

                        Console.Write("Type the (price) of the item :");
                         priceTag = Single.Parse(Console.ReadLine());

                        Console.Write("Type the Shipping (weight) of the item :");
                         weight = Single.Parse(Console.ReadLine());

                          Item itemCustomer = new Item(weight, item[i], priceTag);

                        //Only for the Item alone the taxs System will always be applied
                        Console.Write("\nThe Tax on this Item will be :" + itemCustomer.GetTax(priceTag));

                        //To input A choice from the user
                        Console.Write("\n\nDo you want more of this Item? type (yes) :");
                        string userPart1 = Console.ReadLine();

                        if (userPart1 == "yes")
                        {
                            Console.Write("How many you want from this item? :");
                            int wantMore = Convert.ToInt32(Console.ReadLine());

                            OrderDetail orderDetail = new OrderDetail(wantMore, "Applied");
                            orderDetail.Quanitiy = wantMore;
                            //This for total price of the Qunaitiy operation
                            // decimal totalPrice = priceTag * wantMore; but we don't need it

                             float totalPriceForItem = itemCustomer.GetPriceForQuanitiy(orderDetail, priceTag);

                            Console.Write("\n\nYour Price for this Item now is :" + totalPriceForItem);

                            

                            Console.WriteLine($"Your have Ordered {orderDetail.Quanitiy} of {item[i]}");

                            Console.WriteLine("The shipping weight For now is :" + orderDetail.CalcWeight(itemCustomer));
                            totalWeight += orderDetail.CalcWeight(itemCustomer);
                            Console.WriteLine("The Added Tax on the price are :"+ orderDetail.CalcTax(itemCustomer,totalPriceForItem));
                            Console.WriteLine("Your Total for this Item :"+orderDetail.CalcSub(totalPriceForItem));
                            totalPrice = totalPrice + orderDetail.CalcSub(totalPriceForItem);
                        }
                        else
                        {
                            totalWeight += weight;
                            Console.Write("\n\nyour Item weight is :" + weight);
                        }
                        Console.Write("\n\nIf you want to add another item type (yes\\no) :");
                        string userChoicePart2 = Console.ReadLine();
                        if (userChoicePart2 != "yes")
                        {
                            i = 11;
                        }
                        
                    }

                    OrderDetail orderDetail1 = new OrderDetail("Applied");
                    
                    Console.WriteLine("Please select any of the Methods down:");
                    Console.WriteLine("1. The price of your Current Chart.");
                    Console.WriteLine("2. Sales Tax on your Order.");
                    Console.WriteLine("3. The Number Of your Order.");
                    Console.WriteLine("4. The Full weight of your Order.");

                    int opitions= Convert.ToInt32(Console.ReadLine());
                    switch (opitions)
                    {
                        case 1:
                            Console.WriteLine("The full Price of your Chart:" + order.CalcTotal(totalPrice));
                            break;
                        case 2:
                            Console.WriteLine("The Sales Tax on your Purchase is:"+order.CalcTax(totalPrice)+" The status of the Sales Tax are:"+ orderDetail1.TaxStatus);
                            break;
                        case 3:
                            Console.WriteLine("Your Order Number is:" + order.NumberOrder);
                            break;
                        case 4:
                            Console.WriteLine("The Total weight of your Order is:"+ order.CalcTotalWeight(totalWeight) );
                            break;
                        default:
                            Console.WriteLine("Time for Payment Panel");
                            break;
                        
                    }


                    Payment payment = new Payment();
                    Console.WriteLine("Your Purchase costs:"+ payment.Amount.Equals(totalPrice));
                    Console.WriteLine("Please select any of the Methods down:");
                    Console.WriteLine("1. Cash");
                    Console.WriteLine("2. Credit");
                    Console.WriteLine("3. Bank Checks");

                    Console.Write("Enter An option:");
                    int opitions2 = Convert.ToInt32(Console.ReadLine());
                    if (opitions2 == 1 || opitions2 == 2 || opitions2 == 3)
                    {
                        switch (opitions2)
                        {
                            case 1:

                                Console.Write("\n Enter the Amount you want to pay with Cash:");
                                int amount = Convert.ToInt32(Console.ReadLine());
                                Cash cash = new Cash();
                                cash.CashTendered = amount;

                                break;

                            case 2:
                                Console.Write("\n Enter the Amount you want to pay with Cash:");
                                int amount2 = Convert.ToInt32(Console.ReadLine());
                                Credit credit = new Credit();
                                credit.authorzied(true);
                                Cash cash2 = new Cash();
                                cash2.CashTendered = amount2;
                                break;

                            case 3:
                                Console.Write("\n Enter the Amount you want to pay with Back Check:");
                                int amount3 = Convert.ToInt32(Console.ReadLine());
                                Check check = new Check();
                                check.authorzied(true);
                                Cash cash3 = new Cash();
                                cash3.CashTendered = amount3;
                                break;


                        }
                    }
                    else
                    {
                        Console.WriteLine("We cancling your order");
                        Console.Write("Thanks for Using our App Mr/Mrs :" + customer.Name);
                    }




                }
                else
                {
                    Console.WriteLine("We cancling your order");
                    Console.Write("Thanks for Using our App Mr/Mrs :" + customer.Name);
                }

            }
            else
                Console.Write("Thanks for Using our App Mr/Mrs:"+customer.Name);
        }
            else { Console.Write("Thanks for Using our App");
        }



    }
}