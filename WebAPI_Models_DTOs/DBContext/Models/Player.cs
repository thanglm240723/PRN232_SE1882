namespace WebAPI_Models_DTOs.DBContext.Models
{
    public class Player
    {

        public int Id { get; set; }

        public string Name { get; set; }    

        public DateTime JoinedDate { get; set; }

        public List<PlayerInstrument> PlayerInstruments { get; set; }



    }
}
