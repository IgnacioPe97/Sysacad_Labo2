using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    public class Serializacion
    {
        public  string rutaDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        /// <summary>
        /// Serializa una lista generica
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="listaGenerica">lista generica</param>
        /// <param name="nombreArchivo">nombre de archivo</param>
        public  void SerializarUnaLista<T>(List<T> listaGenerica, string nombreArchivo)
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


        public List<Estudiante> DeserializarUnaListaEstudianteJson<T>(string nombreArchivo,List<Curso>cursos)
        {
            string rutaCompleta = Path.Combine(rutaDesktop, "miCarpeta", nombreArchivo);

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

        private List<Estudiante> RetornaEstudianteJsonAEstudiante(List<EstudianteJson> estudiantesJson, List<Curso> cursos)
        {
            List<Estudiante> lista = new List<Estudiante>();
            foreach (EstudianteJson item in estudiantesJson)
            {
                lista.Add(Estudiante.ModificaEstudianteJsonAEstudiante(item, cursos));
            }
            return lista;
        }
        public List<Curso>DeserializarUnaDeCursos(string nombreArchivo)
        {
            string rutaCompleta = Path.Combine(rutaDesktop, "miCarpeta", nombreArchivo);
            try
            {
                if (File.Exists(rutaCompleta))
                {
                    string json = File.ReadAllText(rutaCompleta);
                    if (!string.IsNullOrEmpty(json))
                    {
                        List<Curso> listaDeserializada = JsonSerializer.Deserialize<List<Curso>>(json);
                        return listaDeserializada;
                    }
                    else
                    {
                        return new List<Curso>();
                    }
                    
                }
                else
                {
                    return new List<Curso>();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }



    }
}
