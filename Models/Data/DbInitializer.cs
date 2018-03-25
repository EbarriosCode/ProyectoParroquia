using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Models.Domain;

namespace Models
{
    public static class DbInitializer
    {
        public static void Initialize(ParroquiaDbContext context)
        {
            //context.Database.EnsureCreated();
            context.Database.Migrate();
            
            if (context.Departamento.Any())
            {
                return;
            }
            //Agregando Campos Al crear la Tabla Departamento
            var departamentos = new Departamento[]
            {
                new Departamento { NombreDepartamento = "Petén" },
                new Departamento { NombreDepartamento = "Huehuetenango" },
                new Departamento { NombreDepartamento = "Quiché" },
                new Departamento { NombreDepartamento = "Alta Verapaz" },
                new Departamento { NombreDepartamento = "Baja Verapaz" },
                new Departamento { NombreDepartamento = "San Marcos" },
                new Departamento { NombreDepartamento = "Quetzaltenango" },
                new Departamento { NombreDepartamento = "Totonicapán" },
                new Departamento { NombreDepartamento = "Sololá" },
                new Departamento { NombreDepartamento = "Retalhuleu" },
                new Departamento { NombreDepartamento = "Suchitepéquez" },
                new Departamento { NombreDepartamento = "Chimaltenango" },
                new Departamento { NombreDepartamento = "Sacatepéquez" },
                new Departamento { NombreDepartamento = "Guatemala" },
                new Departamento { NombreDepartamento = "Escuintla" },
                new Departamento { NombreDepartamento = "Santa Rosa" },
                new Departamento { NombreDepartamento = "Jutiapa" },
                new Departamento { NombreDepartamento = "Jalapa" },
                new Departamento { NombreDepartamento = "Chiquimula" },
                new Departamento { NombreDepartamento = "El Progreso" },
                new Departamento { NombreDepartamento = "Zacapa" },
                new Departamento { NombreDepartamento = "Izabal"}
            };

            foreach(Departamento d in departamentos)
            {
                context.Departamento.Add(d);
            }
            context.SaveChanges();


            if (context.Municipio.Any())
            {
                return;
            }

            var municipios = new Municipio[]
            {
                // Petén
                new Municipio { NombreMunicipio="Flores", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Petén").DepartamentoId},
                new Municipio { NombreMunicipio="Dolores", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Petén").DepartamentoId},
                new Municipio { NombreMunicipio="El Chal", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Petén").DepartamentoId},
                new Municipio { NombreMunicipio="La Libertad", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Petén").DepartamentoId},
                new Municipio { NombreMunicipio="Las Cruces", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Petén").DepartamentoId},
                new Municipio { NombreMunicipio="Melchor de Mencos", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Petén").DepartamentoId},
                new Municipio { NombreMunicipio="Poptún", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Petén").DepartamentoId},
                new Municipio { NombreMunicipio="San Andrés", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Petén").DepartamentoId},
                new Municipio { NombreMunicipio="San Benito", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Petén").DepartamentoId},
                new Municipio { NombreMunicipio="San Francisco", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Petén").DepartamentoId},
                new Municipio { NombreMunicipio="San José", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Petén").DepartamentoId},
                new Municipio { NombreMunicipio="San Luis", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Petén").DepartamentoId},
                new Municipio { NombreMunicipio="Santa Ana", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Petén").DepartamentoId},
                new Municipio { NombreMunicipio="Sayaxché", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Petén").DepartamentoId},

                //Huehuetenango
                new Municipio { NombreMunicipio="Huehuetenango", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Huehuetenango").DepartamentoId},
                new Municipio { NombreMunicipio="Aguacatán", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Huehuetenango").DepartamentoId},
                new Municipio { NombreMunicipio="Chiantla", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Huehuetenango").DepartamentoId},
                new Municipio { NombreMunicipio="Colotenango", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Huehuetenango").DepartamentoId},
                new Municipio { NombreMunicipio="Concepción Huista", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Huehuetenango").DepartamentoId},
                new Municipio { NombreMunicipio="Cuilco", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Huehuetenango").DepartamentoId},
                new Municipio { NombreMunicipio="Jacaltenango", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Huehuetenango").DepartamentoId},
                new Municipio { NombreMunicipio="La Democracia", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Huehuetenango").DepartamentoId},
                new Municipio { NombreMunicipio="La Libertad", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Huehuetenango").DepartamentoId},
                new Municipio { NombreMunicipio="Malacatancito", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Huehuetenango").DepartamentoId},
                new Municipio { NombreMunicipio="Nentón", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Huehuetenango").DepartamentoId},
                new Municipio { NombreMunicipio="San Antonio Huista", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Huehuetenango").DepartamentoId},
                new Municipio { NombreMunicipio="San Gaspar Ixchil", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Huehuetenango").DepartamentoId},
                new Municipio { NombreMunicipio="San Ildefonso Ixtahuacán", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Huehuetenango").DepartamentoId},
                new Municipio { NombreMunicipio="San Juan Atitán", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Huehuetenango").DepartamentoId},
                new Municipio { NombreMunicipio="San Juan Ixcoy", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Huehuetenango").DepartamentoId},
                new Municipio { NombreMunicipio="San Mateo Ixtatán", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Huehuetenango").DepartamentoId},
                new Municipio { NombreMunicipio="San Miguel Acatán", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Huehuetenango").DepartamentoId},
                new Municipio { NombreMunicipio="San Pedro Nécta", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Huehuetenango").DepartamentoId},
                new Municipio { NombreMunicipio="San Pedro Soloma", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Huehuetenango").DepartamentoId},
                new Municipio { NombreMunicipio="San Rafael La Independencia", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Huehuetenango").DepartamentoId},
                new Municipio { NombreMunicipio="San Rafael Pétzal", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Huehuetenango").DepartamentoId},
                new Municipio { NombreMunicipio="San Sebastián Coatán", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Huehuetenango").DepartamentoId},
                new Municipio { NombreMunicipio="San Sebastián Huehuetenango", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Huehuetenango").DepartamentoId},
                new Municipio { NombreMunicipio="Santa Ana Huista", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Huehuetenango").DepartamentoId},
                new Municipio { NombreMunicipio="Santa Bárbara", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Huehuetenango").DepartamentoId},
                new Municipio { NombreMunicipio="Santa Cruz Barillas", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Huehuetenango").DepartamentoId},
                new Municipio { NombreMunicipio="Santa Eulalia", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Huehuetenango").DepartamentoId},
                new Municipio { NombreMunicipio="Santiago Chimaltenango", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Huehuetenango").DepartamentoId},
                new Municipio { NombreMunicipio="Tectitán", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Huehuetenango").DepartamentoId},
                new Municipio { NombreMunicipio="Todos Santos Cuchumatán", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Huehuetenango").DepartamentoId},
                new Municipio { NombreMunicipio="Unión Cantinil", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Huehuetenango").DepartamentoId},
                new Municipio { NombreMunicipio="Santiago Petatán", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Huehuetenango").DepartamentoId},

                // Quiché
                new Municipio { NombreMunicipio="Santa Cruz del Quiché", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Quiché").DepartamentoId},
                new Municipio { NombreMunicipio="Canillá", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Quiché").DepartamentoId},
                new Municipio { NombreMunicipio="Chajul", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Quiché").DepartamentoId},
                new Municipio { NombreMunicipio="Chicamán", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Quiché").DepartamentoId},
                new Municipio { NombreMunicipio="Chiché", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Quiché").DepartamentoId},
                new Municipio { NombreMunicipio="Chichicastenango", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Quiché").DepartamentoId},
                new Municipio { NombreMunicipio="Chinique", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Quiché").DepartamentoId},
                new Municipio { NombreMunicipio="Cunén", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Quiché").DepartamentoId},
                new Municipio { NombreMunicipio="Ixcán", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Quiché").DepartamentoId},
                new Municipio { NombreMunicipio="Joyabaj", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Quiché").DepartamentoId},
                new Municipio { NombreMunicipio="Pachalum", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Quiché").DepartamentoId},
                new Municipio { NombreMunicipio="Patzité", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Quiché").DepartamentoId},
                new Municipio { NombreMunicipio="Sacapulas", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Quiché").DepartamentoId},
                new Municipio { NombreMunicipio="San Andrés Sajcabajá", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Quiché").DepartamentoId},
                new Municipio { NombreMunicipio="San Antonio Ilotenango", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Quiché").DepartamentoId},
                new Municipio { NombreMunicipio="San Bartolomé Jocotenango", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Quiché").DepartamentoId},
                new Municipio { NombreMunicipio="San Juan Cotzal", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Quiché").DepartamentoId},
                new Municipio { NombreMunicipio="San Pedro Jocopilas", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Quiché").DepartamentoId},
                new Municipio { NombreMunicipio="Santa María Nebaj", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Quiché").DepartamentoId},
                new Municipio { NombreMunicipio="Uspantán", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Quiché").DepartamentoId},
                new Municipio { NombreMunicipio="Zacualpa", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Quiché").DepartamentoId},

                // Alta Verapaz
                new Municipio { NombreMunicipio="Cobán", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Alta Verapaz").DepartamentoId},
                new Municipio { NombreMunicipio="Santa Cruz Verapaz", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Alta Verapaz").DepartamentoId},
                new Municipio { NombreMunicipio="San Cristóbal Verapaz", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Alta Verapaz").DepartamentoId},
                new Municipio { NombreMunicipio="Tactic", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Alta Verapaz").DepartamentoId},
                new Municipio { NombreMunicipio="Tamahú", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Alta Verapaz").DepartamentoId},
                new Municipio { NombreMunicipio="Tucurú", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Alta Verapaz").DepartamentoId},
                new Municipio { NombreMunicipio="Panzós", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Alta Verapaz").DepartamentoId},
                new Municipio { NombreMunicipio="Senahú", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Alta Verapaz").DepartamentoId},
                new Municipio { NombreMunicipio="San Pedro Carchá", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Alta Verapaz").DepartamentoId},
                new Municipio { NombreMunicipio="San Juan Chamelco", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Alta Verapaz").DepartamentoId},
                new Municipio { NombreMunicipio="Lanquín", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Alta Verapaz").DepartamentoId},
                new Municipio { NombreMunicipio="Santa María Cahabón", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Alta Verapaz").DepartamentoId},
                new Municipio { NombreMunicipio="Chisec", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Alta Verapaz").DepartamentoId},
                new Municipio { NombreMunicipio="Chahal", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Alta Verapaz").DepartamentoId},
                new Municipio { NombreMunicipio="Fray Bartolomé de las Casas", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Alta Verapaz").DepartamentoId},
                new Municipio { NombreMunicipio="Santa Catalina La Tinta", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Alta Verapaz").DepartamentoId},
                new Municipio { NombreMunicipio="Raxruha", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Alta Verapaz").DepartamentoId},                

                // Baja Verapaz
                new Municipio { NombreMunicipio="Cubulco", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Baja Verapaz").DepartamentoId},
                new Municipio { NombreMunicipio="Santa Cruz el Chol", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Baja Verapaz").DepartamentoId},
                new Municipio { NombreMunicipio="Granados", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Baja Verapaz").DepartamentoId},
                new Municipio { NombreMunicipio="Purulhá", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Baja Verapaz").DepartamentoId},
                new Municipio { NombreMunicipio="Rabinal", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Baja Verapaz").DepartamentoId},
                new Municipio { NombreMunicipio="Salamá", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Baja Verapaz").DepartamentoId},
                new Municipio { NombreMunicipio="San Miguel Chicaj", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Baja Verapaz").DepartamentoId},
                new Municipio { NombreMunicipio="San Jerónimo", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Baja Verapaz").DepartamentoId},

                // San Marcos
                new Municipio { NombreMunicipio="San Marcos", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "San Marcos").DepartamentoId},
                new Municipio { NombreMunicipio="Ayutla", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "San Marcos").DepartamentoId},
                new Municipio { NombreMunicipio="Catarina", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "San Marcos").DepartamentoId},
                new Municipio { NombreMunicipio="Comitancillo", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "San Marcos").DepartamentoId},
                new Municipio { NombreMunicipio="Concepción Tutuapa", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "San Marcos").DepartamentoId},
                new Municipio { NombreMunicipio="El Quetzal", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "San Marcos").DepartamentoId},
                new Municipio { NombreMunicipio="El Tumbador", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "San Marcos").DepartamentoId},
                new Municipio { NombreMunicipio="Esquipulas Palo Gordo", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "San Marcos").DepartamentoId},
                new Municipio { NombreMunicipio="Ixchiguán", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "San Marcos").DepartamentoId},
                new Municipio { NombreMunicipio="La Blanca", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "San Marcos").DepartamentoId},
                new Municipio { NombreMunicipio="La Reforma", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "San Marcos").DepartamentoId},
                new Municipio { NombreMunicipio="Malacatán", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "San Marcos").DepartamentoId},
                new Municipio { NombreMunicipio="Nuevo Progreso", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "San Marcos").DepartamentoId},
                new Municipio { NombreMunicipio="Ocós", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "San Marcos").DepartamentoId},
                new Municipio { NombreMunicipio="Pajapita", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "San Marcos").DepartamentoId},
                new Municipio { NombreMunicipio="Río Blanco", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "San Marcos").DepartamentoId},
                new Municipio { NombreMunicipio="S. Antonio Sacatepéquez", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "San Marcos").DepartamentoId},
                new Municipio { NombreMunicipio="San Cristóbal Cucho", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "San Marcos").DepartamentoId},
                new Municipio { NombreMunicipio="San José El Rodeo", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "San Marcos").DepartamentoId},                
                new Municipio { NombreMunicipio="San José Ojetenam", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "San Marcos").DepartamentoId},
                new Municipio { NombreMunicipio="San Lorenzo", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "San Marcos").DepartamentoId},
                new Municipio { NombreMunicipio="San Miguel Ixtahuacán", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "San Marcos").DepartamentoId},
                new Municipio { NombreMunicipio="San Pablo", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "San Marcos").DepartamentoId},
                new Municipio { NombreMunicipio="San Pedro Sacatepéquez", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "San Marcos").DepartamentoId},
                new Municipio { NombreMunicipio="San Rafael Pie de la Cuesta", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "San Marcos").DepartamentoId},
                new Municipio { NombreMunicipio="Sibinal", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "San Marcos").DepartamentoId},
                new Municipio { NombreMunicipio="Sipacapa", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "San Marcos").DepartamentoId},
                new Municipio { NombreMunicipio="Tacaná", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "San Marcos").DepartamentoId},
                new Municipio { NombreMunicipio="Tajumulco", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "San Marcos").DepartamentoId},
                new Municipio { NombreMunicipio="Tejutla", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "San Marcos").DepartamentoId},
                
                // Quetzaltenango
                new Municipio { NombreMunicipio="Quetzaltenango", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Quetzaltenango").DepartamentoId},
                new Municipio { NombreMunicipio="Almolonga", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Quetzaltenango").DepartamentoId},
                new Municipio { NombreMunicipio="Cabricán", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Quetzaltenango").DepartamentoId},
                new Municipio { NombreMunicipio="Cajolá", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Quetzaltenango").DepartamentoId},
                new Municipio { NombreMunicipio="Cantel", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Quetzaltenango").DepartamentoId},
                new Municipio { NombreMunicipio="Coatepeque", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Quetzaltenango").DepartamentoId},
                new Municipio { NombreMunicipio="Colomba Costa Cuca", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Quetzaltenango").DepartamentoId},
                new Municipio { NombreMunicipio="Concepción Chiquirichapa", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Quetzaltenango").DepartamentoId},
                new Municipio { NombreMunicipio="El Palmar", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Quetzaltenango").DepartamentoId},
                new Municipio { NombreMunicipio="Flores Costa Cuca", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Quetzaltenango").DepartamentoId},
                new Municipio { NombreMunicipio="Génova", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Quetzaltenango").DepartamentoId},
                new Municipio { NombreMunicipio="Huitán", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Quetzaltenango").DepartamentoId},
                new Municipio { NombreMunicipio="La Esperanza", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Quetzaltenango").DepartamentoId},
                new Municipio { NombreMunicipio="Olintepeque", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Quetzaltenango").DepartamentoId},
                new Municipio { NombreMunicipio="San Juan Ostuncalco", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Quetzaltenango").DepartamentoId},
                new Municipio { NombreMunicipio="Palestina de Los Altos", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Quetzaltenango").DepartamentoId},
                new Municipio { NombreMunicipio="Salcajá", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Quetzaltenango").DepartamentoId},
                new Municipio { NombreMunicipio="San Carlos Sija", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Quetzaltenango").DepartamentoId},
                new Municipio { NombreMunicipio="San Francisco La Unión", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Quetzaltenango").DepartamentoId},
                new Municipio { NombreMunicipio="San Martín Sacatepéquez", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Quetzaltenango").DepartamentoId},
                new Municipio { NombreMunicipio="San Mateo", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Quetzaltenango").DepartamentoId},
                new Municipio { NombreMunicipio="San Miguel Sigüilá", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Quetzaltenango").DepartamentoId},
                new Municipio { NombreMunicipio="Sibilia", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Quetzaltenango").DepartamentoId},
                new Municipio { NombreMunicipio="Zunil", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Quetzaltenango").DepartamentoId},

                // Totonicapán
                new Municipio { NombreMunicipio="Totonicapán", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Totonicapán").DepartamentoId},
                new Municipio { NombreMunicipio="San Cristóbal Totonicapán", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Totonicapán").DepartamentoId},
                new Municipio { NombreMunicipio="San Francisco El Alto", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Totonicapán").DepartamentoId},
                new Municipio { NombreMunicipio="San Andrés Xecul", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Totonicapán").DepartamentoId},
                new Municipio { NombreMunicipio="Momostenango", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Totonicapán").DepartamentoId},
                new Municipio { NombreMunicipio="Santa María Chiquimula", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Totonicapán").DepartamentoId},
                new Municipio { NombreMunicipio="Santa Lucía La Reforma", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Totonicapán").DepartamentoId},
                new Municipio { NombreMunicipio="San Bartolo", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Totonicapán").DepartamentoId},

                // Sololá 
                new Municipio { NombreMunicipio="Concepción", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Sololá").DepartamentoId},
                new Municipio { NombreMunicipio="Nahualá", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Sololá").DepartamentoId},
                new Municipio { NombreMunicipio="Panajachel", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Sololá").DepartamentoId},
                new Municipio { NombreMunicipio="San Andrés Semetabaj", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Sololá").DepartamentoId},
                new Municipio { NombreMunicipio="San Antonio Palopó", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Sololá").DepartamentoId},
                new Municipio { NombreMunicipio="San José Chacayá", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Sololá").DepartamentoId},
                new Municipio { NombreMunicipio="San Juan La Laguna", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Sololá").DepartamentoId},
                new Municipio { NombreMunicipio="San Lucas Tolimán", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Sololá").DepartamentoId},
                new Municipio { NombreMunicipio="San Marcos La Laguna", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Sololá").DepartamentoId},
                new Municipio { NombreMunicipio="San Pablo La Laguna", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Sololá").DepartamentoId},
                new Municipio { NombreMunicipio="San Pedro La Laguna", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Sololá").DepartamentoId},
                new Municipio { NombreMunicipio="Santa Catarina Ixtahuacan", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Sololá").DepartamentoId},
                new Municipio { NombreMunicipio="Santa Catarina Palopó", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Sololá").DepartamentoId},
                new Municipio { NombreMunicipio="Santa Clara La Laguna", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Sololá").DepartamentoId},
                new Municipio { NombreMunicipio="Santa Cruz La Laguna", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Sololá").DepartamentoId},
                new Municipio { NombreMunicipio="Santa Lucía Utatlán", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Sololá").DepartamentoId},
                new Municipio { NombreMunicipio="Santa María Visitación", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Sololá").DepartamentoId},
                new Municipio { NombreMunicipio="Santiago Atitlán", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Sololá").DepartamentoId},
                new Municipio { NombreMunicipio="Sololá", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Sololá").DepartamentoId},
                

                // Retalhuleu
                new Municipio { NombreMunicipio="Champerico", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Retalhuleu").DepartamentoId},
                new Municipio { NombreMunicipio="El Asintal", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Retalhuleu").DepartamentoId},                        
                new Municipio { NombreMunicipio="Nuevo San Carlos", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Retalhuleu").DepartamentoId},
                new Municipio { NombreMunicipio="Retalhuleu", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Retalhuleu").DepartamentoId},
                new Municipio { NombreMunicipio="San Andrés Villa Seca", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Retalhuleu").DepartamentoId},
                new Municipio { NombreMunicipio="San Felipe", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Retalhuleu").DepartamentoId},
                new Municipio { NombreMunicipio="San Martín Zapotitlán", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Retalhuleu").DepartamentoId},
                new Municipio { NombreMunicipio="San Sebastián", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Retalhuleu").DepartamentoId},
                new Municipio { NombreMunicipio="Santa Cruz Muluá", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Retalhuleu").DepartamentoId},
                                

                // Suchitepéquez
                new Municipio { NombreMunicipio="Chicacao", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Suchitepéquez").DepartamentoId},
                new Municipio { NombreMunicipio="Cuyotenango", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Suchitepéquez").DepartamentoId},
                new Municipio { NombreMunicipio="Mazatenango", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Suchitepéquez").DepartamentoId},
                new Municipio { NombreMunicipio="Patulul", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Suchitepéquez").DepartamentoId},
                new Municipio { NombreMunicipio="Pueblo Nuevo", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Suchitepéquez").DepartamentoId},
                new Municipio { NombreMunicipio="Río Bravo", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Suchitepéquez").DepartamentoId},
                new Municipio { NombreMunicipio="Samayac", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Suchitepéquez").DepartamentoId},
                new Municipio { NombreMunicipio="San Antonio Suchitepéquez", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Suchitepéquez").DepartamentoId},
                new Municipio { NombreMunicipio="San Bernardino", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Suchitepéquez").DepartamentoId},
                new Municipio { NombreMunicipio="San Francisco Zapotitlán", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Suchitepéquez").DepartamentoId},
                new Municipio { NombreMunicipio="San Gabriel", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Suchitepéquez").DepartamentoId},
                new Municipio { NombreMunicipio="San José El Ídolo", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Suchitepéquez").DepartamentoId},
                new Municipio { NombreMunicipio="San José La Máquina", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Suchitepéquez").DepartamentoId},
                new Municipio { NombreMunicipio="San Juan Bautista", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Suchitepéquez").DepartamentoId},
                new Municipio { NombreMunicipio="San Lorenzo", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Suchitepéquez").DepartamentoId},
                new Municipio { NombreMunicipio="San Miguel Panán", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Suchitepéquez").DepartamentoId},
                new Municipio { NombreMunicipio="San Pablo Jocopilas", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Suchitepéquez").DepartamentoId},
                new Municipio { NombreMunicipio="Santa Bárbara", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Suchitepéquez").DepartamentoId},
                new Municipio { NombreMunicipio="Santo Domingo Suchitepéquez", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Suchitepéquez").DepartamentoId},
                new Municipio { NombreMunicipio="Santo Tomás La Unión", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Suchitepéquez").DepartamentoId},
                new Municipio { NombreMunicipio="Zunilito", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Suchitepéquez").DepartamentoId},
                
                // Chimaltenango
                new Municipio { NombreMunicipio="Chimaltenango", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Chimaltenango").DepartamentoId},
                new Municipio { NombreMunicipio="San José Poaquíl", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Chimaltenango").DepartamentoId},
                new Municipio { NombreMunicipio="San Martín Jilotepeque", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Chimaltenango").DepartamentoId},
                new Municipio { NombreMunicipio="San Juan Comalapa", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Chimaltenango").DepartamentoId},
                new Municipio { NombreMunicipio="Santa Apolonia", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Chimaltenango").DepartamentoId},
                new Municipio { NombreMunicipio="Tecpán Guatemala", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Chimaltenango").DepartamentoId},
                new Municipio { NombreMunicipio="Patzún", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Chimaltenango").DepartamentoId},
                new Municipio { NombreMunicipio="Pochuta", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Chimaltenango").DepartamentoId},
                new Municipio { NombreMunicipio="Patzicía", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Chimaltenango").DepartamentoId},
                new Municipio { NombreMunicipio="Santa Cruz Balanyá", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Chimaltenango").DepartamentoId},
                new Municipio { NombreMunicipio="Acatenango", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Chimaltenango").DepartamentoId},
                new Municipio { NombreMunicipio="San Pedro Yepocapa", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Chimaltenango").DepartamentoId},
                new Municipio { NombreMunicipio="San Andrés Itzapa", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Chimaltenango").DepartamentoId},
                new Municipio { NombreMunicipio="Parramos", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Chimaltenango").DepartamentoId},
                new Municipio { NombreMunicipio="Zaragoza", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Chimaltenango").DepartamentoId},
                new Municipio { NombreMunicipio="El Tejar", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Chimaltenango").DepartamentoId},

                // Sacatepéquez
                new Municipio { NombreMunicipio="Alotenango", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Sacatepéquez").DepartamentoId},
                new Municipio { NombreMunicipio="La Antigua Guatemala", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Sacatepéquez").DepartamentoId},
                new Municipio { NombreMunicipio="Ciudad Vieja", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Sacatepéquez").DepartamentoId},
                new Municipio { NombreMunicipio="Jocotenango", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Sacatepéquez").DepartamentoId},
                new Municipio { NombreMunicipio="Magdalena Milpas Altas", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Sacatepéquez").DepartamentoId},
                new Municipio { NombreMunicipio="Pastores", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Sacatepéquez").DepartamentoId},
                new Municipio { NombreMunicipio="San Antonio Aguas Calientes", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Sacatepéquez").DepartamentoId},
                new Municipio { NombreMunicipio="San Bartolomé Milpas Altas", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Sacatepéquez").DepartamentoId},
                new Municipio { NombreMunicipio="San Lucas Sacatepéquez", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Sacatepéquez").DepartamentoId},
                new Municipio { NombreMunicipio="San Miguel Dueñas", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Sacatepéquez").DepartamentoId},
                new Municipio { NombreMunicipio="Santa Catarina Barahona", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Sacatepéquez").DepartamentoId},
                new Municipio { NombreMunicipio="Santa Lucía Milpas Altas", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Sacatepéquez").DepartamentoId},
                new Municipio { NombreMunicipio="Santa María de Jesús", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Sacatepéquez").DepartamentoId},
                new Municipio { NombreMunicipio="Santiago Sacatepéquez", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Sacatepéquez").DepartamentoId},
                new Municipio { NombreMunicipio="Santo Domingo Xenacoj", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Sacatepéquez").DepartamentoId},
                new Municipio { NombreMunicipio="Sumpango", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Sacatepéquez").DepartamentoId},

                // Guatemala
                new Municipio { NombreMunicipio="Guatemala", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Guatemala").DepartamentoId},
                new Municipio { NombreMunicipio="Santa Catarina Pinula", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Guatemala").DepartamentoId},
                new Municipio { NombreMunicipio="San José Pinula", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Guatemala").DepartamentoId},
                new Municipio { NombreMunicipio="San José Del Golfo", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Guatemala").DepartamentoId},
                new Municipio { NombreMunicipio="Palencia", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Guatemala").DepartamentoId},
                new Municipio { NombreMunicipio="Chinautla", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Guatemala").DepartamentoId},
                new Municipio { NombreMunicipio="San Pedro Ayampuc", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Guatemala").DepartamentoId},
                new Municipio { NombreMunicipio="Mixco", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Guatemala").DepartamentoId},
                new Municipio { NombreMunicipio="San Pedro Sacatepéquez", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Guatemala").DepartamentoId},
                new Municipio { NombreMunicipio="San Juan Sacatepéquez", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Guatemala").DepartamentoId},
                new Municipio { NombreMunicipio="Chuarrancho", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Guatemala").DepartamentoId},
                new Municipio { NombreMunicipio="Villa Nueva", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Guatemala").DepartamentoId},
                new Municipio { NombreMunicipio="Villa Canales", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Guatemala").DepartamentoId},
                new Municipio { NombreMunicipio="Amatitlán", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Guatemala").DepartamentoId},
                new Municipio { NombreMunicipio="Fraijanes", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Guatemala").DepartamentoId},
                new Municipio { NombreMunicipio="San Miguel Petapa", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Guatemala").DepartamentoId},
                new Municipio { NombreMunicipio="San Raymundo", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Guatemala").DepartamentoId},

                // Escuintla
                new Municipio { NombreMunicipio="Escuintla", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Escuintla").DepartamentoId},
                new Municipio { NombreMunicipio="Guanagazapa", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Escuintla").DepartamentoId},
                new Municipio { NombreMunicipio="Iztapa", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Escuintla").DepartamentoId},
                new Municipio { NombreMunicipio="La Democracia", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Escuintla").DepartamentoId},
                new Municipio { NombreMunicipio="La Gomera", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Escuintla").DepartamentoId},
                new Municipio { NombreMunicipio="Masagua", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Escuintla").DepartamentoId},
                new Municipio { NombreMunicipio="Nueva Concepción", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Escuintla").DepartamentoId},
                new Municipio { NombreMunicipio="Palín", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Escuintla").DepartamentoId},
                new Municipio { NombreMunicipio="San José", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Escuintla").DepartamentoId},
                new Municipio { NombreMunicipio="San Vicente Pacaya", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Escuintla").DepartamentoId},
                new Municipio { NombreMunicipio="Santa Lucia Cotzumalguapa", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Escuintla").DepartamentoId},
                new Municipio { NombreMunicipio="Siquinalá", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Escuintla").DepartamentoId},
                new Municipio { NombreMunicipio="Tiquisate", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Escuintla").DepartamentoId},                

                // Santa Rosa
                new Municipio { NombreMunicipio="Cuilapa", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Santa Rosa").DepartamentoId},
                new Municipio { NombreMunicipio="Casillas", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Santa Rosa").DepartamentoId},
                new Municipio { NombreMunicipio="Chiquimulilla", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Santa Rosa").DepartamentoId},
                new Municipio { NombreMunicipio="Guazacapán", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Santa Rosa").DepartamentoId},
                new Municipio { NombreMunicipio="Nueva Santa Rosa", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Santa Rosa").DepartamentoId},
                new Municipio { NombreMunicipio="Oratorio", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Santa Rosa").DepartamentoId},
                new Municipio { NombreMunicipio="Pueblo Nuevo Viñas", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Santa Rosa").DepartamentoId},
                new Municipio { NombreMunicipio="San Juan Tecuaco", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Santa Rosa").DepartamentoId},
                new Municipio { NombreMunicipio="San Rafaél Las Flores", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Santa Rosa").DepartamentoId},
                new Municipio { NombreMunicipio="Santa Cruz Naranjo", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Santa Rosa").DepartamentoId},
                new Municipio { NombreMunicipio="Santa María Ixhuatán", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Santa Rosa").DepartamentoId},
                new Municipio { NombreMunicipio="Santa Rosa de Lima", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Santa Rosa").DepartamentoId},
                new Municipio { NombreMunicipio="Taxisco", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Santa Rosa").DepartamentoId},
                new Municipio { NombreMunicipio="Barberena", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Santa Rosa").DepartamentoId},
                
                // Jutiapa
                new Municipio { NombreMunicipio="Jutiapa", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Jutiapa").DepartamentoId},
                new Municipio { NombreMunicipio="Agua Blanca", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Jutiapa").DepartamentoId},
                new Municipio { NombreMunicipio="Asunción Mita", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Jutiapa").DepartamentoId},
                new Municipio { NombreMunicipio="Atescatempa", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Jutiapa").DepartamentoId},
                new Municipio { NombreMunicipio="Comapa", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Jutiapa").DepartamentoId},
                new Municipio { NombreMunicipio="Conguaco", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Jutiapa").DepartamentoId},
                new Municipio { NombreMunicipio="El Adelantado", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Jutiapa").DepartamentoId},
                new Municipio { NombreMunicipio="El Progeso", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Jutiapa").DepartamentoId},
                new Municipio { NombreMunicipio="Jalpatagua", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Jutiapa").DepartamentoId},
                new Municipio { NombreMunicipio="Jerez", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Jutiapa").DepartamentoId},
                new Municipio { NombreMunicipio="Moyuta", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Jutiapa").DepartamentoId},
                new Municipio { NombreMunicipio="Pasaco", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Jutiapa").DepartamentoId},
                new Municipio { NombreMunicipio="Quesada", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Jutiapa").DepartamentoId},
                new Municipio { NombreMunicipio="San José Acatempa", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Jutiapa").DepartamentoId},
                new Municipio { NombreMunicipio="Santa Catarina Mita", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Jutiapa").DepartamentoId},
                new Municipio { NombreMunicipio="Yupiltepeque", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Jutiapa").DepartamentoId},
                new Municipio { NombreMunicipio="Zapotitlán", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Jutiapa").DepartamentoId},

                // Jalapa
                new Municipio { NombreMunicipio="Jalapa", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Jalapa").DepartamentoId},
                new Municipio { NombreMunicipio="Mataquescuintla", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Jalapa").DepartamentoId},
                new Municipio { NombreMunicipio="Monjas", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Jalapa").DepartamentoId},
                new Municipio { NombreMunicipio="San Pedro Pinula", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Jalapa").DepartamentoId},
                new Municipio { NombreMunicipio="San Luis Jilotepeque", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Jalapa").DepartamentoId},
                new Municipio { NombreMunicipio="San Manuel Chaparrón", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Jalapa").DepartamentoId},
                new Municipio { NombreMunicipio="San Carlos Alzatate", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Jalapa").DepartamentoId},

                // Chiquimula
                new Municipio { NombreMunicipio="Chiquimula", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Chiquimula").DepartamentoId},
                new Municipio { NombreMunicipio="Camotan", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Chiquimula").DepartamentoId},
                new Municipio { NombreMunicipio="Concepción las Minas", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Chiquimula").DepartamentoId},
                new Municipio { NombreMunicipio="Esquipulas", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Chiquimula").DepartamentoId},
                new Municipio { NombreMunicipio="Ipala", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Chiquimula").DepartamentoId},
                new Municipio { NombreMunicipio="Jocotan", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Chiquimula").DepartamentoId},
                new Municipio { NombreMunicipio="Olopa", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Chiquimula").DepartamentoId},
                new Municipio { NombreMunicipio="Quetzaltepeque", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Chiquimula").DepartamentoId},
                new Municipio { NombreMunicipio="San José La Arada", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Chiquimula").DepartamentoId},
                new Municipio { NombreMunicipio="San Juan Ermita", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Chiquimula").DepartamentoId},
                new Municipio { NombreMunicipio="San Jacinto", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Chiquimula").DepartamentoId},
                
                // El Progreso
                new Municipio { NombreMunicipio="Guastatoya", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "El Progreso").DepartamentoId},
                new Municipio { NombreMunicipio="Morazán", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "El Progreso").DepartamentoId},
                new Municipio { NombreMunicipio="El Jicaro", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "El Progreso").DepartamentoId},
                new Municipio { NombreMunicipio="San Agustin Acasaguastlán", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "El Progreso").DepartamentoId},
                new Municipio { NombreMunicipio="San Cristobal Acasaguastlán", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "El Progreso").DepartamentoId},
                new Municipio { NombreMunicipio="San Antonio La Paz", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "El Progreso").DepartamentoId},
                new Municipio { NombreMunicipio="Sanarate", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "El Progreso").DepartamentoId},
                new Municipio { NombreMunicipio="Sansare", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "El Progreso").DepartamentoId},

                // Zacapa
                new Municipio { NombreMunicipio="Cabañas", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Zacapa").DepartamentoId},
                new Municipio { NombreMunicipio="Estanzuela", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Zacapa").DepartamentoId},
                new Municipio { NombreMunicipio="Gualán", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Zacapa").DepartamentoId},
                new Municipio { NombreMunicipio="Huité", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Zacapa").DepartamentoId},
                new Municipio { NombreMunicipio="La Unión", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Zacapa").DepartamentoId},
                new Municipio { NombreMunicipio="Río Hondo", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Zacapa").DepartamentoId},
                new Municipio { NombreMunicipio="San Diego", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Zacapa").DepartamentoId},
                new Municipio { NombreMunicipio="San Jorge", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Zacapa").DepartamentoId},
                new Municipio { NombreMunicipio="Teculután", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Zacapa").DepartamentoId},
                new Municipio { NombreMunicipio="Usumatlán", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Zacapa").DepartamentoId},
                new Municipio { NombreMunicipio="Zacapa", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Zacapa").DepartamentoId},                

                // Izabal
                new Municipio { NombreMunicipio="Puerto Barrios", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Izabal").DepartamentoId},
                new Municipio { NombreMunicipio="El Estor", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Izabal").DepartamentoId},
                new Municipio { NombreMunicipio="Livingston", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Izabal").DepartamentoId},
                new Municipio { NombreMunicipio="Los Amates", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Izabal").DepartamentoId},
                new Municipio { NombreMunicipio="Morales", DepartamentoId = departamentos.Single(x => x.NombreDepartamento == "Izabal").DepartamentoId}

            };

            foreach(Municipio m in municipios)
            {
                context.Municipio.Add(m);
            }
            context.SaveChanges();
        }
    }
}
