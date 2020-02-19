﻿using System.Windows;

namespace KMA.ProgrammingInCSharp2020.Practice5Navigation.Views.Tools
{
    public partial class LabelAndTextControl
    {
        public LabelAndTextControl()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty TextProperty = DependencyProperty.Register
        (
            "Text",
            typeof(string),
            typeof(LabelAndTextControl),
            new PropertyMetadata(null)
        );
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(CaptionProperty, value); }
        }

        public static readonly DependencyProperty CaptionProperty = DependencyProperty.Register
        (
            "Caption",
            typeof(string),
            typeof(LabelAndTextControl),
            new PropertyMetadata(null)
        );
        public string Caption
        {
            get { return (string)GetValue(CaptionProperty); }
            set { SetValue(CaptionProperty, value); }
        }
    }
}
