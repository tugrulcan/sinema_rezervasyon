namespace LinkedListImplementation
{
    public class Musteri
    {
        public int koltukNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public override string ToString()
        {
            return Ad + " " + Soyad + " Koltuk Numarasi: " + koltukNo;
        }
    }
}