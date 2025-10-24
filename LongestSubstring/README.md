# Longest Substring Without Repeating Characters

#### Medium

Topics
premium lock icon
Companies

> [!hint]
>
> ### Hint
> Given a string s, find the length of the longest substring without duplicate characters.

## Example 1:

Input: s = "abcabcbb"
Output: 3
Explanation: The answer is "abc", with the length of 3. Note that "bca" and "cab" are also correct answers.

## Example 2:

Input: s = "bbbbb"
Output: 1
Explanation: The answer is "b", with the length of 1.
Example 3:

Input: s = "pwwkew"
Output: 3
Explanation: The answer is "wke", with the length of 3.
Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.

## Constraints:

0 <= s.length <= 5 * 104
s consists of English letters, digits, symbols and spaces.

---

```
    ✋🏼🤚🏼pwwkew ----> _ ----> all unique, move the right hand
    ✋🏼p🤚🏼wwkew ----> p ----> all unique, move the right hand
    ✋🏼pw🤚🏼wkew ----> pw ----> all unique, move the right hand
    ✋🏼pww🤚🏼kew ----> w ----> not all unique, move the left hand (in the while loop, right doesn't move)
    p✋🏼ww🤚🏼kew ----> _ ----> not all unique, move the left hand (in the while loop, right doesn't move)
    pw✋🏼w🤚🏼kew ----> w ----> all unique, move the right hand
    pw✋🏼wk🤚🏼ew ----> wk ----> all unique, move the right hand
    pw✋🏼wke🤚🏼w ----> wke ----> all unique, move the right hand
    pw✋🏼wkew🤚🏼----> ke ----> not all unique, move the left hand (in the while loop, right doesn't move)
    pww✋🏼kew🤚🏼----> kew ----> all unique, no more room to move, return the length of the string  
```

✋🏼🤚🏼

```bash
  dotnet run 
```