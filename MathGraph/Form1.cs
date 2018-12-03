using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;
using System.Collections;
using System.Text.RegularExpressions;

namespace MathGraph
{
    public partial class Form1 : Form
    {
        DrawGraph G;
        List<Vertex> V;
        List<Edge> E;
        int[,] AMatrix; //Матрица смежности
        int[,] IMatrix; //Матрица инцидентности

        int selected1; //Выбранные вершины, для соединения ребрами
        int selected2;

        private ReportForm reportForm = new ReportForm();

        public Form1()
        {
            InitializeComponent();
            V = new List<Vertex>();
            G = new DrawGraph(sheet.Width, sheet.Height);
            E = new List<Edge>();
            sheet.Image = G.GetBitmap();

            sheet.SizeMode = PictureBoxSizeMode.AutoSize;
            vertexText.Text = "";
        }

        //Создание матрицы смежности и вывод в листбокс
        private void createAdjAndOut()
        {
            AMatrix = new int[V.Count, V.Count];
            G.fillAdjacencyMatrix(V.Count, E, AMatrix);
            reportForm.listBoxMatrix.Items.Clear();
            string sOut = V.Count+"";
            for (int i = 0; i < V.Count; i++)
                sOut += /*(i + 1) +*/ " ";
            reportForm.listBoxMatrix.Items.Add(sOut);
            for (int i = 0; i < V.Count; i++)
            {
                sOut = /*(i + 1)*/"" /*+ " | "*/;
                for (int j = 0; j < V.Count; j++)
                    sOut += AMatrix[i, j] + " ";
                reportForm.listBoxMatrix.Items.Add(sOut);
            }
        }

        //Создание матрицы смежности и вывод в листбокс
        private void createAdjAndOutDeg()
        {
            AMatrix = new int[V.Count, V.Count];
            G.fillAdjacencyMatrixForDeg(V.Count, E, AMatrix);
            reportForm.listBoxMatrix.Items.Clear();
            string sOut = "    ";
            for (int i = 0; i < V.Count; i++)
                sOut += (i + 1) + " ";
            reportForm.listBoxMatrix.Items.Add(sOut);
            for (int i = 0; i < V.Count; i++)
            {
                sOut = (i + 1) + " | ";
                for (int j = 0; j < V.Count; j++)
                    sOut += AMatrix[i, j] + " ";
                reportForm.listBoxMatrix.Items.Add(sOut);
            }
        }

        //Список смежности
        private void createListAdj()
        {
            AMatrix = new int[V.Count, V.Count];
            G.fillAdjacencyMatrix(V.Count, E, AMatrix);
            reportForm.listBoxMatrix.Items.Clear();

            string sOut = V.Count + "";
            for (int i = 0; i < V.Count; i++)
                sOut += /*(i + 1) +*/ " ";
            reportForm.listBoxMatrix.Items.Add(sOut);
            for (int i = 0; i < V.Count; i++)
            {

                for (int j = 0; j <= i; j++)
                {
                    if (AMatrix[i, j] != 0)
                    {
                        sOut = "";
                        sOut += (j + 1) + " " + (i + 1) + " " + AMatrix[i, j];
                        reportForm.listBoxMatrix.Items.Add(sOut);
                    }
                }
            }
        }

        //Создание матрицы инцидентности и вывод в листбокс
        private void createIncAndOut()
        {
            if (E.Count > 0)
            {
                IMatrix = new int[V.Count, E.Count];
                G.fillIncidenceMatrix(V.Count, E, IMatrix);
                reportForm.listBoxMatrix.Items.Clear();
                string sOut = "    ";
                for (int i = 0; i < E.Count; i++)
                    sOut += (char)('a' + i) + " ";
                reportForm.listBoxMatrix.Items.Add(sOut);
                for (int i = 0; i < V.Count; i++)
                {
                    sOut = (i + 1) + " | ";
                    for (int j = 0; j < E.Count; j++)
                        sOut += IMatrix[i, j] + " ";
                    reportForm.listBoxMatrix.Items.Add(sOut);
                }
            }
            else
                reportForm.listBoxMatrix.Items.Clear();
        }

