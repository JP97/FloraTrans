using FloraTrans.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FloraTrans.Data
{
    public class DBInitializer
    {
        public void DbInitialize(FloraTransContext context)
        {
            if (context.Container.Any())
            {
                return;   // DB has been seeded
            }

            var Contacts = new Contact[]
            {
                new Contact { Name = "Bob", JobTitel ="MarkedsføringsØkonom", Email = "bob@bob.dk", Phone = "123456"},
                new Contact { Name = "Manfred", JobTitel ="Handelassistent", Email = "manfred@manfred.dk", Phone = "654321"},
                new Contact { Name = "Henrik", JobTitel ="bla", Email = "henrik@henrik.dk", Phone = "456123"},
            };

            var Warehouse = new Warehouse
            {
                RentedContainersFromCC = 15
            };

            var Container = new Container[]
            {
                new Container  { Rented = new DateTime(2021,1,1), Returned = null, Available = false, Lost = false, CurrentClient = 1},
                new Container  { Rented = new DateTime(2021,1,1), Returned = null, Available = false, Lost = false, CurrentClient = 1},
                new Container  { Rented = new DateTime(2021,1,1), Returned = new DateTime(2021,1,7), Available = true, Lost = false, CurrentClient = 1},
                new Container  { Rented = new DateTime(2021,1,1), Returned = new DateTime(2021,1,7), Available = true, Lost = false, CurrentClient = 1},
                new Container  { Rented = new DateTime(2021,1,14), Returned = null, Available = false, Lost = true, CurrentClient = 2},
                new Container  { Rented = new DateTime(2021,1,14), Returned = new DateTime(2021,1,24), Available = true, Lost = false, CurrentClient = 2},
                new Container  { Rented = new DateTime(2021,1,14), Returned = new DateTime(2021,1,24), Available = true, Lost = false, CurrentClient = 2},
                new Container  { Rented = new DateTime(2021,1,14), Returned = new DateTime(2021,1,24), Available = true, Lost = false, CurrentClient = 2},
                new Container  { Rented = new DateTime(2021,1,14), Returned = new DateTime(2021,1,24), Available = true, Lost = false, CurrentClient = 2},
                new Container  { Rented = new DateTime(2021,1,20), Returned = new DateTime(2021,1,25), Available = true, Lost = false, CurrentClient = 3},
                new Container  { Rented = new DateTime(2021,1,20), Returned = new DateTime(2021,1,25), Available = true, Lost = false, CurrentClient = 3},
                new Container  { Rented = new DateTime(2021,1,20), Returned = new DateTime(2021,1,25), Available = true, Lost = false, CurrentClient = 3},
                new Container  { Rented = null, Returned = null, Available = true, Lost = false},
                new Container  { Rented = null, Returned = null, Available = true, Lost = false},
                new Container  { Rented = null, Returned = null, Available = true, Lost = false}
            };

            List<Container> firstRentedList = new List<Container>();
            List<Container> firstReturnedList = new List<Container>();
            firstRentedList.Add(Container[0]);
            firstRentedList.Add(Container[1]);
            
            firstReturnedList.Add(Container[2]);
            firstReturnedList.Add(Container[3]);


            List<Container> secondRentedList = new List<Container>();
            List<Container> secondReturnedList = new List<Container>();
            secondRentedList.Add(Container[4]);
            secondReturnedList.Add(Container[5]);
            secondReturnedList.Add(Container[6]);
            secondReturnedList.Add(Container[7]);
            secondReturnedList.Add(Container[8]);

            List<Container> thirdRentedList = new List<Container>();
            List<Container> thirdReturnedList = new List<Container>();

            thirdReturnedList.Add(Container[9]);
            thirdReturnedList.Add(Container[10]);
            thirdReturnedList.Add(Container[11]);




            var Clients = new Client[]
            {
                new Client { CVR = 10, Address = "Seebladsgade 1", Contact = Contacts[0], RentedContainer = firstRentedList , ReturnedContainer = firstReturnedList},
                new Client { CVR = 11, Address = "Havnegade 134", Contact = Contacts[1], RentedContainer = secondRentedList , ReturnedContainer = secondReturnedList},
                new Client { CVR = 12, Address = "guldsmedsvej 14", Contact = Contacts[2], RentedContainer = thirdRentedList, ReturnedContainer = thirdReturnedList}
            };


            //var containerAssignment = new ContainerAssignment[]
            //{
            //    new ContainerAssignment {ContainerID = Container.Single(c => c.CCTag == 1).CCTag, ClientID = Clients.Single(s => s.ClientID == 1).ClientID },
            //    new ContainerAssignment {ContainerID = Container.Single(c => c.CCTag == 2).CCTag, ClientID = Clients.Single(s => s.ClientID == 1).ClientID },
            //    new ContainerAssignment {ContainerID = Container.Single(c => c.CCTag == 3).CCTag, ClientID = Clients.Single(s => s.ClientID == 1).ClientID },
            //    new ContainerAssignment {ContainerID = Container.Single(c => c.CCTag == 4).CCTag, ClientID = Clients.Single(s => s.ClientID == 1).ClientID },

            //    new ContainerAssignment {ContainerID = Container.Single(c => c.CCTag == 5).CCTag, ClientID = Clients.Single(s => s.ClientID == 2).ClientID },
            //    new ContainerAssignment {ContainerID = Container.Single(c => c.CCTag == 6).CCTag, ClientID = Clients.Single(s => s.ClientID == 2).ClientID },
            //    new ContainerAssignment {ContainerID = Container.Single(c => c.CCTag == 7).CCTag, ClientID = Clients.Single(s => s.ClientID == 2).ClientID },
            //    new ContainerAssignment {ContainerID = Container.Single(c => c.CCTag == 8).CCTag, ClientID = Clients.Single(s => s.ClientID == 2).ClientID },
            //    new ContainerAssignment {ContainerID = Container.Single(c => c.CCTag == 9).CCTag, ClientID = Clients.Single(s => s.ClientID == 2).ClientID },

            //    new ContainerAssignment {ContainerID = Container.Single(c => c.CCTag == 10).CCTag, ClientID = Clients.Single(s => s.ClientID == 3).ClientID },
            //    new ContainerAssignment {ContainerID = Container.Single(c => c.CCTag == 11).CCTag, ClientID = Clients.Single(s => s.ClientID == 3).ClientID },
            //    new ContainerAssignment {ContainerID = Container.Single(c => c.CCTag == 12).CCTag, ClientID = Clients.Single(s => s.ClientID == 3).ClientID },
            //};

            context.AddRange(Contacts);
            context.AddRange(Warehouse);
            context.AddRange(Container);
            context.AddRange(Clients);
            //context.AddRange(containerAssignment);

            context.SaveChanges();
        }
    }
}
