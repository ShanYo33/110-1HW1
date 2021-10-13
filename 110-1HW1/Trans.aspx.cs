using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _110_1HW1
{
    public partial class Trans : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            double d_value = -1;
            d_value = 3.982;
            double d_c = -1;
            d_c = (d_value = 3.982 * 3.982);
            Response.Write("d_value=" + d_value.ToString() + "F=" + d_c.ToString() + "C");
        }
    }
}