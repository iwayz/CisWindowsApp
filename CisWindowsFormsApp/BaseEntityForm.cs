using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cis.Data;
using Microsoft.EntityFrameworkCore;

namespace CisWindowsFormsApp
{
    public partial class BaseEntityForm : Form
    {
        public readonly DbContext dbContext;
        public BaseEntityForm()
        {
            InitializeComponent();
            dbContext = new CisDbContext();
        }

    }
}
