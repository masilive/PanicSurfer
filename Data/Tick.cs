using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanicSurfer.Data
{
    public struct Tick
    {
        public DateTime Timestamp { get; set; }
        public float Bid { get; set; }
        public bool IsVerified { get; set; } = true;
        public Tick(string[] data)
        {
            Timestamp = Convert.ToDateTime(data[0]);
            Bid = Convert.ToSingle(data[1]);
        }
        public Tick(DateTime timestamp)
        {
            Timestamp = timestamp;
            Bid = 0f;
            IsVerified = false;
        }
    }
}
