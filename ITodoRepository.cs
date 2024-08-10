using MongoDB.Bson;
using MongoWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoWeb
{
    public interface ITodoRepository
    {
        //Them sp
        void Add(Products products);
        //Xoa sp
        void Delete(string id);
        //Sua sp
        void UpdateProduct(string id, Products products);
        //Lay sp
        List<Products> GetAll();
        //Lay danh muc sp
        List<string> GetProductCategories();
        //Lay sp by id
        Products GetById(string id);
        //Tim kiem sp
        List<Products> SearchProducts(string query);
        void Login(string email, string password);
        //Register
        void Register(Register register);
        //Lấy ds User
        List<Users> GetAllUsers();
        //Them user
        void Add(Users user);
        //Lay user
        Users Getuser(string username);
        //Xoa user
        void Deleteuser(string id);
        //Sua user
        void UpdateUser(string id, Users user);
        //Lay user theo id
        Users GetUserById(string id);
        //Tim kiem user
        Users GetUserByEmail(string email);
        List<CartItem> GetCartItems();
        List<Order> GetAllOrders();
        void UpdateStatus(string id, Order UpdateOrder);
        //Users GetUserById(string id);
        void ClearCart(ObjectId UserId);

        // Order Methods

        void PlaceOrder(Order order);
        Order GetOrderById(string id);
        List<Order> GetAllOrders(string email);
        void UpdateOrder(Order order);
        void DeleteOrder(string orderId);
    }

}
