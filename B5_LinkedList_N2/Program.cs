public class Node
{
    public object element;
    public Node link;
    public Node() { element = null; link = null; }
    public Node(object element) { this.element = element; link = null; }
}
public class LinkedList
{
    public Node header;
    public LinkedList() { header = new Node("Header"); }
    public Node Find(object specificelem)
    {
        Node current = header;
        while (current.element != specificelem)
            current = current.link;
        return current;
    }
    //Insert tương đường với AddAfter
    public void Insert(object newelem, object afterelem)
    {
        Node current = Find(afterelem);
        Node newnode = new Node(newelem);
        newnode.link = current.link;
        current.link = newnode;
    }
    public void AddFirst(object newelem){

    }
    public void AddLast(object newelem){

    }
    public void AddBefore(object newelem, object beforeelem){

    }
    public Node FindPrev(object specificelem)
    {
        Node current = header;
        while (current.link.element != specificelem)
            current = current.link;
        return current;
    }
    public void Remove(object specificelem)
    {
        Node beforedeletednode = FindPrev(specificelem);
        beforedeletednode.link = beforedeletednode.link.link;
    }
    public void Swap(object elA, object elB)
    {
        Node prevA = FindPrev(elA);
        Node prevB = FindPrev(elB);
        Remove(elB);
        Insert(elA, prevB.element);
        Insert(elB, prevA.element);
        Remove(elA);
    }
    public void Sort()
    {

    }
}
public class Node2
{
    public object element;
    public Node2 flink, blink;
    public Node2()
    {
        element = null;
        flink = blink = null;
    }
    public Node2(object element)
    {
        this.element = element;
        flink = blink = null;
    }
}
public class DoubleLinkedList
{
    public Node2 header;
    public DoubleLinkedList()
    {
        header = new Node2("Header");
    }
    private Node2 Find(object element)
    {
        Node2 current = new Node2();
        current = header;
        while (current.element != element)
        {
            current = current.flink;
        }
        return current;
    }
    //Insert tương ứng với AddAfter
    public void Insert(object newelement, object afterelement)
    {
        Node2 current = new Node2();
        Node2 newnode = new Node2(newelement);
        current = Find(afterelement);
        newnode.flink = current.flink;
        newnode.blink = current;
        current.flink = newnode;
    }
    public void AddFirst(object newelem){

    }
    public void AddLast(object newelem){

    }
    public void AddBefore(object newelem, object beforeelem){
        
    }
    public void Remove(object element)
    {
        Node2 current = Find(element);
        if (current.flink != null)
        {
            current.blink.flink = current.flink;
            current.flink.blink = current.blink;
            current.flink = null;
            current.blink = null;
        }
    }
    public Node2 FindPrev(object specificelem)
    {
        Node2 current = header;
        while (current.flink.element != specificelem)
            current = current.flink;
        return current;
    }
    public void Swap(object elA, object elB)
    {
        Node2 prevA = FindPrev(elA);
        Node2 prevB = FindPrev(elB);
        Remove(elB);
        Insert(elA, prevB.element);
        Remove(elA);
        Insert(elB, prevA.element);
    }
    public void Sort(){
        
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        /*LinkedList llist = new LinkedList();
        llist.Insert("milk", "Header");
        llist.Insert("bacon", "milk");
        llist.Insert("egg", "bacon");
        llist.Insert("bread", "egg");
        ;
        llist.Swap("milk", "bacon");
        //llist.Remove("egg");
        ;*/
        DoubleLinkedList dllist = new DoubleLinkedList();
        dllist.Insert("Mike", "Header");
        dllist.Insert("Raymond", "Mike");
        dllist.Insert("Jacob", "Raymond");
        dllist.Insert("Andy", "Jacob");
        ;
        //dllist.Remove("Jacob");
        dllist.Swap("Mike", "Raymond");
    }
}