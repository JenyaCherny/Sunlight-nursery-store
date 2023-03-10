namespace Sunlight_nursery_store.Data
{
    public class Plant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int SupplierId { get; set; }
        public DateTime DateDelivered { get; set; }
        public int Quantity { get; set; }
    }
}
