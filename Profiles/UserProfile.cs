using AutoMapper;
using DataTransferObjectIntro.Dtos;
using DataTransferObjectIntro.Entities;

namespace DataTransferObjectIntro.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDto>()
                .ForMember(dst => dst.CreditCardNumber,
                    map => map.MapFrom(src => this.FormatCreditCard(src.CreditCardNumber)));
        }

        private string FormatCreditCard(string creditCardNumber)
        {
            var lastCharacters = creditCardNumber.Substring(creditCardNumber.Length - 4);
            return $"xxxx-xxxx-xxxx-{lastCharacters}";
        }
    }
}