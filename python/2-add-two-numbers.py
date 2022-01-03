# https://leetcode.com/problems/add-two-numbers/

class Node:
    def __init__(self, val=None):
        self.val = val
        self.next = None


def AddTwoNumbers(headOne, headTwo):

    headNew = Node()
    headLast = Node()

    carry = 0
    while(headOne != None or headTwo != None):
        val = 0

        if(headOne == None):
            val = (headTwo.val or 0) + carry
        elif(headTwo == None):
            val = (headOne.val or 0) + carry
        else:
            val = (headOne.val or 0) + (headTwo.val or 0) + carry

        carry = 0

        if(val >= 10):
            val -= 10
            carry = 1

        print(val)

        if(headOne != None):
            headOne = headOne.next

        if(headTwo != None):
            headTwo = headTwo.next

        headNew.val = val
        headLast.next = headNew
        headLast = headNew


def SetupList(ints):
    last = Node()
    head = Node()
    for val in ints:
        node = Node(val)

        if(last.val != None):
            last.next = node

        if(head.val == None):
            head = node

        last = node

    return head


AddTwoNumbers(SetupList([]), SetupList([]))
AddTwoNumbers(SetupList([]), SetupList([0]))
AddTwoNumbers(SetupList([0]), SetupList([]))
AddTwoNumbers(SetupList([]), SetupList([1, 2]))
AddTwoNumbers(SetupList([0, 2]), SetupList([3, 2]))

# mismatch array length (26) [6, 2]
AddTwoNumbers(SetupList([2]), SetupList([4, 2]))

# easy example (807) [7, 0, 8]
AddTwoNumbers(SetupList([2, 4, 3]), SetupList([5, 6, 4]))

# carry example (1,320) [0, 2, 3, 1]
AddTwoNumbers(SetupList([9, 8, 7]), SetupList([1, 3, 5]))

# leet example two (10,009,998) [8,9,9,9,0,0,0,1]
AddTwoNumbers(SetupList([9, 9, 9, 9, 9, 9, 9]), SetupList([9, 9, 9, 9]))