        //Выбрать вершину
        private void selectToolStrip_Click(object sender, EventArgs e)
        {
            vertexText.Text = "Выбор вершины";
            selectToolStrip.Enabled = false;
            drawVertexToolStrip.Enabled = true;
            weightOfEdge.Enabled = true;
            drawEdgeToolStrip.Enabled = true;
            deleteVertexToolStrip.Enabled = true;
            adjVertex.Enabled = true;
            countVertex.Enabled = true;
            countEdge.Enabled = true;
            weightOfEdge.Enabled = true;

            G.clearSheet();
            G.drawALLGraph(V, E);
            sheet.Image = G.GetBitmap();
            selected1 = -1;
        }

        //Добавить вершину
        private void drawVertexToolStrip_Click(object sender, EventArgs e)
        {
            vertexText.Text = "Добавление вершины";
            drawVertexToolStrip.Enabled = false;
            selectToolStrip.Enabled = true;
            drawEdgeToolStrip.Enabled = true;
            weightOfEdge.Enabled = true;
            deleteVertexToolStrip.Enabled = true;
            adjVertex.Enabled = true;
            countVertex.Enabled = true;
            countEdge.Enabled = true;
            weightOfEdge.Enabled = true;

            G.clearSheet();
            G.drawALLGraph(V, E);
            sheet.Image = G.GetBitmap();
        }

        //Добавить ребро
        private void drawEdgeToolStrip_Click(object sender, EventArgs e)
        {
            vertexText.Text = "Добавление ребра";
            drawEdgeToolStrip.Enabled = false;
            selectToolStrip.Enabled = true;
            weightOfEdge.Enabled = true;
            drawVertexToolStrip.Enabled = true;
            deleteVertexToolStrip.Enabled = true;
            adjVertex.Enabled = true;
            countVertex.Enabled = true;
            countEdge.Enabled = true;
            weightOfEdge.Enabled = true;

            G.clearSheet();
            G.drawALLGraph(V, E);
            sheet.Image = G.GetBitmap();
            selected1 = -1;
            selected2 = -1;
        }

        private void adjVertex_Click(object sender, EventArgs e)
        {
            vertexText.Text = "Проверка смежности вершин";
            adjVertex.Enabled = false;
            weightOfEdge.Enabled = true;
            drawEdgeToolStrip.Enabled = true;
            selectToolStrip.Enabled = true;
            drawVertexToolStrip.Enabled = true;
            deleteVertexToolStrip.Enabled = true;
            countVertex.Enabled = true;
            countEdge.Enabled = true;
            weightOfEdge.Enabled = true;

            G.clearSheet();
            G.drawALLGraph(V, E);
            sheet.Image = G.GetBitmap();
            selected1 = -1;
            selected2 = -1;
        }

        private void weightOfEdge_Click(object sender, EventArgs e)
        {
            vertexText.Text = "Проверка веса ребра";
            weightOfEdge.Enabled = false;
            adjVertex.Enabled = true;
            drawEdgeToolStrip.Enabled = true;
            selectToolStrip.Enabled = true;
            drawVertexToolStrip.Enabled = true;
            deleteVertexToolStrip.Enabled = true;
            countVertex.Enabled = true;
            countEdge.Enabled = true;

            G.clearSheet();
            G.drawALLGraph(V, E);
            sheet.Image = G.GetBitmap();
            selected1 = -1;
            selected2 = -1;
        }

        //Удалить вершину
        private void deleteVertexToolStrip_Click(object sender, EventArgs e)
        {
            vertexText.Text = "Удаление";
            deleteVertexToolStrip.Enabled = false;
            selectToolStrip.Enabled = true;
            drawVertexToolStrip.Enabled = true;
            drawEdgeToolStrip.Enabled = true;
            adjVertex.Enabled = true;
            countVertex.Enabled = true;
            countEdge.Enabled = true;
            weightOfEdge.Enabled = true;

            G.clearSheet();
            G.drawALLGraph(V, E);
            sheet.Image = G.GetBitmap();
        }

        //Удалить граф
        private void deleteGraphToolStrip_Click(object sender, EventArgs e)
        {
            vertexText.Text = "Удаление графа";
            selectToolStrip.Enabled = true;
            drawVertexToolStrip.Enabled = true;
            drawEdgeToolStrip.Enabled = true;
            weightOfEdge.Enabled = true;
            deleteVertexToolStrip.Enabled = true;
            adjVertex.Enabled = true;
            countVertex.Enabled = true;
            countEdge.Enabled = true;
            weightOfEdge.Enabled = true;

            const string message = "Вы действительно хотите удалить граф?";
            const string caption = "Удаление";
            var MBSave = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (MBSave == DialogResult.Yes)
            {
                V.Clear();
                E.Clear();
                G.clearSheet();
                sheet.Image = G.GetBitmap();
                vertexText.Text = "";
            }
        }

