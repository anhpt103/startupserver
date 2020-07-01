namespace ATKSmartApi.Common.Constants
{
    public static class ValidateModel
    {
        // REQUIRE
        public static string STOREID_REQUIRE = "ID Cửa hàng không thể trống!";
        public static string STORE_REQUIRE = "Tên Cửa hàng không thể trống!";
        public static string USERID_REQUIRE = "ID Tài khoản không thể trống!";
        public static string EMAIL_REQUIRE = "Email không thể trống!";
        public static string PASSWORD_REQUIRE = "Mật khẩu không thể trống!";
        public static string FIRSTNAME_REQUIRE = "Họ không thể trống!";
        public static string LASTNAME_REQUIRE = "Tên không thể trống!";
        public static string ADDRESS_REQUIRE = "Địa chỉ không thể trống!";
        public static string PHONENUMBER_REQUIRE = "Số điện thoại không thể trống!";

        // FORM INPUT INCORRECT
        public static string PHONENUMBER_INVALID = "Định dạng Số điện thoại không đúng!";
        public static string EMAIL_INVALID = "Định dạng Email không đúng!";


        // MIN, MAX LENGTH
        public static string CREATEBY_LENGTH_INVALID = "Độ dài Người tạo tối đa 50 ký tự!";
        public static string UPDATEBY_LENGTH_INVALID = "Độ dài Người cập nhật tối đa 50 ký tự!";
        public static string EMAIL_LENGTH_INVALID = "Độ dài Email tối đa 50 ký tự!";
        public static string PASSWORD_LENGTH_INVALID = "Độ dài Mật khẩu từ 6 đến 32 ký tự!";
        public static string PHONENUMBER_LENGTH_INVALID = "Độ dài Số điện thoại tối đa 15 ký tự!";
        public static string FIRSTNAME_LENGTH_INVALID = "Độ dài Họ tối đa 30 ký tự!";
        public static string LASTNAME_LENGTH_INVALID = "Độ dài Tên tối đa 30 ký tự!";
        public static string ADDRESS_LENGTH_INVALID = "Độ dài Địa chỉ tối đa 100 ký tự!";
        public static string STORE_LENGTH_INVALID = "Độ dài Tên cửa hàng tối đa 50 ký tự!";
    }
}
