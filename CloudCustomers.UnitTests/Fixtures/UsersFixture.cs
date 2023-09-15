using CloudCustomers.API.Models;

namespace CloudCustomers.UnitTests.Fixtures
{
    public static class UsersFixture
    {
        public static List<User> GetTestUsers() => new()
            {
                new User()
                {
                    Id = 1,
                    Name = "Guilherme",
                    Address = new()
                    {
                        City = "World",
                        Street = "Central",
                        ZipCode = "1020304050"
                    },
                    Email = "gui@gui.com.br"
                },
                new User()
                {
                    Id = 1,
                    Name = "Ferrari",
                    Address = new()
                    {
                        City = "World2",
                        Street = "Central2",
                        ZipCode = "1020304050-2"
                    },
                    Email = "gui2@gui.com.br"
                },
            };
    }
}
