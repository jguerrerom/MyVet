// =====================================================================================
// Desarrollado Por		    : Juan Carlos Guerrero Maldonado.
// Fecha de Creación		: 02 Octubre 2019
// Lenguaje Programación	: C#
// Producto o sistema	    : MyVet.Web.Helpers.IUserHelper.cs
// =====================================================================================
// Versión	 Descripción
// [1.0.0.0] Interface helpers
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
    public interface IUserHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        Task<User> GetUserByEmailAsync(string email);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Task<IdentityResult> AddUserAsync(User user, string password);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="roleName"></param>
        /// <returns></returns>
        Task CheckRoleAsync(string roleName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <param name="roleName"></param>
        /// <returns></returns>
        Task AddUserToRoleAsync(User user, string roleName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <param name="roleName"></param>
        /// <returns></returns>
        Task<bool> IsUserInRoleAsync(User user, string roleName);
    }
}


