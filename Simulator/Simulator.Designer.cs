namespace Simulator
{
    partial class Simulator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtInputNumber = new TextBox();
            txtOutputNumber = new TextBox();
            btnChooseIOs = new Button();
            btnSaveToFiles = new Button();
            btnStartStopSimulation = new Button();
            label1 = new Label();
            label2 = new Label();
            txtOutputsFromSimulation = new TextBox();
            linkToGitHub = new LinkLabel();
            SuspendLayout();
            // 
            // txtInputNumber
            // 
            txtInputNumber.Location = new Point(71, 12);
            txtInputNumber.Name = "txtInputNumber";
            txtInputNumber.Size = new Size(45, 23);
            txtInputNumber.TabIndex = 0;
            // 
            // txtOutputNumber
            // 
            txtOutputNumber.Location = new Point(71, 41);
            txtOutputNumber.Name = "txtOutputNumber";
            txtOutputNumber.Size = new Size(45, 23);
            txtOutputNumber.TabIndex = 1;
            // 
            // btnChooseIOs
            // 
            btnChooseIOs.Location = new Point(12, 70);
            btnChooseIOs.Name = "btnChooseIOs";
            btnChooseIOs.Size = new Size(104, 23);
            btnChooseIOs.TabIndex = 2;
            btnChooseIOs.Text = "Select IOs";
            btnChooseIOs.UseVisualStyleBackColor = true;
            btnChooseIOs.Click += btnChooseIOs_Click;
            // 
            // btnSaveToFiles
            // 
            btnSaveToFiles.Location = new Point(12, 362);
            btnSaveToFiles.Name = "btnSaveToFiles";
            btnSaveToFiles.Size = new Size(104, 23);
            btnSaveToFiles.TabIndex = 4;
            btnSaveToFiles.Text = "Save setup to file";
            btnSaveToFiles.UseVisualStyleBackColor = true;
            btnSaveToFiles.Click += btnSaveToFiles_Click;
            // 
            // btnStartStopSimulation
            // 
            btnStartStopSimulation.Location = new Point(12, 403);
            btnStartStopSimulation.Name = "btnStartStopSimulation";
            btnStartStopSimulation.Size = new Size(104, 40);
            btnStartStopSimulation.TabIndex = 5;
            btnStartStopSimulation.Text = "Start/Stop simulation";
            btnStartStopSimulation.UseVisualStyleBackColor = true;
            btnStartStopSimulation.Click += btnStartStopSimulation_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 5;
            label1.Text = "Inputs:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 6;
            label2.Text = "Outputs:";
            // 
            // txtOutputsFromSimulation
            // 
            txtOutputsFromSimulation.Location = new Point(165, 413);
            txtOutputsFromSimulation.Name = "txtOutputsFromSimulation";
            txtOutputsFromSimulation.PlaceholderText = "Output";
            txtOutputsFromSimulation.ReadOnly = true;
            txtOutputsFromSimulation.Size = new Size(262, 23);
            txtOutputsFromSimulation.TabIndex = 6;
            // 
            // linkToGitHub
            // 
            linkToGitHub.AutoSize = true;
            linkToGitHub.Location = new Point(12, 115);
            linkToGitHub.Name = "linkToGitHub";
            linkToGitHub.Size = new Size(67, 15);
            linkToGitHub.TabIndex = 3;
            linkToGitHub.TabStop = true;
            linkToGitHub.Text = "GitHub link";
            linkToGitHub.LinkClicked += linkToGitHub_LinkClicked;
            // 
            // Simulator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 455);
            Controls.Add(linkToGitHub);
            Controls.Add(txtOutputsFromSimulation);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnStartStopSimulation);
            Controls.Add(btnSaveToFiles);
            Controls.Add(btnChooseIOs);
            Controls.Add(txtOutputNumber);
            Controls.Add(txtInputNumber);
            Name = "Simulator";
            Text = "PLC Simulator";
            Resize += Simulator_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInputNumber;
        private TextBox txtOutputNumber;
        private Button btnChooseIOs;
        private Button btnSaveToFiles;
        private Button btnStartStopSimulation;
        private Label label1;
        private Label label2;
        private TextBox txtOutputsFromSimulation;
        private LinkLabel linkToGitHub;
    }
}
