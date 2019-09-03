<<<<<<< .mine
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ticketing
{
    public partial class TicketsForm : Form
    {
        TicketPrice mTicketPrice;
        int mSection = 2;
        int mQuantity = 0;
=======
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ticketing
{
    public partial class TicketsForm : Form
    {
        TicketPrice mTicketPrice;
        int mSection = 2;
        int mQuantity = 0;
>>>>>>> .theirs
        bool mDiscount = false;
        int mDiscount = 0;
<<<<<<< .mine

        public TicketsForm()
        {
            InitializeComponent();
        }

        private void TicketsForm_Load(object sender, EventArgs e)
        {

        }

        private void cmdCalculate_Click(object sender, EventArgs e)
        {
            mQuantity = int.Parse(txtQuantity.Text);

            if (chkDiscount.Checked)
=======

        public TicketsForm()
        {
            InitializeComponent();
        }

        private void TicketsForm_Load(object sender, EventArgs e)
        {

        }

        private void cmdCalculate_Click(object sender, EventArgs e)
        {
            mQuantity = int.Parse(txtQuantity.Text);

            if (chkDiscount.Checked)
>>>>>>> .theirs
                { mDiscount = true; }

            if (radBalcony.Checked)
                { mSection = 1; }
                { mDiscount = 1; }

            else if (chChild.Checked)
            { mDiscount = 2; }
<<<<<<< .mine
            if (radGeneral.Checked)
                { mSection = 2; }
            if (radBox.Checked)
                { mSection = 3; }
            if (radBlack.Checked)
                { mSection = 4; }

            mTicketPrice = new TicketPrice(mSection, mQuantity, mDiscount);

            mTicketPrice.calculatePrice();
            lblAmount.Text = System.Convert.ToString(mTicketPrice.AmountDue);
        }
     }
}

=======

            if (radBalcony.Checked)
                { mSection = 1; }
            if (radGeneral.Checked)
                { mSection = 2; }
            if (radBox.Checked)
                { mSection = 3; }

            mTicketPrice = new TicketPrice(mSection, mQuantity, mDiscount);

            mTicketPrice.calculatePrice();
            lblAmount.Text = System.Convert.ToString(mTicketPrice.AmountDue);
        }
     }
}
>>>>>>> .theirs
