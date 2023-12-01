using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myHw2AnotherTry
{
    class Customer 
    {

        private string name;
        private string address;

        public Customer(string aName, string aAddress,bool make)
        {

            name = aName;
            address = aAddress;

            if (make == true)
            {
                Order newOrder = new Order();
                newOrder.NumberOrder++;
            }
        }

        public string Name
        {
            get { return name; }

        }
        public string Address
        {
            get { return address; }

        }

        



    }

    class Order
    {
        private DateTime date;
        private string status;
        private static int numberOrder = 0;

        public Order()
        {
            DateTime Date = DateTime.Now;
            this.status = "Pending";
            this.NumberOrder = numberOrder;

        }
        public string Status{
        get { return status; }
        }
        public DateTime Date
        {
            get { return date; }
        }
        public int NumberOrder 
        { get { return numberOrder; }
          set
            {
                numberOrder=value;
            }
        }

        public float CalcTotal(float totalPrice)
        {
            return totalPrice;
        }

        public float CalcTax(float totalPrice)
        {
            Item item = new Item();
            float taxFromTotal = totalPrice * item.taxRate;
            return taxFromTotal;
        }

        public float CalcTotalWeight(float totalWeight)
        {
            return totalWeight;
        }



    }

    class OrderDetail
    {
        private int quanitiy;
        private string taxStatus;
        private float taxInc;
        public OrderDetail(int aQuanitiy, string aTaxStatus)
        {
            aQuanitiy = Quanitiy;
            aTaxStatus = TaxStatus;
        }

        public OrderDetail(string aTaxStatus)
        {
            aTaxStatus = TaxStatus;

        }

        public OrderDetail(){


            }
        public int Quanitiy
        {
            get { return quanitiy; }
            set
            {
                if (value == 1 || value <= 100)
                {
                   quanitiy = value;
                    Console.WriteLine("you Ordered " + value + " insder your Cart");
                }
                else if (value < 0)
                {
                    quanitiy = value;
                    Console.WriteLine("Chose Atleast One Item");
                }
                else
                    Console.WriteLine("You Can't put more than 100");
            }
        }
        public string TaxStatus
        {
            get { return taxStatus; }
            set
            {
                if(value == "Applied")
                {
                    Console.WriteLine("Addiotnoal tax will be applied");
                }
                else if(value =="Don't Apply")
                {
                    Console.WriteLine("Your Shopping Free from Taxes");
                }

            }
        }

        public float CalcSub(float totalPrice)
        {
            totalPrice = taxInc + totalPrice;
            return totalPrice;
           
        }


        

        public float CalcTax(Item item , float totalPrice )
        {
            
            taxInc = totalPrice * item.taxRate;
            return taxInc;
        }
        
        public float CalcWeight(Item item)
        {
            float thisOrder = quanitiy * item.ShippingWeight;
            return thisOrder;
        }
    }

    class Item
    {
        private float shippingWeight;
        private string description;
        public float taxRate = 0.15f;
        int i;
        public Item(float ShippingWeight, string description, float price)
        {
            this.ShippingWeight = ShippingWeight;
            this.description = description;
            
        }
        public Item()
        {

        }

        public Item(string description)
        {
            this.description = description;
            
        }
       
        public float ShippingWeight
        {
            get { return shippingWeight; }
            set { shippingWeight = value; }
        }

        public float GetPriceItem(float price)
        {

            return price;
        }

        public float GetPriceForQuanitiy(OrderDetail orderDetail , float price)
        {


            float fullPrice = orderDetail.Quanitiy * price;
            return fullPrice;
        }

        public float GetTax(float price)
        {
            float taxForItem = price * taxRate;
            return taxForItem;
        }

        public string InStock(string description)
        {
            if (description == "cheese" || description == "egg" || description == "milk")
            {
                Console.WriteLine("Item In Stock");
                return description;
            }
            else
            { Console.WriteLine("we will check later");
                return description; }
                 
                    
            
        }

    }

    class Payment
    {
        private float amount;
        
        

        
        public float Amount
        {
            get { 
                return amount;
            } 
            set { 
                 amount= value;
            }
        }
             }



    class Cash : Payment
    {

        private float cashTendered;

        public Cash()
            {

            this.CashTendered = cashTendered;
            
            }

        public float CashTendered
        {
            get { return cashTendered; }
            set { cashTendered = value; }
        
        }
        

        public float BeingPayed(Payment payment)
        {
            
             if(cashTendered !=payment.Amount )
            {
                float beingPayed = Amount - cashTendered;
                Console.WriteLine("The Cash left is:");
                return beingPayed;
            }
             else 
            {
                float fullPayed = 0;
                Console.WriteLine("no cash left to pay:");
                return fullPayed;
            }

        }

    }

    class Check : Payment
    {
        private string name;
        private string bankId;

        public bool authorzied(bool canCustomer)
        {
           


            if (canCustomer == true )
            {
                 
                Console.WriteLine("Can Check the payment");
                return true;
            }
            else
            {
                Console.WriteLine("Can't Check");
                return false;
            }
        }
    }

    class Credit : Payment
    {
        public bool authorzied(bool canCustomer)
        {

            if (canCustomer == true)
            {

                Console.WriteLine("Can Check with Credit the payment");
                return true;
            }
            else
            {
                Console.WriteLine("Can't Check with Credit");
                return false;
            }
        }
    }
}
