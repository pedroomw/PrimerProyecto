namespace PrimerProyecto.Models;

public static class Grupo{
    public static Dictionary<int, Integrante> Integrantes{get; private set;} 


    public static void InicializarGrupo()
    {
        Integrantes = new Dictionary<int, Integrante>();
        DatoPersonal DatoPersona1 = new DatoPersonal("Poda", "Kohn", new DateTime (2008, 07, 02), "/Poda.jpg");
        List<DatoFamiliar> DatosFamiliaresPoda= new List<DatoFamiliar> ();
        DatosFamiliaresPoda.Add (new DatoFamiliar("Beto", "Kohn", "Padre", "El ta"));
     DatosFamiliaresPoda.Add (new DatoFamiliar("Gilda", "Marino", "Abuela", "La tana"));
      DatosInteres datosInteresPoda = new DatosInteres("Pensar y comer y bailar y jugar al futbol y cortar fruta y despues comerla", "adolescense y euphoria", "Fidel y chef", "Lenguaaa");

          Integrante Poda = new Integrante (48793643, DatoPersona1, DatosFamiliaresPoda, datosInteresPoda);
          Integrantes.Add(Poda.DNI, Poda);
        


        
        DatoPersonal DatoPersona2 = new DatoPersonal("Fidel", "Golds", new DateTime (2008, 10, 09), "/Fidel.jpg");
        List<DatoFamiliar> DatosFamiliaresFidel= new List<DatoFamiliar> ();
    DatosFamiliaresFidel.Add (new DatoFamiliar("Esteban", "Goldsman", "Tio", "El tano"));
    DatosFamiliaresFidel.Add (new DatoFamiliar("Roberta", "Goldsman", "Abuela", "La monja"));
     DatosInteres datosInteresFidel = new DatosInteres("Tocar el ukelele, leer freud y enamorarse", "adolescense y strangher things", "Poda y chef", "las matematicas");
     






        Integrante Fidel = new Integrante (49002222, DatoPersona2, DatosFamiliaresFidel, datosInteresFidel);
        Integrantes.Add(Fidel.DNI, Fidel);
    


        DatoPersonal DatoPersonaPedro = new DatoPersonal("Pepe", "Chef", new DateTime(2009, 06, 10), "/Pedro.jpg");
        List<DatoFamiliar> DatosFamiliaresPedro = new List<DatoFamiliar>();
        DatoFamiliar DatosFamiliarPedro1 = new DatoFamiliar("Eduardo","Sancho","Abuelo","Gran pibe, sigma");
        DatoFamiliar DatosFamiliarPedro2 = new DatoFamiliar("Javier","Milei","Tío solterón","Gran pibe, sigma");
        DatosFamiliaresPedro.Add(DatosFamiliarPedro1);
        DatosFamiliaresPedro.Add(DatosFamiliarPedro2);
        DatosInteres datosInteresPedro = new DatosInteres("Divertirse", "Poda enamorandose", "Poda y un par mas", "Edu Física");
        Integrante Pedro = new Integrante (49552421, DatoPersonaPedro, DatosFamiliaresPedro, datosInteresPedro);
        Integrantes.Add(Pedro.DNI, Pedro);

        
    }
}