namespace ClassesMetodos{
    
    struct Ponto {
        public int X {get;set;}
        public int Y {get;set;}

        public Ponto(int x, int y){
            X = x;
            Y = y;
        }

        public void MostrarCoordernada(){
            System.Console.WriteLine($"x:{X} y:{Y}");

        }
    }
    class Struct{
        public static void Executar(){

            Ponto ponto1 = new Ponto(2,4);
            ponto1.MostrarCoordernada();
            Ponto ponto2 = ponto1;
            ponto2.X = 10;
            ponto2.MostrarCoordernada();
            

        }
    }
}