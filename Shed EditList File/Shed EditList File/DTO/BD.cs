using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Shed_EditList_File.DTO
{
    public class BD
    {
        private static ObservableCollection<Flower> Flowers;
        public static ObservableCollection<Flower> GetInstance()
        {
            if (Flowers == null)
                Flowers = new ObservableCollection<Flower>();
            return Flowers;
        }
        public void AddFlower(string name, decimal cost)
        {
            Flowers.Add(new Flower
            {
                NameFlower = name,
                CostFlower = cost
            });
        }
        public void EditFlower(Flower flower)
        {
            var a = Flowers.FirstOrDefault(s => s.NameFlower == flower.NameFlower);
            a = flower;
        }
        public void DeleteFlower(Flower flower) 
        {  
            Flowers.Remove(flower); 
        }

    }
}
