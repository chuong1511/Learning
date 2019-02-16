using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChuongForums.Models.Forum
{
    public class ForumIndexModel
    {
        public IEnumerable<ForumListingModel> ForumList { get; set; }
    }
}
