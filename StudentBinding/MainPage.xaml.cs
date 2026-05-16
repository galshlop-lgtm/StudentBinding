using Microsoft.Maui.Controls;
using StudentBinding.models;
using System;
using StudentBinding.models; 

namespace StudentBinding 
{
    public partial class MainPage : ContentPage
    {
       
        public Student Student1 { get; set; }
        public Student Student2 { get; set; }

        public MainPage()
        {
            InitializeComponent();

          
            Student1 = new Student { Name = "דניאל כהן", Image = "daniel.png" };
            Student2 = new Student { Name = "נועה כהן", Image = "noa.png" };

            
            this.BindingContext = Student1;
        }

       
        private void OnChangeStudentClicked(object sender, EventArgs e)
        {
            if (this.BindingContext == Student1)
            {
                this.BindingContext = Student2;
            }
            else
            {
                this.BindingContext = Student1;
            }
        }
    }
}