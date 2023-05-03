public class Locacao{
    private DateOnly? dataLocacao;
    private DateOnly? dataDevolucao;
    
    public DateOnly getDataLocacao(){
        return (DateOnly) this.dataLocacao;
    }

    public void setDataLocacao(DateOnly dataLocacao){
        this.dataLocacao = dataLocacao;
    }

    public DateOnly getDataDevolucao(){
        return (DateOnly) this.dataDevolucao;
    }

    public void setDataDevolucao(DateOnly datadevolucao){
        this.dataDevolucao = dataDevolucao;
    }
}