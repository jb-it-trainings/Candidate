using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate.BusinessLogic
{
    public class ContactDetailsService
    {
        /// <summary>
        /// 
        /// </summary>
        public ContactDetails ReadContactDetails()
        {
            ContactDetails contactDetails = new ContactDetails();
            try
            {
                Console.WriteLine();
                Console.WriteLine("Provide Candidate Contact Details:\n");
                Console.WriteLine();
                Console.Write("Enter Primary Phone Number: ");
                contactDetails.PrimaryPhoneNumber = Console.ReadLine();
                Console.Write("Enter Secondary Phone Number: ");
                contactDetails.SecondaryPhoneNumber = Console.ReadLine();
                Console.Write("Enter Primary Email Address: ");
                contactDetails.PrimaryEmailAddress = Console.ReadLine();
                Console.Write("Enter Secondary Email Address: ");
                contactDetails.SecondaryEmailAddress = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Mesage: {0}", ex.Message);
                Console.WriteLine();
                Console.WriteLine("Exception Stack Trace: {0}", ex.StackTrace);
            }
            return contactDetails;
        }

        /// <summary>
        /// 
        /// </summary>
        public void PrintContactDetails(ContactDetails details)
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("-------------------------");
                Console.WriteLine();
                Console.WriteLine("Contact Details:");

                Console.WriteLine($"Primary Phone Number: {details.PrimaryPhoneNumber}");
                Console.WriteLine($"Seconday Phone Number: {details.SecondaryPhoneNumber}");
                Console.WriteLine($"Primary Email Address: {details.PrimaryEmailAddress}");
                Console.WriteLine($"Secondary Email Address: {details.SecondaryEmailAddress}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Mesage: {0}", ex.Message);
                Console.WriteLine();
                Console.WriteLine("Exception Stack Trace: {0}", ex.StackTrace);
            }
        }
    }
}
