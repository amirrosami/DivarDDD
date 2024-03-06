﻿using System.ComponentModel;

namespace Bazzar.Core.Domain.Advertisements.ValueObjects
{
    public enum State
    {
        [Description("غیرفعال")]
        Inactive = 1,
        [Description("در انتظار تایید")]
        ReviewPending = 2,
        [Description("فعال")]
        Active = 3,
        [Description("فروخته شده")]
        Sold = 4
    }

}


