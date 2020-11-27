using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace site
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public void Page_Load(object sender, EventArgs e)
        {

        }

        public void btnReg_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DEB;Initial Catalog=DBpim;Persist Security Info=True;User ID=sa;Password=***********");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[TBwebapp]
            ([nome]
            ,[email]
            ,[telefone]
           )
            VALUES
            ('" + "Déborah Leite" + "', '" + "deborah.leite@iteris.com.br" + "', '" + "123456" + "', '" + "txtEmail.Text" + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
  
        }
           
        }
       
    }
