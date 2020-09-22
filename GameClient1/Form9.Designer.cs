namespace GameClient1
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn1Player = new System.Windows.Forms.Button();
            this.btn2GameSession = new System.Windows.Forms.Button();
            this.btn3Person = new System.Windows.Forms.Button();
            this.btn4Race = new System.Windows.Forms.Button();
            this.btn5Class = new System.Windows.Forms.Button();
            this.btn6Item = new System.Windows.Forms.Button();
            this.btn7Spell = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1Player
            // 
            this.btn1Player.Location = new System.Drawing.Point(14, 12);
            this.btn1Player.Name = "btn1Player";
            this.btn1Player.Size = new System.Drawing.Size(153, 51);
            this.btn1Player.TabIndex = 0;
            this.btn1Player.Text = "Игроки";
            this.btn1Player.UseVisualStyleBackColor = true;
            this.btn1Player.Click += new System.EventHandler(this.btn1Player_Click);
            // 
            // btn2GameSession
            // 
            this.btn2GameSession.Location = new System.Drawing.Point(14, 87);
            this.btn2GameSession.Name = "btn2GameSession";
            this.btn2GameSession.Size = new System.Drawing.Size(153, 51);
            this.btn2GameSession.TabIndex = 1;
            this.btn2GameSession.Text = "Игровые сессии";
            this.btn2GameSession.UseVisualStyleBackColor = true;
            this.btn2GameSession.Click += new System.EventHandler(this.btn2GameSession_Click);
            // 
            // btn3Person
            // 
            this.btn3Person.Location = new System.Drawing.Point(14, 165);
            this.btn3Person.Name = "btn3Person";
            this.btn3Person.Size = new System.Drawing.Size(153, 53);
            this.btn3Person.TabIndex = 2;
            this.btn3Person.Text = "Персонажи";
            this.btn3Person.UseVisualStyleBackColor = true;
            this.btn3Person.Click += new System.EventHandler(this.btn3Person_Click);
            // 
            // btn4Race
            // 
            this.btn4Race.Location = new System.Drawing.Point(14, 244);
            this.btn4Race.Name = "btn4Race";
            this.btn4Race.Size = new System.Drawing.Size(153, 53);
            this.btn4Race.TabIndex = 3;
            this.btn4Race.Text = "Расы";
            this.btn4Race.UseVisualStyleBackColor = true;
            this.btn4Race.Click += new System.EventHandler(this.btn4Race_Click);
            // 
            // btn5Class
            // 
            this.btn5Class.Location = new System.Drawing.Point(14, 323);
            this.btn5Class.Name = "btn5Class";
            this.btn5Class.Size = new System.Drawing.Size(153, 54);
            this.btn5Class.TabIndex = 4;
            this.btn5Class.Text = "Классы";
            this.btn5Class.UseVisualStyleBackColor = true;
            this.btn5Class.Click += new System.EventHandler(this.btn5Class_Click);
            // 
            // btn6Item
            // 
            this.btn6Item.Location = new System.Drawing.Point(14, 405);
            this.btn6Item.Name = "btn6Item";
            this.btn6Item.Size = new System.Drawing.Size(153, 49);
            this.btn6Item.TabIndex = 5;
            this.btn6Item.Text = "Предметы";
            this.btn6Item.UseVisualStyleBackColor = true;
            this.btn6Item.Click += new System.EventHandler(this.btn6Item_Click);
            // 
            // btn7Spell
            // 
            this.btn7Spell.Location = new System.Drawing.Point(14, 482);
            this.btn7Spell.Name = "btn7Spell";
            this.btn7Spell.Size = new System.Drawing.Size(153, 52);
            this.btn7Spell.TabIndex = 6;
            this.btn7Spell.Text = "Заклинания";
            this.btn7Spell.UseVisualStyleBackColor = true;
            this.btn7Spell.Click += new System.EventHandler(this.btn7Spell_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 543);
            this.ControlBox = false;
            this.Controls.Add(this.btn7Spell);
            this.Controls.Add(this.btn6Item);
            this.Controls.Add(this.btn5Class);
            this.Controls.Add(this.btn4Race);
            this.Controls.Add(this.btn3Person);
            this.Controls.Add(this.btn2GameSession);
            this.Controls.Add(this.btn1Player);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuForm";
            this.Text = "Form9";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1Player;
        private System.Windows.Forms.Button btn2GameSession;
        private System.Windows.Forms.Button btn3Person;
        private System.Windows.Forms.Button btn4Race;
        private System.Windows.Forms.Button btn5Class;
        private System.Windows.Forms.Button btn6Item;
        private System.Windows.Forms.Button btn7Spell;
    }
}