using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketFinansist.Models
{
    /// <summary>
    /// Класс для создания экземпляров финансов дохода и расхода
    /// </summary>
    /// 
    internal class FinanceModel
    {
        public string Id { get; private set; }
        public string Name { get; private set; }
        public enum FinanceType { unknown, income, consumption }
        public FinanceType financeType { get; private set; }

        public uint Sum { get; private set; }

        public enum RegularityType { unknown, oneTime, weekly, monthly, quarterly, annually, }
        public RegularityType regularity { get; private set; }

        public DateTime DateOfCreate { get; private set; }


        public FinanceModel(string name, FinanceType finType, uint sum, RegularityType regularType) 
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            financeType = finType;
            Sum = sum;
            regularity = regularType;
            DateOfCreate = DateTime.Now;
        }
    }
}
