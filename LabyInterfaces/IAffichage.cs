using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabyInterfaces
{
    public interface IAffichage
    {
        void PersoMove(int direction);
        void PersoTeleport(int x, int y);

        void PlayerAdd(string ip, int x, int y);
        void PlayerMove(string ip, int x, int y);
        void PlayerRemove(string ip);

        void ItemAdd(int x, int y, string nom);
        void ItemRemove(int x, int y);

        void Warfog(int lvl);
    }
}
