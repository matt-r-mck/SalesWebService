using Castle.MicroKernel.SubSystems.Conversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebService.Models {
    public class Order {

        public Order() {

        }

        public int Id { get; set; }
        [StringLength(30)]
        [Required]
        public string Description { get; set; }
        [Column(TypeName = "decimal (12,2)")]
        public decimal Total { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public virtual IEnumerable<OrderLine> OrderLines { get; set; }

    }
}
