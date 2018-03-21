using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.Linq;

namespace HumaneSociety
{
    public static class Query
    {
        internal static void RunEmployeeQueries(Employee employee, string condition)
        {
            HumaneSocietyDataContext context = new HumaneSocietyDataContext();
            var employeeResult = (from x in context.Employees where x.employeeNumber == employee.employeeNumber select x).FirstOrDefault();
            if(condition == "update" || condition == "create")
            {
                employeeResult = employee;
                context.Employees.InsertOnSubmit(employeeResult);
            }
            else if(condition == "delete")
            {
                context.Employees.DeleteOnSubmit(employeeResult);
            }
            else if (condition == "read")
            {
                employeeResult.ToString();
            }
            context.SubmitChanges();
        }

        internal static Client GetClient(string userName, string password)
        {
            HumaneSocietyDataContext context = new HumaneSocietyDataContext();
            var client = (from x in context.Clients where x.userName == userName && x.pass == password select x).First();
            return client;
        }

        internal static  EntitySet<ClientAnimalJunction> GetUserAdoptionStatuses(Client client)
        {
            return client.ClientAnimalJunctions;
        }

        internal static Animal GetAnimalByID(int iD)
        {
            HumaneSocietyDataContext context = new HumaneSocietyDataContext();
            var animal = (from a in context.Animals where a.ID == iD select a).First();
            return animal;
        }

        internal static void Adopt(Animal animal, Client client)
        {
            throw new NotImplementedException();
        }

        internal static List<Client> RetrieveClients()
        {
            HumaneSocietyDataContext context = new HumaneSocietyDataContext();
            var resultList = (from c in context.Clients where c != null select c).ToList();
            return resultList;
        }

        internal static List<USState> GetStates()
        {
            HumaneSocietyDataContext context = new HumaneSocietyDataContext();
            var resultList = (from c in context.USStates where c != null select c).ToList();
            return resultList;
        }

        internal static void AddNewClient(string firstName, string lastName, string username, string password, string email, string streetAddress, int zipCode, int state)
        {
            throw new NotImplementedException();
        }

        internal static void updateClient(Client client)
        {
            throw new NotImplementedException();
        }

        internal static void UpdateUsername(Client client)
        {
            HumaneSocietyDataContext context = new HumaneSocietyDataContext();
            var updatedUserName = (from uSN in context.Clients where uSN.userName == client.userName select uSN).First();
            if (updatedUserName != null)
            {
                context.Clients.InsertOnSubmit(updatedUserName);
            }
            context.SubmitChanges();
        }

        internal static void UpdateEmail(Client client)
        {
            HumaneSocietyDataContext context = new HumaneSocietyDataContext();
            var updatedEmail = (from uE in context.Clients where uE.email == client.email select uE).First();
            if (updatedEmail != null)
            {
                context.Clients.InsertOnSubmit(updatedEmail);
            }
            context.SubmitChanges();
        }

        internal static void UpdateAddress(Client client)
        {
            HumaneSocietyDataContext context = new HumaneSocietyDataContext();
            var updatedAddress = (from uA in context.Clients where uA.userAddress == client.userAddress select uA).First();
            if (updatedAddress != null)
            {
                context.Clients.InsertOnSubmit(updatedAddress);
            }
            context.SubmitChanges();
        }

        internal static void UpdateFirstName(Client client)
        {
            HumaneSocietyDataContext context = new HumaneSocietyDataContext();
            var updatedFirstName = (from uFN in context.Clients where uFN.firstName == client.firstName select uFN).First();
            if (updatedFirstName != null)
            {
                context.Clients.InsertOnSubmit(updatedFirstName);
            }
            context.SubmitChanges();
        }

        internal static Table<ClientAnimalJunction> GetPendingAdoptions()
        {
            HumaneSocietyDataContext context = new HumaneSocietyDataContext();
            return context.ClientAnimalJunctions;
        }

        internal static void UpdateLastName(Client client)
        {
            HumaneSocietyDataContext context = new HumaneSocietyDataContext();
            var updatedLastName = (from uLN in context.Clients where uLN.lastName == client.lastName select uLN).First();
            if (updatedLastName != null)
            {
                context.Clients.InsertOnSubmit(updatedLastName);
            }
            context.SubmitChanges();
        }

        internal static void UpdateAdoption(bool v, ClientAnimalJunction clientAnimalJunction)
        {
            throw new NotImplementedException();
        }

        internal static EntitySet<AnimalShotJunction> GetShots(Animal animal)
        {
            return animal.AnimalShotJunctions; 
        }

        internal static void UpdateShot(string v, Animal animal)
        {
            throw new NotImplementedException();
        }

        internal static void EnterUpdate(Animal animal, Dictionary<int, string> updates)
        {
            throw new NotImplementedException();
        }

        internal static Animal RemoveAnimal(Animal animal)
        {
            throw new NotImplementedException();
        }

        internal static int? GetBreed()
        {
            throw new NotImplementedException();
        }

        internal static int? GetDiet()
        {
            throw new NotImplementedException();
        }

        internal static int? GetLocation()
        {
            throw new NotImplementedException();
        }

        internal static void AddAnimal(Animal animal)
        {
            throw new NotImplementedException();
        }

        internal static Employee EmployeeLogin(string userName, string password)
        {
            throw new NotImplementedException();
        }

        internal static Employee RetrieveEmployeeUser(string email, int employeeNumber)
        {
            throw new NotImplementedException();
        }

        internal static void AddUsernameAndPassword(Employee employee)
        {
            throw new NotImplementedException();
        }

        internal static bool CheckEmployeeUserNameExist(string username)
        {
            throw new NotImplementedException();
        }
    }
}
