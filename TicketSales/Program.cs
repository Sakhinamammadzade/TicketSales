using TicketSales.Models;
using TicketSales.Services;


Ticket ticket = new Ticket();

Console.Clear();

Evvele:


foreach (var tickets in ticket.GetAll())
{
    Console.WriteLine("*******************************");
    Console.WriteLine(tickets.Name+tickets.Session);
    Console.WriteLine("*******************************");
}


Console.WriteLine("Id daxil edin:");
var menu = Console.ReadLine();
var service = ticket.GetById(Convert.ToInt32(menu));
Console.WriteLine(service.Name + "- " + service.place + "-" + service.place);



goto Evvele;