﻿using System.ComponentModel.DataAnnotations;

namespace Library.Api.Models
{
    //TODO : 03 - Creo el DTO para actualizar mi book
    public class BookUpdateDto : BookChangesDto
    {
        public override string Description
        {
            get
            {
                return base.Description;
            }

            set
            {
                base.Description = value;
            }
        }
    }
}
