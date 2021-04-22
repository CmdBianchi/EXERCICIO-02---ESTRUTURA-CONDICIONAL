using System;
class Program{
    /// -------> START / MAIN 
    /////////////////////////////////////////////////////////////////////////////////////////////
    static void Main(string[] args){
        Msg();
        Conditional();
    }
    /// -------> FUNCTIONS
    /////////////////////////////////////////////////////////////////////////////////////////////
    static void Msg(){
        Console.WriteLine("Dizer se este número é negativo ou não");
    }
    //------------------------------------------------------------------------------------------//
    static void Conditional(){
        Console.Write("Digite o valor numérico inteiro: ");
        int a = int.Parse(Console.ReadLine());
        bool c1 = (a % 2 == 0);

        if (c1 == true){
            Console.WriteLine("Par");
        }
        else{
            Console.WriteLine("impar");
        }
    }
    /////////////////////////////////////////////////////////////////////////////////////////////
    /// -------> END
}
