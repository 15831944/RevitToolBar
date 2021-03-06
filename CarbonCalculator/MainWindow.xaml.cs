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
using CarbonMaterials;

namespace CarbonCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            var myelemset = new ElementSet("Category", "Material");
            myelemset.Elements.Add(new Element("Elem 1", 120d, "Revit123", "Foundation", "Concrete"));
            myelemset.Elements.Add(new Element("Elem 2", 109.4d, "Revit124", "Foundation", "Concrete"));
            myelemset.Elements.Add(new Element("Elem 3", 24.2d, "Revit125", "Walls", "RC40"));
            ModelVM vm = new ModelVM(myelemset);

            DataContext = vm;

            InitializeComponent();
        }
    }
}
