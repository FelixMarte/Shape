
using System.Collections.Generic;

public abstract class Persona
{
    public string Nombre { get; set; }

    public Persona(string nombre)
    {
        Nombre = nombre;
    }

    public string GetNombre()
    {
        return Nombre;
    }
}


public class Estudiante : Persona
{
    public int NumeroUnico { get; set; }

    public Estudiante(string nombre, int numeroUnico) : base(nombre)
    {
        NumeroUnico = numeroUnico;
    }

    public int GetNumeroUnico()
    {
        return NumeroUnico;
    }
}


public class Profesor : Persona
{
    public List<Curso> Cursos { get; set; } = new List<Curso>();

    public Profesor(string nombre) : base(nombre) { }

    public void AsignarCurso(Curso curso)
    {
        Cursos.Add(curso);
    }

    public List<Curso> ObtenerCursos()
    {
        return Cursos;
    }
}


public class Clase
{
    public string Identificador { get; set; }
    public List<Estudiante> Estudiantes { get; set; } = new List<Estudiante>();
    public List<Profesor> Profesores { get; set; } = new List<Profesor>();

    public Clase(string identificador)
    {
        Identificador = identificador;
    }

    public void AgregarEstudiante(Estudiante estudiante)
    {
        Estudiantes.Add(estudiante);
    }

    public void AgregarProfesor(Profesor profesor)
    {
        Profesores.Add(profesor);
    }

    public List<Estudiante> ObtenerEstudiantes()
    {
        return Estudiantes;
    }

    public List<Profesor> ObtenerProfesores()
    {
        return Profesores;
    }
}


public class Curso
{
    public string Nombre { get; set; }
    public int RecuentoClases { get; set; }
    public int RecuentoEjercicios { get; set; }

    public Curso(string nombre, int recuentoClases, int recuentoEjercicios)
    {
        Nombre = nombre;
        RecuentoClases = recuentoClases;
        RecuentoEjercicios = recuentoEjercicios;
    }

    public string ObtenerNombre()
    {
        return Nombre;
    }

    public int ObtenerRecuentoClases()
    {
        return RecuentoClases;
    }

    public int ObtenerRecuentoEjercicios()
    {
        return RecuentoEjercicios;
    }
}
