using System;
public class Pelicula
{
    private string titulo;
	private int año;
	private string pais;
	private string director;
	
	public Pelicula(String p, int a ){
		titulo = p;
		año = a;
	}
	
	public void imprime(){
		Console.WriteLine(titulo + "\t" + año);	
	}



}



namespace POO_act_2
{
     class Program
    {
        public static void Main(string[] args)
        {
          Pelicula p1 = new Pelicula("Wall-E",2008);
		p1.imprime();
		


        }
    }
}
