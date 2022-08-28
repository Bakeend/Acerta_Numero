using System; // do sistema
class Program { // do sistema
    static void Main(string[] args) { // do sistema
        Console.Write("Clica enter para continuar.... "); // mensagem deconfirmação do usuario
        string enter = Console.ReadLine(); // verificar confirmação do usuario
        Console.Clear(); // limpar console depois da verificação
        Console.Write("Jogo Iniciado! Aguarde carregar..."); // mensagem carregar jogo
        Thread.Sleep(6000); // sistema de dar um pause para carregar
        int numero_selecionado = 0; // variavéis para sistema funcionar
        int i = 1; // variavéis para sistema funcionar
        while (numero_selecionado != 7) { // aqui ele vai funcionar até usuario não quiser jogar mais
            Console.Clear(); // limpa console após reniciar ou iniciar
            Random rdn = new Random(); // variavéis de criação do numero
            Random rdn2 = new Random(); // variavéis de criação do numero
            int numero_01 = rdn.Next(3000); // variavéis de criação do numero
            int numero_02 = rdn2.Next(300); // variavéis de criação do numero
            
            Console.WriteLine("Pergunta ["+i+"] Quanto é " + numero_01 +" + " + numero_02 + " ?"); // pergunta para usuario
            Console.Write("Resposta: "); // aqui vai ser onde usuario vai falar
            int Resposta = int.Parse(Console.ReadLine()); // aqui vai salvar numero respondido
            int Resposta_Calculo = numero_01 + numero_02; // aqui vai somar os numeros das variavéis da criação do número
            Console.Clear();// limpa console após soma e a resposta
            if(Resposta_Calculo == Resposta) { // aqui vai verificar se está correto
                Console.WriteLine("Você Acertou!!! Espere um pouco que proxima pergunta chega");// mensagem após usuario acertar
                i++; // vai somando quantidade de perguntas
                Thread.Sleep(6000);// vai criar tempo para sistema processar
                
            }
            else { // caso ele erra
                Console.WriteLine("Você errou :( Deseja continuar? (y/n)"); // vai mostrar mensagem que erro e se ele deseja continuar
                char escolha = char.Parse(Console.ReadLine()); // vai amazenar  se ele vai continuar
                if (escolha == 'y' || escolha == 'Y'){ // vai verificar se vai continuar
                    Console.Clear(); // limpa console caso se sim
                    Console.Write("Reniciando!!"); // time para processar sistema
                    i = 1; // renicia contagem de pergunta
                    Thread.Sleep(6000); // vai criar tempo para sistema processar
                } 
                else { // caso usuario não quiser
                        Console.Clear(); // limpa console
                        Console.WriteLine("Fim De Jogo!"); // mostra mensagem de fim de jogo
                        numero_selecionado = numero_selecionado + 7; // vai guardar mais 7 numero para while não funcionar
                    }
            }
        }
    }
}
