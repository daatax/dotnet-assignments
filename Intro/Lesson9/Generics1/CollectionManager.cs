using System;
using System.Collections.Generic;

namespace Intro.Lesson9.Generics1
{
    public class CollectionManager<T>
    {
        private List<T> items = new List<T>();

        public void AddItem(T item) {
            items.Add(item);
        }
        public void RemoveItem(T item) {
            if (items.Contains(item)) {
                items.Remove(item);
            }
            else {
                throw new ArgumentException($"{item} cannot be found in the collection.");
            }
        }

        public List<T> GetItems() {
            return items;
        }
        public int CountItems() {
            return items.Count();
        }
        public void ClearItems() {
            items.Clear();
        }
    }
}