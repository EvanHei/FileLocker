# FileLocker

A Windows desktop app to protect files in rest or in transit using cryptographic techniques and cybersecurity best practices.

## Table of Contents

1. [Getting Started](#getting-started)
   - [Download](#download)
   - [Installation](#installation)
2. [User Guide](#user-guide)
   - [Dashboard Form](#dashboard-form)
   - [Encrypt Form](#encrypt-form)
   - [Decrypt Form](#decrypt-form)
3. [Technologies](#technologies)
4. [Security Features](#security-features)

## Getting Started

### Download

_Coming Soon_

### Installation

_Coming Soon_

## User Guide

### Dashboard Form

<img src="./images/DashboardForm.png" alt="Dashboard Form" width="600">

The Dashboard Form displays files within FileLocker's scope. Each file's status can be seen to the left of its name. Multiple files can be selected for encryption and deletion.

- **+ Add File**: displays a file dialog to select one or more files to be displayed.
- **Encrypt**: launches the [**Encrypt Form**](#encrypt-form).
- **Decrypt**: launches the [**Decrypt Form**](#decrypt-form).
- **🗑️**: shreds a file by overwriting its contents with random data and then deleting.
- 📥: imports a chosen file archive.
- 📤: exports the selected file.
- **User Guide 📖**: opens the GitHub repository in the default browser.
- **File List**: right click on a file to display options, or drag and drop files onto the panel to add them.

---

### Encrypt Form

<img src="./images/EncryptForm.png" alt="Encrypt Form" width="400">

The Encrypt Form allows users to encrypt by choosing an industry-standard encryption algorithm such as AES or 3DES and providing a strength-enforced password. Passwords cleared after 30 seconds of inactivity.

- **Generate Random**: generates a random password that satisfies the strength policy.
- **→**: encrypts the file with the provided password.
- **👁**: shows or hides the password fields.

> [!CAUTION]
> If the password is lost, so is the file's data. FileLocker maintains a zero-knowledge policy.

---

### Decrypt Form

<img src="./images/DecryptForm.png" alt="Decrypt Form" width="400">

The Decrypt Form allows users to decrypt by inputting the encryption password. Passwords cleared after 30 seconds of inactivity.

- **→**: decrypts the file with the provided password, if correct.
- **👁**: shows or hides the password.

## Technologies

- **OS**: Windows
- **IDE**: Visual Studio
- **Programming Language**: C#
- **Framework**: .NET
- **UI**: Windows Forms
- **Version Control**: Git / GitHub
- **Encryption Algorithm(s)**: AES, 3DES
- **MAC Algorithm**: HMACSHA256
- **Key Derivation Algorithm**: PBKDF2
- **Logging Library**: Serilog
- **Unit Testing Library**: xUnit

## Security Features

- **Confidentiality**: Encrypts files with AES or 3DES.
- **Integrity**: Generates HMACs to ensure the integrity of stored or transmitted data.
- **Password Strength Policy**: Sets a strong password to mitigate brute-force attacks.
- **Password Generator**: Generates a password without the need to manually type, mitigating the effect of keystroke logging malware.
- **Password Management**: Clears password inputs after a set time if the device is left running.
- **Password-Based Key Derivation**: Derives encryption keys from passwords.
- **Logging**: Logs important events such as encryption and decryption with Serilog.
- **Constant-Time Comparison**: Uses libraries with constant-time comparison to mitigate timing attacks.
- **File Shredder**: Deletes files without leaving traces by overwriting with random data.
- **Customizable Encryption**: Allows selection of different encryption algorithms.
- **SOLID Principles**: Follows SOLID principles to facilitate quick code updates in the case of a new exploit.
