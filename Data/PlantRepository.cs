namespace Sunlight_nursery_store.Data
{
    public class PlantRepository:IPlantRepository
    {
        private readonly PlantDbContext _plantDbContext;
        public PlantRepository()
        {
            _plantDbContext = new PlantDbContext();
        }
        //instead of lines 11-16 do line 18
        public bool AddPlant(Plant plant)
        {
            var pl = false;
            
            _plantDbContext.Plants.Add(plant);
            return pl;
        }
 //public GetPlants (that will return a list of PlantViewModel)
 //Create view model that would be combination of the query 
        

    }
}
