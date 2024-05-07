using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace ContactManager.Client.Pages
{
    public partial class ContactForm
    {
        [Parameter] public int ContactId { get; set; }
        private Contact contact = new Contact();
        private string errorMessage = string.Empty;
        private string successMessage = string.Empty;

        protected override void OnParametersSet()
        {
            if (ContactId != 0)
            {
                LoadExistingContact();
            }
        }

        private void LoadExistingContact()
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
            else
            {
                errorMessage = "Contact not found.";
            }
        }

        private async Task HandleValidSubmit()
        {
            try
            {
                if (contact.Id == 0)
                {
                    ContactService.Add(contact);
                    successMessage = "Contact added successfully!";
                }
                else
                {
                    ContactService.Update(contact);
                    successMessage = "Contact updated successfully!";
                }
                errorMessage = string.Empty;
                NavigationManager.NavigateTo("/contacts");
            }
            catch (System.Exception ex)
            {
                errorMessage = $"An error occurred: {ex.Message}";
                successMessage = string.Empty;
            }
        }

        private void Cancel()
        {
            NavigationManager.NavigateTo("/contacts");
        }
    }
}
