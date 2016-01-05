using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClassi
{
    public partial class Season
    {
        partial void InitializePartial()
        {
            SeasonId = new Guid();
        }
    }
}
