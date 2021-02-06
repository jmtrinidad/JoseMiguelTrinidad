namespace BackEnd.Core.Interfaces
{
    using BackEnd.Core.Entities;
    using System.Threading.Tasks;

    public  interface IUsuarioRepository:IBaseRepository<Usuario>
    {
        bool InsertWithAdot(Usuario usuario); 
    }
}
