using mobileprogrammingproject.Models;

namespace mobileprogrammingproject;

public partial class EnrollPage : ContentPage
{

    int Stu_ID;
    int Crs_ID;
    public EnrollPage()
	{
		InitializeComponent();
        Student_List.ItemsSource = App.DBTrans.GetAllStudents();
        Course_List.ItemsSource = App.DBTrans.GetAllCourses();
        Enroll_List.ItemsSource = App.DBTrans.GetAllEnrolls();
    }

    private void Student_List_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var student = e.Item as Student;
        Stu_ID = student.StudentID;
    }

    private void Course_List_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var course = e.Item as Course;
        Crs_ID = course.CourseID;
    }

    private void Add_Enroll_Clicked(object sender, EventArgs e)
    {
        App.DBTrans.AddEnroll(new Models.Enroll
        {
            StudentID = Stu_ID,
            CourseID = Crs_ID,
        });
    }

    private void Show_Enroll_Clicked(object sender, EventArgs e)
    {

        Enroll_List.ItemsSource = App.DBTrans.GetAllEnrolls();


    }

    private void Enroll_List_ItemTapped(object sender, ItemTappedEventArgs e)
    {

    }

    private void Delete_Enroll_Clicked(object sender, EventArgs e)
    {

        Button button = (Button)sender;
        App.DBTrans.DeleteEnroll((int)button.BindingContext);
        Enroll_List.ItemsSource = App.DBTrans.GetAllEnrolls();
    }

    private void Show_Selections_Clicked(object sender, EventArgs e)
    {
        Student_List.ItemsSource = App.DBTrans.GetAllStudents();
        Course_List.ItemsSource = App.DBTrans.GetAllCourses();
    }
}