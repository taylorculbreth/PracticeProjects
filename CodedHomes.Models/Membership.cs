﻿using System;


namespace CodedHomes.Models
{
    public class Membership
    {
        public int UserId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string  ConfirmationToken { get; set; }
        public bool? IsConfirmed { get; set; }
        public DateTime? LastPasswordFailureDate { get; set; }
        public int PasswordFailuesSinceLastSuccess { get; set; }
        public string Password { get; set; }
        public DateTime? PasswordChangedDate { get; set; }
        public string PasswordSalt { get; set; }
        public string PasswordVerificationToken { get; set; }
        public DateTime? PasswordVerificationTokenExpireationDate { get; set; }
    }
}
