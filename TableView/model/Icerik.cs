using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDers.modell
{
    internal class Icerik
    {
        public int icerikKod { get; set; }
        public int CatID {  get; set; }
        public string Title { get; set; }
        public string spot { get; set; }
        public string body { get; set; }
        public DateTime shownDate { get; set; }
        public int statu { get; set; }
        public bool frPage { get; set; }
        public DateTime deadLine { get; set; }
        public string adminID { get; set; }
        public int puan { get; set; }
        public int oylama { get; set; }
        public int pageView { get; set; }
        public int parentid { get; set; }
        public int rank { get; set; }
        public int ctxtLevel { get; set; }

        public Icerik(int icerikKod, int catID, string title, string spot, string body, DateTime shownDate, int statu, bool frPage, DateTime deadLine, 
            string adminID, int puan, int oylama, int pageView, int parentid, int rank, int ctxtLevel)
        {
            this.icerikKod = icerikKod;
            CatID = catID;
            Title = title;
            this.spot = spot;
            this.body = body;
            this.shownDate = shownDate;
            this.statu = statu;
            this.frPage = frPage;
            this.deadLine = deadLine;
            this.adminID = adminID;
            this.puan = puan;
            this.oylama = oylama;
            this.pageView = pageView;
            this.parentid = parentid;
            this.rank = rank;
            this.ctxtLevel = ctxtLevel;
        }
    }
}
