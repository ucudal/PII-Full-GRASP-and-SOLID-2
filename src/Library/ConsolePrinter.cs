using System;
using System.Collections;


namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter
    {
        Recipe recipee = new Recipe();
        public ConsolePrinter(Recipe recippe){
            
            this.recipee = recippe;
        }
        public void consolePrinter(){
            Console.WriteLine($"Receta de {recipee.FinalProduct.Description}:");
            foreach (Step step in recipee.steps){
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
    }   
}
            
        
        
        
    
    
     
        