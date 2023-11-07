namespace CityInfo.Services
{
    public class LocalMailService
    {
        private string _mailTo = "admin@example.com";
        private string _mailFrom = "noreply@example.com";


        public void Send(string subject, string message)
        {
            //send mail - output to console window
            Console.WriteLine($"Mail from {_mailFrom} to {_mailTo}, " +
                $"with {nameof(LocalMailService)}.");
            Console.WriteLine($"Subject: {subject}");
            Console.WriteLine($"Message: {message}");

        }
    }
}
