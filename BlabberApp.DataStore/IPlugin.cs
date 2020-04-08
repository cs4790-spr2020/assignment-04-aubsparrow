using System;
using System.Collections;
using BlabberApp.Domain;

namespace BlabberApp.DataStore
{
    public interface IPlugin
    {
        void Create(IDatum obj);
        IEnumerable ReadAll();
    }
}