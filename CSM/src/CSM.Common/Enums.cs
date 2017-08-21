using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSM.Common
{
    public enum FieldStructureTypeEnums
    {
        TextBox = 1,
        RadioGroup = 2,
        CheckBox = 3,
        TextArea = 4,
        DropDownList = 5,
        C_Splitter = 100,
        C_PriceSet = 101,
        C_ImagesUpload = 102,
        C_LocationPicker = 103,
        C_Title = 104,
        C_Description = 105
    }
    public enum HintTypeEnums
    {
        Information = 1,
        Warning = 2,
        Danger = 3
    }
    public enum QuestionTypeEnums
    {
        TextEnter = 1,
        SingleChoice = 2,
        MultiChoice = 3,
    }

    public enum RoleTypeEnums
    {
        Anonymous = 1,
        NormalUser = 10,
        Mod = 20,
        Operator = 30,
        Admin = 40,
        SuperAdmin = 50,
        Executor = 60,
    }

    public enum UserStatusEnums
    {
        Active = 1,
        Deactive = 2,
    }

    public enum LoginResponseEnums
    {
        UnknowError = 0,
        WrongPassword = 1,
        ErrorCaptcha = 2,
        WasBanned = 3,
        DuplicateUserName = 4,
    }

    public enum ValidateRuleTypeEnums
    {
        Required = 1,
        MaxLength = 2,
        MinLength = 3,
        MaxValue = 4,
        MinValue = 5,
        IsAnEmail = 10,
        IsAPhoneNumber = 11,
        CustomExpression = 100
    }

    public enum VerificationTypeEnums
    {
        SMS = 1,
        Email = 2,
    }

    public enum RespondedSMSCodeEnums
    {
        Success = 1,
        WrongCode = 2,
        Expired = 3,
        UnknowError = 4,
        WasVerified = 5,
    }

    public enum RespondedSendSMSEnums
    {
        Success = 1,
        Fail = 2,
        Spam = 3,
        UnknowError = 4,
        WasVerified = 5,
        CountryNotSupport = 6,
        NoPhoneNumber = 7,
        WrongNumber = 8,
    }

    public enum ESMSResponseCodeEnums
    {
        Success = 100,
        LoginFail = 101,
        AccountBlocked = 102,
        UnknowError = 99,
        NotEnoughMoney = 103,
        WrongBrandName = 104,
    }

    public enum SpeedSMSResponseCodeEnums
    {
        Success = 00,
        IP_locked = 007,
        Account_blocked = 008,
        Not_allow_call_API = 009,
        Wrong_parameters = 101,
        Wrong_phone_number = 105,
        Wrong_content_encoding = 110,
        Content_too_long = 113,
        Not_enough_money = 300,
        Unknow_error = 500,
    }

    public enum MyAdStatusEnums
    {
        Pending = 01,
        InProgress = 02,
        Expired = 03,
        Reject = 04,
    }

    public enum ChangePassResponseEnums
    {
        Success = 0,
        WrongOldPass = 1,
        NewPassNotLong = 2,
        NewPassNotMatch = 3,
        UnknowError = 4,
    }

    public enum MailEnums
    {
        Sender = 0,
        Receiver = 1,
        CC = 2,
        Bcc = 3,
    }

    public enum MyAdTypeEnums
    {
        None = 0,
        NeedToProvide = 1,
        Demand = 2
    }

    public enum DynamicFieldForMyAdTypeEnums
    {
        ForAll = 0,
        ForNeedToProviderSide = 1,
        ForDemandSide = 2
    }

    public enum PriceTypeEnums
    {
        Amount = 1,
        Negotiable = 2,
        Free = 3,
        SwapTrade = 4
    }

    public enum RateTypeEnums
    {
        Satisfied = 1,
        Normal = 2,
        Unsatisfied = 3,
        ByOperator = 4,
    }

    public enum CreateNewSavedFormResultEnums
    {
        Success = 1,
        NeedReplaceConfirmation = 2,
        Fail = 3
    }

    public enum ForceImportSavedFormTypeEnums
    {
        None = 0,
        Replace = 1,
        Append = 2
    }

    public enum SendResetPasswordViaEmailResultEnums
    {
        Success = 1,
        WrongEmail = 2,
        Fail = 3
    }
    public enum ResetPasswordResultEnums
    {
        Success = 1,
        Fail = 2,
        CodeExpired = 3,
        WrongCode = 4
    }
}