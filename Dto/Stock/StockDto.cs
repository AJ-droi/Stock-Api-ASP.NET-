﻿using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using web_api.Models;
using web_api.Dto.Comment;

namespace web_api.Dto.Stock
{
	public class StockDto
	{
        public int Id { get; set; }

        public string Symbol { get; set; } = string.Empty;

        public string CompanyName { get; set; } = string.Empty;

        public decimal Purchase { get; set; }

        public decimal LastDiv { get; set; }

        public string Industry { get; set; } = string.Empty;

        public long MarketCap { get; set; }

        public List<CommentDto>? Comments { get; set; }

    }
}

