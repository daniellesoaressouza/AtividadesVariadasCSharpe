using System;

namespace jogo
{
    class GameManager
    {
        static void Main(string[] args)
        {
            Player P1, P2;
            P1 = new Player();
            P2 = new Player();

            //Cada iteração do while será um turno para cada personagem
            //Cada personagem deve escolher entre ataque normal e magia
            //Um personagem não pode atacar se estiver morto
            Console.WriteLine("Jogador 1 do tipo: " + P1.Tipo);
            Console.WriteLine("Jogador 2 do tipo: " + P2.Tipo);

            while (P1.vivo && P2.vivo)
            {
                Console.WriteLine("Primeiro turno: Jogador 1");
                if (P1.vivo)
                {
                    Console.WriteLine("Vida: " + P1.vida);
                    Console.WriteLine("Mana: " + P1.mana);

                    Console.WriteLine("Deseja atacar ou usar magia?");
                    string poder = Console.ReadLine();

                    if (poder == "atacar")
                    {
                        P1.Atacar(P2);
                        Console.WriteLine("\nVida inimigo: " + P2.vida);
                    }
                    else if (poder == "magia")
                    {
                        P1.Magia(P2);
                        Console.WriteLine("\nVida inimigo: " + P2.vida);
                    }
                }
                    Console.WriteLine("\nSegundo turno: Jogador 2");
                    if (P1.vivo)
                    {
                        Console.WriteLine("Vida: " + P2.vida);
                        Console.WriteLine("Mana: " + P2.mana);

                        Console.WriteLine("\nDeseja atacar ou usar magia?");
                        string poder = Console.ReadLine();

                        if (poder == "atacar")
                        {
                            P2.Atacar(P1);
                            Console.WriteLine("\nVida inimigo: " + P1.vida);
                        }
                        else if (poder == "magia")
                        {
                            P2.Magia(P1);
                            Console.WriteLine("\nVida inimigo: " + P1.vida);
                        }


                    }
                //Mostrar a quantidade de vida e mana
                //Perguntar se ele deseja atacar ou usar magia


                //Turno do jogador 2
                //Se o jogador 2 estiver vivo 
                //Mostrar a quantidade de vida e mana
                //Perguntar se ele deseja atacar ou usar magia

            }
            if (P1.vivo)
            {
                Console.WriteLine("Jogador 1 venceu");
            }
            else if (P2.vivo)
            {
                Console.WriteLine("Jogador 2 venceu");
            }

        }
    }

    public class Player
    {
        public int vida = 100;
        public int mana = 20;
        int Ataque = 10;
        int AtaqueMagico = 25;

        public bool vivo = true;


        //Pode ser Fogo, Agua e Planta
        //Agua +28% de dano a mais em fogo
        //Agua - 33% em Planta

        //Fogo -25% em Agua
        //Fogo +37% em Planta

        //Planta + 20% em Agua
        //Planta - 40% em Fogo
        public string Tipo;

        public Player()
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            int Num = rnd.Next(1, 4);
            switch (Num)
            {
                case 1:
                    Tipo = "Agua";
                    break;

                case 2:
                    Tipo = "Fogo";
                    break;

                case 3:
                    Tipo = "Planta";
                    break;
            }
        }

        public void TomarDano(int Dano)
        {
            if (vida - Dano < 0)
            {
                vida = 0;
                vivo = false;
            }
            else
                vida -= Dano;
        }

        public void Atacar(Player inimigo)
        {
            //Verifica se o proprio tipo é de agua
            if (Tipo == "Agua")
            {
                //Se o proprio tipo for de agua e o do inimigo de fogo + 28% de dano
                if (inimigo.Tipo == "Fogo")
                    inimigo.TomarDano(Ataque + 28 * Ataque / 100);
                //Se o proprio tipo for de agua e o do inimigo de planta - 33% de dano
                else if (inimigo.Tipo == "Planta")
                    inimigo.TomarDano(Ataque - 33 * Ataque / 100);
            }
            else if (Tipo == "Fogo")
            {
                if (inimigo.Tipo == "Agua")
                    inimigo.TomarDano(Ataque - 25 * Ataque / 100);

                else if (inimigo.Tipo == "Planta")
                    inimigo.TomarDano(Ataque + 37 * Ataque / 100);
            }
            else if (Tipo == "Planta")
            {
                if (inimigo.Tipo == "Agua")
                    inimigo.TomarDano(Ataque + 20 * Ataque / 100);

                else if (inimigo.Tipo == "Fogo")
                    inimigo.TomarDano(Ataque - 40 * Ataque / 100);
            }
            else
                inimigo.TomarDano(Ataque);
        }

        public void Magia(Player inimigo)
        {
            if (mana - 6 >= 0)
            {
                mana -= 6;
                inimigo.TomarDano(AtaqueMagico);
            }
        }
    }
}
