public class Boxeador
{
    public string Pais{get; set;}
    public int Peso{get; set;}
    public string Nombre{get;set;}
    public int PotenciaGolpes{get; set;}
    public int VelocidadPiernas{get; set;}

    public Boxeador(string nom ,string pais, int peso, int pg, int vp ){
        Pais = pais;
        Peso = peso;
        Nombre = nom;
        VelocidadPiernas = vp;
        PotenciaGolpes = pg;
    }
    

    public int ObtenerSkill(){
        Random random = new Random();
        int rnd = random.Next(1,10);
        double  skill = PotenciaGolpes * 0.8 +  VelocidadPiernas * 0.6 + rnd;
        int Rskill = (int)skill; 
        return Rskill;
    }
}