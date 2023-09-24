using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQLProject.Models;

namespace GraphQLProject.Interfaces
{
    public interface IMenuRepository
    {
        List<Menu> GetAllMenu();
        Menu GetMenuById(int id);
        Menu AddMenu(Menu menu);
        Menu UpdateMenu(int id, Menu menu);
        void DeleteMenu(int id);
    }
}
