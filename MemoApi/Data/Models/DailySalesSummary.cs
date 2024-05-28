using System;
using System.Collections.Generic;

namespace MemoApi.Data.Models;

public partial class DailySalesSummary
{
    public DateTime SummaryDate { get; set; }

    public decimal? TotalSales { get; set; }

    public int? TotalOrders { get; set; }

    public decimal? TotalRefunds { get; set; }
}
