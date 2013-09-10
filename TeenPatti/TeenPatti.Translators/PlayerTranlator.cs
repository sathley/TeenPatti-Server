using TeenPatti.Model;

namespace TeenPatti.Translators
{
    public static class PlayerTranlator
    {
        public static TeenPatti.Model.Player ToDomainModel(this TeenPatti.DataContracts.Player player)
        {
            return new Model.Player()
                {
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
                    Bank = player.Bank,
                    Attributes = player.Items,
                };
        }

        public static DataContracts.Player ToDataModel(this TeenPatti.Model.Player player)
        {
            return new DataContracts.Player()
            {
                Items = player.Attributes,
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
