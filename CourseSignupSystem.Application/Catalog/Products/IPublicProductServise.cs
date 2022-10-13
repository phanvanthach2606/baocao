using CourseSignupSystem.Application.Catalog.Dtos;
using CourseSignupSystem.Application.Catalog.Products.Dtos.Public;
using CourseSignupSystem.Application.Catalog.Products.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSignupSystem.Application.Catalog.Products
{
    public interface IPublicProductServise
    {
        PagedViewModel<ProducViewModel> GetAllByCategory(GetProductPagingRequest reques);
    }
}
