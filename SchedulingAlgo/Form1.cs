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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable dataTable = new DataTable();
        int i;
        string input;
        int quantumTime1 = 0;
        int quantumTime2 = 0;

        private void lbl2_Click(object sender, EventArgs e)
        {
            lbl2.Text = cmb1.Text;
        }

        private void cmb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl2.Text = cmb1.Text;
            if (cmb1.Text.Contains("Round Robin"))
            {
                input = Interaction.InputBox("Enter Quantum Time for Queue 1:", "Quantum Input");
                if (int.TryParse(input, out quantumTime1))
                {
                    MessageBox.Show("Quantum Time for Queue 1 is set to: " + quantumTime1);
                }
                else
                {
                    MessageBox.Show("Invalid input for Queue 1.");
                }
            }
        }

        private void cmb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl4.Text = cmb2.Text;
            if (cmb2.Text.Contains("Round Robin"))
            {
                input = Interaction.InputBox("Enter Quantum Time for Queue 2:", "Quantum Input");
                if (int.TryParse(input, out quantumTime2))
                {   
                    MessageBox.Show("Quantum Time for Queue 2 is set to: " + quantumTime2);
                }
                else
                {
                    MessageBox.Show("Invalid input for Queue 2.");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataTable.Columns.Add("Process ID", typeof(int));
            dataTable.Columns.Add("Queue Level", typeof(int));
            dataTable.Columns.Add("CPU Burst Time", typeof(double));
            dataTable.Columns.Add("Arrival Time", typeof(double));
            dataTable.Columns.Add("Waiting Time", typeof(double));
            dataTable.Columns.Add("Completion Time", typeof(double));
            dataTable.Columns.Add("Turnaround Time", typeof(double));

            dataGridView1.DataSource = dataTable;
        }

        private void bttn1_Click(object sender, EventArgs e)
        {
            dataTable.Rows.Add(txt1.Text, txt2.Text, txt3.Text, txt4.Text);
            dataGridView1.DataSource = dataTable;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            DataGridViewRow selectRow = dataGridView1.Rows[i];
            txt1.Text = selectRow.Cells[0].Value.ToString();
            txt2.Text = selectRow.Cells[1].Value.ToString();
            txt3.Text = selectRow.Cells[2].Value.ToString();
            txt4.Text = selectRow.Cells[3].Value.ToString();
        }

        private void bttn2_Click(object sender, EventArgs e)
        {
            DataGridViewRow upData = dataGridView1.Rows[i];
            upData.Cells[0].Value = txt1.Text;
            upData.Cells[1].Value = txt2.Text;
            upData.Cells[2].Value = txt3.Text;
            upData.Cells[3].Value = txt4.Text;
        }

        private void bttn3_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(row);
        }

        private void bttn4_Click(object sender, EventArgs e)
        {
            var allProcesses = dataTable.AsEnumerable().OrderBy(r => r.Field<double>("Arrival Time")).ToList();
            Dictionary<DataRow, double> remainingBurst = allProcesses.ToDictionary(r => r, r => r.Field<double>("CPU Burst Time"));
            Dictionary<DataRow, double> startTime = allProcesses.ToDictionary(r => r, r => -1.0);
            HashSet<DataRow> completed = new HashSet<DataRow>();
            double time = 0;

            
            Dictionary<int, List<DataRow>> queueMap = new Dictionary<int, List<DataRow>>();

            while (completed.Count < allProcesses.Count)
            {
                
                foreach (var proc in allProcesses)
                {
                    if (proc.Field<double>("Arrival Time") <= time && !completed.Contains(proc))
                    {
                        int level = proc.Field<int>("Queue Level");
                        if (!queueMap.ContainsKey(level))
                            queueMap[level] = new List<DataRow>();

                        if (!queueMap[level].Contains(proc))
                            queueMap[level].Add(proc);
                    }
                }

                var availableLevels = queueMap.Keys.OrderBy(k => k).ToList();
                DataRow procToRun = null;
                double execTime = 0;
                int selectedLevel = -1;
                string selectedAlgo = "";

                foreach (var level in availableLevels)
                {
                    if (queueMap[level].Count == 0)
                        continue;

                    selectedLevel = level;
                    selectedAlgo = (level == 1) ? cmb1.Text : cmb2.Text;

                    if (selectedAlgo == "Round Robin (RR)")
                    {
                        if (!queueMap[level].Any(p => remainingBurst[p] > 0))
                            continue;

                        procToRun = queueMap[level][0]; 
                        queueMap[level].RemoveAt(0);

                        int quantum = (level == 1) ? quantumTime1 : quantumTime2;
                        execTime = Math.Min(quantum, remainingBurst[procToRun]);

                        if (startTime[procToRun] < 0)
                            startTime[procToRun] = time;

                        remainingBurst[procToRun] -= execTime;
                        time += execTime;

                        if (remainingBurst[procToRun] <= 0)
                        {
                            double arrivalTime = procToRun.Field<double>("Arrival Time");
                            double burstTime = procToRun.Field<double>("CPU Burst Time");
                            double completionTime = time;
                            double turnaroundTime = completionTime - arrivalTime;
                            double waitingTime = turnaroundTime - burstTime;

                            procToRun.SetField("Completion Time", Math.Round(completionTime, 2));
                            procToRun.SetField("Turnaround Time", Math.Round(turnaroundTime, 2));
                            procToRun.SetField("Waiting Time", Math.Round(waitingTime, 2));

                            completed.Add(procToRun);
                        }
                        else
                        {
                            queueMap[level].Add(procToRun); 
                        }
                        break;
                    }
                    else if (selectedAlgo == "First Come, First Serve (FCFS)")
                    {
                        procToRun = queueMap[level].OrderBy(p => p.Field<double>("Arrival Time")).First();

                        if (startTime[procToRun] < 0)
                            startTime[procToRun] = time;

                        execTime = remainingBurst[procToRun];
                        time += execTime;
                        remainingBurst[procToRun] = 0;

                        double arrivalTime = procToRun.Field<double>("Arrival Time");
                        double burstTime = procToRun.Field<double>("CPU Burst Time");
                        double completionTime = time;
                        double turnaroundTime = completionTime - arrivalTime;
                        double waitingTime = turnaroundTime - burstTime;

                        procToRun.SetField("Completion Time", Math.Round(completionTime, 2));
                        procToRun.SetField("Turnaround Time", Math.Round(turnaroundTime, 2));
                        procToRun.SetField("Waiting Time", Math.Round(waitingTime, 2));

                        completed.Add(procToRun);
                        queueMap[level].Remove(procToRun);
                        break;
                    }
                    else if (selectedAlgo == "Shortest Remaining Time First (SRTF)")
                    {
                        var availableSRTF = queueMap[level].Where(p => remainingBurst[p] > 0).OrderBy(p => remainingBurst[p]).ToList();
                        if (availableSRTF.Count == 0)
                            continue;

                        procToRun = availableSRTF.First();

                        if (startTime[procToRun] < 0)
                            startTime[procToRun] = time;

                        execTime = 1;
                        remainingBurst[procToRun] -= execTime;
                        time += execTime;

                        if (remainingBurst[procToRun] <= 0)
                        {
                            double arrivalTime = procToRun.Field<double>("Arrival Time");
                            double burstTime = procToRun.Field<double>("CPU Burst Time");
                            double completionTime = time;
                            double turnaroundTime = completionTime - arrivalTime;
                            double waitingTime = turnaroundTime - burstTime;

                            procToRun.SetField("Completion Time", Math.Round(completionTime, 2));
                            procToRun.SetField("Turnaround Time", Math.Round(turnaroundTime, 2));
                            procToRun.SetField("Waiting Time", Math.Round(waitingTime, 2));

                            completed.Add(procToRun);
                            queueMap[level].Remove(procToRun);
                        }
                        break;
                    }
                }

                if (procToRun == null)
                {
                    time++; 
                }
            }

            var combined = allProcesses.OrderBy(r => r.Field<int>("Process ID")).CopyToDataTable();
            dataGridView1.DataSource = combined;

            if (dataGridView1.Rows.Count >= 4)
            {
                lblP1.Text = "WT of P1: " + dataGridView1.Rows[0].Cells["Waiting Time"].Value.ToString();
                lblP2.Text = "WT of P2: " + dataGridView1.Rows[1].Cells["Waiting Time"].Value.ToString();
                lblP3.Text = "WT of P3: " + dataGridView1.Rows[2].Cells["Waiting Time"].Value.ToString();
                lblP4.Text = "WT of P4: " + dataGridView1.Rows[3].Cells["Waiting Time"].Value.ToString();

                lblC1.Text = "CT of P1: " + dataGridView1.Rows[0].Cells["Completion Time"].Value.ToString();
                lblC2.Text = "CT of P2: " + dataGridView1.Rows[1].Cells["Completion Time"].Value.ToString();
                lblC3.Text = "CT of P3: " + dataGridView1.Rows[2].Cells["Completion Time"].Value.ToString();
                lblC4.Text = "CT of P4: " + dataGridView1.Rows[3].Cells["Completion Time"].Value.ToString();

                lblT1.Text = "TAT of P1: " + dataGridView1.Rows[0].Cells["Turnaround Time"].Value.ToString();
                lblT2.Text = "TAT of P2: " + dataGridView1.Rows[1].Cells["Turnaround Time"].Value.ToString();
                lblT3.Text = "TAT of P3: " + dataGridView1.Rows[2].Cells["Turnaround Time"].Value.ToString();
                lblT4.Text = "TAT of P4: " + dataGridView1.Rows[3].Cells["Turnaround Time"].Value.ToString();
            }
        }

        private void lblP1_Click(object sender, EventArgs e) { }
    }
}