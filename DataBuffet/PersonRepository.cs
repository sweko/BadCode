using System.Collections.Generic;

namespace DataBuffet
{
    internal class PersonRepository
    {
        public static Person LoadPerson()
        {
            return new Person
            {
                FirstName = "Wekoslav",
                LastName = "Stefanovski",
                Address = new Address
                {
                    City = new City
                    {
                        Name = "Skopje",
                        Country = new Country
                        {
                            Name = "Macedonia",
                            Cities = new List<City>
                            {
                                new City
                                {
                                    Name = "Bitola",
                                    Country = 
                                }
                            }
                        }
                    }
                }

            };
        }
    }
}