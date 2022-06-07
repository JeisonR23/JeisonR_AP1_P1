
public class AportesBLL
{
    private Contexto _contexto;
    public AportesBLL(Contexto contexto)
    {
        this._contexto = contexto;

    }

    public bool Guardar(Aportes aporte)
    {
        if (!Existe(aporte.AporteId))
        {
            return Insertar(aporte);

        }
        else
        {
            return Modificar(aporte);
        }

    }
    public bool Existe(int aporteId)
    {
        return _contexto.Aportes.Any(a => a.AporteId == aporteId);
    }

    public bool Insertar(Aportes aporte)
    {
        _contexto.Aportes.Add(aporte);
        int cantidad = _contexto.SaveChanges();
        return cantidad > 0;

    }
    public bool Modificar(Aportes aporte)
    {
        _contexto.Entry(aporte).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        int cantidad = _contexto.SaveChanges();
        return cantidad > 0;

    }

    public bool Eliminar(Aportes aporte)
    {
        _contexto.Entry(aporte).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
        int cantidad = _contexto.SaveChanges();
        return cantidad > 0;

    }

    public Aportes Buscar(int aporteId)
    {
        var encontrado = _contexto.Aportes.Find(aporteId);
        return encontrado;
    }

    public List<Aportes> GetAportes()
    {
        return _contexto.Aportes.ToList();
    }

}