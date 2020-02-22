using System;
public class Pelicula
{
    private string titulo;
	private int año;
	private string pais;
	private string director;
	
	public Pelicula(string t, int a){
		titulo = t;
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
         List<Pelicula> P1 = new List<Pelicula>();
		P1.Add(new Pelicula ("Toy Story 3", 2019));
		P1.Add(new Pelicula ("Wall-E",2008));
		P1.Add(new Pelicula ("Ratatouille",2007));
		P1.Add(new Pelicula ("Joker",2019));
		P1.Add(new Pelicula ("Krauss",2019));
		
		foreach (Pelicula p in P1){
			p.imprime();
		}
		


        }
    }
}
