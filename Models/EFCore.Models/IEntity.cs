using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore.Models
{
    public interface IEntity
    {
        int Id { get; set; }
    }
}
