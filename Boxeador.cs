public class Boxeador
{
    public string Pais{get; set;}
    public int Peso{get; set;}
    public string Nombre{get;set;}
    public int PotenciaGolpes{get; set;}
    public int VelocidadPiernas{get; set;}

    public Boxeador1(string nom ,string pais, int peso, int pg, int vp ){
        Pais = pais;
        Peso = peso;
        Nombre = nom;
        VelocidadPiernas = vp;
        PotenciaGolpes = pg;
    }
    public Boxeador2(string nom ,string pais, int peso, int pg, int vp ){
        Pais = pais;
        Peso = peso;
        Nombre = nom;
        VelocidadPiernas = vp;
        PotenciaGolpes = pg;
    }

    public ObtenerSkill(){
        Random rnd = new Random(1,10)
        int skill = VelocidadPiernas * 0.6 +  PotenciaGolpes * 0.8 + rnd;       
        return skill;
    }
}