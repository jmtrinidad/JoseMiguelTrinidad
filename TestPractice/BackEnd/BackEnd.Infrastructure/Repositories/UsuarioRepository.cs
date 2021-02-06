namespace BackEnd.Infrastructure.Repositories
{
    using BackEnd.Core.Entities;
    using BackEnd.Core.Interfaces;
    using BackEnd.Infrastructure.Data;
    using Microsoft.Extensions.Configuration;
    using System.Data.SqlClient;

    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(DataContext context, IConfiguration configuration) : base(context,configuration)
        {
        }

        public void InsertWithAdot(Usuario usuario)
        {
            using (var conection= new SqlConnection(_conectionString))
            {
                conection.Open();
                var query = @$"INSERT INTO Usuarios(Nombres,Apellidos,Genero,Cedula,Fecha_Nacimiento,DepartamentoId,Cargo,Supervisor_Inmediato)
                                VALUES(@{nameof(Usuario.Nombres)},@{nameof(Usuario.Apellidos)},@{nameof(Usuario.Genero)},
                                @{nameof(Usuario.Cedula)},@{nameof(Usuario.Fecha_Nacimiento)},@{nameof(Usuario.DepartamentoId)},
                                @{nameof(Usuario.Cargo)}, @{nameof(Usuario.Supervisor_Inmediato)})";


                using (var command = new SqlCommand(query, conection))
                {
                    command.Parameters.AddWithValue($"@{nameof(Usuario.Nombres)}", usuario.Nombres);
                    command.Parameters.AddWithValue($"@{nameof(Usuario.Apellidos)}", usuario.Apellidos);
                    command.Parameters.AddWithValue($"@{nameof(Usuario.Genero)}", usuario.Genero);
                    command.Parameters.AddWithValue($"@{nameof(Usuario.Cedula)}", usuario.Cedula);
                    command.Parameters.AddWithValue($"@{nameof(Usuario.Fecha_Nacimiento)}", usuario.Fecha_Nacimiento);
                    command.Parameters.AddWithValue($"@{nameof(Usuario.DepartamentoId)}", usuario.DepartamentoId);
                    command.Parameters.AddWithValue($"@{nameof(Usuario.Cargo)}", usuario.Cargo);
                    command.Parameters.AddWithValue($"@{nameof(Usuario.Supervisor_Inmediato)}", usuario.Supervisor_Inmediato);

                    command.ExecuteNonQuery();
                }
               
            }
        }
    }
}
