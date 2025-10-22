# Two Sum
#### Easy

Topics
premium lock icon
Companies

> [!hint]
> Hint  
> Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
>
> You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.



## Example 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
Example 2:

Input: nums = [3,2,4], target = 6
Output: [1,2]
Example 3:

Input: nums = [3,3], target = 6
Output: [0,1]


## Constraints:

2 <= nums.length <= 104
-109 <= nums[i] <= 109
-109 <= target <= 109
Only one valid answer exists.


**Follow-up:** Can you come up with an algorithm that is less than O(n2) time complexity?

```bash
  dotnet run 
```

---

### Intuition

I did a first solution with pure brute force. Then I realised:

* Instead of checking if the sum matches the target, I could use the difference between the target and the current number (so, O(n) should be possibel)
* If I calculate the difference for the current index and it matches a difference that I have calculated before, I already have the pair!

### Approach

* Start calculating the difference top-to-bottom
* If I don't "remember" seeing the current difference store it for later
* If I DO "remember" the current differnce, I have the answer: [current index (i), last index of the same difference (index)]

#### Complexity
**Time complexity:** O(n)

**Space complexity:** O(n)