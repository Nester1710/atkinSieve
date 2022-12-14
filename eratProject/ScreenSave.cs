using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace atkinSieve
{
    class ScreenSave
    {
        /// <summary>
        /// Сохраняет изображение по выбранному пути
        /// </summary>
        /// <param name="gp">Элемент для скрина</param>
        public void SaveImage(GroupBox gp)
        {
            Control control = gp;
            System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(control.Width, control.Height); // отрисовали область
            control.DrawToBitmap(bitmap, control.ClientRectangle);

            SaveFileDialog savedialog = new SaveFileDialog();
            savedialog.Title = "Сохранение";
            savedialog.OverwritePrompt = true;
            savedialog.CheckPathExists = true;
            savedialog.Filter = "PNG (*.png)|*.png|JPG (*.jpg)|*.jpg"; // доступные форматы файла
            savedialog.ShowHelp = true;

            // проверка успешности сохранения изображения
            if (savedialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = savedialog.FileName;
                    bitmap.Save(path, ImageFormat.Png);
                    MessageBox.Show("Изображение успешно сохранено!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exc)
                {
                    MessageBox.Show($"Невозможно сохранить изображение\nПричина: {exc.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
