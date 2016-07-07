using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication_Car.Models;

namespace WebApplication_Car
{
    public partial class Car_WebForm : System.Web.UI.Page
    {
        Car c;
        List<Car> carList = new List<Car>();
        //SortedList<int, string> companyList = new SortedList<int, string>()
        //{
           
        //    {1,"Alfa Romeo"}, 
        //    {2,"Bentley" },
        //    {3,"BMW" },  
        //    {4,"Cadillac" },    
        //    {5,"Ferrari"},
        //    {6,"Jaguar"},  
        //    {7,"Jeep"},
        //    {8,"Lamborghini"},
        //    {9,"Land Rover"},
        //    {10,"Lexus"}  
        //};

        Dictionary<string, string[]> companymodel = new Dictionary<string, string[]>()
            {
                {"Alfa Romeo",new string[] { "Alfa Romeo_Model1", "Alfa Romeo_Model2" }},
                {"Bentley",new string[] { "Bentley_Model1", "Bentley_Model2","Bentley_Model3" }},
                {"BMW" ,new string[] { "BMW__Model1", "BMW_Model2","BMW_Model3","BMW_Model4" }},
                {"Cadillac",new string[] { "Cadillac_Model1" }},
                {"Ferrari",new string[] { "Ferrari_Model1", "Ferrari_Model2" ,"Ferrari_Model3"}},
                {"Jaguar",new string[] { "Jaguar_Model1", "Jaguar_Model2" }},
                {"Lamborghini",new string[] { "Lamborghini_Model1", "Lamborghini_Model2" }},
                {"Land Rover",new string[] { "Land Rover_Model1", "Land Rover_Model2" }},
                {"Lexus",new string[] { "Lexus_Model1", "Lexus_Model2" }}
        };

        string[] companies;
        string[] models;
        string selectedcompany;


        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                PopulateCarCompany();
            }

        }


        protected void PopulateCarCompany()
        {
            companies = new string[companymodel.Count];
            companymodel.Keys.CopyTo(companies, 0);
            ddlCompany.DataSource = companies;            
            ddlCompany.DataBind();
        }


        protected void ddlCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedcompany = ddlCompany.SelectedItem.Text;
            models = new string[companymodel.Count];
            foreach (KeyValuePair<string, string[]> item in companymodel)
            {
                if (item.Key == selectedcompany)
                {
                    models = item.Value;
                }

            }

            ddlModel.DataSource = models;
            ddlModel.DataBind();
        }


        protected void btnAddCar_Click(object sender, EventArgs e)
        {
            bool IsDataValid = CheckDataValid();
            if (!IsDataValid) lblAddCarStatus.Text = "Something wrong happens!";
            bool IsCarCreated = CreateNewCar();
            if (!IsCarCreated) lblAddCarStatus.Text = "Something wrong happens!";         
            bool IsSaved=StoreCarInSession();
            if (!IsSaved) lblAddCarStatus.Text = "Something wrong happens!";
            bool IsPrinted=PrintCar();
            if (!IsPrinted) lblAddCarStatus.Text = "Something wrong happens!";
        }


        protected bool CheckDataValid()
        {
            //TODO: add server validations
            return true;
        }


        protected bool CreateNewCar()
        {
            string company;
            string model;
            string year;
            string engineSize;
            string price;

            try
            {
                company = ddlCompany.SelectedItem.Text;
                model =ddlModel.SelectedItem.Text;
                year = txtYear.Text;
                engineSize = txtEngineSize.Text;
                price = txtPrice.Text;
                c = new Car(company, model, year, engineSize, price);
                lblAddCarStatus.Text = "New car was added sucessfully!";            
                return true;
            }
            catch
            {
                return false;
            }
        }


        protected bool PrintCar()
        {         
            if (Session["cars"] != null)
            {
                carList = (List<Car>)(Session["cars"]);
                foreach (Car c in carList)
                {
                    lstResult.Items.Add(new String('*', 20));
                    lstResult.Items.Add("Company is: "+c.Company);
                    lstResult.Items.Add("Model is: " + c.Model);
                    lstResult.Items.Add("Year is: " + c.Year);
                    lstResult.Items.Add("EngineSize is: " + c.EngineSize);
                    lstResult.Items.Add("Price is: " + c.Price);
                    lstResult.Items.Add(new String('*',20));
                }
                return true;
            }
            else
            {
                lstResult.Items.Add("No cars in the list");
                return false;
            }
            //lstResult.Items.Add(c.Company);
            //lstResult.Items.Add(c.Model);
            //lstResult.Items.Add(c.Year);
            //lstResult.Items.Add(c.EngineSize);
            //lstResult.Items.Add(c.Price);
        }

        protected bool StoreCarInSession()
        {
            try
            {
                if (Session["cars"] != null)
                {
                    carList = (List<Car>)(Session["cars"]);
                }
                carList.Add(c);
                Session["cars"] = carList;
                return true;
            }
            catch
            {
                return false;
            }
        }

        protected void btnFindCar_Click(object sender, EventArgs e)
        {

        }

        
    }
}