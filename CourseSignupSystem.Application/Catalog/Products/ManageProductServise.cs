using CourseSignupSystem.Application.Catalog.Dtos;
using CourseSignupSystem.Application.Catalog.Products.Dtos;
using CourseSignupSystem.Application.Catalog.Products.Dtos.Manage;
using CourseSignupSystem.Data.EF;
using CourseSignupSystem.Data.Entity;
using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CourseSignupSystem.Application.Catalog.Products
{
    public class ManageProductServise : IManageProductServise
    {
        private readonly CSSDbContext _context;
        public ManageProductServise(CSSDbContext context)
        {
            _context = context;
        }

        public async Task AddViewcount (int DSHocVienId)
        {
            var ds = await _context.DSHocViens.FindAsync(DSHocVienId);
            ds.ViewCount += 1;
            await _context.SaveChangesAsync();
        }
        public async Task<int> Create(ProductCreateRequest request)
        {
            var dsHocVien = new DSHocVien()
            {
                HinhAnh = request.HinhAnh,
                HoTen = request.HoTen,
                PhuHuynh = request.PhuHuynh,
                DiaChi = request.DiaChi,
                NgaySinh = DateTime.Now,
                SDT = request.SDT,
                Email = request.Email,
            };
            _context.DSHocViens.Add(DSHocVien);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> Update(ProductEditRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Delete(int DSHocVienId)
        {
            if(DSHocVien == null) throw new Null
            var ds = await _context.DSHocViens.FindAsync(DSHocVienId);
            _context.DSHocViens.Remove(DSHocVien);
            await _context.SaveChangesAsync();

        }

        public async Task<List<ProducViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<PagedViewModel<ProducViewModel>> GetAllpaging(string TimKiem, int SoTT, int KichCo)
        {
            throw new NotImplementedException();
        }

    }
}
