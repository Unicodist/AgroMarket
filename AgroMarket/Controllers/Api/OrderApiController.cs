﻿using AgroMarket.Data.Repository;
using AgroMarket.Helper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AgroMarket.Controllers.Api;

public class OrderApiController : ApiControllerBase
{
    private readonly OrderRepository _orderRepository;
    private readonly UserHelper _userHelper;
    private OrderProductRepository _orderProductRepository;

    public OrderApiController(OrderRepository orderRepository, UserHelper userHelper)
    {
        _orderRepository = orderRepository;
        _userHelper = userHelper;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var user = _userHelper.GetCurrentUser(this);
        var orders = await _orderProductRepository.GetQueryable().Where(x=>x.Order.OrderedByUserId==user.Id).ToListAsync();
        return Ok(orders);
    }
}