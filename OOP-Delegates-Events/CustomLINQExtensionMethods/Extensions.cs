using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLINQExtensionMethods
{
    public static class Extensions
    {

        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            List<T> result = new List<T>();

            foreach (var element in collection)
            {
                if (!predicate(element))
                {
                    result.Add(element);
                }
            }

            return result;
        }

        public static TSelector Max<TSource, TSelector>(this IEnumerable<TSource> collection , Func<TSource, TSelector> selector )
            where  TSelector:IComparable
        {
            TSelector result = selector(collection.First());

            foreach (var item in collection)
            {
                if (result.CompareTo(selector(item))<0)
                {
                    result = selector(item);
                }
            }

            return result;
        }

    }
}
