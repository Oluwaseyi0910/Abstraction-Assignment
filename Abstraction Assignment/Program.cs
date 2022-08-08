using System;

namespace Abstraction_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JobRequirement jobRequirement1 = new JobRequirement();
            bool acadRequirement = jobRequirement1.AcademicQualification(true, true, false);
            bool ageRequirement = jobRequirement1.RequiredAge(26);
            bool yearsOfExperience = jobRequirement1.YearsofExperience(2);
            if (acadRequirement && yearsOfExperience && ageRequirement)
            {
                Console.WriteLine("You got the job");
            }
            else
            {
                Console.WriteLine("We currently do not require your services.");
            }

        }
    }

    internal class JobRequirement: IRecruitmentRequirement
    {
        public bool AcademicQualification(bool bachelorsDegree, bool mastersDegree, bool doctorofPhilospohy)
        {
            if (bachelorsDegree == true && mastersDegree == true)
            {
              
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RequiredAge(int age)
        {
            if (age <= 30 && age >= 25)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool YearsofExperience(int numberOfYears)
        {
            if (numberOfYears <= 5 && numberOfYears >= 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    interface IRecruitmentRequirement
    {
        public bool AcademicQualification(bool bachelorsDegree, bool mastersDegree, bool doctorofPhilospohy);
        public bool RequiredAge(int age);
        public bool YearsofExperience(int numberOfYears);
    }
}

