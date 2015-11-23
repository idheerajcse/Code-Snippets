using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Login : System.Web.UI.Page
{
    
    SqlDataAdapter da;
    DataSet ds;
    SqlCommand cmd;
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString);
    string sqlQuery = string.Empty;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.Cookies["UserName"] != null && Request.Cookies["Password"] != null)
            {
                txtUserId.Text = Request.Cookies["UserName"].Value;
                txtPassword.Attributes["value"] = Request.Cookies["Password"].Value;
            }
        }
       
    }
    protected void btnOk_Click(object sender, EventArgs e)
    {
        if (ddlLoginType.SelectedIndex == 0)
        {
            lblError.Text = "<b style='color:Red' >Please Select any Login Type.</b> ";
            return;
        }
        if (txtUserId.Text == "")
        {
            lblError.Text = "<b style='color:Red' >Please Type User Id. </b>";
            return;
        }
        if (txtPassword.Text == "")
        {
            lblError.Text = "<b style='color:Red' >Please Type User Password.</b> ";
            return;
         }
        //Check Login
        if (ddlLoginType.SelectedItem.Text == "Admin")
        {

            checkCredentialsByType("Admin");
           
        }
        if (ddlLoginType.SelectedItem.Text == "Branch Login")
        {

            checkCredentialsByType("Branch Admin");

        }
        if (ddlLoginType.SelectedItem.Text == "Data Operator")
        {

            checkCredentialsByType("Data Operator");

        }

    }
    public void checkCredentialsByType(string UserType)
    {
        sqlQuery = "Select * from UserLogin Where Userid='" + txtUserId.Text + "' and userpassword='" + txtPassword.Text + "' and UserType='"+ UserType+"'";
        da = new SqlDataAdapter(sqlQuery, con);
        ds = new DataSet();
        da.Fill(ds, "temp");
        if (ds.Tables["temp"].Rows.Count > 0)
        {
            Session.Add("uname", ds.Tables["temp"].Rows[0]["UserName"].ToString());
            if (chkRememberMe.Checked == true)
            {
                Response.Cookies["UserName"].Expires = DateTime.Now.AddDays(30);
                Response.Cookies["Password"].Expires = DateTime.Now.AddDays(30);

            }
            else
            {
                

        Response.Cookies["UserName"].Expires = DateTime.Now.AddDays(-1);
        Response.Cookies["Password"].Expires = DateTime.Now.AddDays(-1);
 
            


            }
            Response.Cookies["UserName"].Value = txtUserId.Text.Trim();
            Response.Cookies["Password"].Value = txtPassword.Text.Trim();

            Response.Redirect("Home.aspx");
        }
        else
        {
            lblError.Text = "<b style='color:Red' >Please Type Correct User Name and Password.</b>  ";


        }



    }
}
