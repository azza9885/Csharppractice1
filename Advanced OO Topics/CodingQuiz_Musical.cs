using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_OO_Topics
{
    public class CodingQuiz_Musical : CodingQuiz_Ticket
    {
        private string _bandName;
        private int _numberofSongs;

        public CodingQuiz_Musical(string ticketNum, decimal ticketPrice, string seatNum, string duration,
            string BandName,int numofSongs):base(ticketNum, ticketPrice, seatNum, duration)
        {
            _BandName = BandName;
            _NumberofSongs = numofSongs;
        }

        public override string GetEvent_Details()
        {
            return "Ticket Number: " + _ticketNumber + "\n" +
                    "Ticket Price: " + _ticketPrice.ToString("C") + "\n" +
                    "Seat Number: " + _seatNumber + "\n" +
                    "Event Duration(in Approx HRs): " + _eventDuration + "\n" +
                    "Band Name: " + _BandName + "\n" +
                    "Total number of Songs being Performed: " + _NumberofSongs;
        }
        public string _BandName
        {
            get {return _bandName; }

            set {_bandName=value; }

        }

        public int _NumberofSongs
        {
            get { return _numberofSongs; }

            set { _numberofSongs = value; }

        }
    }
}
