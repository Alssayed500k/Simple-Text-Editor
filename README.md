# Windows Forms Notepad & Text Editor App

A lightweight desktop text editor application built with **C#** and **Windows Forms** (.NET). This project demonstrates foundational concepts of UI event handling, file I/O operations, dialog integration, dynamic control state management, and Clipboard mechanisms.

---

## 🎯 Core Concept & Pillars

The primary goal of this project is to build a functional multi-purpose text editing interface using standard Windows UI components. 

The core architectural pillars of this application include:
1. **File System Integration:** Reading from and writing to plain text files using C#'s `System.IO` namespace.
2. **Common Dialog Management:** Utilizing built-in Windows dialog components (`OpenFileDialog`, `SaveFileDialog`, `ColorDialog`, `FontDialog`) for a seamless user experience.
3. **UI Event Handling & Control Manipulation:** Dynamic toggling of control visibility, focus state, and text editing controls through menu items (`MenuStrip`).

---

## 🚀 Key Features Learned & Implemented

### 📁 File Operations
* **New Document Creation (`New`):** Clears the working context, resets internal labels/placeholders, and readies `textBox1` for fresh input.
* **Open File (`OpenFileDialog`):** Prompts the user to select a text file (`.txt`), safely reads its contents via `File.ReadAllText()`, and loads it into the editor with robust `try-catch` exception handling.
* **Save File (`SaveFileDialog`):** Saves the current editor content to a target text file using `File.WriteAllText()` with feedback provided via `MessageBox`.

### 🎨 Text Formatting & Styling
* **Custom Text Color (`ColorDialog`):** Allows users to select and apply custom colors to the text editor (`textBox1.ForeColor`).
* **Custom Font & Live Preview (`FontDialog`):** Enables dynamic font customization with live `Apply` event handling (`fontDialog1_Apply`) for real-time visual updates.

### 📋 Clipboard Management
* **Copy:** Checks text presence and safely assigns selected content to the system clipboard using `Clipboard.SetText()`.
* **Cut:** Copies highlighted text (`textBox1.SelectedText`) to the clipboard and removes it from the input area.
* **Paste:** Verifies text presence in the clipboard via `Clipboard.ContainsText()` and injects it at the active cursor position using `textBox1.SelectedText`.

### 🛠️ Control & Life Cycle Management
* **Dynamic Label Handling:** Implements helper functions to auto-toggle label visibility based on input length and presence.
* **Safe Application Exit:** Handles clean form termination and resource disposal (`this.Close()` / `this.Dispose()`).

---

## 💻 Tech Stack & Tools

* **Language:** C#
* **Framework:** .NET Framework / Windows Forms (WinForms)
* **IDE:** Visual Studio

---

## 🌟 Continuous Learning Journey

> *"I am currently in the active learning phase, continuously building projects and sharpening my software engineering skills to reach a professional level that aligns with my ambitions."*

**Developer:** Anwer El-Sayed  
**GitHub Profile:** [@Alssayed500k](https://github.com/Alssayed500k)
