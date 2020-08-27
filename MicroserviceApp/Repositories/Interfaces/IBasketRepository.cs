using System;
using Basket.API.Entities;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Basket.API.Repositories.Interfaces
{
    public interface IBasketRepository
    {
         Task<BasketCart> GetBasket(string userName);
         Task<BasketCart> UpdateBasket(BasketCart basket);
         Task<bool> DeleteBasket(string userName);
    }
}