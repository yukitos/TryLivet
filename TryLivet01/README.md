TryLivet01
==========

1. WPF アプリケーションを新規作成
2. ソリューションエクスプローラーでソリューションを選択後、右クリックから「NuGet パッケージの復元の有効化」を選択
3. ソリューションエクスプローラーでプロジェクト「TryLivet01」を選択後、右クリックから「NuGet パッケージの管理」を選択
4.「Livet Cask」をインストール
5. クラスファイル「MainWindowModel.cs」を追加

    ```csharp
    using System.Collections.Generic;
    using Livet;

    namespace TryLivet01
    {
        class MainWindowModel : ViewModel
        {
            public MainWindowModel()
            {
                Message = "Hello Livet World!";
            }

            private string _message;
            public string Message
            {
                get { return _message; }
                set
                {
                    if (EqualityComparer<string>.Default.Equals(_message, value))
                        return;

                    _message = value;
                    RaisePropertyChanged();
                }
            }
        }
    }
    ```
6. 「MainWindow.xaml」の変更

    ```xml
    <Window x:Class="TryLivet01.MainWindow"
            xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
            xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
            xmlns:vm="clr-namespace:TryLivet01"
            Title="MainWindow" Height="350" Width="525">
        <Window.DataContext>
            <vm:MainWindowModel/>
        </Window.DataContext>
        <Grid>
            <TextBlock Text="{Binding Path=Message}"/>
        </Grid>
    </Window>
    ```

Memo
====

* ViewとViewModelの結びつけはMainWindow.xamlの以下：

    ```xml
    <Window.DataContext>
        <vm:MainWindowModel/>
    </Window.DataContext>
    ```

* MainWindowModel.Messageを変更していない＝RaisePropertyChangedを呼んでいないので
  きちんとVとVMが結びついたかどうかまだよくわからない感じ。
