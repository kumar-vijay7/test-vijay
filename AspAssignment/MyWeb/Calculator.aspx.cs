using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWeb
{
    //------------------------------------Question 2 starts here----------------------------------------- 
    public partial class Calculator : System.Web.UI.Page
    {
             
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                ViewState["operationPerformed"] = false;//setting the default value of viewstate
                ViewState["result"] = 0;


            }
        }
 /*--------------------------------------------button_click Method starts here---------------------------------------------------*/
      
        
        protected void Button_click(object sender, EventArgs e)//this method adding the number button value(like 1234567890) and adding the value in textview
        {
            try
            {

                //if ((DisplayText.Text == "0") || ((bool)ViewState["operationPerformed"]))

                //{ DisplayText.Text = String.Empty; }
                Button button = (Button)sender;
                DisplayText.Text += button.Text;

            }
            catch (NullReferenceException ex)
            {
                Response.Write("Error Occured" + ex);
            }
            catch(Exception)
            {
                Response.Write("Error Occured");
            }

        }

        /*--------------------------------------------button_click Method ends here---------------------------------------------------*/

        /*---------------------------------------CallOperator Method Starts Here-------------------------------------------*/



        protected void CallOperator(object sender, EventArgs e)
        {
            try
            {
                Button button = (Button)sender;//creating the instance of button 

                //if ((int)ViewState["result"] != 0)//this condition check if viewstate result variable container the value then perform the calculate
                //{
                //    this.Calculate(sender, e);
                //    ViewState["OperatorSymbol"] = button.Text;
                //    ViewState["operationPerformed"] = true;
                //}
                //else//else part we are storing the container of the operator button[like +,-,*,/] in the operator symbol
                //{
                    ViewState["OperatorSymbol"] = button.Text;
                    ViewState["result"] = Double.Parse(DisplayText.Text);//this is storing the current textview text in the result
                    DisplayText.Text = String.Empty;
                //    ViewState["operationPerformed"] = true;//setting the operation performed true
                //}
            }
            catch (NullReferenceException nx)
            {
                Response.Write("Error Occured" + nx);
            }
            catch(Exception err)
            {
                Response.Write("Error Occured" + err);
            }


        }
        /*---------------------------------------CallOperator Method ends Here-------------------------------------------*/


        /*---------------------------------------Calculate Method Starts Here-------------------------------------------*/


        protected void Calculate(object sender, EventArgs e)//this method perform the calcualtion 
        {
            switch (ViewState["OperatorSymbol"])
            {
                case "+":
                    DisplayText.Text = ((double)ViewState["result"] + Double.Parse(DisplayText.Text)).ToString(); break;
                case "-":
                    DisplayText.Text = ((double)ViewState["result"] - Double.Parse(DisplayText.Text)).ToString(); break;
                case "/":
                    try
                    {

                        DisplayText.Text = ((Decimal)ViewState["result"] / Decimal.Parse(DisplayText.Text)).ToString(); 

                    }
                    catch (DivideByZeroException )
                    {

                        Response.Write("Number Cannot be divided by zero");
                    };
                    break;
                case "x":
                    DisplayText.Text = ((double)ViewState["result"] * Double.Parse(DisplayText.Text)).ToString(); break;
            }
        }
        /*----------------------------------Calculate Method Ends Here----------------------------------*/

     /*------------------------------------ClearDisplay Method Starts Here-----------------------------*/
        protected void ClearDisplay(object sender, EventArgs e)//this is the method which clear the textbox or all the viewstate variable
        {
            DisplayText.Text = String.Empty;
            ViewState["result"]=0;
            ViewState["OperatorSymbol"] = "";


        }
        /*------------------------------------ClearDisplay Method Ends Here-----------------------------*/

    }

}