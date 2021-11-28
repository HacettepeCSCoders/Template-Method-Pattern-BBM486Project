using System;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Service.Concrete;
using Service.Concrete.Managers;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            InternManager _internManager = new InternManager(new EfInternDal());
            JuniorSoftwareDeveloperManager _juniorSoftwareDeveloperManager = new JuniorSoftwareDeveloperManager(new EfJuniorSoftwareDeveloperDal());
            ProjectManagerManager _projectManager = new ProjectManagerManager(new EfProjectManagerDal());
            QAEngineerManager _qaEngineerManager = new QAEngineerManager(new EfQAEngineerDal());
            SeniorSoftwareDeveloperManager _seniorSoftwareDeveloperManager = new SeniorSoftwareDeveloperManager(new EfSeniorSoftwareDeveloperDal());
            SoftwareDeveloperManager _softwareDeveloperManager = new SoftwareDeveloperManager(new EfSoftwareDeveloperDal());
            SystemAnalystManager _systemAnalystManager = new SystemAnalystManager(new EfSystemAnalystDal());
            TestEngineerManager _testEngineerManager = new TestEngineerManager(new EfTestEngineerDal());
            UIDesignerManager _uiDesignerManager = new UIDesignerManager(new EfUIDesignerDal());

            // Intern intern = _internManager.GetById(1);
            // Console.WriteLine("First : " + intern.FirstName);
            // intern.FirstName = "Denemetullah";
            // _internManager.Update(intern);
            //
            // Intern intern1 = _internManager.GetById(1);
            // Console.WriteLine("After change : " + intern1.FirstName);
            // intern1.FirstName = "Bonnie";
            // _internManager.Update(intern1);

            // foreach (var intern in _internManager.GetAll())
            // {
            //     Console.WriteLine(intern.FirstName);
            // }
            // foreach (var intern in _juniorSoftwareDeveloperManager.GetAll())
            // {
            //     Console.WriteLine(intern.FirstName);
            // }
            // foreach (var intern in _projectManager.GetAll())
            // {
            //     Console.WriteLine(intern.FirstName);
            // }
            // foreach (var intern in _qaEngineerManager.GetAll())
            // {
            //     Console.WriteLine(intern.FirstName);
            // }
            // foreach (var intern in _seniorSoftwareDeveloperManager.GetAll())
            // {
            //     Console.WriteLine(intern.FirstName);
            // }
        }
    }
}