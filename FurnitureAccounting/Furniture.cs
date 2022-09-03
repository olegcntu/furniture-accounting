using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureAccounting
{
    class Furniture
    {
        private string name;
        private string manufacturer;
        private string material;
        private int count;
        private string description;
        public Furniture(string name, string manufacturer, string material, int count, string description)
        {
            this.name = name;
            this.manufacturer = manufacturer;
            this.material = material;
            this.count = count;
            this.description = description;
        }

        public string getName()
        {
            return this.name;
        }
        public string getManufacturer()
        {
            return this.manufacturer;
        }
        public string getMaterial()
        {
            return this.material;
        }
        public int getCount()
        {
            return this.count;
        }
        public string getDescription()
        {
            return this.description;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setManufacturer(string manufacturer)
        {
            this.manufacturer = manufacturer;
        }
        public void setMaterial(string material)
        {
            this.material = material;
        }

        public void setCount(int count)
        {
            this.count = count;
        }
        public void setDescription(string description)
        {
            this.description = description;
        }
    }
    
}

