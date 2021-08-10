using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos.UserImages
{
    public class UserImagesDto : IDto
    {
        public Guid SecondaryId { get; set; }
        public Guid UserId { get; set; }
        public Guid ImageId { get; set; }
    }
}
