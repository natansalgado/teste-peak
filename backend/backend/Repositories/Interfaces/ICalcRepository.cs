using backend.Models;

namespace backend.Repositories.Interfaces
{
    public interface ICalcRepository
    {
        public decimal CalcValue(CalcModel calcModel);
    }
}
