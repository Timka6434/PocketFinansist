using CommunityToolkit.Mvvm.ComponentModel;
using PocketFinansist.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketFinansist.ViewModels
{
    internal class FinanceViewModel : ObservableObject
    {
        private string _name;
        private FinanceModel.FinanceType _type;
        private uint _sum;
        private FinanceModel.RegularityType _regularity;

        // Свойства для привязки к интерфейсу
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value); // Уведомление об изменении
        }

        public FinanceModel.FinanceType Type
        {
            get => _type;
            set => SetProperty(ref _type, value); // Уведомление об изменении
        }

        public uint Sum
        {
            get => _sum;
            set => SetProperty(ref _sum, value); // Уведомление об изменении
        }

        public FinanceModel.RegularityType Regularity
        {
            get => _regularity;
            set => SetProperty(ref _regularity, value); // Уведомление об изменении
        }

        // Модель финансовой единицы
        public FinanceModel FinModel { get; private set; }

        public void CreateFinanceUnit()
        {
            FinModel = new FinanceModel(Name, Type, Sum, Regularity);
        }
    }
}
