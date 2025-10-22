# FizzBuzz

![/problems/fizzbuzz/file/statement/en/img-0001.png](https://open.kattis.com/problems/fizzbuzz/file/statement/en/img-0001.png)

[Image](https://chrismorgan.info/media/images/rust-fizzbuzz.svg) by chris morgan cc by

According to Wikipedia, FizzBuzz is a group word game for children to teach them about division. This may or may not be true, but this question is generally used to ~~torture~~ screen young computer science graduates during programming interviews.

Basically, this is how it works: you print the integers from 1 to N, replacing any of them divisible by X with Fizz or, if they are divisible by Y, with Buzz. If the number is divisible by both X and Y, you print FizzBuzz instead.

Check the samples for further clarification.

Input

Input contains a single test case. Each test case contains three integers on a single line, ,  and  ().

Output

Print integers from  to  in order, each on its own line, replacing the ones divisible by  with Fizz, the ones divisible by  with Buzz and ones divisible by both  and  with FizzBuzz.

Check the samples for further clarification.

## Input

Input contains a single test case. Each test case contains three integers on a single line, ,  and  ().

## Output

Print integers from  to  in order, each on its own line, replacing the ones divisible by  with Fizz, the ones divisible by  with Buzz and ones divisible by both  and  with FizzBuzz.

|Sample Input 1|Sample Output 1|
|---|---|
|2 3 7|1<br>Fizz<br>Buzz<br>Fizz<br>5<br>FizzBuzz<br>7|

|Sample Input 2|Sample Output 2|
|---|---|
|2 4 7|1<br>Fizz<br>3<br>FizzBuzz<br>5<br>Fizz<br>7|

| Sample Input 3 | Sample Output 3                          |
| -------------- | ---------------------------------------- |
| 3 5 7          | 1<br>2<br>Fizz<br>4<br>Buzz<br>Fizz<br>7 |

## Test Solution:
```bash
    dotnet run 2 3 7
    
    1
    Fizz
    Buzz
    Fizz
    5
    FizzBuzz
    7
```

```bash
    dotnet run 2 4 7
    
    1
    Fizz
    3
    FizzBuzz
    5
    Fizz
    7
```

```bash
    dotnet run 3 5 7
    
    1
    2
    Fizz
    4
    Buzz
    Fizz
    7
```