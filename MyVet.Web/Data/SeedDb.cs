using MyVet.Web.Data.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Web.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="context"></param>
        public SeedDb(DataContext context)
        {
            _context = context;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckPetTypesAsync();
            await CheckServiceTypesAsync();
            await CheckOwnersAsync();
            await CheckPetsAsync();
            await CheckAgendasAsync();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private async Task CheckPetsAsync()
        {
            var owner = _context.Owners.FirstOrDefault();
            var petType = _context.PetTypes.FirstOrDefault();
            if (!_context.Pets.Any())
            {
                AddPet("Otto", owner, petType, "Shih tzu");
                AddPet("Killer", owner, petType, "Dobermann");
                await _context.SaveChangesAsync();
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private async Task CheckServiceTypesAsync()
        {
            if (!_context.ServiceTypes.Any())
            {
                _context.ServiceTypes.Add(new ServiceType { Name = "Consulta" });
                _context.ServiceTypes.Add(new ServiceType { Name = "Urgencia" });
                _context.ServiceTypes.Add(new ServiceType { Name = "Vacunación" });
                await _context.SaveChangesAsync();
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private async Task CheckPetTypesAsync()
        {
            if (!_context.PetTypes.Any())
            {
                _context.PetTypes.Add(new PetType { Name = "Perro" });
                _context.PetTypes.Add(new PetType { Name = "Gato" });
                await _context.SaveChangesAsync();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private async Task CheckOwnersAsync()
        {
            if (!_context.Owners.Any())
            {
                AddOwner("8989898", "Juan", "Guerrero", "234 3232", "310 322 3221", "Calle Luna Calle Sol");
                AddOwner("7655544", "Sebastian", "Cardona", "343 3226", "300 322 3221", "Calle 77 #22 21");
                AddOwner("6565555", "Irina", "Perdomo", "450 4332", "350 322 3221", "Carrera 56 #22 21");
                await _context.SaveChangesAsync();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="document"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="fixedPhone"></param>
        /// <param name="cellPhone"></param>
        /// <param name="address"></param>
        private void AddOwner(string document, string firstName, string lastName, string fixedPhone, string cellPhone, string address)
        {
            _context.Owners.Add(new Owner
            {
                Address = address,
                CellPhone = cellPhone,
                Document = document,
                FirstName = firstName,
                FixedPhone = fixedPhone,
                LastName = lastName
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="owner"></param>
        /// <param name="petType"></param>
        /// <param name="race"></param>
        private void AddPet(string name, Owner owner, PetType petType, string race)
        {
            _context.Pets.Add(new Pet
            {
                Born = DateTime.Now.AddYears(-2),
                Name = name,
                Owner = owner,
                PetType = petType,
                Race = race
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private async Task CheckAgendasAsync()
        {
            if (!_context.Agendas.Any())
            {
                var initialDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 0, 0);
                var finalDate = initialDate.AddYears(1);
                while (initialDate < finalDate)
                {
                    if (initialDate.DayOfWeek != DayOfWeek.Sunday)
                    {
                        var finalDate2 = initialDate.AddHours(10);
                        while (initialDate < finalDate2)
                        {
                            _context.Agendas.Add(new Agenda
                            {
                                //------------------
                                //-- grabar la hora universal _ meridiano cero  hora de londres
                                //------------------
                                Date = initialDate.ToUniversalTime(),
                                IsAvailable = true
                            });

                            initialDate = initialDate.AddMinutes(30);
                        }

                        initialDate = initialDate.AddHours(14);
                    }
                    else
                    {
                        initialDate = initialDate.AddDays(1);
                    }
                }

                await _context.SaveChangesAsync();
            }
        }
    }
}
