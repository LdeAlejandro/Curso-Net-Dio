using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso_Net_2.Models
{
    public class ExemploExcecao
    {
        
    public void Metodo1()
    {
        try
        {
            Metodo2();
            Console.WriteLine("Try");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Catch");
            Console.WriteLine("Exeção tratada:\n"+ ex.StackTrace);
        }
       
    }
    
    public void Metodo2()
    {
        Metodo3();
    }
    
    public void Metodo3()
    {
        Metodo4();
    }
    
    public void Metodo4()
    {
        throw new Exception("Occureo uma exceção");
    }

    }

}