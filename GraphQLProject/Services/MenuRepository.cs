using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQLProject.Data;
using GraphQLProject.Interfaces;
using GraphQLProject.Models;

namespace GraphQLProject.Services
{
    public class MenuRepository : IMenuRepository
    {
        //private static List<Menu> MenuList = new List<Menu>()
        //{
        //    new Menu(){Id=1,Name="Vada Pav", Description="Tasty Vada Pav",Price=20 },
        //    new Menu(){Id=2,Name="Samosa", Description="Tasty Samosa",Price=25 },
        //    new Menu(){Id=3,Name="Sada Dosa", Description="Tasty Sada Dosa",Price=30 },
        //    new Menu(){Id=4,Name="Masala Dosa", Description="Tasty Masala Dosa",Price=50 },
        //};

        private GraphQLDbContext dbContext;

        public MenuRepository(GraphQLDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Menu AddMenu(Menu menu)
        {
            dbContext.Menus.Add(menu);
            dbContext.SaveChanges();
            return menu;
        }

        public void DeleteMenu(int id)
        {
            //MenuList.RemoveAt(id);
            var menuResult = dbContext.Menus.Find(id);
            dbContext.Menus.Remove(menuResult);
            dbContext.SaveChanges();
        }

        public List<Menu> GetAllMenu()
        {
            return dbContext.Menus.ToList();
        }

        public Menu GetMenuById(int id)
        {
            return dbContext.Menus.Find(id);
        }

        public Menu UpdateMenu(int id, Menu menu)
        {
            //MenuList[id] = menu;
            var menuResult = dbContext.Menus.Find(id);

            menuResult.Name = menu.Name;
            menuResult.Description = menu.Description;
            menuResult.Price = menu.Price;
            dbContext.SaveChanges();
            return menuResult;
        }
    }
}
