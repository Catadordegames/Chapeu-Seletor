//Sortear casas para os alunos
using System.Collections;
using System;
using System.Runtime.CompilerServices;
class Program{
    static void Main(){
        Abertura();
        int[] contadorCasas = {0, 0, 0, 0};
        // pergunta se deseja excluir elementos do sorteio
        bool[] casas = {true, true, true, true};
        Console.Write("Deseja excluir alguma casa do sorteio? (y/n)");
        string exclusao = Console.ReadLine()!.ToLower();
        if (exclusao == "Y")
            Exclusao(casas);
        //Seleciona quantos sorteios seram feitos
        Console.Write("quantos sorteios voce deseja fazer?: ");
        int sorteios = int.Parse(Console.ReadLine()!);
        Console.Clear();
        //calcula quantas vezes cada casa pode ser sorteada
        int maxSorteios = MaxSorteios(casas, sorteios);
        //cria o objeto de sorteio
        Random random = new Random();
        for(int i = 0; i < sorteios; i++){
            //verifica se o valor deve permancer verdadeiro
            for(int j = 0; j < 4; j++){
                if(contadorCasas[j] >= maxSorteios){
                    casas[j] = false;
                    }
                //Console.WriteLine("casa {0} é {1}", j, casas[j]);
                }
            //sorteia
            Console.WriteLine("Presione qualquer tecla para sortear: ");
            Console.ReadKey();
           Console.Clear( );
            int casaSorteada = random.Next(1, 5);
            switch (casaSorteada){
                case 1:
                    if(casas[0]){
                        contadorCasas[0]++;
                        Amistad();
                        break;
                    }else goto case 2;
                case 2:
                    if(casas[1]){
                        contadorCasas[1]++;
                        Isibindi();
                        break;
                    }else goto case 3;
                case 3:
                    if(casas[2]){
                        contadorCasas[2]++;
                        Nukumori();
                        break;
                    }else goto case 4;
                case 4:
                    if(casas[3]){
                        contadorCasas[3]++;
                        Sollevare();
                        break;
                    }else goto case 1;
            }
        }
        Console.Write("Deseja realizar outro sorteio? (y/n): ");
        string reiniciar = Console.ReadLine()!.ToLower();
            if(reiniciar == "y"){
                Console.Clear();
                Main();
            }
        Console.WriteLine("presione qualquer tecla para encerrar: ");
        Console.ReadKey();
    }

