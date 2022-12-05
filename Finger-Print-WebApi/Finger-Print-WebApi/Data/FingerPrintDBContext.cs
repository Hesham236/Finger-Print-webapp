using Microsoft.EntityFrameworkCore;


namespace Finger_Print_WebApi.Data
{
    public class FingerPrintDBContext : DbContext
    {
        public FingerPrintDBContext(DbContextOptions<FingerPrintDBContext> options) : base(options)
        {

        }


    }
}
