using Bazzar.Core.Domain.Advertisements.ValueObjects;
using Framework.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazzar.Core.Domain.Advertisements.Entities
{
    public class Advertisement:BaseEntity<Guid>
    {
        public  OwnerId OwnerId { get; set; }
        public Title Title { get; set; }
        public Text  Text { get; set; }
        public State  State { get; set; }
        public  List<Picture> Pictures { get; set; }




    }
}
