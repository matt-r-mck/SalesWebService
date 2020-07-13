using System.Text.Json.Serialization;

namespace SalesWebService.Models {
    public class OrderLine {

        public OrderLine() {

        }

        public int Id { get; set; }

        public int Quantity { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        [JsonIgnore]
        public virtual Order Order { get; set; }

        public int OrderId { get; set; }
    }
}