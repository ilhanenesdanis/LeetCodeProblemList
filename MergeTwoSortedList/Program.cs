
var list = new ListNode(1);

list.next = new ListNode(2);
list.next.next = new ListNode(4);

var list2 = new ListNode(1);
list2.next = new ListNode(3);
list2.next.next = new ListNode(4);

var newSortedList = new List<int>();


AddValues(list, newSortedList);
AddValues(list2, newSortedList);

var order = newSortedList.Order().ToArray();


ListNode orderedNode = AddItemNode(order, 0);

Console.ReadLine();

ListNode AddItemNode(int[]? order, int index)
{
    if (index >= order.Length)
        return null;

    ListNode newNode = new ListNode(order[index]);

    newNode.next = AddItemNode(order, index + 1);

    return newNode;
}

void AddValues(ListNode list, List<int> sorted)
{
    if (list == null)
        return;

    sorted.Add(list.val);
    AddValues(list.next, sorted);

}


class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}


