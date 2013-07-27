using System;
using System.Collections.Generic;

namespace TeenPatti.Server
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

        public string Language { get; set; }

        public Dictionary<string, string> Attributes { get;  set; }

        public long Bank { get; set; }

        public string this[string name]
        {
            get
            {
                if (this.Attributes == null)
                    return null;
                string match = null;
                if (this.Attributes.TryGetValue(name, out match) == true)
                    return match;
                else return null;
            }
            set
            {
                if (this.Attributes == null)
                    this.Attributes = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
                this.Attributes[name] = value;
            }
        }

        public static Player Create(Player player)
        {
            throw new NotImplementedException();
        }

        public static Player Get(long playerId)
        {
            throw new NotImplementedException();
        }

        public static Player Update(Player player, long playerId)
        {
            throw new NotImplementedException();
        }

        public static void Delete(long playerId)
        {
            throw new NotImplementedException();
        }

        public bool ValidateSession(string token)
        {
            throw new NotImplementedException();
        }

        public void InValidateSession(string token)
        {
            throw new NotImplementedException();
        }

        public string GetSecretQuestion(string playerId)
        {
            throw new NotImplementedException();
        }

        public string Authenticate(Credentials request)
        {
            throw new NotImplementedException();
        }
    }
}
