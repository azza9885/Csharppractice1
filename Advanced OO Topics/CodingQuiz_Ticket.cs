using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_OO_Topics
{
    public abstract class CodingQuiz_Ticket
    {
        protected string _ticketNumber;
        protected decimal _ticketPrice;
        protected string _seatNumber;
        protected string _eventDuration;

        public CodingQuiz_Ticket()
        {

        }

        public CodingQuiz_Ticket(string ticketNum,decimal ticketPrice,string seatNum,string duration)
        {
            _ticketNumber = ticketNum;
            _ticketPrice = ticketPrice;
            _seatNumber = seatNum;
            _eventDuration = duration;
        }

        public abstract string GetEvent_Details();
        
    }
}
