namespace LinkedListImplementation
{
    public class Koltuk
    {
        public int koltukNo { get; set; }
        public bool rezerveEdilebilirMi { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public override string ToString()
        {
            return Ad + " " + Soyad + " Koltuk Numarasi: " + koltukNo + " Rezerve edilebilir mi: " + rezerveEdilebilirMi;
        }
    }
}