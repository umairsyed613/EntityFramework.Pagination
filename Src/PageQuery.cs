﻿namespace EntityFramework.Pagination
{
    public class PageQuery : IPageQuery
    {
        public int PageSize { get ; set ; }
        public int PageNr { get ; set ; }
    }
}
