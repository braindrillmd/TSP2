﻿namespace TSP2
{
    partial class TSP2
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
            this.pictureBoxCanvas = new System.Windows.Forms.PictureBox();
            this.buttonDrawGraph = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxVerticesNumber = new System.Windows.Forms.TextBox();
            this.buttonGenerateGraph = new System.Windows.Forms.Button();
            this.buttonRandomTour = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPathLength = new System.Windows.Forms.TextBox();
            this.buttonMCE = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxIterations = new System.Windows.Forms.TextBox();
            this.buttonMutation = new System.Windows.Forms.Button();
            this.buttonCrossingOver = new System.Windows.Forms.Button();
            this.buttonGA = new System.Windows.Forms.Button();
            this.textBoxGAIterations = new System.Windows.Forms.TextBox();
            this.textBoxGACapacity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxGAThreadsNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonLoadMap = new System.Windows.Forms.Button();
            this.buttonEraseGraph = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.buttonSaveGraph = new System.Windows.Forms.Button();
            this.buttonLoadGraph = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCanvas
            // 
            this.pictureBoxCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCanvas.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxCanvas.Name = "pictureBoxCanvas";
            this.pictureBoxCanvas.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxCanvas.TabIndex = 0;
            this.pictureBoxCanvas.TabStop = false;
            this.pictureBoxCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxCanvas_MouseClick);
            // 
            // buttonDrawGraph
            // 
            this.buttonDrawGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDrawGraph.Location = new System.Drawing.Point(872, 81);
            this.buttonDrawGraph.Name = "buttonDrawGraph";
            this.buttonDrawGraph.Size = new System.Drawing.Size(124, 23);
            this.buttonDrawGraph.TabIndex = 1;
            this.buttonDrawGraph.Text = "Нарисовать граф";
            this.buttonDrawGraph.UseVisualStyleBackColor = true;
            this.buttonDrawGraph.Click += new System.EventHandler(this.buttonDrawGraph_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(869, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Число вершин:";
            // 
            // textBoxVerticesNumber
            // 
            this.textBoxVerticesNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxVerticesNumber.Location = new System.Drawing.Point(872, 55);
            this.textBoxVerticesNumber.Name = "textBoxVerticesNumber";
            this.textBoxVerticesNumber.Size = new System.Drawing.Size(124, 20);
            this.textBoxVerticesNumber.TabIndex = 3;
            this.textBoxVerticesNumber.TextChanged += new System.EventHandler(this.textBoxVerticesNumber_TextChanged);
            // 
            // buttonGenerateGraph
            // 
            this.buttonGenerateGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGenerateGraph.Location = new System.Drawing.Point(872, 11);
            this.buttonGenerateGraph.Name = "buttonGenerateGraph";
            this.buttonGenerateGraph.Size = new System.Drawing.Size(124, 23);
            this.buttonGenerateGraph.TabIndex = 4;
            this.buttonGenerateGraph.Text = "Сгенерировать граф";
            this.buttonGenerateGraph.UseVisualStyleBackColor = true;
            this.buttonGenerateGraph.Click += new System.EventHandler(this.buttonGenerateGraph_Click);
            // 
            // buttonRandomTour
            // 
            this.buttonRandomTour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRandomTour.Location = new System.Drawing.Point(872, 111);
            this.buttonRandomTour.Name = "buttonRandomTour";
            this.buttonRandomTour.Size = new System.Drawing.Size(124, 23);
            this.buttonRandomTour.TabIndex = 5;
            this.buttonRandomTour.Text = "Случайный путь";
            this.buttonRandomTour.UseVisualStyleBackColor = true;
            this.buttonRandomTour.Click += new System.EventHandler(this.buttonRandomTour_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(869, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Длина пути:";
            // 
            // textBoxPathLength
            // 
            this.textBoxPathLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPathLength.Location = new System.Drawing.Point(872, 153);
            this.textBoxPathLength.Name = "textBoxPathLength";
            this.textBoxPathLength.ReadOnly = true;
            this.textBoxPathLength.Size = new System.Drawing.Size(124, 20);
            this.textBoxPathLength.TabIndex = 7;
            // 
            // buttonMCE
            // 
            this.buttonMCE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMCE.Location = new System.Drawing.Point(872, 179);
            this.buttonMCE.Name = "buttonMCE";
            this.buttonMCE.Size = new System.Drawing.Size(124, 23);
            this.buttonMCE.TabIndex = 8;
            this.buttonMCE.Text = "ММК";
            this.buttonMCE.UseVisualStyleBackColor = true;
            this.buttonMCE.Click += new System.EventHandler(this.buttonMCE_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(872, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Итерации:";
            // 
            // textBoxIterations
            // 
            this.textBoxIterations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIterations.Location = new System.Drawing.Point(872, 226);
            this.textBoxIterations.Name = "textBoxIterations";
            this.textBoxIterations.Size = new System.Drawing.Size(124, 20);
            this.textBoxIterations.TabIndex = 10;
            this.textBoxIterations.TextChanged += new System.EventHandler(this.textBoxIterations_TextChanged);
            // 
            // buttonMutation
            // 
            this.buttonMutation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMutation.Location = new System.Drawing.Point(872, 252);
            this.buttonMutation.Name = "buttonMutation";
            this.buttonMutation.Size = new System.Drawing.Size(124, 23);
            this.buttonMutation.TabIndex = 12;
            this.buttonMutation.Text = "Мутация";
            this.buttonMutation.UseVisualStyleBackColor = true;
            this.buttonMutation.Click += new System.EventHandler(this.buttonMutation_Click);
            // 
            // buttonCrossingOver
            // 
            this.buttonCrossingOver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrossingOver.Location = new System.Drawing.Point(872, 282);
            this.buttonCrossingOver.Name = "buttonCrossingOver";
            this.buttonCrossingOver.Size = new System.Drawing.Size(124, 23);
            this.buttonCrossingOver.TabIndex = 13;
            this.buttonCrossingOver.Text = "Кроссинговер";
            this.buttonCrossingOver.UseVisualStyleBackColor = true;
            this.buttonCrossingOver.Click += new System.EventHandler(this.buttonCrossingOver_Click);
            // 
            // buttonGA
            // 
            this.buttonGA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGA.Location = new System.Drawing.Point(872, 312);
            this.buttonGA.Name = "buttonGA";
            this.buttonGA.Size = new System.Drawing.Size(124, 23);
            this.buttonGA.TabIndex = 14;
            this.buttonGA.Text = "ГА";
            this.buttonGA.UseVisualStyleBackColor = true;
            this.buttonGA.Click += new System.EventHandler(this.buttonGA_Click);
            // 
            // textBoxGAIterations
            // 
            this.textBoxGAIterations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxGAIterations.Location = new System.Drawing.Point(872, 358);
            this.textBoxGAIterations.Name = "textBoxGAIterations";
            this.textBoxGAIterations.Size = new System.Drawing.Size(124, 20);
            this.textBoxGAIterations.TabIndex = 15;
            this.textBoxGAIterations.TextChanged += new System.EventHandler(this.textBoxGAIterations_TextChanged);
            // 
            // textBoxGACapacity
            // 
            this.textBoxGACapacity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxGACapacity.Location = new System.Drawing.Point(872, 401);
            this.textBoxGACapacity.Name = "textBoxGACapacity";
            this.textBoxGACapacity.Size = new System.Drawing.Size(124, 20);
            this.textBoxGACapacity.TabIndex = 16;
            this.textBoxGACapacity.TextChanged += new System.EventHandler(this.textBoxGACapacity_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(872, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Количество итераций:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(872, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Размер популяции:";
            // 
            // textBoxGAThreadsNumber
            // 
            this.textBoxGAThreadsNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxGAThreadsNumber.Location = new System.Drawing.Point(872, 440);
            this.textBoxGAThreadsNumber.Name = "textBoxGAThreadsNumber";
            this.textBoxGAThreadsNumber.Size = new System.Drawing.Size(124, 20);
            this.textBoxGAThreadsNumber.TabIndex = 19;
            this.textBoxGAThreadsNumber.TextChanged += new System.EventHandler(this.textBoxGAThreadsNumber_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(872, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Число потоков:";
            // 
            // buttonLoadMap
            // 
            this.buttonLoadMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoadMap.Location = new System.Drawing.Point(872, 466);
            this.buttonLoadMap.Name = "buttonLoadMap";
            this.buttonLoadMap.Size = new System.Drawing.Size(124, 23);
            this.buttonLoadMap.TabIndex = 21;
            this.buttonLoadMap.Text = "Загрузить карту";
            this.buttonLoadMap.UseVisualStyleBackColor = true;
            this.buttonLoadMap.Click += new System.EventHandler(this.buttonLoadMap_Click);
            // 
            // buttonEraseGraph
            // 
            this.buttonEraseGraph.Location = new System.Drawing.Point(872, 534);
            this.buttonEraseGraph.Name = "buttonEraseGraph";
            this.buttonEraseGraph.Size = new System.Drawing.Size(124, 23);
            this.buttonEraseGraph.TabIndex = 22;
            this.buttonEraseGraph.Text = "Стереть граф";
            this.buttonEraseGraph.UseVisualStyleBackColor = true;
            this.buttonEraseGraph.Click += new System.EventHandler(this.buttonEraseGraph_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(869, 492);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Время:";
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(872, 508);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.ReadOnly = true;
            this.textBoxTime.Size = new System.Drawing.Size(124, 20);
            this.textBoxTime.TabIndex = 24;
            // 
            // buttonSaveGraph
            // 
            this.buttonSaveGraph.Location = new System.Drawing.Point(872, 563);
            this.buttonSaveGraph.Name = "buttonSaveGraph";
            this.buttonSaveGraph.Size = new System.Drawing.Size(124, 23);
            this.buttonSaveGraph.TabIndex = 25;
            this.buttonSaveGraph.Text = "Сохранить граф";
            this.buttonSaveGraph.UseVisualStyleBackColor = true;
            this.buttonSaveGraph.Click += new System.EventHandler(this.buttonSaveGraph_Click);
            // 
            // buttonLoadGraph
            // 
            this.buttonLoadGraph.Location = new System.Drawing.Point(872, 593);
            this.buttonLoadGraph.Name = "buttonLoadGraph";
            this.buttonLoadGraph.Size = new System.Drawing.Size(124, 23);
            this.buttonLoadGraph.TabIndex = 26;
            this.buttonLoadGraph.Text = "Загрузить граф";
            this.buttonLoadGraph.UseVisualStyleBackColor = true;
            this.buttonLoadGraph.Click += new System.EventHandler(this.buttonLoadGraph_Click);
            // 
            // TSP2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.buttonLoadGraph);
            this.Controls.Add(this.buttonSaveGraph);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonEraseGraph);
            this.Controls.Add(this.buttonLoadMap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxGAThreadsNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxGACapacity);
            this.Controls.Add(this.textBoxGAIterations);
            this.Controls.Add(this.buttonGA);
            this.Controls.Add(this.buttonCrossingOver);
            this.Controls.Add(this.buttonMutation);
            this.Controls.Add(this.textBoxIterations);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonMCE);
            this.Controls.Add(this.textBoxPathLength);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonRandomTour);
            this.Controls.Add(this.buttonGenerateGraph);
            this.Controls.Add(this.textBoxVerticesNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDrawGraph);
            this.Controls.Add(this.pictureBoxCanvas);
            this.Name = "TSP2";
            this.Text = "TSP2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCanvas;
        private System.Windows.Forms.Button buttonDrawGraph;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxVerticesNumber;
        private System.Windows.Forms.Button buttonGenerateGraph;
        private System.Windows.Forms.Button buttonRandomTour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPathLength;
        private System.Windows.Forms.Button buttonMCE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxIterations;
        private System.Windows.Forms.Button buttonMutation;
        private System.Windows.Forms.Button buttonCrossingOver;
        private System.Windows.Forms.Button buttonGA;
        private System.Windows.Forms.TextBox textBoxGAIterations;
        private System.Windows.Forms.TextBox textBoxGACapacity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxGAThreadsNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonLoadMap;
        private System.Windows.Forms.Button buttonEraseGraph;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Button buttonSaveGraph;
        private System.Windows.Forms.Button buttonLoadGraph;
    }
}
