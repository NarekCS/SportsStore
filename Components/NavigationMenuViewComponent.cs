using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        public string Invoke()
        {
            return "HEllo from the Nav View Component";
        }
    }
}
