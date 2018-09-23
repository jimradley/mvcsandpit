using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCSandpit.Data.Model
{
    public enum Genre
    {
        [Display(Name ="Non Fiction")]
        NonFiction,
        ScienceFiction

    }
}
