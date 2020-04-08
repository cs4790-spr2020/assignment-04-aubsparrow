using System;
using System.Collections;
using BlabberApp.Domain;

namespace BlabberApp.DataStore
{
    public class UserAdapter
    {
        private readonly IPlugin UserPlugin;

        public UserAdapter(IPlugin plugin)
        {
            UserPlugin = plugin;
        }

        public void Add (User user)
        {
            UserPlugin.Create(user);
        }

        public IEnumerable GetAll()
        {
            return UserPlugin.ReadAll();
        }

        

    }


}