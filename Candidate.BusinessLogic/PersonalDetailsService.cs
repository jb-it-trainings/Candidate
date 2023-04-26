using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Candidate;

namespace Candidate.BusinessLogic
{
    /// <summary>
    /// 
    /// </summary>
    public class PersonalDetailsService
    {
        /// <summary>
        /// Method that reads Candidate personal details from console screen
        /// </summary>
        public PersonalDetails ReadPersonalDetails()
        {
            PersonalDetails personalDetails = new PersonalDetails();
            StringBuilder validations = new StringBuilder();
            try
            {
                Console.WriteLine("Provide Candidate Personal Details:\n");
                Console.Write("Enter First Name: ");
                string firstName = Console.ReadLine();

                if (!string.IsNullOrEmpty(firstName))
                    personalDetails.FirstName = firstName;
                else
                    validations.Append("Candidate First Name is Missing.\n");

                Console.Write("Enter Middle Name: ");
                string middleName = Console.ReadLine();

                if (!string.IsNullOrEmpty(middleName))
                    personalDetails.MiddleName = middleName;
                else
                    validations.Append("Candidate Middle Name is Missing.\n");

                Console.Write("Enter Last Name: ");
                string lastName = Console.ReadLine();

                if (!string.IsNullOrEmpty(lastName))
                    personalDetails.LastName = lastName;
                else
                    validations.Append("Candidate Last Name is Missing.\n");

                Console.WriteLine("Different Values for Gender: ");

                List<string> genderList = new List<string>();
                genderList.Add(Constants.Constants.MALE);
                genderList.Add(Constants.Constants.FEMALE);
                genderList.Add(Constants.Constants.TRANSGENDER);

                //Print Gender List
                Utility.Utility.PrintListValues(genderList);

                Console.Write("Select Value for Gender(Ex: 1 for Male): ");

                int genderOutput = 0;
                bool isGenderHasValue = int.TryParse(Console.ReadLine(), out genderOutput);

                string genderValue = string.Empty;

                if (isGenderHasValue)
                {
                    switch (genderOutput)
                    {
                        case (int)Enums.Gender.Male:
                            genderValue = Constants.Constants.MALE;
                            break;
                        case (int)Enums.Gender.Female:
                            genderValue = Constants.Constants.FEMALE;
                            break;
                        case (int)Enums.Gender.Transgender:
                            genderValue = Constants.Constants.TRANSGENDER;
                            break;
                        default:
                            validations.Append("Unknown Value for Gender is selected.");
                            break;
                    }
                    personalDetails.Gender = genderValue;
                }
                else
                {
                    validations.Append("Please select integer value for Gnder(Ex: 1 for Male)\n");
                }

                Console.WriteLine("Different Values for Candidate Type: ");
                List<string> candidateTypeList = new List<string>();
                candidateTypeList.Add(Constants.Constants.SINGLE_PARENT);
                candidateTypeList.Add(Constants.Constants.WORKING_MOTHER);
                candidateTypeList.Add(Constants.Constants.SERVED_IN_MILITARY);
                candidateTypeList.Add(Constants.Constants.RETIRED);
                candidateTypeList.Add(Constants.Constants.LGBTQ);

                Utility.Utility.PrintListValues(candidateTypeList);

                Console.Write("Select Value for Candidate Type(Ex: 1 for Single Parent): ");

                int candidateTypeOutput = 0;
                bool isCandidateTypeValid = int.TryParse(Console.ReadLine(), out candidateTypeOutput);

                string candidateTypeValue = string.Empty;

                if (isCandidateTypeValid)
                {
                    switch (candidateTypeOutput)
                    {
                        case (int)Enums.CandidateType.Single_Parent:
                            candidateTypeValue = Constants.Constants.SINGLE_PARENT;
                            break;
                        case (int)Enums.CandidateType.Working_Mother:
                            candidateTypeValue = Constants.Constants.WORKING_MOTHER;
                            break;
                        case (int)Enums.CandidateType.Server_In_Military:
                            candidateTypeValue = Constants.Constants.SERVED_IN_MILITARY;
                            break;
                        case (int)Enums.CandidateType.Retired:
                            candidateTypeValue = Constants.Constants.RETIRED;
                            break;
                        case (int)Enums.CandidateType.LGBTQ:
                            candidateTypeValue = Constants.Constants.LGBTQ;
                            break;
                        default:
                            validations.Append("Unknown Value for Candidate Type is selected.");
                            break;
                    }
                    personalDetails.CandidateType = candidateTypeValue;
                }
                else
                {
                    validations.Append("Please select integer value for Candidate Type(Ex: 1 for Single Parent)\n");
                }







                Console.WriteLine("Different Values for Differently Abled: ");

                List<string> differentlyAbledList = new List<string>();
                genderList.Add("Yes");
                genderList.Add("No");

                //Print Gender List
                Utility.Utility.PrintListValues(differentlyAbledList);

                Console.Write("Select Value for Differently Abled(Ex: 1 for Yes): ");

                int differentlyAbled = 0;
                bool isDifferentlyAbledHasValue = int.TryParse(Console.ReadLine(), out differentlyAbled);

                string differentlyAbledValue = string.Empty;

                if (isDifferentlyAbledHasValue)
                {
                    switch (differentlyAbled)
                    {
                        case 1:
                            differentlyAbledValue = Constants.Constants.MALE;
                            break;
                        case 2:
                            differentlyAbledValue = Constants.Constants.FEMALE;
                            break;
                        default:
                            validations.Append("Unknown Value is selected for Differently Abled.");
                            break;
                    }

                    personalDetails.DifferentlyAbled = differentlyAbledValue;
                }
                else
                {
                    validations.Append("Please select integer value for Gnder(Ex: 1 for Male)\n");
                }




                //Validation Errors Displayed here
                if (!string.IsNullOrEmpty(validations.ToString()))
                    Console.WriteLine($"\n\nValidation Errors:\n{validations}");
            }
            catch (FormatException ex)//Specific Exception
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Mesage: {0}", ex.Message);
                Console.WriteLine();
                Console.WriteLine("Exception Stack Trace: {0}", ex.StackTrace);
            }

            return personalDetails;
        }

        /// <summary>
        /// Method that writes/prints Candidate personal details to the console screen
        /// </summary>
        public void PrintPersonalDetails(PersonalDetails details)
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("-------------------------");
                Console.WriteLine();
                Console.WriteLine("Personal Details:");

                Console.WriteLine($"Name: {details.FirstName} {details.MiddleName} {details.LastName}");

                Console.WriteLine($"Gender: {details.Gender}");
                Console.WriteLine($"Candidate Type: {details.CandidateType}");
                Console.WriteLine($"Marital Status: {details.MaritalStatus}");
                Console.WriteLine($"Date Of Birth: {details.DateOfBirth}");
                Console.WriteLine($"Category: {details.Category}");

             

                Console.WriteLine($"Work Permit USA: {details.WorkPermitUSA}");
                Console.WriteLine($"Work Permit Other Countries: {details.WorkPermitOtherCountries}");
                Console.WriteLine($"Work Status: {details.WorkStatus}");
                Console.WriteLine($"Notice Period: {details.NoticePeriod}");
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
