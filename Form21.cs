using System;
using System.Drawing;

namespace VITAL_V9
{
    internal class Form21
    {
        public Size ClientSize { get; private set; }
        public string Name { get; private set; }
        public EventHandler Load { get; private set; }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Form21";
            NewMethod();
            this.ResumeLayout(false);

        }

        private void NewMethod()
        {
            this.Load += new System.EventHandler(this.Form2_Load);
        }

        private void ResumeLayout(bool v)
        {
            throw new NotImplementedException();
        }

        private void SuspendLayout()
        {
            throw new NotImplementedException();
        }

        private void Form2_Load(object sender, System.EventArgs e)
        {

        }

        internal void Show()
        {
            throw new NotImplementedException();
        }
    }
}