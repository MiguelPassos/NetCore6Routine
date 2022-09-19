using NetCore6Routine.Infra.Data.Interfaces;
using NetCore6Routine.Services.Interfaces;

namespace NetCore6Routine.Services
{
    public class BaseService : IBaseService
    {
        private IBaseRepository _repository;

        public BaseService(IBaseRepository baseRepository)
        {
            _repository = baseRepository;
        }

        public void Execute()
        {
            Console.WriteLine(SetMessage());
        }

        public string SetMessage()
        {
            return "Hello World!";
        }
    }
}