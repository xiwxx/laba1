// ============================================================================
// RaceLog — Журнал тренировочных заездов (Windows Forms, .NET 10)
// ============================================================================
// Файл Form1.Designer.cs — автоматически генерируемая часть класса формы.
// Этот файл содержит код размещения элементов управления на форме,
// созданный визуальным конструктором Visual Studio.
// ВНИМАНИЕ: Этот файл обычно не редактируется вручную.
// ============================================================================

namespace RaceLog
{
    /// <summary>
    /// Автоматически создаваемая часть класса Form1.
    /// Содержит метод InitializeComponent, который размещает и настраивает
    /// все элементы управления формы.
    /// </summary>
    partial class Form1
    {
        /// <summary>
        /// Освобождение ресурсов, занятых формой.
        /// Вызывается при закрытии окна.
        /// </summary>
        /// <param name="disposing">true, если нужно освободить управляемые ресурсы.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора — не изменяйте
        /// содержимое этого метода с помощью редактора кода.
        /// Создаёт и настраивает все элементы управления на форме.
        /// </summary>
        private void InitializeComponent()
        {
            // ---- Создание объектов элементов управления ----
            txtDriver = new TextBox();
            cmbCar = new ComboBox();
            cmbTrack = new ComboBox();
            txtTime = new TextBox();
            lstResults = new ListBox();
            lblStatus = new Label();
            lblDriver = new Label();
            lblCar = new Label();
            lblTrack = new Label();
            lblTime = new Label();
            lblResults = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            SuspendLayout();

            // ================================================================
            // ТЕКСТОВОЕ ПОЛЕ: Имя пилота (txtDriver)
            // ================================================================
            txtDriver.Location = new Point(24, 54);
            txtDriver.Name = "txtDriver";
            txtDriver.Size = new Size(250, 28);
            txtDriver.TabIndex = 0;  // Первый элемент при нажатии Tab
            txtDriver.Text = "";     // Пустое при запуске

            // ================================================================
            // ВЫПАДАЮЩИЙ СПИСОК: Автомобиль (cmbCar)
            // ================================================================
            cmbCar.DropDownStyle = ComboBoxStyle.DropDownList;
            // DropDownList запрещает ввод произвольного текста —
            // пользователь может только выбирать из списка
            cmbCar.Items.AddRange(new object[] { "Street", "Sport", "Prototype" });
            cmbCar.Location = new Point(24, 124);
            cmbCar.Name = "cmbCar";
            cmbCar.Size = new Size(250, 28);
            cmbCar.TabIndex = 1;

            // ================================================================
            // ВЫПАДАЮЩИЙ СПИСОК: Трасса (cmbTrack)
            // ================================================================
            cmbTrack.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTrack.Items.AddRange(new object[] { "Учебный овал", "Городское кольцо", "Спринт" });
            cmbTrack.Location = new Point(24, 194);
            cmbTrack.Name = "cmbTrack";
            cmbTrack.Size = new Size(250, 28);
            cmbTrack.TabIndex = 2;

            // ================================================================
            // ТЕКСТОВОЕ ПОЛЕ: Время круга (txtTime)
            // ================================================================
            txtTime.Location = new Point(24, 264);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(250, 28);
            txtTime.TabIndex = 3;
            txtTime.Text = "";

            // ================================================================
            // СПИСОК РЕЗУЛЬТАТОВ (lstResults)
            // ================================================================
            lstResults.FormattingEnabled = true;
            lstResults.HorizontalScrollbar = true; // Горизонтальная прокрутка для длинных записей
            lstResults.ItemHeight = 20;
            lstResults.Location = new Point(304, 54);
            lstResults.Name = "lstResults";
            lstResults.SelectionMode = SelectionMode.One; // Можно выбрать только одну строку
            lstResults.Size = new Size(652, 296);
            lstResults.TabIndex = 6;

            // ================================================================
            // МЕТКА СОСТОЯНИЯ (lblStatus) — внизу формы
            // ================================================================
            lblStatus.AutoSize = false;       // Отключаем автоматический размер
            lblStatus.BorderStyle = BorderStyle.FixedSingle;
            lblStatus.Location = new Point(24, 434);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(932, 48);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Введите имя пилота";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;

            // ================================================================
            // МЕТОК-ПОДПИСЕЙ (Label) — поясняют назначение полей ввода
            // ================================================================

            // Подпись «Пилот:» над полем txtDriver
            lblDriver.AutoSize = true;
            lblDriver.Location = new Point(24, 30);
            lblDriver.Name = "lblDriver";
            lblDriver.Size = new Size(100, 21);
            lblDriver.Text = "Пилот:";

            // Подпись «Автомобиль:» над списком cmbCar
            lblCar.AutoSize = true;
            lblCar.Location = new Point(24, 100);
            lblCar.Name = "lblCar";
            lblCar.Size = new Size(100, 21);
            lblCar.Text = "Автомобиль:";

            // Подпись «Трасса:» над списком cmbTrack
            lblTrack.AutoSize = true;
            lblTrack.Location = new Point(24, 170);
            lblTrack.Name = "lblTrack";
            lblTrack.Size = new Size(100, 21);
            lblTrack.Text = "Трасса:";

            // Подпись «Время круга, с:» над полем txtTime
            lblTime.AutoSize = true;
            lblTime.Location = new Point(24, 240);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(150, 21);
            lblTime.Text = "Время круга, с:";

            // Подпись «Результаты заездов:» над списком lstResults
            lblResults.AutoSize = true;
            lblResults.Location = new Point(304, 30);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(150, 21);
            lblResults.Text = "Результаты заездов:";

            // ================================================================
            // КНОПКИ управления
            // ================================================================

            // Кнопка «Добавить» — основное действие (Enter тоже вызывает)
            btnAdd.Location = new Point(24, 320);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(250, 35);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyles = true;
            // Привязка события Click к обработчику btnAdd_Click
            btnAdd.Click += new EventHandler(this.btnAdd_Click);

            // Кнопка «Очистить поля» — сбрасывает поля ввода, не трогая список
            btnClear.Location = new Point(24, 365);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(250, 35);
            btnClear.TabIndex = 5;
            btnClear.Text = "Очистить поля";
            btnClear.UseVisualStyles = true;
            btnClear.Click += new EventHandler(this.btnClear_Click);

            // Кнопка «Удалить выбранную» — удаляет выбранную строку из списка
            btnDelete.Location = new Point(304, 365);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(250, 35);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Удалить выбранную";
            btnDelete.UseVisualStyles = true;
            btnDelete.Click += new EventHandler(this.btnDelete_Click);

            // ================================================================
            // НАСТРОЙКИ САМОЙ ФОРМЫ (окна приложения)
            // ================================================================
            AcceptButton = btnAdd;    // Enter вызывает кнопку «Добавить»
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 500);  // Внутренний размер окна
            Controls.Add(lblDriver);
            Controls.Add(txtDriver);
            Controls.Add(lblCar);
            Controls.Add(cmbCar);
            Controls.Add(lblTrack);
            Controls.Add(cmbTrack);
            Controls.Add(lblTime);
            Controls.Add(txtTime);
            Controls.Add(lblResults);
            Controls.Add(lstResults);
            Controls.Add(btnAdd);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(lblStatus);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle; // Фиксированный размер
            MaximizeBox = false;   // Запрет развёртывания на весь экран
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen; // Окно по центру экрана
            Text = "Журнал заездов"; // Заголовок окна
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // Объявление полей — ссылок на элементы управления формы.
        // Каждое поле соответствует одному элементу в дизайнере.
        private TextBox txtDriver;       // Поле ввода имени пилота
        private ComboBox cmbCar;         // Выпадающий список автомобилей
        private ComboBox cmbTrack;       // Выпадающий список трасс
        private TextBox txtTime;         // Поле ввода времени круга
        private ListBox lstResults;      // Список результатов заездов
        private Label lblStatus;         // Метка для сообщений (статус)
        private Label lblDriver;         // Подпись «Пилот:»
        private Label lblCar;            // Подпись «Автомобиль:»
        private Label lblTrack;          // Подпись «Трасса:»
        private Label lblTime;           // Подпись «Время круга, с:»
        private Label lblResults;        // Подпись «Результаты заездов:»
        private Button btnAdd;           // Кнопка «Добавить»
        private Button btnDelete;        // Кнопка «Удалить выбранную»
        private Button btnClear;         // Кнопка «Очистить поля»

        // Обязательное поле для конструктора форм Windows Forms.
        // Хранит список компонентов формы для корректного освобождения ресурсов.
        private System.ComponentModel.IContainer components = null;
    }
}
