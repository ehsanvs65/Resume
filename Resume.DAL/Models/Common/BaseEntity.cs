using System.ComponentModel.DataAnnotations;

namespace Resume.DAL.Models.Common;

public class BaseEntity<T>
{
    [Key] public T Id { set; get; }
    public DateTime CreateDate { set; get; }
}