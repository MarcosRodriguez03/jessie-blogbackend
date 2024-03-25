using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class userModel
{
    public int ID { get; set; }
    public string? Username { get; set; }
    public string? Salt { get; set; }
    public int? Hash { get; set; }
    public userModel()
    {

    }
}
