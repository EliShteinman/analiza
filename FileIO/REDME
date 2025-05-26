# 🕵️‍♂️ Secret Messages – Atbash Cipher Writer

This is a simple C# console application that allows users to write, encrypt, save, read, and decrypt secret messages using the **Atbash cipher**.

## 📦 Project Structure

The project is cleanly organized with clear responsibilities per class:

| File              | Responsibility                                    |
|-------------------|---------------------------------------------------|
| `Program.cs`      | Main entry point of the application               |
| `MessageInput.cs` | Gets a message from the user via console          |
| `Encrypted.cs`    | Encrypts the message using the Atbash cipher      |
| `Decrypted.cs`    | Decrypts the encrypted message using Atbash       |
| `Writer.cs`       | Writes encrypted messages to a file               |
| `Reader.cs`       | Reads encrypted messages from a file              |

## 🔐 How the Atbash Cipher Works

The Atbash cipher is a simple substitution cipher that reverses the alphabet:

- A ↔ Z
- B ↔ Y
- C ↔ X
- ...
- a ↔ z
- b ↔ y
- etc.

Only letters are encrypted; all other characters (spaces, punctuation) are left unchanged.

## 💡 Example

If the user inputs:

```
hello world
```

It will be encrypted as:

```
svool dliow
```

And then saved to a file named `secret.txt`. The program can read it back and decrypt it to restore the original message.

## 🛠️ How to Run

1. Make sure you have the .NET SDK installed.
2. Open a terminal in the project directory.
3. Run the program:

```bash
dotnet run
```

4. Follow the prompts in the console to input and view secret messages.

## 📁 File Location

The file `secret.txt` will be created in the working directory (e.g. `bin/Debug/net8.0/` if using Rider or Visual Studio).

## 🎯 Learning Goals

- Practice using file I/O with `File.WriteAllText()` and `File.ReadAllText()`
- Apply basic string manipulation
- Use a classic cipher for educational purposes

---

Created with 💙 using C#
