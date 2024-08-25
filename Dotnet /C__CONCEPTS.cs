//Method Overloading
class Calc{
public static int MathAdd(int a , int b){
return a + b;
}

public static float MathAdd(float a, float b)
{
    return a + b ;
}
}
class Program{
    public static void Main(string[] args){
        Calc Total = new Calc;
        total.MathAdd(2,5);
        total.MathAdd(2.4, 4.7)
    }
}


//Method Overriding 
public News{
    public virtual void newsItem(){
        console.WriteLine("This is Main News;");
    }
}
class GeneralNews : News{
     public override void newsItem(){
        console.WriteLine("This is generalNews News;");
    }
}
class TechNews : News{
     public override void newsItem(){
        console.WriteLine("This is TechNews News;");
    }
}

class prrogram{
    News news = new news();
    news.newsItem();
     GeneralNews news = new GeneralNews();
    news.newsItem();
     TechNews news = new TechNews();
    news.newsItem();
}


//Abstract Class
abstract class News{

    //Regular Method
    public void NewsRegular(){
        console.WriteLine("This is TechNews News");
    }
    //Abstract Method
    public abstract NewsContent()// Wont have body
}

class TechNews : News{
     public override NewsContent(){
        console.WriteLine("This is TechNews News");
    }
}

class SportNews : News{
      public override NewsContent(){
        console.WriteLine("This is SportNews News");
    }
}

class Program{
    public static void Main(string[] args){
        TechNews n = new TechNews();
        n.NewsContent();// Thi is abstract method call
        n.NewsRegular(); // This is regular method call
    }
}


//Interface 
interface iNews{
    void NewsContent(){
        console.WriteLine("This is Main News");
    }
}
class TechNews : iNews{
     public  NewsContent(){
        console.WriteLine("This is TechNews News");
    }
}

class SportNews : iNews{
      public  NewsContent(){
        console.WriteLine("This is SportNews News");
    }
}

class Program{
    public static void Main(string[] args){
        TechNews n = new TechNews();
        n.NewsContent();
        n.NewsRegular();

    }
}