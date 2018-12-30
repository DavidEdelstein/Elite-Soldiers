using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public interface ISoldier
    {
        void Shoot();

        string Recon();

        void ResiliantSurvive();
        //set is if the value is always the same.
        bool Sniper { get;}
        bool Elite { get;}
        bool UnderwaterWarefare { get;}
        bool AntiTerrorist { get;}

    }
}
