using Microsoft.Extensions.Options;
using NetCore6Routine.Domain;
using NetCore6Routine.Infra.Data.Interfaces;

namespace NetCore6Routine.Infra.Data
{
    public class BaseRepository : IBaseRepository
    {
        public Parameters? Parameters { get; }

        public BaseRepository(IOptions<AppSettings> options)
        {
            if (options.Value.Enviroment == "DEV")
                Parameters = options.Value.DevParameters;
            else if (options.Value.Enviroment == "HML")
                Parameters = options.Value.HmlParameters;
            else if (options.Value.Enviroment == "PRD")
                Parameters = options.Value.ProdParameters;
        }
    }
}