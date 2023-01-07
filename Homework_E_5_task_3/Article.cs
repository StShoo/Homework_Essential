using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_E_5_task_3
{
    internal class Article
    {
        string name;
        string shopName;
        double cost;

        public Article(string name, string shopName, double cost)
        {
            this.name = name;
            this.shopName = shopName;
            this.cost = cost;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public string ShopName
        {
            get
            {
                return shopName;
            }
        }

        public double Cost
        {
            get
            {
                return cost;
            }
        }
    }
}
