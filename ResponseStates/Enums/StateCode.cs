using ResponseStates.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResponseStates.Enums
{
    public enum StateCode
    {
        #region 1xx Informational
        [StateDisplay(Code = 100, Name = "Continue", Message = "Devam et", Success = true)]
        Continue = 100,
        [StateDisplay(Code = 101, Name = "SwitchingProtocols", Message = "Anahtarlama Protokolleri", Success = true)]
        SwitchingProtocols = 101,
        [StateDisplay(Code = 102, Name = "Processing", Message = "İşleme (WebDAV)", Success = true)]
        Processing = 102,
        #endregion

        #region 2xx Success
        [StateDisplay(Code = 200, Name = "OK", Message = "Başarılı", Success = true)]
        OK = 200,
        [StateDisplay(Code = 201, Name = "Created", Message = "Oluşturdu", Success = true)]
        Created = 201,
        [StateDisplay(Code = 202, Name = "Accepted", Message = "Kabul Edildi", Success = true)]
        Accepted = 202,
        [StateDisplay(Code = 203, Name = "NonAuthoritativeInformation", Message = "Yetkilendirilmemiş Bilgi", Success = true)]
        NonAuthoritativeInformation = 203,
        [StateDisplay(Code = 204, Name = "NoContent", Message = "İçerik Yok", Success = true)]
        NoContent = 204,
        [StateDisplay(Code = 205, Name = "ResetContent", Message = "Yenilenmiş İçerik", Success = true)]
        ResetContent = 205,
        [StateDisplay(Code = 206, Name = "PartialContent", Message = "Kısmi İçerik", Success = true)]
        PartialContent = 206,
        [StateDisplay(Code = 207, Name = "MultiStatus", Message = "Çoklu Durum", Success = true)]
        MultiStatus = 207,
        [StateDisplay(Code = 208, Name = "AlreadyReported", Message = "Önceden Bildirilen", Success = true)]
        AlreadyReported = 208,
        [StateDisplay(Code = 209, Name = "IMUsed", Message = "IM Used", Success = true)]
        IMUsed = 226,
        #endregion

        #region 3xx Redirection
        [StateDisplay(Code = 300, Name = "MultipleChoices", Message = "Çoklu Seçim", Success = true)]
        MultipleChoices = 300,
        [StateDisplay(Code = 301, Name = "MovedPermanently", Message = "Kalıcı Olarak Taşındı", Success = true)]
        MovedPermanently = 301,
        [StateDisplay(Code = 302, Name = "Found", Message = "Bulundu", Success = true)]
        Found = 302,
        [StateDisplay(Code = 303, Name = "SeeOther", Message = "Diğerine Bak", Success = true)]
        SeeOther = 303,
        [StateDisplay(Code = 304, Name = "NotModified", Message = "Değiştirilemedi", Success = true)]
        NotModified = 304,
        [StateDisplay(Code = 305, Name = "UseProxy", Message = "Proxy Kullan", Success = true)]
        UseProxy = 305,
        [StateDisplay(Code = 306, Name = "Unused", Message = "Kullanılmamış", Success = true)]
        Unused = 306,
        [StateDisplay(Code = 307, Name = "TemporaryRedirect", Message = "Geçici Yönlendirme", Success = true)]
        TemporaryRedirect = 307,
        [StateDisplay(Code = 308, Name = "PermanentRedirect", Message = "Kalıcı Yönlendirme", Success = true)]
        PermanentRedirect = 308,
        #endregion

        #region 4xx Client Error
        [StateDisplay(Code = 400, Name = "BadRequest", Message = "Hatalı İstek", Success = false)]
        BadRequest = 400,
        [StateDisplay(Code = 401, Name = "Unauthorized", Message = "Yetkisiz", Success = false)]
        Unauthorized = 401,
        [StateDisplay(Code = 402, Name = "PaymentRequired", Message = "Ödeme Gerekli", Success = false)]
        PaymentRequired = 402,
        [StateDisplay(Code = 403, Name = "Forbidden", Message = "Yasaklanmış", Success = false)]
        Forbidden = 403,
        [StateDisplay(Code = 404, Name = "NotFound", Message = "Bulunamadı", Success = false)]
        NotFound = 404,
        [StateDisplay(Code = 405, Name = "MethodNotAllowed", Message = "İzin Verilmeyen Metod", Success = false)]
        MethodNotAllowed = 405,
        [StateDisplay(Code = 406, Name = "NotAcceptable", Message = "Kabul Edilemez", Success = false)]
        NotAcceptable = 406,
        [StateDisplay(Code = 407, Name = "ProxyAuthenticationRequired", Message = "Proxy Kimlik Doğrulaması Gerekli", Success = false)]
        ProxyAuthenticationRequired = 407,
        [StateDisplay(Code = 408, Name = "RequestTimeout", Message = "İstek Zaman Aşımına Uğradı", Success = false)]
        RequestTimeout = 408,
        [StateDisplay(Code = 409, Name = "Conflict", Message = "İstek Çatışması", Success = false)]
        Conflict = 409,
        [StateDisplay(Code = 410, Name = "Gone", Message = "Yok Olmuş - Erişilemez", Success = false)]
        Gone = 410,
        [StateDisplay(Code = 411, Name = "LengthRequired", Message = "İçerik Uzunluğu Gerekli", Success = false)]
        LengthRequired = 411,
        [StateDisplay(Code = 412, Name = "PreconditionFailed", Message = "Önkoşul Başarısız", Success = false)]
        PreconditionFailed = 412,
        [StateDisplay(Code = 413, Name = "RequestEntityTooLarge", Message = "Gönderilen Veri Çok Fazla", Success = false)]
        RequestEntityTooLarge = 413,
        [StateDisplay(Code = 414, Name = "RequestURITooLong", Message = "İstek URL'li Çok Uzun", Success = false)]
        RequestURITooLong = 414,
        [StateDisplay(Code = 415, Name = "UnsupportedMediaType", Message = "Desteklenmeyen Medya Türü", Success = false)]
        UnsupportedMediaType = 415,
        [StateDisplay(Code = 416, Name = "RequestedRangeNotSatisfiable", Message = "İstenen Aralık Uygun Değildir", Success = false)]
        RequestedRangeNotSatisfiable = 416,
        [StateDisplay(Code = 417, Name = "ExpectationFailed", Message = "Beklenti Başarısız oldu", Success = false)]
        ExpectationFailed = 417,
        [StateDisplay(Code = 418, Name = "IMaTeapot", Message = "IMaTeapot", Success = false)]
        IMaTeapot = 418,
        [StateDisplay(Code = 420, Name = "EnhanceYourCalm", Message = "Sakinleştirin", Success = false)]
        EnhanceYourCalm = 420,
        [StateDisplay(Code = 422, Name = "UnprocessableEntity", Message = "İşlenemez Varlık", Success = false)]
        UnprocessableEntity = 422,
        [StateDisplay(Code = 423, Name = "Locked", Message = "Kilitli", Success = false)]
        Locked = 423,
        [StateDisplay(Code = 424, Name = "FailedDependency", Message = "Başarısız Bağımlılık", Success = false)]
        FailedDependency = 424,
        [StateDisplay(Code = 425, Name = "ReservedforWebDAV", Message = "WebDAV için ayrılmıştır", Success = false)]
        ReservedforWebDAV = 425,
        [StateDisplay(Code = 426, Name = "UpgradeRequired", Message = "Yükseltme Gerekli", Success = false)]
        UpgradeRequired = 426,
        [StateDisplay(Code = 428, Name = "PreconditionRequired", Message = "Önkoşul Gerekli", Success = false)]
        PreconditionRequired = 428,
        [StateDisplay(Code = 429, Name = "TooManyRequests", Message = "Çok Fazla İstek", Success = false)]
        TooManyRequests = 429,
        [StateDisplay(Code = 431, Name = "RequestHeaderFieldsTooLarge", Message = "İsteğin Başlık Alanları Çok Büyük", Success = false)]
        RequestHeaderFieldsTooLarge = 431,
        [StateDisplay(Code = 444, Name = "NoResponseNginx", Message = "Nginx Yanıt Vermiyor", Success = false)]
        NoResponseNginx = 444,
        [StateDisplay(Code = 449, Name = "RetryWithMicrosoft", Message = "Microsoft ile yeniden dene", Success = false)]
        RetryWithMicrosoft = 449,
        [StateDisplay(Code = 450, Name = "BlockedByWindowsParentalControls", Message = "Windows Ebeveyn Denetimleri Tarafından Engellendi", Success = false)]
        BlockedByWindowsParentalControls = 450,
        [StateDisplay(Code = 451, Name = "UnavailableForLegalReasons", Message = "Yasal Sebeplerden Dolayı Kullanılamaz", Success = false)]
        UnavailableForLegalReasons = 451,
        [StateDisplay(Code = 499, Name = "ClientClosedRequest", Message = "İstemcinin Kapalı İsteği", Success = false)]
        ClientClosedRequest = 499,
        #endregion

        #region 5xx Server Error
        [StateDisplay(Code = 500, Name = "InternalServerError", Message = "İç Sunucu Hatası", Success = false)]
        InternalServerError = 500,
        [StateDisplay(Code = 501, Name = "NotImplemented", Message = "İsteği Yerine Getiremedi", Success = false)]
        NotImplemented = 501,
        [StateDisplay(Code = 502, Name = "BadGateway", Message = "Hatalı Ağ Geçidi", Success = false)]
        BadGateway = 502,
        [StateDisplay(Code = 503, Name = "ServiceUnavailable", Message = "Sunucu kullanılmaz.", Success = false)]
        ServiceUnavailable = 503,
        [StateDisplay(Code = 504, Name = "GatewayTimeout", Message = "GatewayTimeout", Success = false)]
        GatewayTimeout = 504,
        [StateDisplay(Code = 505, Name = "HTTPVersionNotSupported", Message = "HTTPVersionNotSupported", Success = false)]
        HTTPVersionNotSupported = 505,
        [StateDisplay(Code = 506, Name = "VariantAlsoNegotiates", Message = "VariantAlsoNegotiates", Success = false)]
        VariantAlsoNegotiates = 506,
        [StateDisplay(Code = 507, Name = "InsufficientStorage", Message = "InsufficientStorage", Success = false)]
        InsufficientStorage = 507,
        [StateDisplay(Code = 508, Name = "LoopDetected", Message = "LoopDetected", Success = false)]
        LoopDetected = 508,
        [StateDisplay(Code = 509, Name = "BandwidthLimitExceeded", Message = "BandwidthLimitExceeded", Success = false)]
        BandwidthLimitExceeded = 509,
        [StateDisplay(Code = 510, Name = "NotExtended", Message = "NotExtended", Success = false)]
        NotExtended = 510,
        [StateDisplay(Code = 511, Name = "NetworkAuthenticationRequired", Message = "NetworkAuthenticationRequired", Success = false)]
        NetworkAuthenticationRequired = 511,
        [StateDisplay(Code = 598, Name = "NetworkReadTimeoutError", Message = "NetworkReadTimeoutError", Success = false)]
        NetworkReadTimeoutError = 598,
        [StateDisplay(Code = 599, Name = "NetworkConnectTimeoutError", Message = "NetworkConnectTimeoutError", Success = false)]
        NetworkConnectTimeoutError = 599,
        #endregion


        #region Application Success

        [StateDisplay(Code = 200, SubCode = 20000, Name = "OK", Success = true)]
        Success = 20000,

        #region MAIL


        [StateDisplay(Code = 200, SubCode = 20100, Name = "MailForgotPasswordSendSucces", Success = true)]
        MailForgotPasswordSendSucces = 20100,
        [StateDisplay(Code = 200, SubCode = 20101, Name = "UserForgotPasswordSendSucces", Success = true)]
        UserForgotPasswordSendSucces = 20101,


        #endregion

        #region USER


        [StateDisplay(Code = 200, SubCode = 20200, Name = "UserFound", Success = true)]
        UserFound = 20200,
        //[StateDisplay(Code = 200, SubCode = 20201, Name = "UserUpdate", Success = true)]
        //UserUpdate = 20201,
        [StateDisplay(Code = 200, SubCode = 20202, Name = "UserChangedPassword", Success = true)]
        UserChangedPassword = 20202,
        [StateDisplay(Code = 200, SubCode = 20203, Name = "UserCreate", Success = true)]
        UserCreate = 20203,
        //[StateDisplay(Code = 204, SubCode = 20204, Name = "UserDeleted", Success = true)]
        //UserDeleted = 20204,
        [StateDisplay(Code = 204, Name = "UserDeleted", Success = true)]
        UserDeleted = 20204,
        [StateDisplay(Code = 204, Name = "UserUpdate", Success = true)]
        UserUpdate = 20205,
        [StateDisplay(Code = 204, Name = "UserEmailUpdate", Success = true)]
        UserEmailUpdate = 20206,


        #endregion

        #region NumberPlate
        [StateDisplay(Code = 200, SubCode = 20300, Name = "NumberPlateRemove", Success = true)]
        NumberPlateRemove = 20300,
        [StateDisplay(Code = 200, SubCode = 20301, Name = "NumberPlateCreate", Success = true)]
        NumberPlateCreate = 20301,

        #endregion

        #region Balance
        [StateDisplay(Code = 200, SubCode = 20400, Name = "LoadBalanceSuccess", Success = true)]
        LoadBalanceSuccess = 20400,
        #endregion

        #region Appeal
        [StateDisplay(Code = 200, SubCode = 20500, Name = "AppealSuccess", Success = true)]
        AppealSuccess = 20500,

        #endregion

        #region OILSTATION

        [StateDisplay(Code = 200, SubCode = 20600, Name = "OilStationSuccess", Success = true)]
        OilStationSuccess = 20600,

        #endregion

        #region CREDIT
        [StateDisplay(Code = 200, SubCode = 20700, Name = "AppealCreditSuccess", Success = true)]
        AppealCreditSuccess = 20700,
        #endregion

        #endregion

        #region Application Errors

        [StateDisplay(Code = 400, SubCode = 40000, Name = "Error", Success = false)]
        Error = 40000,
        [StateDisplay(Code = 400, SubCode = 40001, Name = "UnexpectedError", Success = false)]
        UnexpectedError = 40001,
        [StateDisplay(Code = 400, SubCode = 40002, Name = "ValidationError", Success = false)]
        ValidationError = 40002,
        [StateDisplay(Code = 400, SubCode = 40003, Name = "WebUIValidationError", Success = false)]
        WebUIUnexpectedError = 40003,
        [StateDisplay(Code = 400, SubCode = 40004, Name = "ManagementUIValidationError", Success = false)]
        ManagementUIUnexpectedError = 40004,
        [StateDisplay(Code = 400, SubCode = 40005, Name = "APIMobileUnexpectedError", Success = false)]
        APIMobileUnexpectedError = 40005,
        [StateDisplay(Code = 400, SubCode = 40006, Name = "APIPosUnexpectedError", Success = false)]
        APIPosUnexpectedError = 40006,
        [StateDisplay(Code = 400, SubCode = 40007, Name = "NotSendMail", Success = false)]
        NotSendMail = 40007,

        #region LOGIN - TOKEN

        [StateDisplay(Code = 400, SubCode = 40100, Name = "WrongMail", Success = false)]
        WrongMail = 40100,
        [StateDisplay(Code = 400, SubCode = 40101, Name = "WrongUser", Success = false)]
        WrongUser = 40101,
        [StateDisplay(Code = 400, SubCode = 40102, Name = "WrongPassword", Success = false)]
        WrongPassword = 40102,
        [StateDisplay(Code = 400, SubCode = 40103, Name = "AppKeyWrong", Success = false)]
        AppKeyWrong = 40103,
        [StateDisplay(Code = 400, SubCode = 40104, Name = "AppKeyExpiry", Success = false)]
        AppKeyExpiry = 40104,
        [StateDisplay(Code = 400, SubCode = 40105, Name = "AppKeyPassive", Success = false)]
        AppKeyPassive = 40105,
        [StateDisplay(Code = 400, SubCode = 40106, Name = "AppKeyDeleted", Success = false)]
        AppKeyDeleted = 40106,
        [StateDisplay(Code = 400, SubCode = 40107, Name = "InActiveUser", Success = false)]
        InActiveUser = 40107,
        [StateDisplay(Code = 400, SubCode = 40108, Name = "DeletedUser", Success = false)]
        DeletedUser = 40108,
        [StateDisplay(Code = 400, SubCode = 40109, Name = "BlockedUser", Success = false)]
        BlockedUser = 40109,
        [StateDisplay(Code = 400, SubCode = 40110, Name = "TokenExpiry", Success = false)]
        TokenExpiry = 40110,
        [StateDisplay(Code = 400, SubCode = 40111, Name = "TokenNotFound", Success = false)]
        TokenNotFound = 40111,
        [StateDisplay(Code = 400, SubCode = 40112, Name = "TokenInvalid", Success = false)]
        TokenInvalid = 40112,
        [StateDisplay(Code = 400, SubCode = 40113, Name = "NotPosUser", Success = false)]
        NotPosUser = 40113,


        #endregion

        #region USER


        [StateDisplay(Code = 404, SubCode = 40200, Name = "NotFoundUser", Success = false)]
        NotFoundUser = 40200,
        [StateDisplay(Code = 400, SubCode = 40201, Name = "NotFoundCode", Success = false)]
        NotFoundCode = 40201,
        [StateDisplay(Code = 400, SubCode = 40202, Name = "UserCodeExpriy", Success = false)]
        UserCodeExpriy = 40202,
        [StateDisplay(Code = 400, SubCode = 40203, Name = "UserCodeNotCreated", Success = false)]
        UserCodeNotCreated = 40203,
        [StateDisplay(Code = 400, SubCode = 40204, Name = "UserChangePassword", Success = false)]
        UserChangePassword = 40204,
        [StateDisplay(Code = 400, SubCode = 40205, Name = "UserPasswordConfirm", Success = false)]
        UserPasswordConfirm = 40205,
        [StateDisplay(Code = 400, SubCode = 40206, Name = "UserNotUpdate", Success = false)]
        UserNotUpdate = 40206,
        [StateDisplay(Code = 400, SubCode = 40207, Name = "UserNotCreate", Success = false)]
        UserNotCreate = 40207,
        [StateDisplay(Code = 400, SubCode = 40208, Name = "UserFoundSame", Success = false)]
        UserFoundSame = 40208,
        [StateDisplay(Code = 400, SubCode = 40209, Name = "UserNotSameID", Success = false)]
        UserNotSameID = 40209,
        [StateDisplay(Code = 400, SubCode = 40210, Name = "UserNotChangedPassword", Success = false)]
        UserNotChangedPassword = 40210,



        #endregion

        #region NumberPlate
        [StateDisplay(Code = 400, SubCode = 40300, Name = "NumberPlateNotRemove", Success = false)]
        NumberPlateNotRemove = 40300,
        [StateDisplay(Code = 400, SubCode = 40301, Name = "NumberPlateNotCreate", Success = false)]
        NumberPlateNotCreate = 40301,
        [StateDisplay(Code = 400, SubCode = 40302, Name = "NumberPlateNotFound", Success = false)]
        NumberPlateNotFound = 40302,
        [StateDisplay(Code = 400, SubCode = 40303, Name = "NumberPlateCountZero", Success = false)]
        NumberPlateCountZero = 40303,
        [StateDisplay(Code = 400, SubCode = 40304, Name = "NumberPlateNotMatchUser", Success = false)]
        NumberPlateNotMatchUser = 40304,


        #endregion

        #region Balance
        [StateDisplay(Code = 400, SubCode = 40400, Name = "LoadBalanceError", Success = false)]
        LoadBalanceError = 40400,
        #endregion

        #region APPEAL
        [StateDisplay(Code = 400, SubCode = 40500, Name = "AppealError", Success = false)]
        AppealError = 40500,
        #endregion

        #region GASSTATION
        [StateDisplay(Code = 400, SubCode = 40600, Name = "OilStationError", Success = false)]
        OilStationError = 40600,
        [StateDisplay(Code = 400, SubCode = 40601, Name = "OilStationFoundSame", Success = false)]
        OilStationFoundSame = 40601,
        [StateDisplay(Code = 400, SubCode = 40602, Name = "GasStationNotFound", Success = false)]
        GasStationNotFound = 40602,
        [StateDisplay(Code = 400, SubCode = 40603, Name = "GasStationDeleted", Success = false)]
        GasStationDeleted = 40603,
        [StateDisplay(Code = 400, SubCode = 40604, Name = "GasStationBlocked", Success = false)]
        GasStationBlocked = 40604,
        [StateDisplay(Code = 400, SubCode = 40605, Name = "GasStationInActive", Success = false)]
        GasStationInActive = 40605,
        #endregion

        #region FLEET
        [StateDisplay(Code = 400, SubCode = 40700, Name = "FleetFoundSame", Success = false)]
        FleetFoundSame = 40700,
        #endregion

        #region QRTRANSACTION

        [StateDisplay(Code = 400, SubCode = 40800, Name = "QRTransactionNotFound", Success = false)]
        QRTransactionNotFound = 40800,
        [StateDisplay(Code = 400, SubCode = 40801, Name = "QRTransactionNotCreate", Success = false)]
        QRTransactionNotCreate = 40801,
        [StateDisplay(Code = 400, SubCode = 40802, Name = "QRTransactionConfirmed", Success = false)]
        QRTransactionConfirmed = 40802,
        [StateDisplay(Code = 400, SubCode = 40803, Name = "QRTransactionRejeted", Success = false)]
        QRTransactionRejeted = 40803,
        [StateDisplay(Code = 400, SubCode = 40804, Name = "QRTransactionTimeOut", Success = false)]
        QRTransactionTimeOut = 40804,
        [StateDisplay(Code = 400, SubCode = 40805, Name = "QRTransactionCanceled", Success = false)]
        QRTransactionCanceled = 40805,

        [StateDisplay(Code = 400, SubCode = 40806, Name = "QRTransactionNotConfirmed", Success = false)]
        QRTransactionNotConfirmed = 40806,
        [StateDisplay(Code = 400, SubCode = 40807, Name = "QRTransactionNotRejeted", Success = false)]
        QRTransactionNotRejeted = 40807,
        [StateDisplay(Code = 400, SubCode = 40804, Name = "QRTransactionNotTimeOut", Success = false)]
        QRTransactionNotTimeOut = 40808,
        [StateDisplay(Code = 400, SubCode = 40805, Name = "QRTransactionNotCanceled", Success = false)]
        QRTransactionNotCanceled = 40809,
        [StateDisplay(Code = 400, SubCode = 40805, Name = "QRTransactionNotWaiting", Success = false)]
        QRTransactionNotWaiting = 40810,

        #endregion

        #region TRANSACTION

        [StateDisplay(Code = 400, SubCode = 40900, Name = "TransactionNotFound", Success = false)]
        TransactionNotFound = 40900,
        [StateDisplay(Code = 400, SubCode = 40901, Name = "TransactionNotCreate", Success = false)]
        TransactionNotCreate = 40901,
        [StateDisplay(Code = 400, SubCode = 40902, Name = "NotEnoughCredit", Success = false)]
        NotEnoughCredit = 40902,

        #endregion

        #region CREDIT


        #endregion






        #endregion
    }
}
