using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1_2_kassakvitto
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Validate();
            if (IsValid)
            {
                try
                {
                    var receipt = new Model.Receipt(Double.Parse(Price.Text));

                    Subtotal.Text = receipt.Subtotal.ToString();
                    Discount.Text = (receipt.DiscountRate * 100).ToString();
                    MoneyOff.Text = receipt.MoneyOff.ToString();
                    Total.Text = receipt.Total.ToString();

                    Receipt.Visible = true;
                }
                catch (Exception)
                {
                    ModelState.AddModelError(String.Empty, "An error has occured serverside");
                }
            }
        }
    }
}