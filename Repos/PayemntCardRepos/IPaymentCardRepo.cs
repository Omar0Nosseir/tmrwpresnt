using tmrwpresnt.Dto;

namespace tmrwpresnt.Repos.PayemntCardRepos
{
    public interface IPaymentCardRepo
    {
        PaymentCardDto? GetById(int id);
        List<PaymentCardDto> GetAll();

        void Add(PaymentCardDto catdto);
        bool Update(PaymentCardDto catdto);
        void Delete(int id);
    }
}
