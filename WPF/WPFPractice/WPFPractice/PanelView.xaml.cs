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

namespace WPFPractice
{
    /// <summary>
    /// Interaction logic for PanelView.xaml
    /// </summary>
    public partial class PanelView : UserControl
    {
        ColumnDefinition column1CloneForLayer0;
        ColumnDefinition column2CloneForLayer0;
        ColumnDefinition column2CloneForLayer1;

        public PanelView()
        {
            InitializeComponent();

            column1CloneForLayer0 = new ColumnDefinition();
            column1CloneForLayer0.SharedSizeGroup = "column1";
            column2CloneForLayer0 = new ColumnDefinition();
            column2CloneForLayer0.SharedSizeGroup = "column2";
            column2CloneForLayer1 = new ColumnDefinition();
            column2CloneForLayer1.SharedSizeGroup = "column2";
        }

        public void pane1Pin_Click(object sender, RoutedEventArgs e)
        {
            if (pane1Button.Visibility == Visibility.Collapsed)
                UndockPane(1);
            else
                DockPane(1);
        }

        public void pane2Pin_Click(object sender, RoutedEventArgs e)
        {
            if (pane2Button.Visibility == Visibility.Collapsed)
                UndockPane(2);
            else
                DockPane(2);
        }


        public void pane1Button_MouseEnter(object sender, RoutedEventArgs e)
        {
            layer1.Visibility = Visibility.Visible;

            // Adjust Z order to ensure the pane is on top:
            Grid.SetZIndex(layer1, 1);
            Grid.SetZIndex(layer2, 0);

            // Ensure the other pane is hidden if it is undocked
            if (pane2Button.Visibility == Visibility.Visible)
                layer2.Visibility = Visibility.Collapsed;
        }

        public void pane2Button_MouseEnter(object sender, RoutedEventArgs e)
        {
            layer2.Visibility = Visibility.Visible;

            // Adjust Z order to ensure the pane is on top:
            Grid.SetZIndex(layer2, 1);
            Grid.SetZIndex(layer1, 0);

            // Ensure the other pane is hidden if it is undocked
            if (pane1Button.Visibility == Visibility.Visible)
                layer1.Visibility = Visibility.Collapsed;
        }

        public void layer0_MouseEnter(object sender, RoutedEventArgs e)
        {
            if (pane1Button.Visibility == Visibility.Visible)
                layer1.Visibility = Visibility.Collapsed;
            if (pane2Button.Visibility == Visibility.Visible)
                layer2.Visibility = Visibility.Collapsed;
        }

        public void pane1_MouseEnter(object sender, RoutedEventArgs e)
        {
            if (pane2Button.Visibility == Visibility.Visible)
                layer2.Visibility = Visibility.Collapsed;
        }

        public void pane2_MouseEnter(object sender, RoutedEventArgs e)
        {
            if (pane1Button.Visibility == Visibility.Visible)
                layer1.Visibility = Visibility.Collapsed;
        }

        public void DockPane(int paneNumber)
        {
            if (paneNumber == 1)
            {
                pane1Button.Visibility = Visibility.Collapsed;

                // Add the cloned column to layer 0:
                layer0.ColumnDefinitions.Add(column1CloneForLayer0);
                // Add the cloned column to layer 1, but only if pane 2 is docked:
                if (pane2Button.Visibility == Visibility.Collapsed)
                    layer1.ColumnDefinitions.Add(column2CloneForLayer1);
            }
            else if (paneNumber == 2)
            {
                pane2Button.Visibility = Visibility.Collapsed;

                // Add the cloned column to layer 0:
                layer0.ColumnDefinitions.Add(column2CloneForLayer0);
                // Add the cloned column to layer 1, but only if pane 1 is docked:
                if (pane1Button.Visibility == Visibility.Collapsed)
                    layer1.ColumnDefinitions.Add(column2CloneForLayer1);
            }
        }


        public void UndockPane(int paneNumber)
        {
            if (paneNumber == 1)
            {
                layer1.Visibility = Visibility.Visible;
                pane1Button.Visibility = Visibility.Visible;

                // Remove the cloned columns from layers 0 and 1:
                layer0.ColumnDefinitions.Remove(column1CloneForLayer0);
                // This won’t always be present, but Remove silently ignores bad columns:
                layer1.ColumnDefinitions.Remove(column2CloneForLayer1);
            }
            else if (paneNumber == 2)
            {
                layer2.Visibility = Visibility.Visible;
                pane2Button.Visibility = Visibility.Visible;

                // Remove the cloned columns from layers 0 and 1:
                layer0.ColumnDefinitions.Remove(column2CloneForLayer0);
                // This won’t always be present, but Remove silently ignores bad columns:
                layer1.ColumnDefinitions.Remove(column2CloneForLayer1);
            }
        }
    }
}
