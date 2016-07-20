using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacationBalance.Models
{
    /// <summary>
    /// Vacation meta data
    /// </summary>
    [Serializable]
    public class Vacation
    {

        /// <summary>
        /// Represents the StartDate
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Represents the EndDate
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Represents the Days
        /// </summary>
        public decimal Days { get; set; }

    }
}
