﻿using MySportShope.API.Context;
using MySportShope.API.Models;

namespace MySportShope.API.Repositories
{
    public class PaymentRepository : RepositoryBase<Payment>, IPaymentRepository
    {
        public PaymentRepository(MainContext _context) : base(_context)
        {
        }
    }




}
