﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Evaluation_Manager.Repositories;

namespace Evaluation_Manager
{
    public partial class FrmStudents : Form
    {
        public FrmStudents()
        {
            InitializeComponent();
        }

        private void FrmStudents_Load(object sender, EventArgs e)
        {
            ShowStudents();
        }

        private void ShowStudents()
        {
            var students = StudentRepository.GetStudents();
            dgvStudents.DataSource = students;

            dgvStudents.Columns["Id"].DisplayIndex = 0;
            dgvStudents.Columns["FirstName"].DisplayIndex = 1;
            dgvStudents.Columns["LastName"].DisplayIndex = 2;
            dgvStudents.Columns["Grade"].DisplayIndex = 3;
        }
    }
}
