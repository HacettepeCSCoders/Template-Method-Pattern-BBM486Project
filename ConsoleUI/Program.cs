using DataAccess.Concrete.EntityFramework;
using Service.Concrete.Managers;

namespace ConsoleUI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var _internManager = new InternManager(new EfInternDal());
            var _juniorSoftwareDeveloperManager =
                new JuniorSoftwareDeveloperManager(new EfJuniorSoftwareDeveloperDal());
            var _projectManager = new ProjectManagerManager(new EfProjectManagerDal());
            var _qaEngineerManager = new QAEngineerManager(new EfQAEngineerDal());
            var _seniorSoftwareDeveloperManager =
                new SeniorSoftwareDeveloperManager(new EfSeniorSoftwareDeveloperDal());
            var _softwareDeveloperManager = new SoftwareDeveloperManager(new EfSoftwareDeveloperDal());
            var _systemAnalystManager = new SystemAnalystManager(new EfSystemAnalystDal());
            var _testEngineerManager = new TestEngineerManager(new EfTestEngineerDal());
            var _uiDesignerManager = new UIDesignerManager(new EfUIDesignerDal());

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