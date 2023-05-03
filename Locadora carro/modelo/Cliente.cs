

public class Cliente {
    private string? nome;
    private string? rg;
    private string? cpf;
    private string? cnh;
    private DateOnly? dataNascimento;
    private string? endereco;
    private string? telefone;

    public string getNome(){
        return this.nome;
    }

    public void setNome(string nome){
        this.nome = nome;
    }

    public string getRg(){
        return this.rg;
    }

    public void setRg(string rg){
        this.rg = rg;
    }

    public string getCpf(){
        return this.cpf;
    }

    public void setCpf(string cpf){
        this.cpf = cpf;
    }

    public string getCnh(){
        return this.cnh;
    }

    public void setCnh(string cnh){
        this.cnh = cnh;
    }

    public DateOnly getDataNascimento(){
        return (DateOnly) this.dataNascimento;
    }

    public void setDataNascimento(DateOnly dataNascimento){
        this.dataNascimento = dataNascimento;
    }

    public string getEndereco(){
        return this.endereco;
    }

    public void setEndereco(string endereco){
        this.endereco = endereco;
    }

    public string getTelefone(){
        return this.telefone;
    }

    public void setTelefone(string telefone){
        this.telefone = telefone;
    }

    public Cliente(){}

    public Cliente( string nome, string rg, string cpf,
    string cnh, DateOnly dataNascimento, string endereco, 
    string telefone){
        this.nome = nome;
        this.rg = rg;
        this.cpf = cpf;
        this.cnh = cnh;
        this.dataNascimento = dataNascimento;
        this.endereco = endereco;
        this.telefone = telefone;
    }

}