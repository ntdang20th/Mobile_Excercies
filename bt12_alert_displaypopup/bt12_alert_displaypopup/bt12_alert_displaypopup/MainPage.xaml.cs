using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace bt12_alert_displaypopup
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Username.Text = Preferences.Get("user", "");
            password.Text = Preferences.Get("pass", "");
            ckbRemember.IsChecked = Preferences.ContainsKey("pass");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string user = Username.Text.Trim();
            string pass = password.Text.Trim();
            bool ischecked = ckbRemember.IsChecked;
            bool islogin = user == pass ? true : false;
            if (islogin)
                if (ischecked)
                {
                    DisplayAlert("Thông báo đăng nhập", "Đăng nhập thành công! Nhớ mật khẩu.", "OK");
                    Preferences.Set("user", user);
                    Preferences.Set("pass", pass);
                }
                else
                {
                    DisplayAlert("Thông báo đăng nhập", "Đăng nhập thành công! Không lưu mật khẩu.", "OK");
                    Preferences.Clear();
                }
            else
                DisplayAlert("Thông báo đăng nhập", "Đăng nhập thất bại. Vui lòng kiểm tra tên đăng nhập hoặc mật khẩu.", "OK");
        }
    }
}
