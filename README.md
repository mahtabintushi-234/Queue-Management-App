
# Queue Management App (Windows Forms)

 📌 Overview  
This Windows Forms application simulates a simple queue system. Users can enter their name to join a queue, and the program tracks their position. A “Serve” button removes the next person in line. This project demonstrates basic data structures (Queue\<T\>), event‑driven programming, and UI interaction in C#.

---

 🚀 Features  
- Add a name to the queue  
- Automatically assign and display queue position  
- Serve (remove) the next person in line  
- Prevent serving when the queue is empty  
- Simple, clean user interface  

---

 🛠️ Technologies Used  
- **C#**  
- **.NET Framework / Windows Forms**  
- **Queue\<string\>** collection  

---

 📂 How It Works  

 **Joining the Queue**
- User types their name into a textbox  
- Clicking **Join**:
  - Validates the input  
  - Adds the name to the queue  
  - Displays the position in a ListBox  
  - Clears the textbox  

**Serving the Queue**
- Clicking **Serve**:
  - Checks if the queue is empty  
  - Removes the first person (`Dequeue()`)  
  - Removes the first entry from the ListBox  

---

🧩 Code Summary  
The core logic uses a `Queue<string>` to store names in FIFO order.  
UI events (`joinButton_Click` and `serveButton_Click`) update both the queue and the ListBox.

---

## ▶️ How to Run  
1. Open the project in **Visual Studio**  
2. Build the solution  
3. Run the application  
4. Enter names and manage the queue using the buttons  

---

📸 UI Components  
- **TextBox** – for entering names  
- **Join Button** – adds name to queue  
- **Serve Button** – removes next person  
- **ListBox** – displays queue order  

---

📘 Possible Improvements  
- Display the name of the person being served  
- Add timestamps  
- Add a “Clear Queue” button  
- Save queue state to a file  

---


