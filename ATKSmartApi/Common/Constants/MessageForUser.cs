namespace ATKSmartApi.Common.Constants
{
    public static class MessageForUser
    {
        // REQUIRE
        public static string USERID_REQUIRE = "ID tài khoản không đúng!";
        public static string EMAIL_REQUIRE = "Email không thể trống!";
        public static string PASSWORD_REQUIRE = "Mật khẩu không thể trống!";
        public static string FIRSTNAME_REQUIRE = "Họ không thể trống!";
        public static string LASTNAME_REQUIRE = "Tên không thể trống!";
        public static string ADDRESS_REQUIRE = "Địa chỉ không thể trống!";
        public static string PHONENUMBER_REQUIRE = "Số điện thoại không thể trống!";

        // INVALID
        public static string LOGIN_INVALID = "Email hoặc mật khẩu không đúng!";
        

        // FAILD
        public static string REGISTER_FAILD = "Đăng ký không thành công!";

        // OBJECT INPUT INVALID
        public static string OBJ_INPUT_INVALID = "Dữ liệu đầu vào là rỗng! Vui lòng kiểm tra lại!";

        // NOTFOUND
        public static string USER_NOTFOUND = "Không tìm thấy tài khoản trong dữ liệu! Vui lòng kiểm tra lại!";
    }
}
