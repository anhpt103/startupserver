namespace ATKSmartApi.Common.Constants
{
    public static class MessageForUser
    {
        // DUPLICATE
        public static string EMAIL_DUPLICATE = "Email này đã sử dụng để đăng ký!"; 

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

        // OBJECT MAPPER INVALID
        public static string OBJ_MAPPER_INVALID = "Dữ liệu đầu vào là rỗng! Vui lòng kiểm tra lại!";

        // NOTFOUND
        public static string USER_NOTFOUND = "Không tìm thấy tài khoản trong dữ liệu! Vui lòng kiểm tra lại!";
        public static string STORE_NOTFOUND = "Không tìm thấy cửa hàng trong dữ liệu! Vui lòng kiểm tra lại!";

        // EXECUTE INSERT, UPDATE, DELETE FAILD
        public static string EXECUTE_CRUD_FAILD = "Xử lý lưu dữ liệu không thành công";
    }
}
