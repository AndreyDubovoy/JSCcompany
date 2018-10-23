using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public static class CollectionExtension
    {

        public static Type GetListType<T>(this IEnumerable<T> list)
        {
            return list.GetType().GetGenericArguments()[0];
        }

        public static IEnumerable<T> OrderCollection<T>(this IEnumerable<T> collection, string currentOrder, bool desc = false)
        {
            var type = collection.GetListType();
            var propertyInfo = type.GetProperty(currentOrder);
            if (desc) return collection.OrderByDescending(t => propertyInfo.GetValue(t));
            return collection.OrderBy(t => propertyInfo.GetValue(t));
        }

        public static IEnumerable<T> OrderCollectionWithIndex<T>(IEnumerable<T> collection, string currentOrder,
                                                  Predicate<T> predicate, out int index)
        {
            //  Set<T> newCollection = new Set<T>();
            List<T> newCollection = new List<T>();
            int i = 0;
            index = 0;
            var type = collection.GetListType();
            var propertyInfo = type.GetProperty(currentOrder);
            var order = collection.OrderBy(t => propertyInfo.GetValue(t));
            foreach (T h in order)
            {
                newCollection.Add(h);
                if (predicate(h)) index = i;
                i++;
            }
            return newCollection;
        }
    }
}
