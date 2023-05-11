using System;
using System.Reflection;


[assembly: AssemblyDescription("Simple extension to check if your object is a null value in .NET")]


namespace ObjectExtensions
{
    static public class ObjectExtensions
    {
        static public Boolean IsNull(this Object o)
        {
            return o == null;
        }
    }
}
