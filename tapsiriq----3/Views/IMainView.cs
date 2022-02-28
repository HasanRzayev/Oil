using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tapsiriq____3.Views
{
    public interface IMainView
    {

        EventHandler<EventArgs> BuyEventHandler { get; set; }
        EventHandler<EventArgs> radiobuttonlitrEventHandler { get; set; }
        EventHandler<EventArgs> radiobuttonmanatEventHandler { get; set; }



        string Benzinqiymeti { get; set; }

        string Litr { get; set; }

        string Manat { get; set; }

        string Sendvicqiymet { get; set; }

        string Hamburgerqiymet { get; set; }
        string Pizzaqiymet { get; set; }
        string Kokakolaqiymet { get; set; }
        string Fantaqiymet { get; set; }
        string Sendvicqiymetsay { get; set; }

        string Hamburgerqiymetsay { get; set; }
        string Pizzaqiymetsay { get; set; }
        string Kokakolaqiymetsay { get; set; }
        string Fantaqiymetsay { get; set; }
        string benzinumumiqiymet { get; set; }


        List<string> combo_benzinler1 { set; }


    }
}
