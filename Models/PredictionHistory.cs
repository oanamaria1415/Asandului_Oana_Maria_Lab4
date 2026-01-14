using System;

namespace Asandului_Oana_Maria_Lab4.Models
{
    public class PredictionHistory
    {
        public int Id { get; set; }

        public float UserId { get; set; }
        public float MovieId { get; set; }

        public float Score { get; set; }
        public bool Recommended { get; set; }

        public string? Message { get; set; } 
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public string PaymentType { get; set; } = "";
        public float PredictedPrice { get; set; }

    }
}
