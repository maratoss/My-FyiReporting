using System;
using System.Windows.Forms;

namespace fyiReporting.RdlDesign.InsertParams
{
    using System.Threading;

    public partial class InsertParameterForm : Form
    {
        private readonly ManualResetEvent manualResetEvent;

        public InsertParameterForm(ManualResetEvent manualResetEvent)
        {
            this.manualResetEvent = manualResetEvent;
            InitializeComponent();
        }

        public ListBox ListParameters
        {
            get
            {
                return this.listParameters;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            manualResetEvent.Set();
        }
    }
}
