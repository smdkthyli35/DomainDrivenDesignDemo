﻿using DomainDrivenDesignDemo.Domain.AggregateModels.OrderModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDrivenDesignDemo.Domain.Events
{
    public class OrderStartedDomainEvent : INotification
    {
        public string UserName { get; set; }
        public Order Order { get; set; }

        public OrderStartedDomainEvent(string userName, Order order)
        {
            UserName = userName;
            Order = order;
        }
    }
}
