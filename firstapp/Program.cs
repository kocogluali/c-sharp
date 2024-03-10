using firstapp.Business;
using firstapp.Entities;

CourseManager courseManager = new();

Course[] courses = courseManager.GetAll();

for (int i = 0; i < courses.Length; i++)
{
    System.Console.WriteLine(courses[i].Name + " " + courses[i].Description);
}

IndividualCustomer individualCustomer1 = new();

individualCustomer1.Id =1;
individualCustomer1.NationalIdentity ="12345678922";
individualCustomer1.FirstName ="ali";
individualCustomer1.LastName="koçoğlu";
individualCustomer1.CustomerNumber="123456";

IndividualCustomer individualCustomer2 = new();

individualCustomer2.Id =2;
individualCustomer2.NationalIdentity ="12345678924";
individualCustomer2.FirstName ="sema";
individualCustomer2.LastName="koçoğlu";
individualCustomer2.CustomerNumber="1234567";

CorporateCustomer corporateCustomer3  =new();

corporateCustomer3.Id=3;
corporateCustomer3.Name ="kodlama.io";
corporateCustomer3.CustomerNumber = "11234";
corporateCustomer3.TaxNumber="1234567";

CorporateCustomer corporateCustomer4  =new();

corporateCustomer4.Id=4;
corporateCustomer4.Name ="kodlama.io";
corporateCustomer4.CustomerNumber = "611234";
corporateCustomer4.TaxNumber="21234567";

BaseCustomer[] baseCustomers = {individualCustomer1,individualCustomer2,corporateCustomer3,corporateCustomer4};
foreach(BaseCustomer customer in baseCustomers) {
    System.Console.WriteLine(customer.CustomerNumber);
}