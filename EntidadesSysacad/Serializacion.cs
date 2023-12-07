using EntidadesSysacad;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace LogicaDeNegocio
{
    public class Serializacion
    {
        public  string rutaDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public event EventHandler<string> ArchivoNoEncontrado;
        private const string nombreArchivoEstudiantes = "EstudiantesJson.json";
        private const string nombreArchivoAdministradores = "Administradores.json";
        private const string nombreArchivoCursos = "CursosJson.json";




        /// <summary>
        /// Serializa una lista generica
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="listaGenerica">lista generica</param>
        /// <param name="nombreArchivo">nombre de archivo</param>
        public void SerializarUnaLista<T>(List<T> listaGenerica, string nombreArchivo)
        {
            try
            {
                if (listaGenerica is not null && nombreArchivo is not null)
                {
                    JsonSerializerOptions jsonOption = new JsonSerializerOptions()
                    { WriteIndented = true, ReferenceHandler = ReferenceHandler.IgnoreCycles};
                    string rutaCompleta = Path.Combine(rutaDesktop, "miCarpeta", nombreArchivo);
                    string json = JsonSerializer.Serialize(listaGenerica, jsonOption);
                    File.WriteAllText(rutaCompleta, json);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public  List<T> DeserializarUnaLista<T>(string nombreArchivo)
        {
            string rutaCompleta = Path.Combine(rutaDesktop, "miCarpeta", nombreArchivo);
            try
            {
                if (File.Exists(rutaCompleta))
                {
                    string json = File.ReadAllText(rutaCompleta);
                    if (!string.IsNullOrEmpty(json))
                    {
                        List<T> listaDeserializada = JsonSerializer.Deserialize<List<T>>(json);
                        return listaDeserializada;
                    }
                    else
                    {
                       return new List<T>();
                    }
                    
                }
                else
                {
                    return new List<T>();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        public List<Estudiante> DeserializarUnaListaEstudianteJson<T>(List<Curso>cursos)
        {
            string rutaCompleta = Path.Combine(rutaDesktop, "miCarpeta", nombreArchivoEstudiantes);
            try
            {
                if (File.Exists(rutaCompleta))
                {
                    string json = File.ReadAllText(rutaCompleta);
                    if (!string.IsNullOrEmpty(json))
                    {
                        List<EstudianteJson> listaDeserializada = JsonSerializer.Deserialize<List<EstudianteJson>>(json);
                        if (listaDeserializada is not null)
                        {
                            List<Estudiante> listaEstudiante = RetornaEstudianteJsonAEstudiante(listaDeserializada, cursos);
                            return listaEstudiante;
                        }
                    }
                    else
                    {
                        return new List<Estudiante>();
                    }

                }
                return new List<Estudiante>();
            }
            catch (Excepciones) 
            {
                
                throw new Excepciones("El archivo no se encontró en la ruta especificada: " + rutaCompleta);

            }
        }
        public Estudiante ObtieneEstudianteDeLista(List<Curso> cursos,string mail, string contra)
        {
            string rutaCompleta = Path.Combine(rutaDesktop, "miCarpeta", nombreArchivoEstudiantes);
            Estudiante estudiante;
           
                if (File.Exists(rutaCompleta))
                {
                    string json = File.ReadAllText(rutaCompleta);
                    if (!string.IsNullOrEmpty(json))
                    {
                        List<EstudianteJson> listaDeserializada = JsonSerializer.Deserialize<List<EstudianteJson>>(json);
                        if (listaDeserializada is not null)
                        {
                            estudiante = RetornaUnEstudianteDesdeJson(listaDeserializada, cursos, mail, contra);
                            return estudiante;
                        }
                    }
                }
                else
                {
                    ArchivoNoEncontrado?.Invoke(this, "El archivo no se encuentra");
                }
            return null;
        }
           

        

        private List<Estudiante> RetornaEstudianteJsonAEstudiante(List<EstudianteJson> estudiantesJson, List<Curso> cursos)
        {
            List<Estudiante> lista = new List<Estudiante>();
            foreach (EstudianteJson item in estudiantesJson)
            {
                lista.Add(Estudiante.ModificaEstudianteJsonAEstudiante(item, cursos));
            }
            return lista;
        }
        private Estudiante RetornaUnEstudianteDesdeJson(List<EstudianteJson> estudiantesJson, List<Curso> cursos, string email, string contrasenia)
        {

            foreach (EstudianteJson item in estudiantesJson)
            {
                if (Hash.ValidaContrasenia(contrasenia,item.Contrasenia) && item.Correo.Equals(email))
                {
                    return Estudiante.ModificaEstudianteJsonAEstudiante(item, cursos);
                }
            }
            return null;
        }
        public List<CursoJson>DeserializarListaDeCursos()
        {
            string rutaCompleta = Path.Combine(rutaDesktop, "miCarpeta", nombreArchivoCursos);
            try
            {
                if (File.Exists(rutaCompleta))
                {
                    string json = File.ReadAllText(rutaCompleta);
                    if (!string.IsNullOrEmpty(json))
                    {
                        List<CursoJson> listaDeserializada = JsonSerializer.Deserialize<List<CursoJson>>(json);
                        return listaDeserializada;
                    }
                    else
                    {
                        return new List<CursoJson>();
                    }
                    
                }
                else
                {
                    return new List<CursoJson>();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }



    }
}
