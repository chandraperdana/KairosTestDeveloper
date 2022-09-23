using SoalA.Models;

namespace SoalA.Service
{
    public interface IBarangService
    {
        IEnumerable<Barang> GetAllBySearch(string search);
        void SaveOrUpdate(Barang barang);
        void Delete(int id);
    }
}
