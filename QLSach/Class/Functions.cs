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
        private static SqlCommand command;  // Tạo đối tượng SqlCommand thao tác với db
        private static SqlDataAdapter adapter;  // Tạo SQLDataAdapter trung gian dữ liệu
        private static DataTable table;         // Tạo đối tượng table để nhận dữ liệu về

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

        // Lấy dữ liệu từ database đổ vào đối tượng DataTable
        public static DataTable getDataToTable(string sql, SqlConnection connect)
        {
            command = new SqlCommand();         // Tạo đối tượng command thao tác với db
            command.Connection = connect;       // command này thực hiện truy vấn với kết nối là connect
            command.CommandText = sql;          // gán câu lệnh sql
            adapter = new SqlDataAdapter();     // Tạo đối tượng adapter
            adapter.SelectCommand = command;    // gán đối tượng command

            table = new DataTable();
            adapter.Fill(table);                // Khi Fill này chạy thì adapter.Selectcommand sẽ thực hiện truy vấn và đấp dữ liệu trả về vào table

            return table;
        }
    }
}
