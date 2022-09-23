using Microsoft.Data.SqlClient.Server;
using Microsoft.EntityFrameworkCore;
using SoalA.Context;
using SoalA.Models;

namespace SoalA.Service
{
    public class BarangService : IBarangService
    {
        private readonly DatabaseContext context;

        public BarangService(DatabaseContext context)
        {
            this.context = context;
        }

        public void Delete(int id)
        {
            context.Database.ExecuteSqlRaw($"DeleteBarang {id}");
        }
        public IEnumerable<Barang> GetAllBySearch(string search)
        {
            var barangList = context.MS_Barang.FromSqlRaw($"GetBarangBySearch {search}").ToList();
            return barangList;
        }

        public void SaveOrUpdate(Barang barang)
        {
            string Tanggal = barang.Tanggal.ToString("yyyy-MM-dd");
            context.Database.ExecuteSqlRaw($"SaveOrUpdatebarang {barang.Id}, {barang.Nama_Barang}, {barang.Kode_Barang}, {barang.Jumlah_Barang}, '{Tanggal}'");
        }
    }
}
