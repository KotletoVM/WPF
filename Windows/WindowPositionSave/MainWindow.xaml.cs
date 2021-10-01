using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WindowPositionSave
{
    // Данное приложение для хранения данных использует settings файл.
    // Есть два вида настроек settings:
    // 1) Application-scoped - эти значения не могут меняться на этапе выполнения. Обычно это ConnectionString или подобные значения.
    // 2) User-scoped - эти значения могут меняться в процессе выполнения приложения (например, размеры окна, цвет и т.д.)
    // Файл settings находится в папке Properties в Solution Explorer
    // Данные самого приложения, записанные в процессе выполнения, находятся в папке C:\Documents and Settings\AppData\AppName
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Вешаем обработчик на событие перед закрытием окна.
            Closing += new CancelEventHandler(MainWindow_Closing);

            // Восстанавливаем позицию на экране.
            Left = Properties.Settings.Default.WindowPosition.Left;
            Top = Properties.Settings.Default.WindowPosition.Top;
            // Востанавливаем размеры окна.
            Width = Properties.Settings.Default.WindowPosition.Width;
            Height = Properties.Settings.Default.WindowPosition.Height;
            // Востанавливаем заголовок окна.
            Title = Properties.Settings.Default.Title;
        }
        private void MainWindow_Closing(object sender, CancelEventArgs e)
        {
            // RestoreBounds - Возвращает размер и расположение окна перед тем, как оно было свернуто или развернуто.
            Properties.Settings.Default.WindowPosition = this.RestoreBounds;
            //// ОШИБКА! Настройки Application-scoped нельзя изменить.
            //Properties.Settings.Default.Title = Title;
            // Сохранение настроек.
            Properties.Settings.Default.Save();
        }
    }
}

