using System;

namespace ObjectExtensions
{
    static public class Extensions
    {
        static public Boolean IsNull(this Object o)
        {
            return o == null;
        }
    }
}
