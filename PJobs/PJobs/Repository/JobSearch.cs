using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PJobs.Models;
using System.Globalization;

namespace PJobs.Repository
{
    public class JobSearch
    {
        public NewJoin NewJoinModel { get; set; }

        public ThongTinLinhVuc LinhVucModel { get; set; }

        public JobSearch()
        {
            NewJoinModel = new NewJoin();
            LinhVucModel = new ThongTinLinhVuc();
        }

    }
}


