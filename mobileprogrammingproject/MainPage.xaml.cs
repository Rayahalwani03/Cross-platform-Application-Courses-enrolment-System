namespace mobileprogrammingproject
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            Student_List.ItemsSource = App.DBTrans.GetAllStudents();
        }

        private void Student_List_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }

        private void Delete_Student_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            App.DBTrans.DeleteStudent((int)button.BindingContext);
            Student_List.ItemsSource = App.DBTrans.GetAllStudents();
        }

        private void Add_Student_Clicked(object sender, EventArgs e)
        {

            App.DBTrans.AddStudent(new Models.Student
            {
                StudentName = Student_Name.Text,
                StudentDepartment = Student_Department.Text,
            });

            Student_Name.Text = string.Empty;
            Student_Department.Text = string.Empty;

        }

        private void Show_Student_Clicked(object sender, EventArgs e)
        {
            Student_List.ItemsSource = App.DBTrans.GetAllStudents();

        }
    }

}
