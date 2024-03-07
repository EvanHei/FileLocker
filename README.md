# FileLocker

FileLocker is a Windows desktop application designed protect files in rest or in transit using security best practices.

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

- **TODO**: the installer.
- **Certificate**: the certificate allowing installation.

### Installation

#### Import Certificate

TODO

#### Install

TODO

## User Guide

### Dashboard Form

<img src="./images/DashboardForm.png" alt="Dashboard Form" width="600">

The Dashboard Form displays what files are currently within FileLocker's scope. Each file's status can be seen to the left of its name. 🔐 means secure and 📄 means unsecure.

- **+ Add File**: displays a file dialog to select one or more files to be displayed.
- **Encrypt**: launches the [**Encrypt Form**](#encrypt-form).
- **Decrypt**: launches the [**Decrypt Form**](#decrypt-form).
- **🗑️**: shreds a file by overwriting its contents with random data and then deleting.
- **List Panel**: right click on a file to display options.

### Tabs

<img src="./images/FileTab.png" alt="File Tab" width="400">
<img src="./images/HelpTab.png" alt="Help Tab" width="400">

- **File Tab**: displays a menu with the following options:

  - Import Archive: select a file archive to load into FileLocker.
  - Export Archive: exports the curruntly selected file archive into a .filelocker file.
  - Exit: terminate the app.

- **Help Tab**:

  - User Guide: opens the GitHub repository in the default browser.

---

### Encrypt Form

<img src="./images/EncryptForm.png" alt="Encrypt Form" width="400">

The Encrypt Form allows users to encrypt a file with industry-standard encryption algorithms using a password of a required strength.

- **Generate Random**: generates a random password that satisfies the strength policy.
- **→**: encrypts the file with the provided password.
- **👁**: shows or hides the password.

---

### Decrypt Form

<img src="./images/DecryptForm.png" alt="Decrypt Form" width="400">

The Decrypt Form allows users to decrypt a file with the correct password.

- **→**: decrypts the file with the provided password, if correct.
- **👁**: shows or hides the password.

## Technologies

- **OS**: Windows 10 (x86 and x64)
- **IDE**: Visual Studio
- **Programming Language**: C#
- **Framework**: .NET
- **UI**: Windows Forms
- **Version Control**: Git / GitHub
- **Encryption Algorithm**: AES256
- **MAC Algorithm**: HMACSHA256
- **Key Derivation Algorithm**: PBKDF2
- **Logging Library**: Serilog
- **Unit Testing Library**: xUnit

## Security Features

- **Confidentiality**: Encrypts files with AES256.
- **Integrity**: Uses HMACs to ensure the integrity of stored or transmitted data.
- **Password Strength Policy**: Sets a strong password to mitigate brute-force attacks.
- **Password Generator**: Generates a password without the need to manually type, mitigating the effect of keystroke logging malware.
- **Password Management**: Hashes and salts passwords to protect against rainbow table attacks.
- **Password-Based Key Derivation**: Derives encryption keys from passwords.
- **Logging**: Uses Serilog to track application events.
- **Constant-Time Comparison**: Uses libraries with constant-time comparison to mitigate timing attacks.
- **File Shredder**: Deletes files without leaving traces by overwriting with random data.
- **Customizable Encryption**: Allows users to choose different encryption algorithms.
- **SOLID Principles**: Follows SOLID principles to facilitate quick code updates in the case of a new exploit.
