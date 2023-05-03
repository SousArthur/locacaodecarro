
public class Program {
public static void Main(string[] args){

    Cliente cliente1 = new Cliente();
    cliente1.setNome("Arthur");
    cliente1.setRg("78956423");
    cliente1.setCpf("111.111.111-11");
    cliente1.setCnh("8467928872654");
    cliente1.setDataNascimento( new DateOnly(2004, 01, 01));
    cliente1.setEndereco("Rua A numero 1");
    cliente1.setTelefone("(62)3222-2222");


    Cliente cliente2 = new Cliente("Pedro",
     "7896325416","222.222.222-22", "356247896541", 
     new DateOnly(1990,12,31), "Avenida B numero 2", 
     "(62)3233-3333");

     printSimplificadoDadosCliente(cliente1);
     printSimplificadoDadosCliente(cliente2);

    }

    public static void printSimplificadoDadosCliente(Cliente cliente){
        Console.WriteLine("O nome do cliente é: " + cliente.getNome());
        Console.WriteLine("A cnh do cliente é: " + cliente.getCnh());
        Console.WriteLine("O telefone é: " + cliente.getTelefone());
    }
    
}
