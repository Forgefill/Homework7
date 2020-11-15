using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid1
{
    //Який принцип S.O.L.I.D. порушено? Виправте!


    // Порушено принцип єдиного обов'язку (SRP);
    class Item
    {

    }
    class Order
    {
        private List<Item> itemList;

        internal List<Item> ItemList
        {
            get
            {
                return itemList;
            }

            set
            {
                itemList = value;
            }
        }

        public void CalculateTotalSum() {/*...*/}
        public void GetItems() {/*...*/}
        public void GetItemCount() {/*...*/}
        public void AddItem(Item item) {/*...*/}
        public void DeleteItem(Item item) {/*...*/}

    }

    class OrderRepository
    {
        public void Load(int id) {/*...*/}
        public void Save(Item item) {/*...*/}
        public void Update(int id, Item item) {/*...*/}
        public void Delete(int id) {/*...*/}

    }
    class PrintManager
    {
        public void PrintOrder(List<Item> order) {/*...*/}
        public void ShowOrder(List<Item> order) {/*...*/}
    }
    class Ex1
    {
        static void Main()
        {
        }
    }
}