        private void sheet_MouseClick(object sender, MouseEventArgs e)
        {
            //Нажато меню "Выбрать", ищем степень вершины
            if (selectToolStrip.Enabled == false)
            {
                for (int i = 0; i < V.Count; i++)
                {
                    if (Math.Pow((V[i].x - e.X), 2) + Math.Pow((V[i].y - e.Y), 2) <= G.R * G.R)
                    {
                        if (selected1 != -1)
                        {
                            selected1 = -1;
                            G.clearSheet();
                            G.drawALLGraph(V, E);
                            sheet.Image = G.GetBitmap();
                        }
                        if (selected1 == -1)
                        {
                            G.drawSelectedVertex(V[i].x, V[i].y);
                            selected1 = i;
                            sheet.Image = G.GetBitmap();
                            createAdjAndOutDeg();
                            int degree = 0;
                            for (int j = 0; j < V.Count; j++)
                                degree += AMatrix[selected1, j];
                            vertexText.Text = "Степень вершины №" + (selected1 + 1) + " равна " + degree;
                            break;
                        }
                    }
                }
            }
            //Нажато меню "Добавить вершину"
            if (drawVertexToolStrip.Enabled == false)
            {
                V.Add(new Vertex(e.X, e.Y));
                G.drawVertex(e.X, e.Y, V.Count.ToString());
                sheet.Image = G.GetBitmap();
            }
            //Нажато меню "Добавить ребро"
            if (drawEdgeToolStrip.Enabled == false)
            {
                for (int i = 0; i < V.Count; i++)
                {
                    if (Math.Pow((V[i].x - e.X), 2) + Math.Pow((V[i].y - e.Y), 2) <= G.R * G.R)
                    {
                        if (selected1 == -1)
                        {
                            G.drawSelectedVertex(V[i].x, V[i].y);
                            selected1 = i;
                            sheet.Image = G.GetBitmap();
                            break;
                        }
                        if (selected2 == -1)
                        {
                            string Weigh = Interaction.InputBox("Введите вес ребра", "Добавление ребра", "1", -1, -1);
                            if (Weigh == "")
                            {
                                break;
                            }
                            int Weight = 0;
                            try
                            {
                                Weight = int.Parse(Weigh);
                                if (Weight <= 0)
                                {
                                    break;
                                }
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Введите число", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }
                            G.drawSelectedVertex(V[i].x, V[i].y);
                            selected2 = i;
                            E.Add(new Edge(selected1, selected2, Weight));

                            G.drawEdge(V[selected1], V[selected2], E[E.Count - 1], E.Count - 1, Weight);
                            selected1 = -1;
                            selected2 = -1;
                            sheet.Image = G.GetBitmap();
                            break;
                        }
                    }
                }
            }
            //Проверить смежность вершин 
            if (adjVertex.Enabled == false)
            {
                for (int i = 0; i < V.Count; i++)
                {
                    if (Math.Pow((V[i].x - e.X), 2) + Math.Pow((V[i].y - e.Y), 2) <= G.R * G.R)
                    {
                        if (selected1 == -1)
                        {
                            G.drawSelectedVertex(V[i].x, V[i].y);
                            selected1 = i;
                            sheet.Image = G.GetBitmap();
                            break;
                        }
                        if (selected2 == -1)
                        {
                            G.drawSelectedVertex(V[i].x, V[i].y);
                            selected2 = i;

                            AMatrix = new int[V.Count, V.Count];
                            G.fillAdjacencyMatrix(V.Count, E, AMatrix);

                            if (AMatrix[selected1, selected2] > 0)
                            {
                                MessageBox.Show("Вершины смежны", "Смежность", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                            else
                            {
                                MessageBox.Show("Вершины не смежны", "Смежность", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }

                            selected1 = -1;
                            selected2 = -1;
                            sheet.Image = G.GetBitmap();
                            G.drawALLGraph(V, E);
                            break;
                        }
                    }
                }
            }
            //Узнать вес ребра 
            if (weightOfEdge.Enabled == false)
            {
                for (int i = 0; i < V.Count; i++)
                {
                    if (Math.Pow((V[i].x - e.X), 2) + Math.Pow((V[i].y - e.Y), 2) <= G.R * G.R)
                    {
                        if (selected1 == -1)
                        {
                            G.drawSelectedVertex(V[i].x, V[i].y);
                            selected1 = i;
                            sheet.Image = G.GetBitmap();
                            break;
                        }
                        if (selected2 == -1)
                        {
                            G.drawSelectedVertex(V[i].x, V[i].y);
                            selected2 = i;

                            AMatrix = new int[V.Count, V.Count];
                            G.fillAdjacencyMatrix(V.Count, E, AMatrix);

                            MessageBox.Show("Вес ребра: " + AMatrix[selected1, selected2], "Вес ребра", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


                            selected1 = -1;
                            selected2 = -1;
                            sheet.Image = G.GetBitmap();
                            G.drawALLGraph(V, E);
                            break;
                        }
                    }
                }
            }
            //Нажато меню "Удалить вершину"
            if (deleteVertexToolStrip.Enabled == false)
            {
                bool flag = false; //Удалили ли что-нибудь по ЭТОМУ клику
                //Ищем, возможно была нажата вершина
                for (int i = 0; i < V.Count; i++)
                {
                    if (Math.Pow((V[i].x - e.X), 2) + Math.Pow((V[i].y - e.Y), 2) <= G.R * G.R)
                    {
                        for (int j = 0; j < E.Count; j++)
                        {
                            if ((E[j].v1 == i) || (E[j].v2 == i))
                            {
                                E.RemoveAt(j);
                                j--;
                            }
                            else
                            {
                                if (E[j].v1 > i) E[j].v1--;
                                if (E[j].v2 > i) E[j].v2--;
                            }
                        }
                        V.RemoveAt(i);
                        flag = true;
                        break;
                    }
                }
                //Ищем, возможно было нажато ребро
                if (!flag)
                {
                    for (int i = 0; i < E.Count; i++)
                    {
                        if (E[i].v1 == E[i].v2) //Если это петля
                        {
                            if ((Math.Pow((V[E[i].v1].x - G.R - e.X), 2) + Math.Pow((V[E[i].v1].y - G.R - e.Y), 2) <= ((G.R + 2) * (G.R + 2))) &&
                                (Math.Pow((V[E[i].v1].x - G.R - e.X), 2) + Math.Pow((V[E[i].v1].y - G.R - e.Y), 2) >= ((G.R - 2) * (G.R - 2))))
                            {
                                E.RemoveAt(i);
                                flag = true;
                                break;
                            }
                        }
                        else //Не петля
                        {
                            if (((e.X - V[E[i].v1].x) * (V[E[i].v2].y - V[E[i].v1].y) / (V[E[i].v2].x - V[E[i].v1].x) + V[E[i].v1].y) <= (e.Y + 4) &&
                                ((e.X - V[E[i].v1].x) * (V[E[i].v2].y - V[E[i].v1].y) / (V[E[i].v2].x - V[E[i].v1].x) + V[E[i].v1].y) >= (e.Y - 4))
                            {
                                if ((V[E[i].v1].x <= V[E[i].v2].x && V[E[i].v1].x <= e.X && e.X <= V[E[i].v2].x) ||
                                    (V[E[i].v1].x >= V[E[i].v2].x && V[E[i].v1].x >= e.X && e.X >= V[E[i].v2].x))
                                {
                                    E.RemoveAt(i);
                                    flag = true;
                                    break;
                                }
                            }
                        }
                    }
                }
                //Если что-то было удалено, то обновляем граф на экране
                if (flag)
                {
                    G.clearSheet();
                    G.drawALLGraph(V, E);
                    sheet.Image = G.GetBitmap();
                }
            }
        }

        private void вывестиМатрицуСмежностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createAdjAndOut();
            reportForm.ShowDialog();
        }

        private void матрицаИнцидентностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createIncAndOut();
            reportForm.ShowDialog();
        }

        private void спискиСвязностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createListAdj();
            reportForm.ShowDialog();
        }

        private void сохранитьГрафToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sheet.Image != null)
            {
                SaveFileDialog savedialog = new SaveFileDialog();
                savedialog.Title = "Сохранить картинку как...";
                savedialog.OverwritePrompt = true;
                savedialog.CheckPathExists = true;
                savedialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
                savedialog.ShowHelp = true;
                if (savedialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        sheet.Image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        MessageBox.Show("Сохранение произведено успешно", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void countVertex_Click(object sender, EventArgs e)
        {
            AMatrix = new int[V.Count, V.Count];
            G.fillAdjacencyMatrix(V.Count, E, AMatrix);
            MessageBox.Show("Количество вершин графа: " + V.Count.ToString(), "Количество вершин графа", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            vertexText.Text = "Проверка количества вершин";
        }

        private void countEdge_Click(object sender, EventArgs e)
        {
            vertexText.Text = "Проверка количества рёбер";
            if (E.Count > 0)
            {
                IMatrix = new int[V.Count, E.Count];
                G.fillIncidenceMatrix(V.Count, E, IMatrix);
                MessageBox.Show("Количество рёбер графа: " + E.Count.ToString(), "Количество рёбер графа", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Количество рёбер графа: " + 0, "Количество рёбер графа", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        /****************ИМПОРТИРОВАНИЕ ИЗ ФАЙЛА*******************/
        private void матрицуСмежностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename;
            OpenFileDialog openFileDialog1 = new OpenFileDialog()
            {
                Filter = "Текстовые файлы(*.txt)|*.txt"
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                V.Clear();
                E.Clear();
                G.clearSheet();
                sheet.Image = G.GetBitmap();
                filename = openFileDialog1.FileName;

                //Чтение файла
                StreamReader sr = File.OpenText(filename);
                List<string[]> allElements = new List<string[]>();
                while (true)
                {
                    string str = sr.ReadLine();
                    if (str == null)
                        break;
                    string[] elements = Regex.Split(str, @"[ \s]").Where(item => !String.IsNullOrEmpty(item)).Select(item => item.Trim()).ToArray();
                    allElements.Add(elements);
                }
                sr.Close();

                string[][] matrix = allElements.ToArray();
                int size = int.Parse(matrix[0][0]);

                int x0 = 300;
                int y0 = 160;

                for (int i = 0; i < size; i++)
                {
                    int X = (int) (x0 + 120 * Math.Cos(2 * Math.PI * i / size));
                    int Y = (int) (y0 + 120 * Math.Sin(2 * Math.PI * i / size));

                    V.Add(new Vertex(X, Y));
                    G.drawVertex(X, Y, V.Count.ToString());
                    sheet.Image = G.GetBitmap();
                }
                for (int i = 1; i <= size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if(i==j && int.Parse(matrix[i][j]) == 0)
                        {
                            continue;
                        }
                        else if (i>j || int.Parse(matrix[i][j])==0)
                        {
                            continue;
                        }
                        else
                        {
                            E.Add(new Edge(i - 1, j, int.Parse(matrix[i][j])));
                            G.drawEdge(V[i - 1], V[j], E[E.Count - 1], E.Count - 1, int.Parse(matrix[i][j]));
                        }
                    }
                }
                sheet.Image = G.GetBitmap();
            }
        }

        private void списокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename;
            OpenFileDialog openFileDialog1 = new OpenFileDialog()
            {
                Filter = "Текстовые файлы(*.txt)|*.txt"
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                V.Clear();
                E.Clear();
                G.clearSheet();
                sheet.Image = G.GetBitmap();
                filename = openFileDialog1.FileName;

                //Чтение файла
                int counterRows = 0;
                StreamReader sr = File.OpenText(filename);
                List<string[]> allElements = new List<string[]>();
                while (true)
                {
                    string str = sr.ReadLine();
                    if (str == null)
                        break;
                    string[] elements = Regex.Split(str, @"[ \s]").Where(item => !String.IsNullOrEmpty(item)).Select(item => item.Trim()).ToArray();
                    allElements.Add(elements);
                    counterRows++;
                }
                sr.Close();

                string[][] matrix = allElements.ToArray();

                int size = int.Parse(matrix[0][0]);
                int[,] resultMatrix = new int[size,size];
                /**********Преобразование в матрицу смежности***********/
                for(int i=0; i<size; i++)
                {
                    for(int j=0; j<size; j++)
                    {
                        resultMatrix[i,j] = 0;
                    }
                }
                for(int i=1; i<counterRows; i++)
                {
                    int row = int.Parse(matrix[i][0]);
                    int col = int.Parse(matrix[i][1]);

                    resultMatrix[row-1,col-1] = int.Parse(matrix[i][2]);
                    resultMatrix[col-1,row-1] = int.Parse(matrix[i][2]);
                }
                /**********Конец преобразования в матрицу смежности***********/
                int x0 = 300;
                int y0 = 160;

                for (int i = 0; i < size; i++)
                {
                    int X = (int)(x0 + 120 * Math.Cos(2 * Math.PI * i / size));
                    int Y = (int)(y0 + 120 * Math.Sin(2 * Math.PI * i / size));

                    V.Add(new Vertex(X, Y));
                    G.drawVertex(X, Y, V.Count.ToString());
                    sheet.Image = G.GetBitmap();
                }
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (i == j && resultMatrix[i,j] == 0)
                        {
                            continue;
                        }
                        else if (i > j || resultMatrix[i, j] == 0)
                        {
                            continue;
                        }
                        else
                        {
                            E.Add(new Edge(i, j, resultMatrix[i, j]));
                            G.drawEdge(V[i], V[j], E[E.Count - 1], E.Count - 1, resultMatrix[i, j]);
                        }
                    }
                }
                sheet.Image = G.GetBitmap();
            }
        }


        //Создание матрицы смежности и вывод в листбокс
        private void adjeClear(ReportForm reportForm)
        {
            AMatrix = new int[V.Count, V.Count];
            G.fillAdjacencyMatrix(V.Count, E, AMatrix);
            
            string sOut = V.Count + "";
            for (int i = 0; i < V.Count; i++)
                sOut += /*(i + 1) +*/ " ";
            reportForm.listBoxMatrix.Items.Add(sOut);
            for (int i = 0; i < V.Count; i++)
            {
                sOut = /*(i + 1)*/"" /*+ " | "*/;
                for (int j = 0; j < V.Count; j++)
                    sOut += AMatrix[i, j] + " ";
                reportForm.listBoxMatrix.Items.Add(sOut);
            }
        }

        private void cohesion_Click(object sender, EventArgs e)
        {
            AMatrix = new int[V.Count, V.Count];
            G.fillAdjacencyMatrix(V.Count, E, AMatrix);

            if (V.Count == 0)
            {
                MessageBox.Show("Заполните граф!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int[] status = new int[V.Count];
            for(int i=0; i<V.Count; i++)
            {
                status[i] = 0;
            }

            int curr = 0;
            status[curr] = 1; //Вершина с индексом 0 считается проиденнои
            Queue och = new Queue();
            och.Enqueue(curr);
            //Перемещаемся до тех пор, пока в очереди не останется ни однои вершины графа
            while (och.Count != 0)
            {
                curr = Convert.ToInt32(och.Dequeue());
                for (int j = 0; j < V.Count; j++)
                {
                    if (AMatrix[curr, j] != 0 && status[j] == 0)
                    {
                        status[j] = 1; //Посетили вершину
                        och.Enqueue(j);
                    }
                }
            }

            int finalCounter = 0;
            for(int i=0; i<V.Count; i++)
            {
                if (status[i] == 1)
                {
                    finalCounter++;
                }
            }
            string res = "";
            if (finalCounter == V.Count)
            {
                res = "Граф является связным";
            }
            else
            {
                res = "Граф НЕ является связным";
            }
            ReportForm reportForm = new ReportForm();
            reportForm.listBoxMatrix.Items.Clear();

            reportForm.listBoxMatrix.Items.Add("Тема: Связность графа (#9)");
            reportForm.listBoxMatrix.Items.Add("Студент: Селютин Александр Дмитриевич");
            reportForm.listBoxMatrix.Items.Add("Группа: Б2-ИФСТ-31");
            reportForm.listBoxMatrix.Items.Add(DateTime.Now.ToString("yyyy-MM-dd"));
            reportForm.listBoxMatrix.Items.Add(DateTime.Now.ToString("HH:mm:ss"));
            reportForm.listBoxMatrix.Items.Add("Матрица смежности");
            adjeClear(reportForm);
            reportForm.listBoxMatrix.Items.Add("Результат: "+res);

            reportForm.Show();
        }
    }
}
