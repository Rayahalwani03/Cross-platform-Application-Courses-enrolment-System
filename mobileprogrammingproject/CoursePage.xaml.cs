namespace mobileprogrammingproject;

public partial class CoursePage : ContentPage
{
	public CoursePage()
	{
		InitializeComponent();
        Course_List.ItemsSource = App.DBTrans.GetAllCourses();

    }

    private void Course_List_ItemTapped(object sender, ItemTappedEventArgs e)
    {

    }

    private void Show_Course_Clicked(object sender, EventArgs e)
    {
        Course_List.ItemsSource = App.DBTrans.GetAllCourses();

    }

    private void Add_Course_Clicked(object sender, EventArgs e)
    {
        App.DBTrans.AddCourse(new Models.Course
        {
            CourseCode = Course_Code.Text,
            CourseName = Course_Name.Text
        });

        Course_Code.Text = string.Empty;
        Course_Name.Text = string.Empty;
    }

    private void Delete_Course_Clicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        App.DBTrans.DeleteCourse((int)button.BindingContext);
        Course_List.ItemsSource = App.DBTrans.GetAllCourses();
    }
}