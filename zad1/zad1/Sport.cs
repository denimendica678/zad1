using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    public class Sport
    {

        private string Naziv;
        private bool IgraLiSeLoptom;
        private byte BrojIgraca;

        public Sport(byte brojIgraca, string naziv, bool igraLiSeLoptom)
        {
            BrojIgraca = brojIgraca;
            Naziv = naziv;
            IgraLiSeLoptom = igraLiSeLoptom;
        }

        public string Naziv1 { get => Naziv; set => Naziv = value; }
        public bool IgraLiSeLoptom1 { get => IgraLiSeLoptom; set => IgraLiSeLoptom = value; }
        public byte BrojIgraca1 { get => BrojIgraca; set => BrojIgraca = value; }
    }
}
