
using CloudCustomers.API.Models;

namespace CloundCustomers.UnitTests.Fixtures
{
    public static class UsersFixture
    {
        public static List<User> GetTestUsers() =>
            new List<User>()
            {
                new User(){
                    Name = "Test",
                    Email = "Test@gmil.com",
                    Address = new Address(){
                        Street = "123 Market St",
                        City = "Somewhere",
                        ZipCode = "40002"
                    },
                },
                new User(){
                    Name = "Test2",
                    Email = "Test2@gmil.com",
                    Address = new Address(){
                        Street = "126 Market St",
                        City = "Somewhere2",
                        ZipCode = "40002"
                    },
                },
                new User(){
                    Name = "Test3",
                    Email = "Test3@gmil.com",
                    Address = new Address(){
                        Street = "226 Market St",
                        City = "Somewhere3",
                        ZipCode = "40002"
                    },
                },

            };
    }
}
