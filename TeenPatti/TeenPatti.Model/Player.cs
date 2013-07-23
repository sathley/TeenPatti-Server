using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeenPatti.Model
{
    public class Player
    {
        public Player()
        {
            this.Attributes = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        }

        public long Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public string Username { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Password { get; set; }

        public string EmailAddress { get; set; }

        public string SecretQuestion { get; set; }

        public string SecretAnswer { get; set; }

        public string SecretAnswerHash { get; set; }

        public DateTime UtcJoiningDate { get; set; }

        public bool IsEnabled { get; set; }

        public Dictionary<string, string> Attributes { get; private set; }

        public long Bank { get; set; }
    }
}
