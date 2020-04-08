using BlabberApp.Domain;

namespace BlabberApp.DataStore
{
    public interface IUserPlugin : IPlugin
    {
        IDatum ReadByEmail(string email);
    }
}