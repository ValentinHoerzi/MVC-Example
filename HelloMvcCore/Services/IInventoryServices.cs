﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloMvcCore.Models;

namespace HelloMvcCore.Services
{
    public interface IInventoryServices
    {
        InventoryItems AddInventoryItems(InventoryItems items);
        Dictionary<string, InventoryItems> GetInventoryItems();
    }
}
