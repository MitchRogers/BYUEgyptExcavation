using Microsoft.EntityFrameworkCore;


namespace BYUEgyptExcavation.Models
{
    public class RDSContext : DbContext
    {
        public RDSContext()
        {
        }

        public static RDSContext Create()
        {
            return new RDSContext();
        }

       
    }


}
