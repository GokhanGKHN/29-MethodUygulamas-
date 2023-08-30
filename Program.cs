using System;
using Microsoft.VisualBasic;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program

    {


        static void Main(string[] args)
        {
           var soru1=new Soru() {SoruMetni="Hangisi programlama dilidir?"                   ,Secenekler= new string[4]{"A","B","C","D"},Cevap="A"};
           var soru2=new Soru() {SoruMetni="Hangisi en populer wep Programlama dilidir?"    ,Secenekler= new string[4]{"A","B","C","D"},Cevap="B"};
           var soru3=new Soru() {SoruMetni="Hangisi en populer programlama dilidir?"        ,Secenekler= new string[4]{"A","B","C","D"},Cevap="C"};

           var sorular =new Soru[3] {soru1,soru2,soru3};

                        foreach(var i in sorular){
                        Console.WriteLine(i.SoruMetni);
                        foreach(var j in i.Secenekler){
                        Console.WriteLine(j);
                        }
                        Console.WriteLine("Cevabınız:");
                        var cevap =Console.ReadLine();

                        if(i.CevapKontrol(cevap)){
                            Console.WriteLine("Doğru Cevap");
                        }else{
                            Console.WriteLine("Yanlış Cevap");
                        }

                        }
        }         
    }

    

class Soru
{
    //Prop
public string SoruMetni { get; set; }
public string[] Secenekler { get; set; }

public string Cevap { get; set; }

    //Methods
public bool CevapKontrol(string cevap){

    return this.Cevap == cevap;

}

}















}
