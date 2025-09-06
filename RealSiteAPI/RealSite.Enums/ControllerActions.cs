using System.ComponentModel;

namespace RealSite.Enums
{
    public enum ControllerActions
    {
        [DescriptionAttribute("GetBankDetails")]
        GetBankDetails,
        [DescriptionAttribute("GetEmployeeDetails")]
        GetEmployeeDetails,
        [DescriptionAttribute("GetFileReassignDetails")]
        GetFileReassignDetails,

        [DescriptionAttribute("CreateAddress")]
        CREATEADDRESS,

        [DescriptionAttribute("EditAddress")]
        EDITADDRESS,

        [DescriptionAttribute("DeleteAddress")]
        DELETEADDRESS,

        [DescriptionAttribute("GetSecurityQuestions")]
        GETSECURITYQUESTIONS,

        [DescriptionAttribute("GetPin")]
        GETPIN,

        [DescriptionAttribute("ChangeSecurityQuestions")]
        CHANGESECURITYQUESTIONS,

        [DescriptionAttribute("ChangePin")]
        CHANGEPIN,


        [DescriptionAttribute("ChangePin")]
        UPDATEPASSWORD,

        [DescriptionAttribute("GetActiveDiscounts")]
        GETACTIVEDISCOUNTS,
        [DescriptionAttribute("GetDefaultPhone")]
        GETDEFAULTPHONE,

        [DescriptionAttribute("GetDefaultEmail")]
        GETDEFAULTEMAIL,

        [DescriptionAttribute("GetDefaultAddress")]
        GETDEFAULTADDRESSES,

        [DescriptionAttribute("GetAccountstatusForCloseAccount")]
        GETACSTATUSFORCLOSEACCOUNT,

        [DescriptionAttribute("CloseCustomerAccount")]
        CLOSECUSTOMERACCOUNT,

        [DescriptionAttribute("GetCustomerAttributes")]
        GETCUSTOMERATTRIBUTES,

        [DescriptionAttribute("GetCustomerCycle")]
        GETCUSTOMERCYCLE,
        [DescriptionAttribute("UpdateStatementDeliveryOptions")]
        UPDATESTATEMENTDELIVERYOPTIONS,

        [DescriptionAttribute("UpdateStatementDeliveryOptions")]
        UPDATESTATEMENTCYCLEANDSCHEDULELOG,

        [DescriptionAttribute("UpdateTransponderPurchaseMethod")]
        UPDATETRANSPONDERPURCHASEMETHOD,
        [DescriptionAttribute("GetSummaryDetails")]
        GETSUMMARYDETAILS,
        [DescriptionAttribute("GetNactivities")]
        GETNACTIVITIES,
        [DescriptionAttribute("GetActiveVehicles")]
        GETACTIVEVEHICLES,
        [DescriptionAttribute("GetNTrips")]
        GETNTRIPS,
        [DescriptionAttribute("GetNParkingTransactions")]
        GETNPARKINGTRANSACTIONS
    }
}