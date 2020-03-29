using System;

namespace BlabberApp.Domain
{
    public class Blab : BaseDatum
    {
       public DateTime DTTM {get; set;}
       public string Message{get; set;}
       public string UserID{get; set;}

       public Blab()
       {
           DTTM = DateTime.Now;
       }

    }
}