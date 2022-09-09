// See https://aka.ms/new-console-template for more information
using AddressBookUsingLINQ;

Console.WriteLine("Wellcome to the Address Book Problem Using LINQ");

AddressBook addressbook1 = new AddressBook();
addressbook1.AddToDataTable();
addressbook1.DisplayLastNameFromTable();
addressbook1.DisplayAddressFromTable();
addressbook1.DisplayCityFromTable();
addressbook1.DisplayStateFromTable();
addressbook1.DisplayZipCodeFromTable();
addressbook1.DisplayPhoneNumberFromTable();
addressbook1.DisplayEmailFromTable();


