﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroServicios.Modelo.DTO
{
    class DTOAdminUsers : dbContext
    {
        // **** PERSONAS ****
        private int personId;
        private string firstName;
        private string lastName;
        private DateTime birthday;
        private string dni;
        private string personAddress;
        private string personEmail;
        private string personPhone;
        // **** USUARIO ****
        private string user;
        private string password;
        private bool userStatus;
        private int userAttempts;
        private int role;

        public int PersonId { get => personId; set => personId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public string Dni { get => dni; set => dni = value; }
        public string PersonAddress { get => personAddress; set => personAddress = value; }
        public string PersonEmail { get => personEmail; set => personEmail = value; }
        public string PersonPhone { get => personPhone; set => personPhone = value; }
        public string User { get => user; set => user = value; }
        public string Password { get => password; set => password = value; }
        public bool UserStatus { get => userStatus; set => userStatus = value; }
        public int UserAttempts { get => userAttempts; set => userAttempts = value; }
        public int Role { get => role; set => role = value; }
    }
}
