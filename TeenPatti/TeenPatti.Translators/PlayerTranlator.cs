using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeenPatti.DataContracts;

using TeenPatti.Model;

namespace TeenPatti.Translators
{
    public class PlayerTranlator
    {
        public DataContracts.Player ToDomainModel(Model.Player player)
        {
            return new DataContracts.Player()
                {
                    Items=player.Attributes,
                    DateOfBirth = player.DateOfBirth,
                    EmailAddress = player.EmailAddress,
                    FirstName = player.FirstName,
                    IsEnabled = player.IsEnabled,
                    Id = player.Id,
                    LastName = player.LastName,
                    Password = player.Password,
                    Phone = player.Phone,
                    SecretAnswer = player.SecretAnswer,
                    SecretAnswerHash = player.SecretAnswerHash,
                    SecretQuestion = player.SecretQuestion,
                    Username = player.Username,
                    UtcJoiningDate = player.UtcJoiningDate,
                    Bank = player.Bank
                };
        }

        public Model.Player ToDataModel(DataContracts.Player player)
        {
            return new Model.Player()
            {
                Attributes = player.Items,
                DateOfBirth = player.DateOfBirth,
                EmailAddress = player.EmailAddress,
                FirstName = player.FirstName,
                IsEnabled = player.IsEnabled,
                Id = player.Id,
                LastName = player.LastName,
                Password = player.Password,
                Phone = player.Phone,
                SecretAnswer = player.SecretAnswer,
                SecretAnswerHash = player.SecretAnswerHash,
                SecretQuestion = player.SecretQuestion,
                Username = player.Username,
                UtcJoiningDate = player.UtcJoiningDate,
                Bank = player.Bank
            };
        }
    }
}
