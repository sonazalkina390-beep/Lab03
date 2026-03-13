using System;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnCheckOptimized.Click += btnCheckOptimized_Click;
        }
        private void btnCheckNaive_Click(object sender, EventArgs e)
        {
            RunAlgorithm(PrimeChecker.CheckNaive,
                lblValueResultNaive, lblValueTimeNaive, lblValueOpsNaive);
        }

        private void btnCheckOptimized_Click(object sender, EventArgs e)
        {
            RunAlgorithm(PrimeChecker.CheckOptimized,
                lblValueResultOptimized, lblValueTimeOptimized, lblValueOpsOptimized);
        }
        private void RunAlgorithm(
            Func<long, PrimeResult> algorithm,
            Label lblResult, Label lblTime, Label lblOps)
        {
            if (!long.TryParse(txtInputNumber.Text, out long n))
            {
                MessageBox.Show("Введите целое число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (n < 2 || n > 1_000_000)
            {
                MessageBox.Show("Число должно быть в диапазоне [2; 1 000 000].", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                PrimeResult result = algorithm(n);
                lblResult.Text = result.IsPrime ? "Простое" : "Составное";
                lblTime.Text = $"{result.ExecutionTimeMs:F4} мс";
                lblOps.Text = result.OperationCount.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка выполнения:\n{ex.Message}", "Исключение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}