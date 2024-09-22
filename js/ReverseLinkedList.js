/**
 * Definition for singly-linked list.
 * function ListNode(val, next) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.next = (next===undefined ? null : next)
 * }
 */
/**
 * @param {ListNode} head
 * @return {ListNode}
 */
// var reverseList = function(head) {
//     return reverse(null, head);
// };

// var reverse = function(pre, cur) {
//     if(!cur) return pre;
//     const next = cur.next;
//     cur.next = pre;
//     return reverse(cur, next);
// };

// var reverseList = function(head) {
//     if(head == null || head.next == null) return head;
//     let last = reverseList(head.next);
//     head.next.next = head;
//     head.next = null;
//     return last;
// };

var reverseList = function(head) {
    if(!head || !head.next) return head;
    let pre = null, cur = head, temp = null;
    while(cur != null) {
        temp = cur.next;
        cur.next = pre;
        pre = cur;
        cur = temp;
    }
    return pre;
};