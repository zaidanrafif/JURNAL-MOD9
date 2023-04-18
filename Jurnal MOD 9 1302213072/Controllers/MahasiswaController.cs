using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace modul9_1302210104.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        public static List<string> course = new List<string>
        {
            "KPL", "BD", "PBO"
        };

        public static List<Mahasiswa> mahasiswaList = new List<Mahasiswa>
        {
            new Mahasiswa ("Muhammad Zaidan Rafif","1302213072", course, 2019),
            new Mahasiswa ("Mhs 2","1302210032", course, 2019),
            new Mahasiswa ("Mhs 3","1302213088", course, 2019),
        };

        private readonly ILogger<MahasiswaController> _logger;

        public MahasiswaController(ILogger<MahasiswaController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "PostMahasiswa")]
        public void addMahasiswa([FromBody] Mahasiswa mhs)
        {

            mahasiswaList.Add(mhs);

        }

        [HttpGet(Name = "GetMahasiswa")]
        public List<Mahasiswa> Get()
        {
            return mahasiswaList;
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return mahasiswaList[id];

        }

        [HttpDelete(("{id}"))]
        public void deleteMahasiswaByIndex(int id)
        {
            if (id >= 0 && id < mahasiswaList.Count())
            {
                mahasiswaList.RemoveAt(id);
            }
            else
            {
                Console.WriteLine("Indeks tidak valid");
            }
        }

    }
}
