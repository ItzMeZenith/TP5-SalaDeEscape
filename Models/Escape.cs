public static class Escape{
    private static string[] incognitasSalas;
    private static int estadoJuego = 1;

    private static void InicializarJuego()
    {
        string [] incognitas = {"ALAN TURING", "LIBRO", "ANRPVNN", "648738"};
        incognitasSalas = incognitas;
    }

    public static int GetEstadoJuego(){

        return estadoJuego;
    }

    public static bool ResolverSala(int Sala, string Incognita){

        bool a = true;
        if (estadoJuego == 1){
            
            InicializarJuego();
        }

        if(Sala == estadoJuego){

            if(Incognita.ToUpper() == incognitasSalas[Sala-1])
            {
                estadoJuego++;
            }
            else 
            {
                a = false;
            }
        }
        else
        {
            a = false;
        }
        
        return a;
    }
}