<<<<<<< .mine
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ticketing
{
    public class TicketPrice
    {
        private int section;
        private int quantity;
=======
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ticketing
{
    public class TicketPrice
    {
        private int section;
        private int quantity;
>>>>>>> .theirs
        private bool discount;
        private int discount;
<<<<<<< .mine
        private decimal amountDue;
        private decimal mPrice;

        const decimal mdecBalcony = 35.5m;
        const decimal mdecGeneral = 28.75m;
        const decimal mdecBox = 62.0m;
=======
        private decimal amountDue;
        private decimal mPrice;

        const decimal mdecBalcony = 35.5m;
        const decimal mdecGeneral = 28.75m;
        const decimal mdecBox = 62.0m;
>>>>>>> .theirs
        const decimal mdecDiscount = 5.0m;

        const decimal mdecBlackStall = 15.0m;
        const decimal mdecDiscounts = 5.0m;

        const decimal mdecDiscountc = 10.0m;
<<<<<<< .mine

        private int Section
        {
            get { return section; }
            set { section = value; }
        }

         private int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

=======

        private int Section
        {
            get { return section; }
            set { section = value; }
        }

         private int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

>>>>>>> .theirs
         private bool Discount
         private int Discount
<<<<<<< .mine
        {
            get { return discount; }
            set { discount = value; }
        }

         public decimal AmountDue
        {
            get { return amountDue; }
            set { amountDue = value; }
        }

    // Constructor for TcicketPrice
=======
        {
            get { return discount; }
            set { discount = value; }
        }

         public decimal AmountDue
        {
            get { return amountDue; }
            set { amountDue = value; }
        }

    // Constructor for TcicketPrice
>>>>>>> .theirs
    public TicketPrice(int section, int quantity, bool discount)
    public TicketPrice(int section, int quantity, int discount)
<<<<<<< .mine
    {
        Section = section;
        Quantity = quantity;
        Discount = discount;
        AmountDue = amountDue;
    }

     public void calculatePrice()
     {

         switch (section)
         {
=======
    {
        Section = section;
        Quantity = quantity;
        Discount = discount;
        AmountDue = amountDue;
    }

     public void calculatePrice()
     {

         switch (section)
         {
>>>>>>> .theirs
             case 1:
                 mPrice = mdecBalcony;
                 break;
             case 2:
                 mPrice = mdecGeneral;
                 break;
             case 3:
                 mPrice = mdecBox;
                 break;
             case 4:
                 mPrice = mdecBlackStall;
                 break;
         }
         if (discount==1)
         { mPrice -= mdecDiscounts; }
         else if (discount == 2)
            { mPrice -= mdecDiscountc; }
<<<<<<< .mine
         { mPrice -= mdecDiscount; }

         AmountDue = mPrice * quantity;

     }
    }
}
=======

         AmountDue = mPrice * quantity;

     }
    }
}

>>>>>>> .theirs
