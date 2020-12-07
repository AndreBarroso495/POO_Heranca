namespace POO_Heranca.Classes
{
    //com : seguido do nome da superclasse, utilizamos a herança
    public class PessoaJuridica : Pessoa
    {
        public string cnpj;
        public string inscriscaoEstadual;

        public bool ValidarCNPJ(string documento){

            if(documento != ""){
            return true;
            }

            return false;

        }
    }
}