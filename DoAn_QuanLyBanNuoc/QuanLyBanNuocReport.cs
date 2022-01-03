using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QuanLyBanNuoc
{
    class QuanLyBanNuocReport
    {
        public int STT { get; set; }
        
        public string IDTABLE { get; set; }

        public string FULLNAME { get; set; }

        public string STAFF { get; set; }


        public int TIMESORDER { get; set; }

        public string DRINKNAME { get; set; }

        public int QUANTITY { get; set; }

        public long TOTALMONEY { get; set; }

        public DateTime? DATE { get; set; }

    }
}
