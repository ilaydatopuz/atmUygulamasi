using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Kullanıcı doğrulaması
        Console.Write("Kullanıcı adını girin: ");
        string username = Console.ReadLine();

        if (!IsUserValid(username))
        {
            Console.WriteLine("Geçersiz kullanıcı. Lütfen kayıtlı bir kullanıcı adı girin.");
            return;
        }

        Console.WriteLine($"Hoş geldiniz, {username}!");

        // İşlem listesi
        List<string> transactions = new List<string>
        {
            "Para Çekme",
            "Para Yatırma",
            "Ödeme Yapma"
            // İsteğe bağlı olarak işlem listesi genişletilebilir
        };

        Console.WriteLine("Mevcut işlemler:");
        DisplayTransactions(transactions);

        Console.Write("\nYapmak istediğiniz işlemi seçin: ");
        string selectedTransaction = Console.ReadLine();

        if (!transactions.Contains(selectedTransaction))
        {
            Console.WriteLine("Geçersiz işlem. Lütfen listeden bir işlem seçin.");
            return;
        }

        Console.WriteLine($"{selectedTransaction} işlemi seçildi. İşlem gerçekleştiriliyor...");

        // Simule edilen gün sonu işlemleri
        SimulateEndOfDay();

        Console.WriteLine("İşlem tamamlandı.");
    }

    static bool IsUserValid(string username)
    {
        // Kullanıcı doğrulama simülasyonu
        // Sistemde kayıtlı kullanıcı adları
        string[] registeredUsers = { "user1", "user2", "user3" };

        return Array.Exists(registeredUsers, user => user == username);
    }

    static void DisplayTransactions(List<string> transactions)
    {
        foreach (var transaction in transactions)
        {
            Console.WriteLine(transaction);
        }
    }

    static void SimulateEndOfDay()
    {
        // Simüle edilen gün sonu işlemleri
        // Burada gün sonu işlemleri yapılabilir ve loglar bir dosyaya yazılabilir

        string[] logs = { "Transaction1 log...", "Transaction2 log...", "Transaction3 log..." };

        Console.WriteLine("Gün sonu işlemleri:");

        foreach (var log in logs)
        {
            Console.WriteLine(log);
        }

        // Dosyaya yazma (gün sonu loglarını dosyaya yazma)
        WriteLogsToFile(logs);
    }

    static void WriteLogsToFile(string[] logs)
    {
        string date = DateTime.Now.ToString("ddMMyyyy");
        string fileName = $"EOD_{date}.txt";

        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var log in logs)
                {
                    writer.WriteLine(log);
                }
            }

            Console.WriteLine($"Gün sonu logları {fileName} dosyasına yazıldı.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Dosyaya yazma hatası: " + ex.Message);
        }
    }
}