    static void Abertura(){
        Console.WriteLine(@"                                                                                                    
                                                          ...:.....                                 
                                                      :~^~!^^^~^^~!!^                               
                                                     ~!^~J!..:7^^!77?7^....                         
                                                    ~!^77?Y::?J^77!~^^^~~~~~~^.                     
                                                  .7!:.:7J5?~55~!~!7!~^^^~^^^^^^:.                  
                                                 ^7~:^:^~JPGY5PJ^~YP5YJ7!!~!!!77!~~:                
                                              .^!!^^^~!!~~!JP5PP??5PJ7:...  ..::::.                 
                                            .~77~:.::::^~!~^~!~55Y5J!.                              
                                           :7!^^^!!~^^!?JJJJ?7~?5J!^                                
                                          ^7~^^~~^^~??7???PG5?^:?!                                  
                                         :7^:^~~!?J!^^..:75PP?^.:?.                                 
                                        ^7~^^^^~~!!??!^.^JYPG5?^:7:                                 
                                      .!7!^^^~!77!!77!~^:?5PGY7^~7!                                 
                                     .77~^::~?Y5PP5Y???!::75P7:^?5?                                 
                                     ^J!^:.:^?Y55PGGGY755!^!?~^?PGY^                                
                                     7?^:^~~:!J55PPGGG5!YPY!~~7??7!!~.                              
                                    .?~^!?!..:!J5PPPGGG5!75PYJJJ7!!~?^                              
                                    :?^!J!:...:~?JY5PPPP57~~~!~!7JYJ:                               
                                    !77Y7....:::^!7?Y555PP5??J5GGP5Y:                               
                                   ^JJYJ:^^^^^~~!77?JYY55YYJ5PPPYJ7?!                               
                                  :?55Y^^^~!7?JJJYYJJ???!^:..^?Y7~!!!                               
                                 .?!YY^......:^^^~~~!!!~^::::..^7??J?:                              
                                 !?!^::~!7?7~^~!!J5PPPPPP5555JJ?!~?Y5?.                             
                               .^!77!~!!7???J5PPP5555555PPPPPPGGP5?~!77.                            
                             .!Y?!!!!!!7?JJYYYJYJJJJJ?JJJJYYJJJJYY5Y!??7^                           
                             ~7PP5Y??7!!~~^::^^!7~~^^~^~~!7?JYJJJJ?JYYY7?.                          
                            .?7??!??77!7?777777~:.....::::^^^~~^^^~~!777?~                          
                             7Y77?JYYJ?77!~~^::...::::^~~!!!~!777!!!!!!!!7^                         
      ....::^^:::..          !7?J?JJ?777!!7?77777!!~~!~!!7?????JJJJJJYJ?JJJ^:^:.                    
   .^!!!!!77777!!777!!~~^::^7?7777!!~!!777!777777777!!!!~~!!!!!!!!!77??7?J?:^^^:...:::::^^::.       
 :?J?7!!?J?7!~~^^~^^~!7???JYYJJ??777777?77!7777!!777?77!~!!!!!7!~~^^^~~~~~~~~~!!777?JJY55YYJJ7~.    
 75Y?7Y5Y?!!!~~~~~~77!!~~~~~!7JY555555Y??!~~!~!!77?777!!!77??J???JJJ?7!!!~7??JY5PPGGGGGGGPPPPP5!    
 :7JYYJYYY??7!!!~~~!7Y5YJ7!~~~!!77?JYJ?7!!7?JYYYYJ???7?????JJJJJ??????JY5PPGGGGGGGGPPP555YYJJ?7^    
   .^!?JJ?????777!~~^7Y555Y?77!~~~~~~~!!!7??JJJJJ?7?7!!!!!!~~!!!!!77~!7?JYYYYYYYYYYYJ?7~:..         
       .:^~!!!!!!!!!!~!!?JYYYYJJJJJ???7777!~~^~~~~~~~~^:.                 ....   ...                
             ..:^~~~~~~~!!7!!!!!7!!!!!!!!~~^^::...                                                  
                  .::^^^:::::::........                                                             
                                                                                                    
                                                                                                    ");
    }

    static void Amistad(){
        Loading();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(@"  ______                 __              __                      __ 
 /      \               /  |            /  |                    /  |
/$$$$$$  | _____  ____  $$/   _______  _$$ |_     ______    ____$$ |
$$ |__$$ |/     \/    \ /  | /       |/ $$   |   /      \  /    $$ |
$$    $$ |$$$$$$ $$$$  |$$ |/$$$$$$$/ $$$$$$/    $$$$$$  |/$$$$$$$ |
$$$$$$$$ |$$ | $$ | $$ |$$ |$$      \   $$ | __  /    $$ |$$ |  $$ |
$$ |  $$ |$$ | $$ | $$ |$$ | $$$$$$  |  $$ |/  |/$$$$$$$ |$$ \__$$ |
$$ |  $$ |$$ | $$ | $$ |$$ |/     $$/   $$  $$/ $$    $$ |$$    $$ |
$$/   $$/ $$/  $$/  $$/ $$/ $$$$$$$/     $$$$/   $$$$$$$/  $$$$$$$/ 
                                                                    
                                                                    
                                                                    ");
        Console.ResetColor();
        
    }
    static void Isibindi(){
        Loading();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(@" ______            __  __        __                  __  __ 
/      |          /  |/  |      /  |                /  |/  |
$$$$$$/   _______ $$/ $$ |____  $$/  _______    ____$$ |$$/ 
  $$ |   /       |/  |$$      \ /  |/       \  /    $$ |/  |
  $$ |  /$$$$$$$/ $$ |$$$$$$$  |$$ |$$$$$$$  |/$$$$$$$ |$$ |
  $$ |  $$      \ $$ |$$ |  $$ |$$ |$$ |  $$ |$$ |  $$ |$$ |
 _$$ |_  $$$$$$  |$$ |$$ |__$$ |$$ |$$ |  $$ |$$ \__$$ |$$ |
/ $$   |/     $$/ $$ |$$    $$/ $$ |$$ |  $$ |$$    $$ |$$ |
$$$$$$/ $$$$$$$/  $$/ $$$$$$$/  $$/ $$/   $$/  $$$$$$$/ $$/ 
                                                            
                                                            
                                                            ");
        Console.ResetColor();
    }
    static void Nukumori(){
        Loading();
        /* roxo aqui FDP
        const string NOME = "Nukumori";
        int i = 1;
        foreach (var item in NOME){
            if(i % 2 == 0){
                Console.ForegroundColor = ConsoleColor.Red;
            }else{
                Console.ForegroundColor = ConsoleColor.DarkBlue;
            }
            Console.Write(item); 
            Console.ResetColor(); i++;
        }*/
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine(@" __    __            __                                                    __ 
/  \  /  |          /  |                                                  /  |
$$  \ $$ | __    __ $$ |   __  __    __  _____  ____    ______    ______  $$/ 
$$$  \$$ |/  |  /  |$$ |  /  |/  |  /  |/     \/    \  /      \  /      \ /  |
$$$$  $$ |$$ |  $$ |$$ |_/$$/ $$ |  $$ |$$$$$$ $$$$  |/$$$$$$  |/$$$$$$  |$$ |
$$ $$ $$ |$$ |  $$ |$$   $$<  $$ |  $$ |$$ | $$ | $$ |$$ |  $$ |$$ |  $$/ $$ |
$$ |$$$$ |$$ \__$$ |$$$$$$  \ $$ \__$$ |$$ | $$ | $$ |$$ \__$$ |$$ |      $$ |
$$ | $$$ |$$    $$/ $$ | $$  |$$    $$/ $$ | $$ | $$ |$$    $$/ $$ |      $$ |
$$/   $$/  $$$$$$/  $$/   $$/  $$$$$$/  $$/  $$/  $$/  $$$$$$/  $$/       $$/ 
                                                                              
                                                                              
                                                                              ");
        Console.ResetColor();
    }
    static void Sollevare(){
        Loading();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(@"  ______             __  __                                                   
 /      \           /  |/  |                                                  
/$$$$$$  |  ______  $$ |$$ |  ______   __     __  ______    ______    ______  
$$ \__$$/  /      \ $$ |$$ | /      \ /  \   /  |/      \  /      \  /      \ 
$$      \ /$$$$$$  |$$ |$$ |/$$$$$$  |$$  \ /$$/ $$$$$$  |/$$$$$$  |/$$$$$$  |
 $$$$$$  |$$ |  $$ |$$ |$$ |$$    $$ | $$  /$$/  /    $$ |$$ |  $$/ $$    $$ |
/  \__$$ |$$ \__$$ |$$ |$$ |$$$$$$$$/   $$ $$/  /$$$$$$$ |$$ |      $$$$$$$$/ 
$$    $$/ $$    $$/ $$ |$$ |$$       |   $$$/   $$    $$ |$$ |      $$       |
 $$$$$$/   $$$$$$/  $$/ $$/  $$$$$$$/     $/     $$$$$$$/ $$/        $$$$$$$/ 
                                                                              
                                                                              
                                                                              ");
        Console.ResetColor();
    } 
    static void Loading(){
        Abertura();
        int espera = 700;
        Console.WriteLine("*************************");
        Console.WriteLine("Estudando a personalidade");
        Console.WriteLine("*************************");
        Thread.Sleep(espera);
        Console.WriteLine("************************");
        Console.WriteLine("Conhecendo as qualidades");
        Console.WriteLine("************************");
        Thread.Sleep(espera);
        Console.WriteLine("**************************");
        Console.WriteLine("Escutando a voz do coração");
        Console.WriteLine("**************************");
        Thread.Sleep(espera);
        Console.WriteLine("*********************");
        Console.WriteLine("Conectando com a alma");
        Console.WriteLine("*********************");
        Thread.Sleep(espera);
        Console.WriteLine("***************************");
        Console.WriteLine("Analisando as posibilidades");
        Console.WriteLine("***************************");
        Thread.Sleep(espera);
        Console.WriteLine("*******************************");
        Console.WriteLine("Escolhendo a Casa mais indicada");
        Console.WriteLine("*******************************");
        Thread.Sleep(espera);
        Console.WriteLine("*************");
        Console.WriteLine("Sua casa é...");
        Console.WriteLine("*************");
        Thread.Sleep(espera);
    }
    static bool[] Exclusao(bool[] casas){
        Console.Clear();
        bool continua = true;
        while(continua == true){
            Console.WriteLine("Quais casas NÃO devem participar?");
            Console.WriteLine("Amistad (1)");
            Console.WriteLine("Isibindi (2)");
            Console.WriteLine("Nukumori (3)");
            Console.WriteLine("Sollevare (4)");
            Console.WriteLine("Sair (5)");
            int opcao = int.Parse(Console.ReadLine()!);
            switch(opcao){
                case 1:
                    casas[0] = false;
                    break;
                case 2:
                    casas[1] = false;
                    break;
                case 3:
                    casas[2] = false;
                    break;
                case 4:
                    casas[3] = false;
                    break;
                default:
                    break;
            }
            Console.Write("Deseja excluir outra casa do sorteio? (y/n)");
            string yes = Console.ReadLine()!.ToLower();
            if (yes == "y" ){
                continua = true;
            }else{
                continua = false;
            }
        }
        Console.Clear();
        return casas;
    }
    static int MaxSorteios(bool[] casas, float sorteios){
        int maxSorteios = 0;
        foreach(bool valor in casas){
            if(valor == true)
                maxSorteios++;
        }
        maxSorteios =  (int)Math.Ceiling(sorteios/maxSorteios);
        return maxSorteios;
    }
}
