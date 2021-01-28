﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SDP.ViewModels;
using SDP.Models;
using SDP.Data;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using System.Collections;
using Microsoft.Data.SqlClient;

namespace SDP.Controllers
{
    public class CustomerController : Controller
    {


        private readonly ApplicationDbContext _context;

        private readonly IHostingEnvironment hostingEnvironment;
        static List<int> cartList = new List<int>();
         
        int qty;
        int pro_id;
        static string Email = "";

        public CustomerController(ApplicationDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            this.hostingEnvironment = hostingEnvironment;
            //cartList.Add(0);
        }


        public IActionResult Index()
        {
            return View();
        }



        [Authorize]

        public IActionResult PurchaseProduct()
        {
            var productsList = _context.products.ToList();
            return View(productsList);
        }
        [HttpGet]
        [Authorize]

        public async Task<IActionResult> AddToCart(int ?id)
        {
            product pd = await _context.products.FindAsync(id);
            cartList.Add((int)id);
            //Console.WriteLine(cartList.Count);
            pd.Name = pd.Name;
            pd.MRP = pd.MRP;
            pd.Category = pd.Category;
            pd.Photopath = pd.Photopath;
            pd.originalPrice = pd.originalPrice;
            pd.Quantity = pd.Quantity - 1;
            _context.Update(pd);
            await _context.SaveChangesAsync();
            
            foreach (int x in cartList)
            {
                Console.WriteLine(x);
            }
            //Console.WriteLine(cartList.Count);
            return RedirectToAction("PurchaseProduct", "Customer");
            //PurchaseProduct pp = new PurchaseProduct()
            //{
            //    ProductCategory = model.ProductCategory,
            //    ProductName = model.ProductName,
            //    ProductQuantity = model.ProductQuantity
            //};

            //SqlConnection cnn;
            //String connectionString = "Server=(localdb)\\mssqllocaldb;Database=aspnet-SDP-CC54433E-7C52-476B-9D44-F833439FB6B2;Trusted_Connection=True;MultipleActiveResultSets=true";
            //cnn = new SqlConnection(connectionString);
            //cnn.Open();
            //System.Diagnostics.Debug.WriteLine("hello");
            //String sql = "SELECT * FROM Products WHERE Category = + '" + model.ProductCategory + "'   and Name =  '" + model.ProductName +"'";
            //SqlCommand command = new SqlCommand(sql,cnn);
            //SqlDataReader reader = command.ExecuteReader();

            //while (reader.Read())
            //{
            //    qty = (int)reader.GetValue(5);
            //    pro_id = (int)reader.GetValue(0);
            //}
            //cnn.Close();
            //if ( qty >= pp.ProductQuantity)
            //{

            //        productlist.Add(pp.ProductCategory);
            //        productlist.Add(pp.ProductName);
            //        productlist.Add(pp.ProductQuantity);



            //}
            //else
            //{
            //    ViewBag.quantity = "Available Quantity :" + qty;
            //    ViewBag.ErrorMessage = "Not enough Quantity";
            //}
            //int i;
            


            
        }

        // [Authorize]

        [HttpGet]
        [Authorize]

        public IActionResult AddCustomer()
        {
            return View();
        }

      
        [HttpPost]
        public IActionResult AddCustomer(CustomerViewModel model)
        {
            if (ModelState.IsValid) { 
                    customer newcustomer = new customer
                    {
                        Name = model.Name,
                        email = model.email,
                        contact = model.contact,
                        address = model.address
                    };
                     Email = model.email;
               // Console.WriteLine(Email);
                    _context.Add(newcustomer);
                    _context.SaveChanges();


                    return RedirectToAction("PurchaseProduct","Customer");
            }
            return View();
        }
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GenerateInvoice()
        {
            int i;
            Console.WriteLine(cartList.Count);
            float amount = 0;
            int total_qauntity = 0;
            int customerId = 0;
            SqlConnection cnn;
            String connectionString = "Server=(localdb)\\mssqllocaldb;Database=aspnet-SDP-CC54433E-7C52-476B-9D44-F833439FB6B2;Trusted_Connection=True;MultipleActiveResultSets=true";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            String query = "SELECT * FROM customers WHERE email = '" + Email + "' ";
            Console.WriteLine(query);
            SqlCommand command = new SqlCommand(query, cnn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                customerId = Int32.Parse((reader.GetValue(0)).ToString());
                //Console.WriteLine(reader.GetValue(0));
            }
            for (i = 0; i < cartList.Count; i++)
            {
                Console.WriteLine(cartList[i]);
            }
            int[] fr1 = new int[100];
            int length = cartList.Count;
            for (i = 0; i < length; i++) {
                fr1[i] = -1;
            }
            for (i = 0; i < length; i++)
            {
                int ctr = 1;
                for (int j = i + 1; j < length; j++)
                {
                    if (cartList[i] == cartList[j])
                    {
                        ctr=ctr+1;
                        fr1[j] = 0;
                    }
                }

                if (fr1[i] != 0)
                {
                    fr1[i] = ctr;
                }
            }
            customer ct = await _context.customers.FindAsync(customerId);

            float total_amount = 0;
            for (i = 0; i < length; i++)
            {
                string pName = "";
                int quantity = 0;
                if (fr1[i] != 0)
                {
                    //Console.Write("{0} occurs {1} times\n", cartList[i], fr1[i]);
                    product pd = await _context.products.FindAsync(cartList[i]);
                    pName = "" + pd.Name;
                    amount = (pd.MRP) * (fr1[i]);
                    quantity = fr1[i];
                    Order customerObj = new Order
                    {
                        customerId = customerId,
                        ProductName = pName,
                        Quantity = quantity,
                        Price = amount
                    };
                    _context.Update(customerObj);
                    await _context.SaveChangesAsync();
                    total_qauntity = total_qauntity + fr1[i];
                    total_amount = total_amount + amount;

                }
            }

            //Order orderObj = await _context.order.FindAsync(customerId);
            //Console.WriteLine(orderObj);
            //query = "SELECT * FROM order WHERE customerId = '" + customerId + "'";
            //Console.WriteLine(query);
            //command = new SqlCommand(query, cnn);
            //reader = command.ExecuteReader();
            var orderList = _context.order.ToList();

            try
            {
                ViewBag.total_amount = total_amount;
                ViewBag.total_quantity = total_qauntity;
                ViewBag.customer_name = ct.Name;
                ViewBag.customer_Id = customerId;
                cnn.Close();
                return View(orderList);
            }
            catch (Exception e) {

                return RedirectToAction("AddCustomer","Customer");
            }
        }
    }
}
