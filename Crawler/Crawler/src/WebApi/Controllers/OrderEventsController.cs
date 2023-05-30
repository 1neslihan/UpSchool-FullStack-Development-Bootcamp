﻿using Application.Features.OrderEvents.Commands.Add;
using Application.Features.OrderEvents.Queries.GetAll;
using Application.Features.Products.Commands.Add;
using Application.Features.Products.Queries.GetAll;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class OrderEventsController : ApiControllerBase
    {
        [HttpPost("Add")]
        public async Task<IActionResult> AddAsync(OrderEventAddCommand command)
        {
            return Ok(await Mediator.Send(command));
        }
        [HttpPost("Pull")]
        public async Task<IActionResult> GetAllAsync(OrderEventGetAllQuery query)
        {
            return Ok(await Mediator.Send(query));
        }
    }
}