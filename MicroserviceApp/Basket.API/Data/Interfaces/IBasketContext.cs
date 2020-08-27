using StackExchange.Redis;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Basket.API.Data.Interfaces
{
    public interface IBasketContext
    {
        IDatabase Redis { get; }
    }
}