public class Carro{
    private string? modelo;

    private string? marca;

    private string? placa;

    private string? chassi;

    private DateOnly? anoFabricacao;
    private DateOnly? anoModel;
    private string? cor;

    public string getModelo(){
        return this.modelo;
    }
    public void seModelo(string modelo){
        this.modelo = modelo;
    }

     public string getMarca(){
        return this.marca;
    }

     public void setModelo(string marca){
        this.marca = marca;
    }

    public string getPlaca(){
        return this.placa;
    }

    public void setPlaca(string placa){
        this.placa = placa;
    }

    public string getChassi(){
        return this.chassi;
    }

    public void setChassi(string chassi){
        this.chassi = chassi;
    }

    public DateOnly getAnoFabricacao(){
        return (DateOnly) this.anoFabricacao;
    }

    public void  setAnoFabricacao(DateOnly anoFabricacao){
        this.anoFabricacao = anoFabricacao;
    }

    public DateOnly getAnoModel(){
        return (DateOnly) this.anoModel;
    }

    public void setAnoModel(DateOnly anoModel){
        this.anoModel = anoModel;
    }

    public string getCor(){
        return this.cor;
    }

    public void setCor(string cor){
        this.cor = cor;
    }
}