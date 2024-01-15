
namespace CafeUrbania.Models.Services;

public interface IContactService
{
    Task PostContact(Contact contact);
}