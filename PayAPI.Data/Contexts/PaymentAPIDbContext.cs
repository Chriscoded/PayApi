using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PayAPI.Core.Payment;
using System;
using System.Collections.Generic;
using System.Text;

namespace PayAPI.Data.Contexts
{
    public class PaymentAPIDbContext :IdentityDbContext
    {
        public PaymentAPIDbContext(DbContextOptions<PaymentAPIDbContext> options)
          : base(options)
        {
        }
        public DbSet<PaymentCardModel> PaymentCardModels { get; set; }
    }
}
