using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_E_5_task_3
{
    internal class Store
    {
        public Article[] CreateArrayOfArticles()
        {
            Article[] articles = {new Article("Hrechka", "Silpo", 34.5),
                new Article("Salt", "EKO", 30.25), new Article("Bread", "Silpo", 24), 
                new Article("Tea", "ATB", 14.60), new Article("Bear", "ATB", 30.25), 
                new Article("Schweppes", "MegaMarket", 24.40)};

            return articles;
        }
    }
}
