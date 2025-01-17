﻿using Core.Entities;

namespace Entities.DTOs
{
    public class UserForUpdateDto : IDto
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } //Kullanıcıdan string alıp kendimiz hashliyoruz
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

}