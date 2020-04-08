using System;
using System.Collections;
using BlabberApp.Domain;

namespace BlabberApp.DataStore
{
    public class UserAdapter
    {
        private readonly IUserPlugin UserPlugin;

        public UserAdapter(IUserPlugin plugin)
        {
            UserPlugin = plugin;
        }

        public void Add (User user)
        {
            UserPlugin.Create(user);
        }

        public void Remove(User user)
        {
            UserPlugin.Delete(user);
        }

        public void Update(User user)
        {
            UserPlugin.Update(user);
        }

        public IEnumerable GetAll()
        {
            return UserPlugin.ReadAll();
        }

        public User GetByEmail(string email)
        {
            return (User)UserPlugin.ReadByEmail(email);
        }

    }


}