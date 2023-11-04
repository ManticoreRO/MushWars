using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QDS.MushWars
{
    internal class PlayerStateSystem : IPlayerStateSystem
    {
        private PlayerState _playerState;

        public PlayerState GetPlayerState() { return _playerState; }

        public void Load()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
