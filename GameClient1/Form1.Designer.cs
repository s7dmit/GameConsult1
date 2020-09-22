namespace GameClient1
{
    partial class PersonForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.clmPersonName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmRace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmClass = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmExperience = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPower = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDexterity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmIntellect = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmWisdom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHealth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmMana = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmPersonName,
            this.clmGender,
            this.clmRace,
            this.clmClass,
            this.clmExperience,
            this.clmPower,
            this.clmDexterity,
            this.clmIntellect,
            this.clmWisdom,
            this.clmHealth,
            this.clmMana});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(937, 350);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // clmPersonName
            // 
            this.clmPersonName.Text = "Персонаж";
            this.clmPersonName.Width = 90;
            // 
            // clmGender
            // 
            this.clmGender.Text = "Пол";
            // 
            // clmRace
            // 
            this.clmRace.Text = "Раса";
            this.clmRace.Width = 80;
            // 
            // clmClass
            // 
            this.clmClass.Text = "Класс";
            this.clmClass.Width = 80;
            // 
            // clmExperience
            // 
            this.clmExperience.Text = "Уровень";
            this.clmExperience.Width = 80;
            // 
            // clmPower
            // 
            this.clmPower.Text = "Сила";
            this.clmPower.Width = 80;
            // 
            // clmDexterity
            // 
            this.clmDexterity.Text = "Ловкость";
            this.clmDexterity.Width = 90;
            // 
            // clmIntellect
            // 
            this.clmIntellect.Text = "Интеллект";
            this.clmIntellect.Width = 100;
            // 
            // clmWisdom
            // 
            this.clmWisdom.Text = "Мудрость";
            this.clmWisdom.Width = 90;
            // 
            // clmHealth
            // 
            this.clmHealth.Text = "Здоровье";
            this.clmHealth.Width = 90;
            // 
            // clmMana
            // 
            this.clmMana.Text = "Мана";
            this.clmMana.Width = 90;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 394);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(129, 44);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(215, 394);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(129, 44);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(415, 394);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(129, 44);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Изменить...";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(598, 394);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(129, 44);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.listView1);
            this.Name = "PersonForm";
            this.Text = "Персонажи игрока";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ColumnHeader clmPersonName;
        private System.Windows.Forms.ColumnHeader clmGender;
        private System.Windows.Forms.ColumnHeader clmRace;
        private System.Windows.Forms.ColumnHeader clmClass;
        private System.Windows.Forms.ColumnHeader clmExperience;
        private System.Windows.Forms.ColumnHeader clmPower;
        private System.Windows.Forms.ColumnHeader clmDexterity;
        private System.Windows.Forms.ColumnHeader clmIntellect;
        private System.Windows.Forms.ColumnHeader clmWisdom;
        private System.Windows.Forms.ColumnHeader clmHealth;
        private System.Windows.Forms.ColumnHeader clmMana;
    }
}

