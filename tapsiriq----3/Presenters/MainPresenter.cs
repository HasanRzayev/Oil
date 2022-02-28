using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using tapsiriq____3.Views;

namespace tapsiriq____3.Presenters
{
    public class MainPresenter
    {
        private readonly IMainView mainView;
        SoundPlayer simpleSound = new SoundPlayer("Para sesi para kasası sesi (320 kbps).wav");
        public MainPresenter(IMainView mainView)
        {
            this.mainView = mainView;
        }

    }
}
