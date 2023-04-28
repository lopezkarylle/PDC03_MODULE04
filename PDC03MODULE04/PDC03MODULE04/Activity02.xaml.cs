using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.Collections.ObjectModel;

namespace PDC03MODULE04
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Activity02 : ContentPage
    {

        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        public ObservableCollection<Employee> Employees { get { return employees; } }

        public Activity02()
        {
            InitializeComponent();
            EmployeeView.ItemsSource = employees;

            employees.Add(new Employee { DisplayName = "Im Nayeon", Position = "Chief Executive Officer" });
            employees.Add(new Employee { DisplayName = "Yoo Jeongyeon", Position = "Chief Operating Officer" });
            employees.Add(new Employee { DisplayName = "Hirai Momo", Position = "Chief Financial Officer" });
            employees.Add(new Employee { DisplayName = "Minatozaki Sana", Position = "Chief Marketing Officer" });
            employees.Add(new Employee { DisplayName = "Park Jihyo", Position = "Marketing Manager" });
            employees.Add(new Employee { DisplayName = "Myoui Mina", Position = "Sales Manager" });
            employees.Add(new Employee { DisplayName = "Kim Dahyun", Position = "Product Manager" });
            employees.Add(new Employee { DisplayName = "Son Chaeyoung", Position = "IT Manager" });
            employees.Add(new Employee { DisplayName = "Chou Tzuyu", Position = "HR Manager" });
        }

        private void Add_Item(object sender, EventArgs e)
        {

        }
        private void Edit_Item(object sender, EventArgs e)
        {

        }
        private void Delete_Item(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;  
            if (menuItem != null)
            {

            }
        }


    }
}