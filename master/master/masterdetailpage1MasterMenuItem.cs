using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace master
{

    public class masterdetailpage1MasterMenuItem
    {
        public masterdetailpage1MasterMenuItem()
        {
            TargetType = typeof(masterdetailpage1MasterMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}