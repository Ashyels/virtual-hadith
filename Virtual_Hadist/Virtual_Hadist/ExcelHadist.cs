using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Hadist
{
    class ExcelHadist
    {
        private string _bab;
        private string _subbab;
        private string _terjemahan;
        private string _arab;
        private string _shahih;

        public string Bab
        {
            get { return _bab; }
            set { _bab = value; }
        }

        public string SubBab
        {
            get { return _subbab; }
            set { _subbab = value; }
        }

        public string Terjemah
        {
            get { return _terjemahan; }
            set { _terjemahan = value; }
        }

        public string Arab
        {
            get { return _arab; }
            set { _arab = value; }
        }

        public string Shahih
        {
            get { return _shahih; }
            set { _shahih = value; }
        }

        public ExcelHadist(string bab_, string subbab_, string terjemahan_, string arab_, string shahih_)
        {
            _bab = bab_;
            _subbab = subbab_;
            _terjemahan = terjemahan_;
            _arab = arab_;
            _shahih = shahih_;
        }

    }
}
