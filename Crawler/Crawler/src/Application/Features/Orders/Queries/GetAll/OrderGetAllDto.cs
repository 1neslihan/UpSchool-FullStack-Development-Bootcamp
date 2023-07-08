﻿using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Orders.Queries.GetAll
{
    public class OrderGetAllDto
    {
        public OrderGetAllDto(Guid id, int? requestedAmount, int? totalFoundAmount, ProductCrawlType productCrawlType, bool isDeleted)
        {
            Id=id;
            RequestedAmount=requestedAmount;
            TotalFoundAmount=totalFoundAmount;
            ProductCrawlType=productCrawlType;
            IsDeleted=isDeleted;
        }

        public Guid Id { get; set; }
        public int? RequestedAmount { get; set; }
        public int? TotalFoundAmount { get; set; }

        //public string UserId { get; set; }
        public ProductCrawlType ProductCrawlType { get; set; }
        public bool IsDeleted { get; set; }
    }
}
