using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Candidate.BusinessLogic;
using Candidate;

namespace CandidatePortal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("\t\t\t\t\t\tWelcome to Candidate Portal \n");

                //Reading Candidate Details 

                PersonalDetailsService personalDetails = new PersonalDetailsService();
                //Read Candidate Personal Details
                //PersonalDetails pDetailsUserInput = personalDetails.ReadPersonalDetails();

                ContactDetailsService contactService = new ContactDetailsService();
                //Read Candiddate Contact Details
                //ContactDetails contactDetails = contactService.ReadContactDetails();

                
                //AddressDetailsService addressDetailsService = new AddressDetailsService();
                //Reading Candidate Address Details
                //addressDetailsService.



                //Print Candidate Details

                //Print Candidate Personal Details
                //personalDetails.PrintPersonalDetails(pDetailsUserInput);

                //Print Candidate Contact Details
               //contactService.PrintContactDetails(contactDetails);

                Console.ReadLine();

            }
            catch (Exception ex)//Handles General Exceptions - Any Type of Exception
            {
                Console.WriteLine("Exception Mesage: {0}", ex.Message);
                Console.WriteLine();
                Console.WriteLine("Exception Stack Trace: {0}", ex.StackTrace);
            }
        }
    }
}
