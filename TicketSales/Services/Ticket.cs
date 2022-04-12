using TicketSales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSales.Services
{
    public class Ticket
    {

        List<Product> ticketList = new()
        {
            new Product
            {
                Name = "Mahlûkat",
                Id=1,
                place="28 Mall",
                Price=3.5,
                Session="10:00",
                Tarix=DateTime.Now,




            },
            new Product
            {
                Name = "Bergen",
                Id = 2,
                place = "Genclik Mall",
                Price = 4,
                Session = "10:05",
                Tarix = DateTime.Now,
            },
            new Product
            {
                Name = "Sonik 2 kinoda",
                Id = 3,
                place = "28 Mall",
                Price = 4.5,
                Session = "12:00",
                Tarix = DateTime.Now,
            },
            new Product
            {
                Name = "The Batman",
                Id = 4,
                place = "Genclik Mall",
                Price = 4.5,
                Session = "16:00",
                Tarix = DateTime.Now,
            },
            new Product
            {
                Name = "The Batman",
                Id = 4,
                place = "28 Mall",
                Price = 4.5,
                Session = "18:00",
                Tarix = DateTime.Now,
            },
            new Product
            {
                Name = "Tecili yardim",
                Id = 5,
                place = "Genclik Mall",
                Price = 5,
                Session = "23:45",
                Tarix = DateTime.Now,
            },

            new Product
            {
                Name = "Tecili yardim",
                Id = 6,
                place = "Deniz Mall",
                Price = 5,
                Session = "22:00",
                Tarix = DateTime.Now,
            },
            new Product
            {
                Name = "Ambulance",
                Id = 7,
                place = "Deniz Mall",
                Price = 5.5,
                Session = "23:45",
                Tarix = DateTime.Now,
            },

        };

        public List<Product> GetAll()
        {
            return ticketList;
        }

        public Product GetById(int id)
        {
            var product =ticketList.FirstOrDefault(x => x.Id == id);
         
            return product;
        }

    

    }



}

        

