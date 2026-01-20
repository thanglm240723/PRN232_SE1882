namespace WebAPI_Models_DTOs.DBContext.Models
{
    public class PlayerInstrument
    {

        public int Id { get; set; }
        public int PlayerId { get; set; }
        public Player Player { get; set; }

        public string ModelName { get; set; }
        public string Level { get; set; }
   
    }
}
