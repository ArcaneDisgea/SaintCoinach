﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaintCoinach.Xiv {
    public interface IShop {
        int Key { get; }
        string Name { get; }
        IEnumerable<ENpc> ENpcs { get; }
        IEnumerable<IShopListing> ShopListings { get; }
    }
}