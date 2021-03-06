﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AppNotes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ColorPicker_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            InkCanvasMain.DefaultDrawingAttributes.Color = ColorPickerMain.SelectedColor.Value;
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            InkCanvasMain.Strokes.Clear();
        }

        private void ButtonUndo_Click(object sender, RoutedEventArgs e)
        {
            InkCanvasMain.Strokes.Remove(InkCanvasMain.Strokes[InkCanvasMain.Strokes.Count - 1]);
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
