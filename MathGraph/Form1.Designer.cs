namespace MathGraph
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sheet = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.импортироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матрицуСмежностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьГрафToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.функцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вывестиМатрицуСмежностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матрицаИнцидентностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.спискиСвязностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.selectToolStrip = new System.Windows.Forms.ToolStripButton();
            this.drawVertexToolStrip = new System.Windows.Forms.ToolStripButton();
            this.drawEdgeToolStrip = new System.Windows.Forms.ToolStripButton();
            this.deleteVertexToolStrip = new System.Windows.Forms.ToolStripButton();
            this.deleteGraphToolStrip = new System.Windows.Forms.ToolStripButton();
            this.vertexText = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.countVertex = new System.Windows.Forms.ToolStripButton();
            this.countEdge = new System.Windows.Forms.ToolStripButton();
            this.adjVertex = new System.Windows.Forms.ToolStripButton();
            this.weightOfEdge = new System.Windows.Forms.ToolStripButton();
            this.cohesion = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.sheet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sheet
            // 
            this.sheet.BackColor = System.Drawing.Color.White;
            this.sheet.Location = new System.Drawing.Point(12, 77);
            this.sheet.Name = "sheet";
            this.sheet.Size = new System.Drawing.Size(600, 380);
            this.sheet.TabIndex = 0;
            this.sheet.TabStop = false;
            this.sheet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sheet_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.функцииToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(629, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.импортироватьToolStripMenuItem,
            this.сохранитьГрафToolStripMenuItem,
            this.toolStripSeparator1,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // импортироватьToolStripMenuItem
            // 
            this.импортироватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.матрицуСмежностиToolStripMenuItem,
            this.списокToolStripMenuItem});
            this.импортироватьToolStripMenuItem.Name = "импортироватьToolStripMenuItem";
            this.импортироватьToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.импортироватьToolStripMenuItem.Text = "Импортировать";
            // 
            // матрицуСмежностиToolStripMenuItem
            // 
            this.матрицуСмежностиToolStripMenuItem.Name = "матрицуСмежностиToolStripMenuItem";
            this.матрицуСмежностиToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.матрицуСмежностиToolStripMenuItem.Text = "Матрицу смежности";
            this.матрицуСмежностиToolStripMenuItem.Click += new System.EventHandler(this.матрицуСмежностиToolStripMenuItem_Click);
            // 
            // списокToolStripMenuItem
            // 
            this.списокToolStripMenuItem.Name = "списокToolStripMenuItem";
            this.списокToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.списокToolStripMenuItem.Text = "Списки смежности";
            this.списокToolStripMenuItem.Click += new System.EventHandler(this.списокToolStripMenuItem_Click);
            // 
            // сохранитьГрафToolStripMenuItem
            // 
            this.сохранитьГрафToolStripMenuItem.Name = "сохранитьГрафToolStripMenuItem";
            this.сохранитьГрафToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.сохранитьГрафToolStripMenuItem.Text = "Сохранить граф";
            this.сохранитьГрафToolStripMenuItem.Click += new System.EventHandler(this.сохранитьГрафToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(159, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // функцииToolStripMenuItem
            // 
            this.функцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вывестиМатрицуСмежностиToolStripMenuItem,
            this.матрицаИнцидентностиToolStripMenuItem,
            this.спискиСвязностиToolStripMenuItem});
            this.функцииToolStripMenuItem.Name = "функцииToolStripMenuItem";
            this.функцииToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.функцииToolStripMenuItem.Text = "Построить";
            // 
            // вывестиМатрицуСмежностиToolStripMenuItem
            // 
            this.вывестиМатрицуСмежностиToolStripMenuItem.Name = "вывестиМатрицуСмежностиToolStripMenuItem";
            this.вывестиМатрицуСмежностиToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.вывестиМатрицуСмежностиToolStripMenuItem.Text = "Матрица смежности";
            this.вывестиМатрицуСмежностиToolStripMenuItem.Click += new System.EventHandler(this.вывестиМатрицуСмежностиToolStripMenuItem_Click);
            // 
            // матрицаИнцидентностиToolStripMenuItem
            // 
            this.матрицаИнцидентностиToolStripMenuItem.Name = "матрицаИнцидентностиToolStripMenuItem";
            this.матрицаИнцидентностиToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.матрицаИнцидентностиToolStripMenuItem.Text = "Матрица инцидентности";
            this.матрицаИнцидентностиToolStripMenuItem.Click += new System.EventHandler(this.матрицаИнцидентностиToolStripMenuItem_Click);
            // 
            // спискиСвязностиToolStripMenuItem
            // 
            this.спискиСвязностиToolStripMenuItem.Name = "спискиСвязностиToolStripMenuItem";
            this.спискиСвязностиToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.спискиСвязностиToolStripMenuItem.Text = "Списки связности";
            this.спискиСвязностиToolStripMenuItem.Click += new System.EventHandler(this.спискиСвязностиToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectToolStrip,
            this.drawVertexToolStrip,
            this.drawEdgeToolStrip,
            this.deleteVertexToolStrip,
            this.deleteGraphToolStrip});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(629, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // selectToolStrip
            // 
            this.selectToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("selectToolStrip.Image")));
            this.selectToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.selectToolStrip.Name = "selectToolStrip";
            this.selectToolStrip.Size = new System.Drawing.Size(74, 22);
            this.selectToolStrip.Text = "Выбрать";
            this.selectToolStrip.Click += new System.EventHandler(this.selectToolStrip_Click);
            // 
            // drawVertexToolStrip
            // 
            this.drawVertexToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("drawVertexToolStrip.Image")));
            this.drawVertexToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawVertexToolStrip.Name = "drawVertexToolStrip";
            this.drawVertexToolStrip.Size = new System.Drawing.Size(132, 22);
            this.drawVertexToolStrip.Text = "Добавить вершину";
            this.drawVertexToolStrip.Click += new System.EventHandler(this.drawVertexToolStrip_Click);
            // 
            // drawEdgeToolStrip
            // 
            this.drawEdgeToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("drawEdgeToolStrip.Image")));
            this.drawEdgeToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawEdgeToolStrip.Name = "drawEdgeToolStrip";
            this.drawEdgeToolStrip.Size = new System.Drawing.Size(116, 22);
            this.drawEdgeToolStrip.Text = "Добавить ребро";
            this.drawEdgeToolStrip.Click += new System.EventHandler(this.drawEdgeToolStrip_Click);
            // 
            // deleteVertexToolStrip
            // 
            this.deleteVertexToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("deleteVertexToolStrip.Image")));
            this.deleteVertexToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteVertexToolStrip.Name = "deleteVertexToolStrip";
            this.deleteVertexToolStrip.Size = new System.Drawing.Size(71, 22);
            this.deleteVertexToolStrip.Text = "Удалить";
            this.deleteVertexToolStrip.Click += new System.EventHandler(this.deleteVertexToolStrip_Click);
            // 
            // deleteGraphToolStrip
            // 
            this.deleteGraphToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("deleteGraphToolStrip.Image")));
            this.deleteGraphToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteGraphToolStrip.Name = "deleteGraphToolStrip";
            this.deleteGraphToolStrip.Size = new System.Drawing.Size(101, 22);
            this.deleteGraphToolStrip.Text = "Удалить граф";
            this.deleteGraphToolStrip.Click += new System.EventHandler(this.deleteGraphToolStrip_Click);
            // 
            // vertexText
            // 
            this.vertexText.AutoSize = true;
            this.vertexText.Location = new System.Drawing.Point(13, 460);
            this.vertexText.Name = "vertexText";
            this.vertexText.Size = new System.Drawing.Size(105, 13);
            this.vertexText.TabIndex = 3;
            this.vertexText.Text = "Выбрана вершина: ";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countVertex,
            this.countEdge,
            this.adjVertex,
            this.weightOfEdge,
            this.cohesion});
            this.toolStrip2.Location = new System.Drawing.Point(0, 49);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(629, 25);
            this.toolStrip2.TabIndex = 4;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // countVertex
            // 
            this.countVertex.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.countVertex.Image = ((System.Drawing.Image)(resources.GetObject("countVertex.Image")));
            this.countVertex.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.countVertex.Name = "countVertex";
            this.countVertex.Size = new System.Drawing.Size(123, 22);
            this.countVertex.Text = "Количество вершин";
            this.countVertex.Click += new System.EventHandler(this.countVertex_Click);
            // 
            // countEdge
            // 
            this.countEdge.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.countEdge.Image = ((System.Drawing.Image)(resources.GetObject("countEdge.Image")));
            this.countEdge.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.countEdge.Name = "countEdge";
            this.countEdge.Size = new System.Drawing.Size(112, 22);
            this.countEdge.Text = "Количество ребёр";
            this.countEdge.Click += new System.EventHandler(this.countEdge_Click);
            // 
            // adjVertex
            // 
            this.adjVertex.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.adjVertex.Image = ((System.Drawing.Image)(resources.GetObject("adjVertex.Image")));
            this.adjVertex.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.adjVertex.Name = "adjVertex";
            this.adjVertex.Size = new System.Drawing.Size(121, 22);
            this.adjVertex.Text = "Смежность вершин";
            this.adjVertex.Click += new System.EventHandler(this.adjVertex_Click);
            // 
            // weightOfEdge
            // 
            this.weightOfEdge.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.weightOfEdge.Image = ((System.Drawing.Image)(resources.GetObject("weightOfEdge.Image")));
            this.weightOfEdge.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.weightOfEdge.Name = "weightOfEdge";
            this.weightOfEdge.Size = new System.Drawing.Size(66, 22);
            this.weightOfEdge.Text = "Вес ребра";
            this.weightOfEdge.Click += new System.EventHandler(this.weightOfEdge_Click);
            // 
            // cohesion
            // 
            this.cohesion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cohesion.Image = ((System.Drawing.Image)(resources.GetObject("cohesion.Image")));
            this.cohesion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cohesion.Name = "cohesion";
            this.cohesion.Size = new System.Drawing.Size(103, 22);
            this.cohesion.Text = "Связность графа";
            this.cohesion.Click += new System.EventHandler(this.cohesion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 481);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.vertexText);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.sheet);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "MathGraph";
            ((System.ComponentModel.ISupportInitialize)(this.sheet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox sheet;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem импортироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матрицуСмежностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton selectToolStrip;
        private System.Windows.Forms.ToolStripButton drawVertexToolStrip;
        private System.Windows.Forms.ToolStripButton drawEdgeToolStrip;
        private System.Windows.Forms.ToolStripMenuItem функцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вывестиМатрицуСмежностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матрицаИнцидентностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem спискиСвязностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton deleteVertexToolStrip;
        private System.Windows.Forms.Label vertexText;
        private System.Windows.Forms.ToolStripButton deleteGraphToolStrip;
        private System.Windows.Forms.ToolStripMenuItem сохранитьГрафToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton countVertex;
        private System.Windows.Forms.ToolStripButton countEdge;
        private System.Windows.Forms.ToolStripButton adjVertex;
        private System.Windows.Forms.ToolStripButton weightOfEdge;
        private System.Windows.Forms.ToolStripButton cohesion;
    }
}

