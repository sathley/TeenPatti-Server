using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Appacitive.Sdk;
using TeenPatti.Model;

namespace TeenPatti.DataAccess
{
    public class PlayerStorage : IPlayerStorage
    {
        public async Task<Player> Create(Player player)
        {
            var user = new User()
                {
                    Username = player.Username,
                    DateOfBirth = player.DateOfBirth,
                    Email = player.EmailAddress,
                    FirstName = player.FirstName,
                    LastName = player.Language,
                    Phone = player.Phone,
                    Password = player.Password,
                    
                };
            user["bank"] = player.Bank;
            user["language"] = player.Language;
            await user.SaveAsync();
            return player;
        }

        public async Task<Player> Get(long playerId)
        {
            var user = await Users.GetByIdAsync(playerId.ToString());
            var player = new Player()
                {
                    Bank = user["bank"],
                    DateOfBirth = user.DateOfBirth ?? DateTime.Now,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Username = user.Username,
                    Password = user.Password,
                    Phone = user.Phone,
                    EmailAddress = user.Email,
                    Id = long.Parse(user.Id),
                    IsEnabled = user["isenabled"],
                    Language = user["language"],
                    UtcJoiningDate = user.UtcCreateDate
                };
            return player;
        }

        public async Task<Player> Update(Player player, long playerId)
        {
            throw new NotImplementedException();
        }

        public void Delete(long playerId)
        {
            Users.DeleteUserAsync(playerId.ToString(CultureInfo.InvariantCulture));
        }
    }
}
