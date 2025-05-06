using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CategoryBUS
    {
        private CategoryDAL cateDAL;

        public CategoryBUS()
        {
            cateDAL = new CategoryDAL();
        }

        public List<Category> GetAll()
        {
            return cateDAL.GetAll();
        }

        public bool Add(Category category)
        {
            return cateDAL.Add(category);
        }

        public bool CheckExist(string cateId, string catename)
        {
            return cateDAL.CheckExist(cateId, catename);
        }
    }
}
