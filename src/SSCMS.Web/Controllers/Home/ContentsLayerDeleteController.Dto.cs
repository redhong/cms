﻿using System.Collections.Generic;
using SSCMS.Dto.Request;

namespace SSCMS.Web.Controllers.Home
{
    public partial class ContentsLayerDeleteController
    {
        public class GetRequest : ChannelRequest
        {
            public List<int> ContentIds { get; set; }
        }

        public class GetResult
        {
            public List<IDictionary<string, object>> Value { get; set; }
        }

        public class SubmitRequest : ChannelRequest
        {
            public List<int> ContentIds { get; set; }
            public bool IsRetainFiles { get; set; }
        }
    }
}
