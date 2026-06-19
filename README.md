# Bank Management System

A fully operational, database-driven Windows Forms desktop application engineered in C# using Microsoft Visual Studio. This project implements a relational database back-end via MS Access, connected securely through localized OLEDB connection strings. The system features a custom graphic user interface (GUI) integrating tailored visual assets for a complete multimedia corporate identity.

---

## 🛠️ Tech Stack & Key Components
* **Language & Framework:** C# (.NET Framework / Windows Forms GUI)
* **Development Environment:** Microsoft Visual Studio
* **Database Management:** Microsoft Access Relational Database (`dbBankSystem.mdb`)
* **Data Connectivity:** OLEDB Database Engine Connection Provider

---

## 🛡️ Core Features & Capabilities

* **User Authentication & Enrollment:** Secure login and registration flows linked directly to the database layer to handle user creation, credential validation, and input sanitization.
* **Financial Ledger Transactions:** Dynamic balance queries allowing users to process real-time simulated financial deposits and withdrawals in Jordanian Dinars (JOD), with values immediately updated in the database tables.
* **Account Profile Management:** Built-in editing modules that grant users the ability to safely update account parameters, contact info, and structural login credentials.
* **Multi-Regional Branch Directory:** An interactive information lookup system parsing official contact matrices, operational schedules, and management information across multiple main regional hubs (Amman, Irbid, and Aqaba).

---

## 🖼️ User Interface & Visual Showcase

### Main Entrance & Authentication
| Main Welcome Vault | Secure Access Login | New Account Registration |
| :---: | :---: | :---: |
| <img src="Screenshots/Main interface.jpg" width="220" alt="Main Vault"> | <img src="Screenshots/Login interface.png" width="220" alt="Login"> | <img src="Screenshots/SignUp interface.png" width="220" alt="Sign Up"> |

### Member Dashboard & Ledger Operations
| User Info & Balance Hub | Ledger Deposit & Withdrawal | Profile Customization Panel |
| :---: | :---: | :---: |
| <img src="Screenshots/User Info interface.png" width="220" alt="Dashboard"> | <img src="Screenshots/Balance interface.png" width="220" alt="Balance"> | <img src="Screenshots/Edit User interface.png" width="220" alt="Edit Profile"> |

### Regional Multi-Branch Hubs
| Regional Directory Selector | Amman Branches Network | Irbid Branches Network |
| :---: | :---: | :---: |
| <img src="Screenshots/Bank Branches interface.png" width="220" alt="Branches Menu"> | <img src="Screenshots/Amman Branches interface.png" width="220" alt="Amman Hub"> | <img src="Screenshots/Irbid Branches interface.png" width="220" alt="Irbid Hub"> |

*(Note: The full Aqaba branches index layout is also preserved inside the asset directory as `Screenshots/Aqaba Branches interface.png`).*

---

## 🚀 Architectural File Breakdown
* **`Bank System.sln`:** The core Visual Studio solution configuration mapping all UI forms and code dependencies.
* **`dbBankSystem.mdb`:** The underlying database storing active data tables for user credentials, profiles, and live balances.
* **`FP Images/`:** The dedicated media asset folder containing custom-designed background images, interface banners, and button icons.
* **`Screenshots/`:** Visual compilation of the application interfaces used for evaluation and documentation.
