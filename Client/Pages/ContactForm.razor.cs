using Microsoft.AspNetCore.Components;

namespace ContactManager.Client.Pages
{
    public partial class ContactForm
    {
        [Parameter] public int ContactId { get; set; }
        private Contact contact = new Contact();

        protected override void OnParametersSet()
        {
            if (ContactId != 0)
            {
                var existingContact = ContactService.Get(ContactId);
                if (existingContact != null)
                {
                    contact = new Contact
                    {
                        Id = existingContact.Id,
                        FirstName = existingContact.FirstName,
                        LastName = existingContact.LastName,
                        Email = existingContact.Email,
                        PhoneNumber = existingContact.PhoneNumber
                    };
                }
            }
        }

        private void HandleValidSubmit()
        {
            if (contact.Id == 0)
            {
                ContactService.Add(contact);
            }
            else
            {
                ContactService.Update(contact);
            }
            NavigationManager.NavigateTo("/contacts");
        }

        private void Cancel()
        {
            NavigationManager.NavigateTo("/contacts");
        }
    }
}
