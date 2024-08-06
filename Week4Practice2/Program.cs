using Week4Practice2;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("-----Parametresiz CTOR------");

        Baby baby1 = new Baby();                                    //Parametresin ctor da nesnenin bilgileri tanımlandı ve bilgilerin yazılması için gerekli motot çağırıldı.
        baby1.Name = "Ali";
        baby1.LastName = "Çakıroğlu";
        baby1.InfoBaby();
       


        Console.WriteLine("-----Parametreli CTOR-------");

        Baby baby2 = new Baby("merve","akkoyunlu");                 //Parametreli ctor olduğu için parametreler tanımlandı ve bilgilerin yazılması için gerekli motot çağırıldı.
        baby2.InfoBaby();
    }
}