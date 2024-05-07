using System.Collections.Generic;
using System.Linq;

public class ContactService
{
    private List<Contact> _contacts = new List<Contact>();
    private int _nextId = 1;

    public IEnumerable<Contact> GetAll() => _contacts;

    public Contact Get(int id) => _contacts.FirstOrDefault(c => c.Id == id);

    public void Add(Contact contact)
    {
        contact.Id = _nextId++;
        _contacts.Add(contact);
    }

    public void Update(Contact contact)
    {
        var existingContact = _contacts.FirstOrDefault(c => c.Id == contact.Id);
        if (existingContact != null)
        {
            existingContact.FirstName = contact.FirstName;
            existingContact.LastName = contact.LastName;
            existingContact.Email = contact.Email;
            existingContact.PhoneNumber = contact.PhoneNumber;
        }
    }

    public void Delete(int id)
    {
        var contact = _contacts.FirstOrDefault(c => c.Id == id);
        if (contact != null)
        {
            _contacts.Remove(contact);
        }
    }
}
