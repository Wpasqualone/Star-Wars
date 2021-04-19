
namespace Star_Wars
{
    partial class Form1
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
            this.id1 = new System.Windows.Forms.Label();
            this.PlanetInput = new System.Windows.Forms.TextBox();
            this.PlanetGenerate = new System.Windows.Forms.Button();
            this.PersonGenerate = new System.Windows.Forms.Button();
            this.PersonInput = new System.Windows.Forms.TextBox();
            this.id2 = new System.Windows.Forms.Label();
            this.SpeciesGenerate = new System.Windows.Forms.Button();
            this.SpeciesInput = new System.Windows.Forms.TextBox();
            this.id3 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listSpecies = new System.Windows.Forms.ListView();
            this.labelSpecies = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // id1
            // 
            this.id1.AutoSize = true;
            this.id1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id1.Location = new System.Drawing.Point(12, 38);
            this.id1.Name = "id1";
            this.id1.Size = new System.Drawing.Size(26, 20);
            this.id1.TabIndex = 0;
            this.id1.Text = "ID";
            // 
            // PlanetInput
            // 
            this.PlanetInput.Location = new System.Drawing.Point(86, 40);
            this.PlanetInput.Name = "PlanetInput";
            this.PlanetInput.Size = new System.Drawing.Size(29, 20);
            this.PlanetInput.TabIndex = 1;
            // 
            // PlanetGenerate
            // 
            this.PlanetGenerate.Location = new System.Drawing.Point(16, 62);
            this.PlanetGenerate.Name = "PlanetGenerate";
            this.PlanetGenerate.Size = new System.Drawing.Size(99, 23);
            this.PlanetGenerate.TabIndex = 2;
            this.PlanetGenerate.Text = "Generate Planet";
            this.PlanetGenerate.UseVisualStyleBackColor = true;
            this.PlanetGenerate.Click += new System.EventHandler(this.PlanetGenerate_Click);
            // 
            // PersonGenerate
            // 
            this.PersonGenerate.Location = new System.Drawing.Point(16, 198);
            this.PersonGenerate.Name = "PersonGenerate";
            this.PersonGenerate.Size = new System.Drawing.Size(99, 23);
            this.PersonGenerate.TabIndex = 5;
            this.PersonGenerate.Text = "Generate Person";
            this.PersonGenerate.UseVisualStyleBackColor = true;
            this.PersonGenerate.Click += new System.EventHandler(this.PersonGenerate_Click);
            // 
            // PersonInput
            // 
            this.PersonInput.Location = new System.Drawing.Point(86, 176);
            this.PersonInput.Name = "PersonInput";
            this.PersonInput.Size = new System.Drawing.Size(29, 20);
            this.PersonInput.TabIndex = 4;
            // 
            // id2
            // 
            this.id2.AutoSize = true;
            this.id2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id2.Location = new System.Drawing.Point(12, 174);
            this.id2.Name = "id2";
            this.id2.Size = new System.Drawing.Size(26, 20);
            this.id2.TabIndex = 3;
            this.id2.Text = "ID";
            // 
            // SpeciesGenerate
            // 
            this.SpeciesGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpeciesGenerate.Location = new System.Drawing.Point(16, 298);
            this.SpeciesGenerate.Name = "SpeciesGenerate";
            this.SpeciesGenerate.Size = new System.Drawing.Size(99, 23);
            this.SpeciesGenerate.TabIndex = 8;
            this.SpeciesGenerate.Text = "Generate Species";
            this.SpeciesGenerate.UseVisualStyleBackColor = true;
            this.SpeciesGenerate.Click += new System.EventHandler(this.SpeciesGenerate_Click);
            // 
            // SpeciesInput
            // 
            this.SpeciesInput.Location = new System.Drawing.Point(86, 276);
            this.SpeciesInput.Name = "SpeciesInput";
            this.SpeciesInput.Size = new System.Drawing.Size(29, 20);
            this.SpeciesInput.TabIndex = 7;
            // 
            // id3
            // 
            this.id3.AutoSize = true;
            this.id3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id3.Location = new System.Drawing.Point(12, 274);
            this.id3.Name = "id3";
            this.id3.Size = new System.Drawing.Size(26, 20);
            this.id3.TabIndex = 6;
            this.id3.Text = "ID";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(211, 19);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(49, 20);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "Temp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Temp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Temp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(211, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Temp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(211, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Temp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(211, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Temp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(211, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Temp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(211, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Temp";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(211, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Temp";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(211, 407);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Temp";
            // 
            // listSpecies
            // 
            this.listSpecies.HideSelection = false;
            this.listSpecies.Location = new System.Drawing.Point(426, 154);
            this.listSpecies.Name = "listSpecies";
            this.listSpecies.Size = new System.Drawing.Size(280, 184);
            this.listSpecies.TabIndex = 19;
            this.listSpecies.UseCompatibleStateImageBehavior = false;
            // 
            // labelSpecies
            // 
            this.labelSpecies.AutoSize = true;
            this.labelSpecies.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpecies.Location = new System.Drawing.Point(515, 126);
            this.labelSpecies.Name = "labelSpecies";
            this.labelSpecies.Size = new System.Drawing.Size(83, 25);
            this.labelSpecies.TabIndex = 20;
            this.labelSpecies.Text = "Species";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 448);
            this.Controls.Add(this.labelSpecies);
            this.Controls.Add(this.listSpecies);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.SpeciesGenerate);
            this.Controls.Add(this.SpeciesInput);
            this.Controls.Add(this.id3);
            this.Controls.Add(this.PersonGenerate);
            this.Controls.Add(this.PersonInput);
            this.Controls.Add(this.id2);
            this.Controls.Add(this.PlanetGenerate);
            this.Controls.Add(this.PlanetInput);
            this.Controls.Add(this.id1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id1;
        private System.Windows.Forms.TextBox PlanetInput;
        private System.Windows.Forms.Button PlanetGenerate;
        private System.Windows.Forms.Button PersonGenerate;
        private System.Windows.Forms.TextBox PersonInput;
        private System.Windows.Forms.Label id2;
        private System.Windows.Forms.Button SpeciesGenerate;
        private System.Windows.Forms.TextBox SpeciesInput;
        private System.Windows.Forms.Label id3;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView listSpecies;
        private System.Windows.Forms.Label labelSpecies;
    }
}

