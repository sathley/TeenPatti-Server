using System.Text;
using System.Threading.Tasks;

namespace TeenPatti.Model
{
    public class Card
    {
        public Card(int value, Suite suite)
        {
            this.Suite = suite;
            this.Value = value;
        }

        public Suite Suite { get; private set; }

        public int Value { get; private set; }

        public void SetSuite(Suite suite)
        {
            this.Suite = suite;
        }

        public void SetValue(int value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            string val = string.Empty;
            switch (Value)
            {
                case 1:
                    val = "Ace";
                    break;
                case 2:
                    val = "Two";
                    break;
                case 3:
                    val = "Three";
                    break;
                case 4:
                    val = "Four";
                    break;
                case 5:
                    val = "Five";
                    break;
                case 6:
                    val = "Six";
                    break;
                case 7:
                    val = "Seven";
                    break;
                case 8:
                    val = "Eight";
                    break;
                case 9:
                    val = "Nine";
                    break;
                case 10:
                    val = "Ten";
                    break;
                case 11:
                    val = "Jack";
                    break;
                case 12:
                    val = "Queen";
                    break;
                case 13:
                    val = "King";
                    break;
                default:
                    break;
            }
            return string.Format("{0} of {1}", val, Suite);
        }
    }
}
