using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace 数当て
{
    public partial class Form1 : Form
    {
        // 変数を作成
        int[] answer = new int[4];
        TextBox[] inputs;
        Random random = new Random();

        public Form1()
        {
            // デザイナー側のメソッドを呼び出す
            InitializeComponent();

            // TextBoxを配列にいれる
            inputs = new TextBox[] { txtInput1, txtInput2, txtInput3, txtInput4 };

            // ゲームを開始
            StartNewGame();
        }

        // ゲーム開始時に呼ぶ
        private void StartNewGame()
        {
            List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 0; i < answer.Length; i++)
            {
                int index = random.Next(numbers.Count);
                answer[i] = numbers[index];
                numbers.RemoveAt(index);
            }
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            string selectedNumber = ((Button)sender).Text;
            foreach (var box in inputs)
            {
                if (box.Text == selectedNumber) return;
            }
            foreach (var box in inputs)
            {
                if (string.IsNullOrEmpty(box.Text))
                {
                    box.Text = selectedNumber;
                    break;
                }
            }
        }

        private void AnsButton_Click(object sender, EventArgs e)
        {
            int hit = 0;
            int blow = 0;

            foreach (var box in inputs)
            {
                if (string.IsNullOrEmpty(box.Text))
                {
                    MessageBox.Show("4つの数字すべてを入力してください。");
                    return;
                }
            }

            for (int n = 0; n < answer.Length; n++)
            {
                if (int.TryParse(inputs[n].Text, out int inputNum))
                {
                    if (answer[n] == inputNum) hit++;
                    else if (Array.IndexOf(answer, inputNum) != -1) blow++;
                }
            }

            if (hit == 4)
            {
                MessageBox.Show("正解です！おめでとう！");
                ResetGame();
            }
            else
            {
                MessageBox.Show($"{hit}ヒット！ {blow}ブロー！");
            }

                
            // 入力欄を空にする
                foreach (var box in inputs)
                {
                    box.Text = "";
                }
                // 入力欄の最初に戻る
                if (inputs.Length > 0)
                {
                    inputs[0].Focus();
                }
            }

        private void ResetGame()
        {
            StartNewGame();
            foreach (var box in inputs) box.Text = "";
            if (inputs.Length > 0) inputs[0].Focus();
        }
    }
}
