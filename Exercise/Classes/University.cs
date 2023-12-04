using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise.Classes;

public class University
{

    public string NameUniversity { get; set; }
    public int Aceptan { get; set; }
    public int Rechazan { get; set; }
    public int Blancos { get; set; }
    public int Nulos { get; set; }
    public List<string> Votes { get; set; }    
}
