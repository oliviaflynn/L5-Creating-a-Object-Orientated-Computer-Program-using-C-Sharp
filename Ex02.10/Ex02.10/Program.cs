using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("type {0} size{1} minval:{2} maxval:{3}", typeof(sbyte), sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
            Console.WriteLine("type {0} size{1} minval:{2} maxval:{3}", typeof(byte), sizeof(byte), byte.MinValue, byte.MaxValue);
            Console.WriteLine("type {0} size{1} minval:{2} maxval:{3}", typeof(char), sizeof(char), char.MinValue, char.MaxValue);
            Console.WriteLine("type {0} size{1} minval:{2} maxval:{3}", typeof(short), sizeof(short), short.MinValue, short.MaxValue);
            Console.WriteLine("type {0} size{1} minval:{2} maxval:{3}", typeof(ushort), sizeof(ushort), ushort.MinValue, ushort.MaxValue);
            Console.WriteLine("type {0} size{1} minval:{2} maxval:{3}", typeof(int), sizeof(int), int.MinValue, int.MaxValue);
            Console.WriteLine("type {0} size{1} minval:{2} maxval:{3}", typeof(uint), sizeof(uint), uint.MinValue, uint.MaxValue);
            Console.WriteLine("type {0} size{1} minval:{2} maxval:{3}", typeof(long), sizeof(long), long.MinValue, long.MaxValue);
            Console.WriteLine("type {0} size{1} minval:{2} maxval:{3}", typeof(ulong), sizeof(ulong), ulong.MinValue, ulong.MaxValue);
            Console.WriteLine("type {0} size{1} minval:{2} maxval:{3}", typeof(float), sizeof(float), float.MinValue, float.MaxValue);
            Console.WriteLine("type {0} size{1} minval:{2} maxval:{3}", typeof(double), sizeof(double), double.MinValue, double.MaxValue);
            Console.WriteLine("type {0} size{1} minval:{2} maxval:{3}", typeof(decimal), sizeof(decimal), decimal.MinValue, decimal.MaxValue);
            Console.ReadKey();
        }

    }
}

/*
 The char data type is 16 bit character using unicode encoding.
 It holds a single unicode character value. It is 2 bytes in size.
 This is a built-in value type in C#. What this means is that the Char type is integral to the C# programming language and is not one that has been defined by the user.
 Also, Char is a value type since it actually stores the value in the memory that has been allocated on the stack. 
 This is unlike reference type where the stack actually contains the reference or address of the variable while the object itself resides in the heap.
     */
