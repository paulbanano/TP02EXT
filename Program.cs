int elecc = 0;

while(elecc=!4){
    menu();
    elecc = ingresarInt("Ingrese que quiere hacer");
    if(elecc == 1){
        string pais = ingresarString("Ingrese su pais");
        string nom = ingresarString("Ingresa su nombre");
        int peso = ingresarInt("Ingrese su peso");
        int pg = ingresarInt("Ingrese su potencia de golpeo");
        int vp = ingresarInt("Ingrese su velocidad de golpep")
        Boxeador bx1 = new Boxeador1(nom ,pais,  peso, pg, vp);
        Console.WriteLine("Se ha creado el boxeador "+nom);
    }
    else if(elecc == 2){
        string pais = ingresarString("Ingrese su pais");
        string nom = ingresarString("Ingresa su nombre");
        int peso = ingresarInt("Ingrese su peso");
        int pg = ingresarInt("Ingrese su potencia de golpeo");
        int vp = ingresarInt("Ingrese su velocidad de golpep")
        Boxeador bx2 = new Boxeador2(nom ,pais,  peso, pg, vp);
        Console.WriteLine("Se ha creado el boxeador "+nom);
    }
    else if(elecc == 3){
        int skill1 = bx1.ObtenerSkill();
        int skill2 = bx2.ObtenerSkill();
        int ganador1 = skill1-skill2
        int ganador2 = skill2-skill1
        if(ganador1 > ganador2)
        {
         if(skill1 >= 30)
         {
            Console.WriteLine("Gano " +bx1.Nombre+" por KO");
         }
         else if(skill1>=10)
         {
            Console.WriteLine("Gano " +bx1.Nombre+" por puntos en fallo unánime");
         }
         else
         {
            Console.WriteLine("Gano " +bx1.Nombre+" por puntos en fallo dividido");
         } 
        }
        else
        {
            if(skill1 >= 30)
         {
            Console.WriteLine("Gano " +bx2.Nombre+" por KO");
         }
         else if(skill1>=10)
         {
            Console.WriteLine("Gano " +bx2.Nombre+" por puntos en fallo unánime");
         }
         else
         {
            Console.WriteLine("Gano " +bx2.Nombre+" por puntos en fallo dividido");
         } 
        }
    }
}

static void ganador()
{
    
}

static void menu()
    {
        Console.WriteLine("1-Cargar Boxeador 1 " + Environment.NewLine + "2-Cargar Boxeador 2" + Environment.NewLine + "3-Pelear!" + Environment.NewLine + "4-Salir");
    }