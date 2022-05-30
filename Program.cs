using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace GestionStock {


    class Program  {

        
        static void Main(string[] args){   
 

                List<Produit> prod = new List<Produit>();

                Produit produit1 = new Produit(1, "Tongs", 50,  "RAS");
                Produit produit2 = new Produit(2, "Ballon",40, "RAS");
                Produit produit3 = new Produit(3, "Maillot", 20, "RAS");
                Produit produit4 = new Produit(4, "Seau", 9, "RAS" );
                Produit produit5 = new Produit(5, "Pelle", 40, "RAS");
                Produit produit6 = new Produit(6, "Sac", 20,"RAS");

                    // Add produits to the list.
                prod.Add(produit1);  
                prod.Add(produit2);
                prod.Add(produit3);
                prod.Add(produit4);
                prod.Add(produit5);
                prod.Add(produit6);

                
                Console.WriteLine();
                Console.WriteLine("+--------------+---------------+----------------------+-----------+");
                Console.WriteLine("|      #       |  Produit      |      Stocks          |  Etat      |");
                Console.WriteLine("+--------------+---------------+----------------------+-----------+");



            //Affichage des produits
            foreach(Produit p in prod)
            {
                
                Console.WriteLine(p);
                Console.WriteLine("..................................................................");


            }
       
         // Choix du produit a decrementer.
        System.Console.WriteLine("Veuillez entrer le numero du produit a decrementer de 1 et 6.");
        string number = Console.ReadKey().KeyChar.ToString();

        Console.WriteLine();

      
            if(Regex.IsMatch(number, @"^[0-9]+$"))
      {  
    
        int numero = Convert.ToInt32(number);
        

                        //Les opertations de decrementation des produits
                        switch (numero) 
                        {
                            case 1:
                            Console.WriteLine("Produit avec indice 1"); 

                                        produit1.decrementerStock();
                                        Console.WriteLine();
                                        Console.WriteLine(produit1);
                                        Console.WriteLine();


                                        //Mettre a jour l'etat du stock
                                          if(produit1.getStock() > 5){

                                                    produit1.setEtat("Disponible");

                                                } else if ( produit1.getStock() > 0 && produit1.getStock() < 5)
                                                {
                                                    produit1.setEtat("En réapprovisionnement");

                                                } else if(produit1.getStock() == 0)
                                                {
                                                    produit1.setEtat("En rupture");
                                                }
                                                                                                                                        

                            break;
                            case 2:
                            Console.WriteLine("Produit avec indice 2");             
                                        
                                        produit2.decrementerStock();
                                        Console.WriteLine(produit2);

                                        //Mettre a jour l'etat du stock
                                         if(produit2.getStock() > 5){

                                                    produit2.setEtat("Disponible");

                                                } else if ( produit2.getStock() > 0 && produit2.getStock() < 5)
                                                {
                                                    produit2.setEtat("En réapprovisionnement");

                                                } else if(produit2.getStock() == 0)
                                                {
                                                    produit2.setEtat("En rupture");
                                                }
                              

                            break;
                            case 3:
                            Console.WriteLine("Produit avec indice 3");
              
                                        
                                        produit3.decrementerStock();
                                        Console.WriteLine(produit3);

                                        //Mettre a jour l'etat du stock
                                        if(produit3.getStock() > 5){

                                                    produit3.setEtat("Disponible");

                                                } else if ( produit3.getStock() > 0 && produit3.getStock() < 5)
                                                {
                                                    produit3.setEtat("En réapprovisionnement");

                                                } else if(produit3.getStock() == 0)
                                                {
                                                    produit3.setEtat("En rupture");
                                                }
                                                                         
                            
                            break;
                            case 4:
                            Console.WriteLine("Produit avec indice 4");           
                                        
                                        produit4.decrementerStock();
                                        Console.WriteLine(produit4);

                                        //Mettre a jour l'etat du stock
                                         if(produit4.getStock() > 5){

                                                    produit4.setEtat("Disponible");

                                                } else if ( produit4.getStock() > 0 && produit4.getStock() < 5)
                                                {
                                                    produit4.setEtat("En réapprovisionnement");

                                                } else if(produit4.getStock() == 0)
                                                {
                                                    produit4.setEtat("En rupture");
                                                }

                            break;
                            case 5:
                            Console.WriteLine("Produit avec indice 5");            
                                        
                                        produit5.decrementerStock();
                                        Console.WriteLine(produit5);

                                        //Mettre a jour l'etat du stock
                                        if(produit5.getStock() > 5){

                                                    produit5.setEtat("Disponible");

                                                } else if ( produit5.getStock() > 0 && produit5.getStock() < 5)
                                                {
                                                    produit5.setEtat("En réapprovisionnement");

                                                } else if(produit5.getStock() == 0)
                                                {
                                                    produit5.setEtat("En rupture");
                                                }


                            break;
                            case 6:
                            Console.WriteLine("Produit avec indice 6");
                            
                                        produit6.decrementerStock();
                                        Console.WriteLine(produit6);

                                        //Mettre a jour l'etat du stock
                                        if(produit6.getStock() > 5){

                                                    produit6.setEtat("Disponible");

                                                } else if ( produit6.getStock() > 0 && produit6.getStock() < 5)
                                                {
                                                    produit6.setEtat("En réapprovisionnement");

                                                } else if(produit6.getStock() == 0)
                                                {
                                                    produit6.setEtat("En rupture");
                                                }

                            break;

                        } 

          
                      }
                            else
                            {
                                Console.WriteLine("Veuillez entrer un nombre.");
                            }
                
            }

           
        }

    }