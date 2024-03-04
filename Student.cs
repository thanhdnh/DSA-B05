class Student
{
    public string name;
    public int age;
    public float gpa;
    public Student(string name, int age, float gpa){
        this.name = name;
        this.age = age;
        this.gpa = gpa;
    }
    public override string ToString()
    {
        return $"Student({name}, {age}, {gpa})";
    }
}