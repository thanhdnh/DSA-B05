using System.Collections;
class StudentDictionary:DictionaryBase{
    public void Add(string k, Student val){
        base.InnerHashtable.Add(k, val);
    }
    public void Remove(string k){
        base.InnerHashtable.Remove(k);
    }
    public Student Item(string k){
        return (Student)base.InnerHashtable[k];
    }
}