using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment2
{
    /// <summary>
    /// A mutual fund
    /// </summary>
    public class MutualFund : InvestmentAccount
    {
        const float ServiceChargePercent = 0.01f;

        #region Contructor



        public MutualFund(float deposit) : base(deposit)
        {
            
        }



        #endregion

        #region Public methods

        /// <summary>
        /// Updates the balance by adding 6%
        /// </summary>
        /// 

        public override void AddMoney(float amount) 
        {
            base.AddMoney(amount * (1 - ServiceChargePercent));
        }

        public override void UpdateBalance()
        {
            balance *= 1.06f;
        }

        /// <summary>
        /// Provides balance with account type caption
        /// </summary>
        /// <returns>balance with caption</returns>
        public override string ToString()
        {
            return "Mutual Fund Balance: " + balance;
        }

        #endregion
    }
}
