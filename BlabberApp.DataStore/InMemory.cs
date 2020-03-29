using System;
using System.Collections;
using BlabberApp.Domain;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BlabberApp.DataStore
{
    public class InMemory<T> : IRepository<T> where T : BaseDatum
    {

        //private List<BaseDatum> _items;
        private ApplicationContext context;

        //replaces List, to use entity framework
        private DbSet<T> _entities;
        public DbSet<T> Entities
        {
            get
            {
                return this._entities;
            }
        }

        public InMemory(ApplicationContext ContextIn)
        {
            //this._items = new List<BaseDatum>();
            context = ContextIn;
            this._entities = context.Set<T>();
        }

        public T Add(T item)
        {
            this._entities.Add(item);
            return item;
        }

        public void Delete(T item)
        {
            this._entities.Remove(item);
            return;
        }

        public T GetByID(string sysId)
        {
            if(sysId == "")
            {
                throw new ArgumentNullException("sysId null");    
            }
            return this._entities.SingleOrDefault(s => s.getSysId() == sysId);
        }

        public T GetByUserID(string userId)
        {
            if(userId == "")
            {
                throw new ArgumentNullException("user id null");
            }
            return this._entities.Find(userId);
        }

        public IEnumerable<T> GetAll()
        {
            return this._entities.AsEnumerable();
        }

        public void Update (T item)
        {
            if(item == null)
            {
                throw new ArgumentNullException("item to update null");
            }
            context.SaveChanges();
        }

        // public bool Create(IDatum datum)
        // {
        //     int idx = this._items.Add(datum);
        //     if(idx < 0)
        //     {
        //         throw new ArgumentOutOfRangeException("OH HELL NO");
        //     }
        //     return true;
        // }

        // public IDatum Read(int index)
        // {
        //     return (IDatum)this._items[index];
        // }

        // public bool Update(IDatum datum)
        // {
        //     return true;
        // }

        // public bool Delete(int index)
        // {
        //     try
        //     {
        //         this._items.RemoveAt(index);
        //     }
        //     catch(ArgumentOutOfRangeException ex){
        //         throw ex;
        //     }
        //     return true;
        // }
    }
}
