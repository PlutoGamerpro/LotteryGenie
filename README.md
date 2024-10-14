# 🎉 LotteryGenie 🎉

 🎟️ Welcome to **LotteryGenie** 🎟️, a fun and simple lottery system that randomly selects numbers for you! ✨ This project generates random lottery numbers and highlights special numbers in a vibrant way. ✨

---

## 📁 Project Structure

```plaintext
├── LotteryGenie/        # Main directory of the project
│   └── Program.cs       # C# source file containing the lottery logic

```

## Technologies Used
- C#: The programming language used to develop this lottery system. 💻
- .NET: Framework for building the application. 🚀

 
 
 ## 🎲 Random Number Generators
 - Initializes two instances of the Random class. One is for general random numbers, and the other is for special numbers.
```csharp
Random rnd = new Random();  
Random SpecialNumber = new Random();
```
## Number Generation
  - Generates a random number and a special number between 1 and 35.
```csharp
  pickednumber = rnd.Next(1, 36);
  specialnumber = rnd.Next(1, 36);
```

## 📋 List Initialization
- Creates a list to store the generated lottery numbers.
 ```csharp
List<int> list = new List<int>();
```
## 🔗 Method Invocation 
- Calls the Lotte method to generate the lottery numbers.
```csharp
Lotte(list);
```
## ✨ Lotte Method Definition
-  Defines a method to generate and display lottery numbers.
 ```csharp
  void Lotte(List<int> lst)
   ```

## 📄 Outer Loop for Lines
- Loops to create up to 7 lines of lottery numbers.
 ```csharp
for (int j = 0; currentlyLine < 7; j++)
      `

   ```

## ⚠️ Duplicate Check
- Ensures the generated number is unique by checking if it already exists in the list. If it does, it regenerates the number.
 ```csharp
while (lst.Contains(pickednumber))
```
## ➕ Adding to List
- Adds the unique picked number to the list.
 ```csharp
lst.Add(pickednumber);
```
## 🌟 Special Number Highlight
- Checks if the picked number is the special number and sets the text color accordingly.
 ```csharp
if (pickednumber == specialnumber)
  ```
## 🔄 Resetting the List
- Clears the list after generating 7 numbers and resets the loop index for the next line.
 ```csharp
  if (i == 6)
{
    lst.Clear();
    i = 0;
    currentlyLine++;
}
 ```
### Thank you for reading!

## 🧑‍🏫 **More Resources & Tutorials**

Check out these amazing resources for more information and advanced coding skills: 📚

If you're looking to deepen your understanding, here are some helpful resources you might find useful:

- 🌟 [Official Visual Studio Documentation](https://docs.microsoft.com/en-us/visualstudio/)
- 📚 [My Coding Tutorials on YouTube](https://www.youtube.com/@CodeByScript)
- 🚀 [Explore My Projects Here!](https://github.com/PlutoGamerpro?tab=stars)  

Feel free to explore these if you're interested! 😊
