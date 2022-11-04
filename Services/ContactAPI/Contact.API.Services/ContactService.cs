﻿using Contact.API.Infrastructure;
using Contact.API.Models;

namespace Contact.API.Services
{
    public class ContactService : IContactService
    {
        public ContactDTO GetContactById(int id)
        {
            return new()
            {
                Id = id,
                FirstName = "Erkan",
                LastName = "KILIÇ"
            };
        }
    }
}
