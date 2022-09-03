using Microsoft.AspNetCore.Mvc;
using src.Models;
using src.Persistence;
using Microsoft.EntityFrameworkCore;

namespace src.Controllers;


[ApiController] //anotação que é um api console
[Route("[controller]")]// rotar de acesso
public class PersonController : ControllerBase{
private DataBaseContext _context{get; set;}
public PersonController(DataBaseContext context)
{
    this._context = context;
}


[HttpGet]
    public ActionResult<List<Person>> Get(){
       // Person pessoa = new Person("James", 38, "123456789");
       // Contract novoContrato = new Contract("loc000001",1.500);
      //  pessoa.contratosAtivos.Add(novoContrato);
      var resultado = _context.Pessoas.Include(campoTabela => campoTabela.contratosAtivos).ToList();
        if(!resultado.Any()){
        
            return  NoContent();
        }
        return Ok(resultado);
    }
[HttpPost]
    public Person Post(Person pessoa){
        _context.Pessoas.Add(pessoa);
        _context.SaveChanges();
        return pessoa;
    }
[HttpPut("{id}")]
public ActionResult<object> Update([FromRoute]int id, [FromBody]Person pessoa){
    _context.Pessoas.Update(pessoa);
    _context.SaveChanges();
    return "Dados do id" + id + "Atualizados";
}
[HttpDelete("{id}")]
public ActionResult<Object> Delete([FromRoute]int id){
    var resultado = _context.Pessoas.SingleOrDefault(campoTabela => campoTabela.id == id);
    if(resultado is null){
            return BadRequest(new {
                 msg = "Id não existe",
                 Status = "400"
            });
           
    }
        _context.Pessoas.Remove(resultado);
        _context.SaveChanges();
    return Ok("Deletado pessoa de Id:"+resultado);
}
}