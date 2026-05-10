# Hit & Blow ゲーム

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91?style=for-the-badge&logo=visual-studio&logoColor=white)

<p align="center">
  <img src="./%E6%95%B0%E5%BD%93%E3%81%A6/images/AppTop.jpg" width="500">
</p>

## download ☛　[Version 1.0](https://github.com/k-haru310/Hit-Blow/releases/download/v1.0.0/default.exe)
## 🎮 遊び方
4桁の数字を当てていくゲームです。  
ユーザーが入力した数値に合わせて、以下の２つを表示する。
- **Hit:** 数字も位置も合っている
- **Blow:** 数字は合っているが位置が違う

## 🛠 開発環境
- **IDE:** Visual Studio 2022
- **Language:** C#
- **Framework:** .NET (Windows Forms)

## 💡 技術的な工夫（雑記）
WinFormsの学習として制作を開始しました。当初はTextBoxでの入力を想定していましたが、以下のユーザビリティ上の課題を考慮し、設計を変更しました。

1. **入力方法の簡略化**
   数字以外（文字や記号）の入力によるバグを防ぐため、ボタン選択式を採用しました。
2. **直感的な操作性**
   入力ミス（範囲外の数値など）を物理的に排除することで、よりスムーズなゲーム体験を追求しました。
