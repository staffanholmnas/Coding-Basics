namespace Exercise
{
    public class ProductWarehouseWithHistory : ProductWarehouse
    {
        public ChangeHistory listOfChanges;
        public int initialBalance;
        public ProductWarehouseWithHistory(string productName, int capacity, int initialBalance) : base(productName, capacity)
        {
            this.initialBalance = initialBalance;
            this.listOfChanges = new ChangeHistory();
            AddToWarehouse(initialBalance);
        }

        public string History()
        {
            return this.listOfChanges.ToString();
        }

        new public void AddToWarehouse(int amount)
        {
          base.AddToWarehouse(amount);
          this.listOfChanges.Add(this.balance);
        }
        
        new public int TakeFromWarehouse(int amount)
        {
          base.TakeFromWarehouse(amount);
          this.listOfChanges.Add(this.balance);
          return amount;
        }
    }
}