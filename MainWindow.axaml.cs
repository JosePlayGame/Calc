using System;
using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup;
using Avalonia.Markup.Xaml;
namespace Calculadora;

public partial class MainWindow : Window
{
    string num1 = "";
    string num2 = "";
    string[]nums;
    int pos=0;
    float result = 0.0f;
    int count=0;
    public MainWindow()
    {
        InitializeComponent();
    }
    public void bt1Num1_Click(object sender, RoutedEventArgs e){
        output.Text+=1; 
    }
    public void bt1Num2_Click(object sender, RoutedEventArgs e){
        output.Text+=2; 
    }
    public void bt1Num3_Click(object sender, RoutedEventArgs e){
        output.Text+=3; 
    }
    public void bt1Num4_Click(object sender, RoutedEventArgs e){
        output.Text+=4; 
    }
    public void bt1Num5_Click(object sender, RoutedEventArgs e){
        output.Text+=5; 
    }
    public void bt1Num6_Click(object sender, RoutedEventArgs e){
        output.Text+=6; 
    }
    public void bt1Num7_Click(object sender, RoutedEventArgs e){
        output.Text+=7; 
    }
    public void bt1Num8_Click(object sender, RoutedEventArgs e){
        output.Text+=8; 
    }
    public void bt1Num9_Click(object sender, RoutedEventArgs e){
        output.Text+=9; 
    }
    public void btnSum_Click(object sender, RoutedEventArgs e){
        num1 = output.Text!;
        output.Text = "";
        nums[pos]=num1;
        pos++;
        num1="";
        
    }
    
    public void btnEquals_Click(object sender, RoutedEventArgs e){
        try
        {
            
            for (int i = 0; i <= nums.Length-1; i++)
            {
                result+=float.Parse(nums[i]);
            }
            resultfinal.Text = result.ToString();
        }
        catch (Exception)
        {
            // Manejar el caso en el que la entrada no sea un número válido
            resultfinal.Text = "Entrada no válida";
        }
    }
}