using System;
using System.Threading.Tasks;

namespace ObjectExtensions
{
    static public partial class IsNullExtension
    {
        static public bool IsNull(this object o)
        {
            return o == null;
        }

        static public async Task<bool> IsNullAsync(this object o)
        {
            return await new Task<bool>(() => { return o.IsNull(); });
        }
    }
}
