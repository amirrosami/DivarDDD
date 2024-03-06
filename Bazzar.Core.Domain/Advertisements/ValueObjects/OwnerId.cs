using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazzar.Core.Domain.Advertisements.ValueObjects
{
    public class OwnerId
    {
        public Guid Value { get; set; }
    }


    public class Price
    {
        public long Value { get; set; }
    }
    public class PictureUrl
    {
        public string Value { get; set; }
    }

    public class PictureAlt
    {
        public string Value { get; set; }
    }
}


