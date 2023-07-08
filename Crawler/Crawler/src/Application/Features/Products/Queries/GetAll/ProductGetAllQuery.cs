﻿using Application.Common.Models.General;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Products.Queries.GetAll
{
    public class ProductGetAllQuery:IRequest<PaginatedList<ProductGetAllDto>>
    {
        public ProductGetAllQuery(bool? isDeleted, Guid? orderId)
        {
            IsDeleted=isDeleted;
            OrderId=orderId;
        }


        public bool? IsDeleted { get; set; }

        public Guid? OrderId { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }

        
    }
}
