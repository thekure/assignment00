namespace Namespace;

public class Class
{
    private string _field;
        
    protected DateTime _fieldAvailableInSubClass;
        
    public string Property { get => _field; } // Getter
        
    public int AutoProperty { get; set; }
        
    public Class() { }

    public string InstanceMethod(string parameter)
    {
        return $"Hello {parameter}";
    }

    public virtual bool OverridableInstanceMethod(bool parameter) => !parameter;

    public static void StaticMethod() { }
       
    private void PrivateInstanceMethod() { }

    public event EventHandler Event;

    protected virtual void OnEvent(EventArgs e)
    {
        EventHandler handler = Event;
        handler?.Invoke(this, e);
    }

    public delegate void MyEventHandler(object sender, EventArgs e);
}