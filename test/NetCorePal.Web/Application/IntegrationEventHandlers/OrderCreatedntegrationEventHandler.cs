﻿using MediatR;
using NetCorePal.Extensions.DistributedTransactions;

namespace NetCorePal.Web.Application.IntegrationEventHandlers
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="mediator"></param>
    /// <param name="logger"></param>
    public class OrderCreatedIntegrationEventHandler(
        IMediator mediator,
        ILogger<OrderCreatedIntegrationEventHandler> logger) : IIntegrationEventHandler<OrderCreatedIntegrationEvent>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="eventData"></param>
        /// <param name="cancellationToken"></param>
        public Task HandleAsync(OrderCreatedIntegrationEvent eventData,
            CancellationToken cancellationToken = default)
        {
            logger.LogInformation("OrderCreatedIntegrationEventHandler.HandleAsync");
            return Task.CompletedTask;
        }
    }
}