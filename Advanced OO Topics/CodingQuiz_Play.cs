using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_OO_Topics
{
    public class CodingQuiz_Play : CodingQuiz_Ticket
    {
        private string playName;
        private string actor_GroupName;

        public CodingQuiz_Play(string ticketNum, decimal ticketPrice, string seatNum, string duration,string nameOfPlay,
            string ActorgrpName):base(ticketNum,ticketPrice,seatNum,duration)
        {
            PlayName = nameOfPlay;
            Actor_GrpName = ActorgrpName;
        }

        public override string GetEvent_Details()
        {
            return "Ticket Number: " + _ticketNumber + "\n" +
                    "Ticket Price: " + _ticketPrice.ToString("C") + "\n" +
                    "Seat Number: " + _seatNumber + "\n" +
                    "Event Duration(in Approx HRs): " + _eventDuration + "\n" +
                    "Play Name: " + PlayName + "\n" +
                    "Actor Group Performing the Play: " + Actor_GrpName;
        }
        public string PlayName 
        {   get 
            {
                return playName;
            } 
            set 
            {
                playName=value; 
            } 
        }

        public string Actor_GrpName
        {
            get
            {
                return actor_GroupName;
            }
            set
            {
                actor_GroupName = value;
            }
        }
    }
}
