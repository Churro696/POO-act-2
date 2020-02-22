using System;
public class Pelicula
{
    public string titulo;
	public int año;
	public string pais;
	public string director;
	



}



namespace POO_act_2
{
     class Program
    {
        public static void Main(string[] args)
        {
            Pelicula p1 = new Pelicula();
		p1.titulo = "Wall-E";
		p1.año = 2008;
		
		Pelicula p2 = new Pelicula();
		p2.titulo = "Ratatouille";
		p2.año = 2016;
		
		Console.WriteLine(p1.titulo + "\t" + p1.año + "\n" + p2.titulo + "\t" + p2.año);
		


        }
    }
}
