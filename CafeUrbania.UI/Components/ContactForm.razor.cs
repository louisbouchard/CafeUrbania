using CafeUrbania.Models;

namespace CafeUrbania.UI.Components;

public partial class ContactForm
{
    public Contact Contact { get; set; } = new Contact();

    public bool HasContacted = false;

    private async void HandleValidSubmit()
    {
        HasContacted = true;
        Contact = new();
    }
}
