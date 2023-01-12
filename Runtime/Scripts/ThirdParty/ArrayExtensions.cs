using System;

namespace NetMQ.Utils
{
    internal static class ArrayExtensions
    {
        // from NetMQ      
        public static Span<T> Slice<T>(this T[] array, int offset)
        {
            Span<T> span = array;
            return span.Slice(offset);
        }
        
        public static Span<T> Slice<T>(this T[] array, int offset, int length)
        {
            Span<T> span = array;
            return span.Slice(offset, length);
        }
 
        // from NaCl
        public static void Clear<T>(this T[] array)
        {
            if (array != null)
            {
                Array.Clear(array, 0, array.Length);
            }
        }
    }
}