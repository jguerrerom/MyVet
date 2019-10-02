// =====================================================================================
// Desarrollado Por		    : Juan Carlos Guerrero Maldonado.
// Fecha de Creación		: 02 Octubre 2019
// Lenguaje Programación	: C#
// Producto o sistema	    : MyVet.Web.Helpers.UserHelper.cs
// =====================================================================================
// Versión	 Descripción
// [1.0.0.0] Clase helpers que implemente IUserHelper
// =====================================================================================
// MODIFICACIONES:
// =====================================================================================
// Ver.	Fecha		    Autor – Empresa                     Descripción
// ---	-------------	---------------------------------   ----------------------------
// =====================================================================================
using Microsoft.AspNetCore.Identity;
using MyVet.Web.Data.Entities;
using System.Threading.Tasks;

namespace MyVet.Web.Helpers
{
    public class UserHelper : IUserHelper
    {
        /// <summary>
        /// El RolManager utiliza la entidad User (especifica de nyestra aplicación)
        /// </summary>
        private readonly UserManager<User> _userManager;

        /// <summary>
        /// El RolManager utiliza la entidad IdentityRole (propia de .net)
        /// /// </summary>
        private readonly RoleManager<IdentityRole> _roleManager;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="userManager"></param>
        /// <param name="roleManager"></param>
        public UserHelper(
            UserManager<User> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        /// <summary>
        /// Agrega un usuario nuevo
        /// </summary>
        /// <param name="user">Usuario</param>
        /// <param name="password">Contraseña</param>
        /// <returns></returns>
        public async Task<IdentityResult> AddUserAsync(User user, string password)
        {
            return await _userManager.CreateAsync(user, password);
        }

        /// <summary>
        /// Agrega un usuario a un rol
        /// </summary>
        /// <param name="user">Usuario</param>
        /// <param name="roleName">Roal al cual agregar el usuario</param>
        /// <returns></returns>
        public async Task AddUserToRoleAsync(User user, string roleName)
        {
            await _userManager.AddToRoleAsync(user, roleName);
        }

        /// <summary>
        /// Verifica si existe rol, si no existe: lo crea.
        /// </summary>
        /// <param name="roleName"></param>
        /// <returns></returns>
        public async Task CheckRoleAsync(string roleName)
        {
            var roleExists = await _roleManager.RoleExistsAsync(roleName);
            if (!roleExists)
            {
                await _roleManager.CreateAsync(new IdentityRole
                {
                    Name = roleName
                });
            }
        }

        /// <summary>
        /// Recupera un usuario mediante el email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public async Task<User> GetUserByEmailAsync(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            return user;
        }

        /// <summary>
        /// Verifica si un usuario esta atado a un rol especifico
        /// </summary>
        /// <param name="user"></param>
        /// <param name="roleName"></param>
        /// <returns></returns>
        public async Task<bool> IsUserInRoleAsync(User user, string roleName)
        {
            return await _userManager.IsInRoleAsync(user, roleName);
        }
    }
}
