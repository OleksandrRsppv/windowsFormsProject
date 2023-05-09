
namespace PO_W_704
{
    partial class GraphicsWorld
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.drawParallelogram = new System.Windows.Forms.Button();
            this.moveParallelogram = new System.Windows.Forms.Button();
            this.deleteParallelogram = new System.Windows.Forms.Button();
            this.deleteCircle = new System.Windows.Forms.Button();
            this.moveCircle = new System.Windows.Forms.Button();
            this.drawCircle = new System.Windows.Forms.Button();
            this.deleteFig3D = new System.Windows.Forms.Button();
            this.moveFig3D = new System.Windows.Forms.Button();
            this.drawFig3D = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawParallelogram
            // 
            this.drawParallelogram.Location = new System.Drawing.Point(5, 19);
            this.drawParallelogram.Name = "drawParallelogram";
            this.drawParallelogram.Size = new System.Drawing.Size(64, 20);
            this.drawParallelogram.TabIndex = 0;
            this.drawParallelogram.Text = "DRAW";
            this.drawParallelogram.UseVisualStyleBackColor = true;
            this.drawParallelogram.Click += new System.EventHandler(this.DrawParallelogram_Click);
            // 
            // moveParallelogram
            // 
            this.moveParallelogram.Location = new System.Drawing.Point(75, 19);
            this.moveParallelogram.Name = "moveParallelogram";
            this.moveParallelogram.Size = new System.Drawing.Size(64, 20);
            this.moveParallelogram.TabIndex = 1;
            this.moveParallelogram.Text = "MOVE";
            this.moveParallelogram.UseVisualStyleBackColor = true;
            this.moveParallelogram.Click += new System.EventHandler(this.MoveParallelogram_Click);
            // 
            // deleteParallelogram
            // 
            this.deleteParallelogram.Location = new System.Drawing.Point(144, 19);
            this.deleteParallelogram.Name = "deleteParallelogram";
            this.deleteParallelogram.Size = new System.Drawing.Size(64, 20);
            this.deleteParallelogram.TabIndex = 2;
            this.deleteParallelogram.Text = "DELETE";
            this.deleteParallelogram.UseVisualStyleBackColor = true;
            this.deleteParallelogram.Click += new System.EventHandler(this.DeleteParallelogram_Click);
            // 
            // deleteCircle
            // 
            this.deleteCircle.Location = new System.Drawing.Point(144, 19);
            this.deleteCircle.Name = "deleteCircle";
            this.deleteCircle.Size = new System.Drawing.Size(64, 20);
            this.deleteCircle.TabIndex = 5;
            this.deleteCircle.Text = "DELETE";
            this.deleteCircle.UseVisualStyleBackColor = true;
            this.deleteCircle.Click += new System.EventHandler(this.DeleteCircle_Click);
            // 
            // moveCircle
            // 
            this.moveCircle.Location = new System.Drawing.Point(75, 19);
            this.moveCircle.Name = "moveCircle";
            this.moveCircle.Size = new System.Drawing.Size(64, 20);
            this.moveCircle.TabIndex = 4;
            this.moveCircle.Text = "MOVE";
            this.moveCircle.UseVisualStyleBackColor = true;
            this.moveCircle.Click += new System.EventHandler(this.MoveCircle_Click);
            // 
            // drawCircle
            // 
            this.drawCircle.Location = new System.Drawing.Point(5, 19);
            this.drawCircle.Name = "drawCircle";
            this.drawCircle.Size = new System.Drawing.Size(64, 20);
            this.drawCircle.TabIndex = 3;
            this.drawCircle.Text = "DRAW";
            this.drawCircle.UseVisualStyleBackColor = true;
            this.drawCircle.Click += new System.EventHandler(this.DrawCircle_Click);
            // 
            // deleteFig3D
            // 
            this.deleteFig3D.Location = new System.Drawing.Point(5, 19);
            this.deleteFig3D.Name = "deleteFig3D";
            this.deleteFig3D.Size = new System.Drawing.Size(64, 20);
            this.deleteFig3D.TabIndex = 2;
            this.deleteFig3D.Text = "DRAW";
            // 
            // moveFig3D
            // 
            this.moveFig3D.Location = new System.Drawing.Point(75, 19);
            this.moveFig3D.Name = "moveFig3D";
            this.moveFig3D.Size = new System.Drawing.Size(64, 20);
            this.moveFig3D.TabIndex = 1;
            this.moveFig3D.Text = "MOVE";
            // 
            // drawFig3D
            // 
            this.drawFig3D.Location = new System.Drawing.Point(144, 19);
            this.drawFig3D.Name = "drawFig3D";
            this.drawFig3D.Size = new System.Drawing.Size(64, 20);
            this.drawFig3D.TabIndex = 0;
            this.drawFig3D.Text = "DELETE";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.drawParallelogram);
            this.groupBox1.Controls.Add(this.moveParallelogram);
            this.groupBox1.Controls.Add(this.deleteParallelogram);
            this.groupBox1.Location = new System.Drawing.Point(10, 335);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 45);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parallelogram";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.drawCircle);
            this.groupBox2.Controls.Add(this.moveCircle);
            this.groupBox2.Controls.Add(this.deleteCircle);
            this.groupBox2.Location = new System.Drawing.Point(238, 335);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 45);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Circle";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.drawFig3D);
            this.groupBox3.Controls.Add(this.moveFig3D);
            this.groupBox3.Controls.Add(this.deleteFig3D);
            this.groupBox3.Location = new System.Drawing.Point(462, 335);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(213, 45);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3D Figure";
            // 
            // GraphicsWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GraphicsWorld";
            this.Text = "GraphicsWorld";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button drawParallelogram;
        private System.Windows.Forms.Button moveParallelogram;
        private System.Windows.Forms.Button deleteParallelogram;
        private System.Windows.Forms.Button deleteCircle;
        private System.Windows.Forms.Button moveCircle;
        private System.Windows.Forms.Button drawCircle;
        private System.Windows.Forms.Button deleteFig3D;
        private System.Windows.Forms.Button moveFig3D;
        private System.Windows.Forms.Button drawFig3D;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

