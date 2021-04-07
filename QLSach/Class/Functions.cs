using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Data;
using System.Data.SqlClient;

namespace QLSach.Class
{
    

    class Functions
    {
        //private static SqlCommand command;  // Tạo đối tượng SqlCommand thao tác với db
        //private static SqlDataAdapter adapter;  // Tạo SQLDataAdapter trung gian dữ liệu
        //private static DataTable table;         // Tạo đối tượng table để nhận dữ liệu về

        public static void customMaterialForm(MaterialForm form)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(form);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, Primary.BlueGrey900,
                Primary.BlueGrey500,
                Accent.LightBlue200,
                TextShade.WHITE
            );

            //var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            //materialSkinManager.EnforceBackcolorOnAllComponents = true;
            //materialSkinManager.AddFormToManage(form);

            //materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
            //    MaterialSkin.Primary.Indigo500,
            //    MaterialSkin.Primary.Indigo700,
            //    MaterialSkin.Primary.Indigo100,
            //    MaterialSkin.Accent.Orange400,
            //    TextShade.WHITE
            //);
        }

        /// <summary>
        /// Tạo một chuỗi random
        /// </summary>
        /// <param name="length">độ dài chuỗi random muốn nhận về</param>
        /// <returns>một chuỗi ngẫu nhiên có độ dài như tham số length truyền vào</returns>
        public static string randomString(int length)
        {
            
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
