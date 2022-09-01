using System;

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
