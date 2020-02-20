using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_OO_Topics
{
    public class CodingQuiz_Lecture:CodingQuiz_Ticket
    {
        private string _lectureTopic;
        private string _speakerName;

        public CodingQuiz_Lecture(string ticketNum, decimal ticketPrice, string seatNum, string duration,
            string Topic,string Speaker):base(ticketNum, ticketPrice, seatNum, duration)
        {
            Lecture_Topic = Topic;
            Speaker_Name = Speaker;
        }

        public override string GetEvent_Details()
        {
            return "Ticket Number: " + _ticketNumber + "\n" +
                    "Ticket Price: " + _ticketPrice.ToString("C") + "\n" +
                    "Seat Number: " + _seatNumber + "\n" +
                    "Event Duration(in Approx HRs): " + _eventDuration + "\n" +
                    "Lecture Topic: " + Lecture_Topic + "\n" +
                    "Speaker Name: " + Speaker_Name;
        }
        public string Lecture_Topic
        {
            get

            {
                return _lectureTopic;
            }

            set
            {
                _lectureTopic = value;
            }
        }

        public string Speaker_Name
        {
            get

            {
                return _speakerName;
            }

            set
            {
                _speakerName = value;
            }
        }

    }

   
}
