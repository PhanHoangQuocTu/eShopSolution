﻿using Client.Dtos.Common;

namespace Client.Dtos.Product
{
    public class GetManageProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}