using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using BYUEgyptExcavation.Models;
using Microsoft.EntityFrameworkCore;
using System;

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
