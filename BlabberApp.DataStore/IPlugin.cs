using System;
using System.Collections;
using BlabberApp.Domain;

namespace BlabberApp.DataStore
{
    public interface IPlugin
    {
        void Create(IDatum obj);
        IEnumerable ReadAll();
        IDatum ReadById(Guid Id);
        void Update(IDatum obj);
        void Delete(IDatum obj);
    }
}