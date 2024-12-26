using Microsoft.Win32.SafeHandles;
using System;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region casting [boxing( save) ,unboxing (un save)]
            ////boxing convert from value to refrence
            ////un boxing convert from refrence to value
            //object obj = new object();
            //obj = "mo";// refrence type r to to
            //obj = 1; //v to r boxing
            //obj = 5;
            //int x;
            //x =(int)obj;//un boxing;

            ////both type take long time and bad deal with memory

            #endregion

            #region nullable data type

            ////Kind of data allow null 
            //int? n = null;
            ////n.HasValue;//bool return IFormatProvider is null or not
            #endregion

            #region null propagation  operator
            //int [] Array = null;
            //for (int i = 0;Array!=null && i < args.Length; i++) //اتاكد ان الاراي بتشاور علي حاجة
            //{
            //    Console.WriteLine(i);
            //}
            ////way_2
            //for (int i = 0; i < args?.Length; i++) //اتاكد ان الاراي بتشاور علي حاجة
            //{
            //    Console.WriteLine(i);
            //}

            ////way_3
            //if (Array != null)
            //{
            //    for (int i = 0; i < Array.Length; i++) //اتاكد ان الاراي بتشاور علي حاجة
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            ////////////////////
            //int? l = Array?.Length;
            //int l1 = Array?.Length??0;//if null make it 0 else assign number(null quleas e operator
            #endregion

            #region function

            #region  passing with value type
            //1-passing by value with va;ue type change in function dont affect in main varible
            //avoid_it with bassing by (ref)  affect in main varible
            #endregion

            #region passing with ref type

            //in both type are same  but( there is Some-cases)
            #endregion

            #region out paramter

            //empty v sent to function with  (out)

            #endregion

            #region params
            //sent spereted array to function
            #endregion

            #endregion

        }
    }
}
