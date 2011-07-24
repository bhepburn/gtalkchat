﻿using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace gtalkchat {
    public partial class SentChatBubble : UserControl {

        public static DependencyProperty TextProperty = DependencyProperty.Register("Text", typeof(string), typeof(SentChatBubble), new PropertyMetadata(""));

        public string Text {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static DependencyProperty TimeStampProperty = DependencyProperty.Register("TimeStamp", typeof(string), typeof(SentChatBubble), new PropertyMetadata(""));

        public string TimeStamp {
            get { return (string)GetValue(TimeStampProperty); }
            set { SetValue(TimeStampProperty, value); }
        }

        public SentChatBubble() {
            // Required to initialize variables
            InitializeComponent();
        }
    }
}