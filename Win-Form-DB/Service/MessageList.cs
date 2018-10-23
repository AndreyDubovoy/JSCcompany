using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_Form_DB.Service
{
    static public class MessageList
    {
        public const string Error = "Error";
        public const string Info = "Info";
        public const string BidCompleteClosed = "The Bid is already complete or closed";
        public const string AgreementComplete = "The agreement is complete";
        public const string AgreementRejection = "The agreement is rejection";
        public const string DistributionRejection = "The distribution was rejected. Try again";
        public const string DistributionComplete = "Dividend distribution on holder accounts is complete";
        public const string MovingComplete = "The moving is complete";
        public const string DividendListRejection = "The  dividend list was rejected. Try again";
        public const string DividendListCreated = "The dividend list was created";
        public const string NotEnoughBalance = "Not enough currency on buyer Balance";
        public const string IncorrectValue = "Incorrect value. Try again";
        public const string IncorrectPrice = "Incorrect price. Try again";
        public const string QuantityIsMore = "Quantity is more than allowable";
        public const string IncorectShareQuantity = "Incorrect share quantity value";
        public const string InvalidInput = "You still have invalid input.";
        public const string IncorrectEmail = "Incorrect Email.";
        public const string IncorrectPhone = "Incorrect Phone.";
        public const string NotEmpty = "can't be empty";
        public const string TooLong = "is too long. It truncated to";
        public const string Characters = "characters";
        public const string GetSettings = "Get program settings ...";
        public const string LoadHolders = "Loading holder list...";
        public const string PrepairHolders = "Prepair holder list...";
        public const string BidClosed = "The Bid is already complete or closed";
        public const string ShareQtyNotZero = "Share quantity can't be 0";
        public const string SharesNotEnough = "Not enough shares for this bid. Change quantity or close another bid.";
        public const string RefillBalance = "Enter amount for refill your Balance";
        public const string WithdrawBalance = "Enter amount for withdraw your Balance";
        public const string DistributeAmountNotEnough = "Distribute amount is not enough. Try again";
        public const string FormHolderList1 = "Do you want form new holder list";
        public const string FormHolderList2 = "for dividend distribution?";
        public const string DistributeDividends1 = "Do you want distribute dividends";
        public const string DistributeDividends2 = "on Balance holders?";
        public const string DividendDistributed = "This dividend list had already distributed on accounts";
        public const string BuyerSellerSame = "Buyer and Seller are the same";
        public const string IncorectCreditCard = "Incorrect number credit card. Enter 16 digits.";
        public const string WaitSomeTime = "Wait some time ...";
        public const string BidForSale = "You have bids for sale";
        public const string BidForBuy = "You have bids for buy";
        public const string CommonShares = "common shares:     ";
        public const string PreferShares = "preference shares: ";
    }
}
