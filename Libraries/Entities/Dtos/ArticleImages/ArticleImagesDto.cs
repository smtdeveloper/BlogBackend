using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos.ArticleImages
{
    public class ArticleImagesDto : IDto
    {
        public Guid SecondaryId { get; set; }
        public Guid ArticleId { get; set; }
        public Guid ImageId { get; set; }
    }
}
