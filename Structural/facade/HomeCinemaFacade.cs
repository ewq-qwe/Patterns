using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.facade
{
    internal class HomeCinemaFacade
    {
        private TV _tv = new TV();
        private Audio _audio = new Audio();
        private Lights _lights = new Lights();
        private Player _player = new Player();

        public void WatchMovie(string movieTitle)
        {
            Console.WriteLine("--- Підготовка до перегляду фільму ---");
            _lights.Dim();
            _tv.TurnOn();
            _audio.SetVolume(50);
            _player.Play(movieTitle);
        }
    }
}
