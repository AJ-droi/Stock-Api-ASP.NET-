using System;
using web_api.Dto.Comment;
using web_api.Models;

namespace web_api.Mappers
{
	public static class CommentMapper
	{
		public static CommentDto ToCommentDto(this Comment commentModel)
		{
			return new CommentDto
			{
				Id = commentModel.Id,
				Title = commentModel.Title,
				Content = commentModel.Content,
				CreatedOn = commentModel.CreatedOn,
                CreatedBy = commentModel.AppUser.UserName,
                StockId = commentModel.StockId
			};
		}

        public static Comment ToCommentFromCreate(this CreateCommentDto commentDto, int stockId)
        {
			return new Comment
			{
				Title = commentDto.Title,
				Content = commentDto.Content,
                CreatedOn = DateTime.Now.ToUniversalTime(),
                StockId = stockId
            };
        }

        public static Comment ToCommentFromUpdate(this UpdateCommentRequestDto commentDto)
        {
            return new Comment
            {
                Title = commentDto.Title,
                Content = commentDto.Content,
                CreatedOn = DateTime.Now.ToUniversalTime(),
            };
        }
    }
}

