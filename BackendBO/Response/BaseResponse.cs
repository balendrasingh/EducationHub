using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackendBO.Response
{
    public class BaseResponse
    {
        public ResponseStatus Status { get; set; }

        /// <summary>
        /// default constructor
        /// </summary>
        public BaseResponse()
        {
        }

        /// <summary>
        /// used to initialize properties 
        /// </summary>
        /// <param name="status"></param>
        public BaseResponse(ResponseStatus status)
        {
            Status = status;
        }

        /// <summary>
        /// this enum used to show service response status
        /// </summary>
        public enum ResponseStatus
        {
            Success = 0, Error = -1, NoDataFound = 1,
            InvalidLoginId = 2, InvalidPassword = 3, AttemptExceed = 4,
            Expired = 5, InvalidDetails = 6, Exists = 7, OTPSent = 8,
            OTPValidationAttemptExceed = 9, CodeExists = 10,
            PointTypeExist = 11, LastTierExists = 12, NotApplicable = 13,
            OTPSendAttemptExceed = 14, LastDetailsMatched = 15, DelayLogin = 16, PromotionNotExist = 17, NotActive = 18, SegmentMappedWithPromotion = 19, SegmentIsRunningMode = 20,
            WithIndateRange = 21
                , CRLimitPerDayExceed = 22, CRLimitPerTransactionExceed = 23,
            CRMaxLimitOverallLimit = 24
                , DRLimitPerDayExceed = 25, DRLimitPerTransactionExceed = 26, DRMaxLimitOverallLimit = 27, GroupMappedWithPartner = 28, PromotionExistWithinDate = 29, DepositRuleNotExist = 30, OTPNotMatched = 31,
            PromoCodeExist = 32, DepositReversalInValid = 33, InValidDealerForTranaction = 34, DepositDebitInValid = 35, customerDeleted = 36, customerDisabled = 37, customerNotVerified = 38, customerNotActive = 39, customerIssued = 40, customerNotIssued = 41,
            shouldPhysicalCard = 42, shouldDigitalcard = 43, SeriesNameExist = 44, SameNoSeriesExist = 45, IsBlockTrue = 46, PinNotMatched = 47, CardUsedByOtherUser = 48,
            LengthExceed = 49, VoucherNotFound = 50, PromotionNotFound = 51, CustomerNotFound = 52, VoucherCodeNotExists = 53, CustomerStageNotDeleted = 54, SendOTPForDelete = 55,
            InValidRedeemPartner = 56, VoucherCodeUsed = 57, VoucherCodeExpired = 58, WithPartneridPointTypeNameExits = 59, TierExistsWithAllAbove = 60, InValidOldLinkedCardNo = 61, OTPExpired = 63, TiersNotAvailableForEnrollment = 64, DuplicateDepositReciptNo = 65, MobileNoExist = 66
            , CHAPICardReplacementError = 67, LastDMSInvoiceIdInvalid = 68, EarningVoidAmountInvalid = 69, ResetPassword = 70, AlreadyVerifiedEmail = 71, CHAPIError = 72,
            PartnerNotFound = 73, CustomerUserOpenIdNotFound = 74, PartnerCHMarketCodeNotFound = 75, VinAlreadyMapped = 76, CardAlreadyLinkedWithBMW = 77,
            ProofRequired = 78, PointIsnegative = 79, IsNotOptInWithDealer = 80, InsufficientBalance = 81, ReversalAmountNotFound = 82, MerchantNotAccess = 83, IsBMWMappingUsed = 84
        }
    }
}