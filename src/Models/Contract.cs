namespace src.Models;


public class Contract{

    public Contract()
    {
        this.DataCriação = DateTime.Now;
        this.CodigoContrato = "000000";
        this.valor = 0;
        this.pago = false;
        
    }
    public Contract(string CodigoContrato, double valor)
    {
            this.DataCriação = DataCriação;
            this.CodigoContrato = CodigoContrato ;
            this.valor = valor;
            this.pago = pago;
    }
public int id { get; set; }
public DateTime DataCriação { get; set; }
public string CodigoContrato { get; set; }
public double valor { get; set; }
public Boolean pago { get; set;}
public int pessoaId { get; set; }








    
}