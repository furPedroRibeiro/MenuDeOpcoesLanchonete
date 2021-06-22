using System;

public class Program
{
    public static void Main()
    {
        int menu, oplanche, opbebida, conta = 0;
        int xtudo = 0, xegg = 0, xsalada = 0, bauru = 0;
        int coca = 0, guarana = 0, sodalimo = 0, fanta = 0;
        double total = 0;
        string voltar;
        do
        {
            Console.Clear();
            
            Console.WriteLine("\n 1-LANCHES \n 2-BEBIDAS \n 3-CONTA \n 0-SAIR");
            
            Console.Write("\n Digite a opção escolhida: ");
            
            menu = int.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    do
                    {
                        Console.Clear();
                        Console.WriteLine(" -----> LANCHES <----- \n \n 1-X-TUDO R$ 10,00 \n 2-X-EGG R$  7,00 \n 3-X-SALADA R$ 6,00 \n 4-BAURU R$ 5,00 \n 0-VOLTAR");
                        
                        Console.Write("\n Digite a opção escolhida: ");
                        
                        oplanche = int.Parse(Console.ReadLine());
                        switch (oplanche)
                        {
                            case 1:
                                xtudo++;
                                break;
                            case 2:
                                xegg++;
                                break;
                            case 3:
                                xsalada++;
                                break;
                            case 4:
                                bauru++;
                                break;
                            case 0:
                                Console.Write("Deseja mesmo voltar? [s/n] ");
                                voltar = Console.ReadLine();
                                if (voltar != "s" && voltar != "S")
                                {
									Console.Clear();
                                    oplanche = 1;
                                }
                                break;
                            default:
								Console.Clear();
                                Console.Write("Opção inválida!\nTecle ENTER!");
                                Console.ReadLine();
                                break;
                        }
                    } while (oplanche != 0);
                    break;
                case 2:
                    do
                      {
                        Console.Clear();
                        Console.WriteLine(" -----> BEBIDAS <----- \n \n 1-COCA-COLA R$ 8,00 \n 2-GUARANÁ R$ 7,00 \n 3-SODA-LIMONADA R$ 6,00 \n 4-FANTA R$ 6,00 \n 0-VOLTAR");
                        
                        Console.Write("\n Digite a opção escolhida: ");
                        
                        opbebida = int.Parse(Console.ReadLine());
                        switch (opbebida)
                        {
                            case 1:
                                coca++;
                                break;
                            case 2:
                                guarana++;
                                break;
                            case 3:
                                sodalimo++;
                                break;
                            case 4:
                                fanta++;
                                break;
                            case 0:
                                Console.Write("Deseja mesmo voltar? [s/n] ");
                                voltar = Console.ReadLine();
                                if (voltar != "s" && voltar != "S")
                                {
                                    opbebida = 1;
                                }
                                break;
                            default:
								Console.Clear();
                                Console.Write("Opção inválida!\nTecle ENTER!");
                                Console.ReadLine();
                                break;
                        }
                    } while (opbebida != 0);
                    break;
                case 3:
						do{
                        Console.Clear();
                        Console.WriteLine("PRODUTO                QTDE              VALOR");
                        if (xtudo > 0)
                        {
                            Console.WriteLine("X-TUDO         " + xtudo +   "        {0}", (xtudo * 10));
                            total += xtudo * 10;
                        }
                        if (xegg > 0)
                        {
                            Console.WriteLine("X-EGG          " + xegg +    "        {0}", (xegg * 7));
                            total += xegg * 7;
                        }
                        if (xsalada > 0)
                        {
                            Console.WriteLine("X-SALADA       " + xsalada + "        {0}", (xsalada * 6));
                            total += xsalada * 6;
                        }
                        if (bauru > 0)
                        {
                            Console.WriteLine("BAURU          " + bauru +   "        {0}", (bauru * 5));
                            total += bauru * 5;
                        }
                        if (coca > 0)
                        {
                            Console.WriteLine("COCA-COLA      " + coca +    "        {0}", (coca * 8));
                            total += coca * 8;
                        }
                        if (guarana > 0)
                        {
                            Console.WriteLine("GUARANÁ        " + guarana + "        {0}", (guarana * 7));
                            total += guarana * 7;
                        }
                        if (sodalimo > 0)
                        {
                            Console.WriteLine("SODA-LIMONADA  " + sodalimo +"        {0}", (sodalimo * 6));
                            total += sodalimo * 6;
                        }
                        if (fanta > 0)
                        {
                            Console.WriteLine("FANTA          " + fanta +   "        {0}", (fanta * 6));
                            total += fanta * 6;
                        }
                        Console.WriteLine("----------------------------");
                        Console.WriteLine("TOTAL                                  {0}", (total));
           
						Console.WriteLine("Deseja voltar?[s/n]");
						voltar=Console.ReadLine();
						if(voltar=="n" || voltar=="N")
						{
							conta=1;
						}
						else if(voltar=="s" || voltar=="S")
						{
							menu=1;
						}
						else
						{
							
			        		Console.WriteLine("Opção inválida!\nTecle ENTER!");
							conta=1;
						}
						}while(conta!=0);
                        break;
					
				case 0:
					Console.Clear();
					Console.WriteLine("Deseja mesmo sair?[s/n]");
					voltar=Console.ReadLine();
					if(voltar== "s" || voltar=="S"){
						Console.Clear();
						Console.WriteLine("Obrigado pela visita, volte sempre ;)");
					}
					else if(voltar!="s" || voltar!="S"){
						Console.Clear();
					    menu=1;
					}
					
					break;
					default:
					Console.Clear();
			        	Console.WriteLine("Opção inválida!\nTecle ENTER!");
			        	Console.ReadLine();
					break;
                      }
                 } while (menu != 0);
                 Console.ReadKey();
    }
}