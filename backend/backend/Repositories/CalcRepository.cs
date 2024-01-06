using backend.Models;
using backend.Repositories.Interfaces;

namespace backend.Repositories
{
    public class CalcRepository : ICalcRepository
    {

        public decimal CalcValue(CalcModel calcModel)
        {
            decimal calc = calcModel.Value * calcModel.Installments;
            decimal fivePerCent = calc * 0.05m;

            decimal total = calc + fivePerCent;

            return total;
        }
    }
}
