using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_Car.Models
{
    public class Car
    {
        string company;
        string model;
        string year;
        string engineSize;
        string price;

        public string Company
        {
            get
            {
                return company;
            }

            set
            {
                company = value;
            }
        }

        public string Model
        {
            get
            {
                return model;
            }

            set
            {
                model = value;
            }
        }

        public string Year
        {
            get
            {
                return year;
            }

            set
            {
                year = value;
            }
        }

        public string EngineSize
        {
            get
            {
                return engineSize;
            }

            set
            {
                engineSize = value;
            }
        }

        public string Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public Car(string company, string model, string year, string engineSize, string price)
        {
            this.Company = company;
            this.Model = model;
            this.Year = year;
            this.EngineSize = engineSize;
            this.Price = price;
        }
    }
}