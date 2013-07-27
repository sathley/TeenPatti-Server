namespace TeenPatti.Server
{
    public static class PlayerTranlator
    {
        public static Player ToDomainModel(this DataContracts.Player player)
        {
            return new Player()
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

        public static DataContracts.Player ToDataModel(this Player player)
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
