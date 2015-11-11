using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App1 {
    public class App : Application {
        public App() {
            MainPage = new MyPage();
        }
    }
    ///////////////////////////////////////////////////////////////////
    //
    // DisplayAlertのサンプル
    //
    ///////////////////////////////////////////////////////////////////
    class MyPage : ContentPage {
        public MyPage() {
            //ボタンの生成
            var button = new Button() {
                Text = "Button"
            };
            //ボタンを押した際のイベント
            button.Clicked += (s, e) => {
                //DisplayAlertの表示
                DisplayAlert("タイトル", "メッセージ", "OK");
            };

            //ボタンを押した際のイベント
            //button.Clicked += async (s, e) => {
            //    //DisplayAlertの表示
            //    var result = await DisplayAlert("タイトル", "選択してください", "OK", "キャンセル");
            //    //戻り値をボタンテキストにセットする
            //    button.Text = result.ToString();
            //};

            Content = button;
        }

    }


    /*
    ///////////////////////////////////////////////////////////////////
    //
    // DisplayActionSheetのサンプル
    //
    ///////////////////////////////////////////////////////////////////
    class MyPage : ContentPage {
        public MyPage() {
            //ボタンの生成
            var button = new Button() {
                Text = "Button"
            };
            //ボタンを押した際のイベント
            button.Clicked += async (s, e) => {
                //DisplayActionSheetの表示
                var retult = await DisplayActionSheet("選択してください", "キャンセル", "削除", "編集", "コピー", "貼り付け");
                //返された文字列でボタンテキストを書き換える
                button.Text = retult;
            };
            Content = new StackLayout {
                Padding = new Thickness(0, 20, 0, 0),//上に余白を持つ
                Children = { button, }//スタックレイアウトにボタンを１つだけ持つ
            };
        }
    }
    */
}