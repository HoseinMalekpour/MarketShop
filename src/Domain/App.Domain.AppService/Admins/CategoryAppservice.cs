using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.AppServices.Admins;
using App.Domain.Core.DataAccess;
using App.Domain.Core.DtoModels;

namespace App.Domain.AppService.Admins
{
    public class CategoryAppservice : ICategoryAppservice
    {
        private readonly ICategoryRipository _categoryRipository;
    public CategoryAppservice(ICategoryRipository categoryRipository)
        {
            _categoryRipository = categoryRipository;
        }

       
    }
}
