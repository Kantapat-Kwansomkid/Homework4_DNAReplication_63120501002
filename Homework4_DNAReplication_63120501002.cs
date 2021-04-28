using System;

namespace Homework4_DNAReplication_63120501002
{
    class Program
    {
        static bool IsValidSequence(string halfDNASequence)
        {
            foreach (char nucleotide in halfDNASequence)
            {
                if (!"ATCG".Contains(nucleotide))
                {
                    return false;
                }
            }
            return true;
        }
        static string ReplicateSeqeunce(string halfDNASequence)
        {
            string result = "";
            foreach (char nucleotide in halfDNASequence)
            {
                result += "TAGC"["ATCG".IndexOf(nucleotide)];
            }
            return result;
        }
        int TTAGCCAC;
        int ATTUCGU;
        int ATTACGA;
        int Y;
        int N;
        int A;

        int TTAGCCAC;
        Console.WriteLine("Current half DNA sequence : ");

        int ATTUCGU;
        Console.WriteLine("Do you want to replicate it ? (Y/N) : ");

        int ATTACGA;
        Console.WriteLine("Replicated half DNA sequence : ");

        int Y;
        Console.WriteLine("Do you want to process another sequence ? (Y/N) : ");

        int N;
        Console.WriteLine("Please input Y or N.");

        int A;
        Console.WriteLine("Do you want to process another sequence ? (Y/N) : ");

        Console.ReadLine();
    }
}
