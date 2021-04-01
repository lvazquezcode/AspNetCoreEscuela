using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MvcWebTest.Models;

namespace MvcWebTest.Context
{
    public class EscuelaContext : DbContext
    {
        public DbSet<Escuela> Escuelas { get; set; }
        public DbSet<Asignatura> Asignaturas { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Evaluación> Evaluaciones { get; set; }

        public EscuelaContext(DbContextOptions<EscuelaContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var escuela = new Escuela()
            {
                Id = Guid.NewGuid().ToString(),
                Nombre = "Escuela Pepe Grillo",
                AñoDeCreación = 2021,
                Dirección = "Dirección de Prueba",
                Ciudad = "CDMX",
                Pais = "México",
                TipoEscuela = TiposEscuela.Primaria
            };
            modelBuilder.Entity<Escuela>().HasData(escuela);

            ///Cargar Cursos de la Escuela
            var Cursos = CargarCursos(escuela);
            modelBuilder.Entity<Curso>().HasData(Cursos.ToArray());

            ///X cada curso cargar Asignaturas
            var asignaturas = CargarAsignaturas(Cursos);
            modelBuilder.Entity<Asignatura>().HasData(asignaturas.ToArray());

            ///X cada curso cargar Alumnos
            var alumnos = CargarAlumnos(Cursos);
            modelBuilder.Entity<Alumno>().HasData(alumnos.ToArray());
        }

        private static List<Asignatura> CargarAsignaturas(List<Curso> Cursos)
        {
            List<Asignatura> listaAsignaturas = new List<Asignatura>();

            foreach (var curso in Cursos)
            {
                var cursosTemp = new List<Asignatura>()
                                    {
                                        new Asignatura()
                                        {
                                            Id = Guid.NewGuid().ToString(),
                                            CursoId = curso.Id,
                                            Nombre = "Matematicas"
                                        },
                                        new Asignatura()
                                        {
                                            Id = Guid.NewGuid().ToString(),
                                            CursoId = curso.Id,
                                            Nombre = "Ingles"
                                        },
                                        new Asignatura()
                                        {
                                            Id = Guid.NewGuid().ToString(),
                                            CursoId = curso.Id,
                                            Nombre = "Educación Fisica"
                                        },
                                        new Asignatura()
                                        {
                                            Id = Guid.NewGuid().ToString(),
                                            CursoId = curso.Id,
                                            Nombre = "Español"
                                        },
                                        new Asignatura()
                                        {
                                            Id = Guid.NewGuid().ToString(),
                                            CursoId = curso.Id,
                                            Nombre = "Ciencias Naturales"
                                        }
                                    };

                listaAsignaturas.AddRange(cursosTemp);
                //curso.Asignaturas = cursosTemp;
            }

            return listaAsignaturas;
        }

        private static List<Curso> CargarCursos(Escuela escuela)
        {
            return new List<Curso>(){
                        new Curso(){
                                Id = Guid.NewGuid().ToString(),
                                EscuelaId = escuela.Id,
                                Nombre = "101",
                                Jornada = TiposJornada.Mañana,
                                Dirección = "Test Address"
                            },
                        new Curso() {
                                Id = Guid.NewGuid().ToString(),
                                EscuelaId = escuela.Id,
                                Nombre = "201",
                                Jornada = TiposJornada.Mañana,
                                Dirección = "Test Address"
                            },
                        new Curso{
                                Id = Guid.NewGuid().ToString(),
                                EscuelaId = escuela.Id,
                                Nombre = "301",
                                Jornada = TiposJornada.Mañana,
                                Dirección = "Test Address"
                            },
                        new Curso(){
                                Id = Guid.NewGuid().ToString(),
                                EscuelaId = escuela.Id,
                                Nombre = "401",
                                Jornada = TiposJornada.Tarde,
                                Dirección = "Test Address"
                            },
                        new Curso() {
                                Id = Guid.NewGuid().ToString(),
                                EscuelaId = escuela.Id,
                                Nombre = "501",
                                Jornada = TiposJornada.Tarde,
                                Dirección = "Test Address"
                            }
                    };
        }

        private List<Alumno> GenerarAlumnosAlAzar(Curso curso, int cantidad)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno
                               {
                                   Nombre = $"{n1} {n2} {a1}",
                                   Id = Guid.NewGuid().ToString(),
                                   CursoId = curso.Id
                               };

            return listaAlumnos.OrderBy((al) => al.Id).Take(cantidad).ToList();
        }

        private List<Alumno> CargarAlumnos(List<Curso> Cursos)
        {
            var listaAlumnos = new List<Alumno>();

            Random rnd = new Random();

            foreach (var curso in Cursos)
            {
                int cantRandom = rnd.Next(5, 20);
                var listaAlumnosTemp = GenerarAlumnosAlAzar(curso, cantRandom);
                listaAlumnos.AddRange(listaAlumnosTemp);
            }

            return listaAlumnos;
        }
    }
}