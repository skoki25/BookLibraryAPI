using BookLibraryAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Net.Mail;

namespace BookLibraryAPI.Services.Automatic
{
    public class AutomaticNoticeService : BackgroundService
    {
        private int executionCount = 0;
        private readonly ILogger<AutomaticNoticeService> _logger;
        private LibraryDbContext _context;
        private Timer _timer = null;

        public AutomaticNoticeService(ILogger<AutomaticNoticeService> logger)
        {
            _logger = logger;
            _context = new LibraryDbContext();
        }
        protected override Task ExecuteAsync(CancellationToken cancellationToken)
        {

            _timer = new Timer(DoWork, null, TimeSpan.Zero,
                TimeSpan.FromSeconds(60));

            return Task.CompletedTask;
        }

        private void DoWork(object? state)
        {
            var count = Interlocked.Increment(ref executionCount);

            _logger.LogInformation($"Timed Hosted Service is working. Count: {count}");

            List<BookBorrow> bookBorrowList = _context.BookBorrow.Where(x => x.ReturnDate < DateTime.Now && !x.IsReturned)
                .Include(x => x.Book)
                .Include(x => x.User)
                .ToList();

            List<User> userList = _context.User
                .Include(x => x.BookBorrow.Where(y => y.IsReturned && y.ReturnDate < DateTime.Now))
                .Where(y => y.BookBorrow.Count() > 0)
                .ToList();

            foreach (User user in userList)
            {

                string BodyText = @"<p>Library Notice dont returned item:</p>
                     <table style='table, th, td { border: 1px solid black; border-collapse: collapse; }'>
                        <tr>
                            <td>EAN</td><td>ISO</td><td>Title</td><td>Borrow Date</td><td>Return Date</td></tr>";
                foreach (BookBorrow bookBorrow in user.BookBorrow)
                {
                    Book book = _context.Book.Where(x => x.Id == bookBorrow.Id)
                            .Include(x => x.BookInfo)
                            .SingleOrDefault();
                    BodyText += $"<tr><td>{book.EanCode}</td><td>{book.ISO}</td><td>{book.BookInfo.Title}</td>";
                    BodyText += $"<td>{bookBorrow.BorrowDate.ToString("dd.mm.yyyy")}</td>";
                    BodyText += $"<td>{bookBorrow.ReturnDate.ToString("dd.mm.yyyy")}</td></tr>";

                }
                BodyText += "</table>";
                using (MailMessage mailMessage = new MailMessage())
                {
                    mailMessage.From = new MailAddress("adeveloper591@gmail.com");
                    mailMessage.To.Add(new MailAddress(user.Email));
                    mailMessage.Subject = "Notice non returned item";
                    mailMessage.Body = BodyText;
                    mailMessage.IsBodyHtml = true;



                    SmtpClient email = new SmtpClient
                    {
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        EnableSsl = true,
                        Host = "smtp.gmail.com",
                        Port = 587,
                        Credentials = new NetworkCredential("adeveloper591@gmail.com", "teno qosp uyna qkwg")
                    };


                    try
                    {
                        Console.WriteLine("Sending email...");
                        email.Send(mailMessage);
                        Console.WriteLine("Sucess");
                    }
                    catch (SmtpException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
        }
    }
}
