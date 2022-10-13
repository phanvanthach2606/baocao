using CourseSignupSystem.Application.Catalog.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSignupSystem.Application.Catalog.Products.Dtos
{
    public class GetProductPagingReques : PagingRequestBase
    {
        public string TimKiem { get; set; }
        public List<int> DSHocVienID { get; set; }
    }
}
