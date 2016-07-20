using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacationBalance.Models
{

    /// <summary>
    /// User Balance info
    /// </summary>
    [Serializable]
    public class UserData
    {
        /// <summary>
        /// Represents the User Id
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// Represents the StartDate
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Represents the StartBalance
        /// </summary>
        public decimal StartBalance { get; set; }

        /// <summary>
        /// Represents the vacations
        /// </summary>
        public List<Vacation> Vacations { get; set; }

    }
}
