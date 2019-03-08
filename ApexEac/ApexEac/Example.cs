using System;

namespace ApexEac
{
    class Example
    {
        static void Main(string[] args)
        {
            try
            {
                ApexEac.Submit("playerId", "firstName", "lastName", "email@email.com", "message");
                Console.WriteLine("Report Sent");
            }
            catch (ApexEac.GetVerificationException)
            {
                Console.WriteLine("Failed to get a token");
            }
            catch (ApexEac.InvalidParameterException ex)
            {
                Console.WriteLine("Parameter error: ");
                Console.WriteLine(ex.Message);
            }
            Console.Write("Press any key to continue...");
            Console.Read();
        }
    }
}
