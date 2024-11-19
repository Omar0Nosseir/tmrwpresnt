using tmrwpresnt.Data;
using tmrwpresnt.Dto;
using tmrwpresnt.Models;

namespace tmrwpresnt.Repos.PayemntCardRepos
{

    public class PaymentCardDto : IPaymentCardRepo
    {
        private readonly AppDbContext _context;

        public PaymentCardDto(AppDbContext context)
        {
            _context = context;
        }

        public void Add(PaymentCardDto catdto)
        {
            var pay = new PaymentCard
            {
                Cardname = pay.Cardname,
                Cardnumber = pay.Cardnumber,
                Expiredate = pay.Expiredate,
                Users = pay.Users.Select(x => new User
                {
                    Name = x.Name,
                    Email = x.Email,
                    Password = x.Password,
                    Products = x.Products.Select(x => new Product
                    {
                        Name = x.Name,
                        price = x.Price,
                    }).ToList(),

                }).ToList()

            };
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<PaymentCardDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public PaymentCardDto? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(PaymentCardDto catdto)
        {
            throw new NotImplementedException();
        }
    }
}

