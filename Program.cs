int elecc = 0;
string nom = "",pais = "";
int peso = 0, pg = 0, vp = 0;
 Boxeador bx2 = new Boxeador(nom ,pais,  peso, pg, vp);
  Boxeador bx1 = new Boxeador(nom ,pais,  peso, pg, vp);
while(elecc != 4){
    menu();
    elecc = ingresarInt("Ingrese que quiere hacer");
    if(elecc == 1){
         pais = ingresarString("Ingrese su pais");
         nom = ingresarString("Ingresa su nombre");
         peso = ingresarInt("Ingrese su peso");
         pg = ingresarInt("Ingrese su potencia de golpeo");
         vp = ingresarInt("Ingrese su velocidad de golpep");
         bx1 = new Boxeador(nom ,pais,  peso, pg, vp);
        Console.WriteLine("Se ha creado el boxeador "+nom);
    }
    else if(elecc == 2){
         pais = ingresarString("Ingrese su pais");
         nom = ingresarString("Ingresa su nombre");
         peso = ingresarInt("Ingrese su peso");
         pg = ingresarInt("Ingrese su potencia de golpeo");
         vp = ingresarInt("Ingrese su velocidad de golpep");
         bx2 = new Boxeador(nom ,pais,  peso, pg, vp);
        Console.WriteLine("Se ha creado el boxeador "+nom);
    }
    else if(elecc == 3){
        int skill1 = bx1.ObtenerSkill();
        int skill2 = bx2.ObtenerSkill();
        int ganador1 = skill1-skill2;
        int ganador2 = skill2-skill1;
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

static int  ingresarInt(string msj)
{
   Console.WriteLine(msj);
   int d = int.Parse(Console.ReadLine());
   return d;
}

static string ingresarString(string msj){
   Console.WriteLine(msj);
   string d = Console.ReadLine();
   return d;
}

static void menu()
{
   Console.WriteLine("1-Cargar Boxeador 1 " + Environment.NewLine + "2-Cargar Boxeador 2" + Environment.NewLine + "3-Pelear!" + Environment.NewLine + "4-Salir");
}