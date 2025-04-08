using System;

namespace HorizonTracker.Models
{
    public class TransactionLog
    {
        public int Id { get; set; }
        public string Action { get; set; }
        public string UserName { get; set; }
        public DateTime Timestamp { get; set; }
    }
}