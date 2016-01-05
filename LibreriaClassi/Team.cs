using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClassi
{
    public partial class Team
    {
        partial void InitializePartial()
        {
            TeamId = new Guid();
        }
    }
}
