namespace modul9_1302210104
{
    public class Mahasiswa
    {
        public string Name { get; set; }

        public string Nim { get; set; }

        public List<string> Course { get; set; }

        public int year { get; set; }

        public Mahasiswa() { }

        public Mahasiswa(string name, string nim, List<string> course, int year)
        {
            Name = name;
            Nim = nim;
            Course = course;
            this.year = year;
        }
    }
}