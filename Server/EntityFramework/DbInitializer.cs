using DOBlazorApp.Shared;
using Tynamix.ObjectFiller;

namespace DOBlazorApp.Server.EntityFramework
{
    public static class DbInitializer
    {
        public static void Initialize(BlazorAppContext context)
        {
            context.Database.EnsureCreated();

            InitializeCompanies(context);
            InitializePeople(context);
        }

        private static void InitializeCompanies(BlazorAppContext context)
        {
            if (context.Companies.Any())
            {
                return;
            }

            var randomName = new MnemonicString();

            var companies = Enumerable.Range(0, 100).Select(i =>
                new Company
                {
                    CompanyName = randomName.GetValue(),
                    PhoneNumber = GetRandomPhoneNumber()
                });

            context.Companies.AddRange(companies);

            context.SaveChanges();
        }

        private static void InitializePeople(BlazorAppContext context)
        {
            if (context.People.Any())
            {
                return;
            }

            var randomFirstName = new RealNames(NameStyle.FirstName);
            var randomLastName = new RealNames(NameStyle.LastName);

            var people = Enumerable.Range(0, 100).Select(i =>
                new Person
                {
                    FirstName = randomFirstName.GetValue(),
                    LastName = randomLastName.GetValue(),
                    PhoneNumber = GetRandomPhoneNumber()
                });

            context.People.AddRange(people);

            context.SaveChanges();
        }

        private static string GetRandomPhoneNumber()
            => $"+{string.Join("", Enumerable.Range(0, 9).Select(i => Random.Shared.Next(0, 10)))}";
    }
}
