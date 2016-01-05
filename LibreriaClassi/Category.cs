using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibreriaClassi
{
    public partial class Category
    {
        partial void InitializePartial()
        {
            CategoryId = new Guid();
        }
    }
}
