using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solium
{
    class StockInvestment
    {
        DateTime grantDate;
        int shares;
        float grantPrice;

        DateTime perfDate;
        float performanceMultiplier;

        DateTime saleDate;
        int soldShares;
        float salePrice;

        ~StockInvestment()
        {
            shares = 0;
            grantPrice = 0;
            performanceMultiplier = 1;
            soldShares = 0;
            salePrice = 0;

            //DateTime.ParseExact( string_datetime, "YYYYMMdd", CultureInfo.InvariantCulture );
            //string[] tokens = published.Split( ',' );
        }

    }
}
