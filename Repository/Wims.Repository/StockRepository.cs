﻿namespace iQuest.Fedex2018.Wims.Repository
{
    public class StockRepository : WimsRepository<Product>
    {
        public StockRepository(string EndpointUrl, string PrimaryKey, string DatabaseName) :
            base(EndpointUrl, PrimaryKey, DatabaseName)
        {
        }
        protected override string CollectionName => "Stock";
    }
}
