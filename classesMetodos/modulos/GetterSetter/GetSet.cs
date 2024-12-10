namespace ClassesMetodos{

    public class Automovel{
        private string Marca;
        private string Modelo;

        public Automovel(string marca,string modelo){
            Marca = marca;
            Modelo = modelo;
        }

        public Automovel(){

        }

        public string GetMarca(){
            return Marca;
        }

        public void SetMarca(string marca){
            Marca = marca;
        }
    }
    class GetSet{
        public static void Executar(){
            

        }
    }
}