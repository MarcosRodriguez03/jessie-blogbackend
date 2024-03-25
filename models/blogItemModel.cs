using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class blogItemModel
{
    public int ID { get; set; }
    public int UserID { get; set; }
    public string? PublishName { get; set; }
    public string? Date { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? Image { get; set; }
    public string? Tags { get; set; }
    public string? Categories { get; set; }
    public bool IsPublished { get; set; }
    public bool IsDeleteed { get; set; }

    public blogItemModel()
    {

    }

}
