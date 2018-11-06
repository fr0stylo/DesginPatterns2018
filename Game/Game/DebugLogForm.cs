﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class DebugLogForm : Form {
        private DebugLogSingleton singleton;
        public DebugLogForm() {
            InitializeComponent();
            singleton = DebugLogSingleton.GetInstance();
            singleton.OnEntry += SingletonOnOnEntry;
            richTextBox1.Text += singleton.ToString();
            comboBox1.Items.AddRange(singleton.DebugLogs.Select(x => x.Class).Distinct().ToArray());
        }

        private void SingletonOnOnEntry(EventArgs eventArgs) {
            richTextBox1.Invoke(new Action(() => {
                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(singleton.DebugLogs.Select(x => x.Class).Distinct().ToArray());
                richTextBox1.Clear();
                richTextBox1.Text += singleton.ToString();
            }));
        }

        private void comboBox1_SelectedValueChanged(ComboBox sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text += singleton.Filter((string) sender.SelectedValue);
        }
    }
}
