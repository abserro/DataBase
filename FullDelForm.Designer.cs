
namespace LR7_BD
{
    partial class FullDelForm
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
            this.FullDelButton = new System.Windows.Forms.Button();
            this.type = new System.Windows.Forms.TextBox();
            this.time = new System.Windows.Forms.MaskedTextBox();
            this.day = new System.Windows.Forms.MaskedTextBox();
            this.numTeacher = new System.Windows.Forms.MaskedTextBox();
            this.idSubject = new System.Windows.Forms.MaskedTextBox();
            this.numGroup = new System.Windows.Forms.MaskedTextBox();
            this.numAudit = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FullDelButton
            // 
            this.FullDelButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.FullDelButton.FlatAppearance.BorderSize = 0;
            this.FullDelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FullDelButton.Location = new System.Drawing.Point(517, 84);
            this.FullDelButton.Name = "FullDelButton";
            this.FullDelButton.Size = new System.Drawing.Size(279, 42);
            this.FullDelButton.TabIndex = 29;
            this.FullDelButton.Text = "Удалить занятие";
            this.FullDelButton.UseVisualStyleBackColor = false;
            this.FullDelButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(1121, 36);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(160, 32);
            this.type.TabIndex = 28;
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(939, 36);
            this.time.Mask = "00:00";
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(175, 32);
            this.time.TabIndex = 27;
            this.time.ValidatingType = typeof(System.DateTime);
            // 
            // day
            // 
            this.day.Location = new System.Drawing.Point(760, 36);
            this.day.Mask = "00/00/0000";
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(163, 32);
            this.day.TabIndex = 26;
            this.day.ValidatingType = typeof(System.DateTime);
            // 
            // numTeacher
            // 
            this.numTeacher.Location = new System.Drawing.Point(581, 36);
            this.numTeacher.Mask = "00";
            this.numTeacher.Name = "numTeacher";
            this.numTeacher.Size = new System.Drawing.Size(167, 32);
            this.numTeacher.TabIndex = 25;
            // 
            // idSubject
            // 
            this.idSubject.Location = new System.Drawing.Point(333, 36);
            this.idSubject.Mask = "00";
            this.idSubject.Name = "idSubject";
            this.idSubject.Size = new System.Drawing.Size(236, 32);
            this.idSubject.TabIndex = 24;
            // 
            // numGroup
            // 
            this.numGroup.Location = new System.Drawing.Point(187, 36);
            this.numGroup.Mask = "0000";
            this.numGroup.Name = "numGroup";
            this.numGroup.Size = new System.Drawing.Size(134, 32);
            this.numGroup.TabIndex = 23;
            // 
            // numAudit
            // 
            this.numAudit.Location = new System.Drawing.Point(9, 36);
            this.numAudit.Mask = "0000";
            this.numAudit.Name = "numAudit";
            this.numAudit.Size = new System.Drawing.Size(166, 32);
            this.numAudit.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(1114, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 24);
            this.label7.TabIndex = 21;
            this.label7.Text = "Тип:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(935, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "Время проведения:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(756, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "День проведения:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(577, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Табельный номер:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(329, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Идентификатор предмета:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(183, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Номер группы:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Номер аудитории:";
            // 
            // FullDelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1304, 142);
            this.Controls.Add(this.FullDelButton);
            this.Controls.Add(this.type);
            this.Controls.Add(this.time);
            this.Controls.Add(this.day);
            this.Controls.Add(this.numTeacher);
            this.Controls.Add(this.idSubject);
            this.Controls.Add(this.numGroup);
            this.Controls.Add(this.numAudit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FullDelForm";
            this.Text = "Удаление занятия";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FullDelButton;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.MaskedTextBox time;
        private System.Windows.Forms.MaskedTextBox day;
        private System.Windows.Forms.MaskedTextBox numTeacher;
        private System.Windows.Forms.MaskedTextBox idSubject;
        private System.Windows.Forms.MaskedTextBox numGroup;
        private System.Windows.Forms.MaskedTextBox numAudit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}