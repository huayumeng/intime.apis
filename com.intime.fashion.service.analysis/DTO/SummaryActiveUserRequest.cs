﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.intime.fashion.service.analysis.DTO
{
    class SummaryActiveUserRequest:SummaryRequestBase
    {
        protected override string MetricName
        {
            get { return "ActiveUsers"; }
        }
    }
}
