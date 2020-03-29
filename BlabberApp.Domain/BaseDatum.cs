using System;
//using BlabberApp.Domain.IDatum;

namespace BlabberApp.Domain
{
    public class BaseDatum : IDatum 
    {
        public DateTime CreatedDTTM{get; set;}
        public DateTime ModifiedDTTM{get; set;}
        private string _sysId;
        public BaseDatum()
        {
            this._sysId = Guid.NewGuid().ToString();
            CreatedDTTM = DateTime.Now;
            ModifiedDTTM = DateTime.Now;
        }
        public string getSysId()
        {
            return this._sysId;
        }

        public bool Equals(string otherID)
        {
            return _sysId.Equals(otherID);
        }
    }    
}