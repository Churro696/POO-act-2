using System;
public class Pelicula
{
 private string titulo;
 private int año;
 private string pais;
 private string director;

 public void SetTitulo(string n){
    titulo = n;
 }
 public string GetTitulo()
 {
    return titulo;
 }
 public void SetAño(int y)
 {
    
    año = y;
 }
 public int GetAño()
 {
    return año;
 }


}



namespace POO_act_2
{
     class Program
    {
        static void Main(string[] args)
        {
            Pelicula p1 = new Pelicula ();
            p1.SetTitulo("Wall-E");
            p1.SetAño(2008);

            Pelicula p2 = new Pelicula();
            p2.SetTitulo("Ratatouille");
            p2.SetAño(2007);
            Console.WriteLine(p1.GetTitulo() + "\t" + p1.GetAño() + "\n" + p2.GetTitulo() + "\t" + p2.GetAño());


        }
    }
}
