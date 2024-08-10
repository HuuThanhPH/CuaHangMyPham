using MongoWeb.Models;
using MongoWeb.Repositores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MongoWeb.Services
{
    public class Login
    {
        public ITodoRepository todoRepository;

        public Login(ITodoRepository todoRepository)
        {
            this.todoRepository = todoRepository;
        }

        //public void Excute(string email, string password)
        //{
        //    // Gọi phương thức Login của repository để xác thực người dùng
        //    todoRepository.Login(email, password);
        //}
        public bool Authenticate(string email, string password)
        {
            try
            {
                todoRepository.Login(email, password);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}