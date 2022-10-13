using CourseSignupSystem.Application.Catalog.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSignupSystem.Application.Catalog.Products.Dtos.Public
{
    public class GetProductPagingRequest: PagingRequestBase
    {
        public int DSHocVienId { get; set; }
    }
}
