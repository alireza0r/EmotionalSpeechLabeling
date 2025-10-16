# Emotional Speech Labeling App

A **C#-based desktop application** for labeling emotional speech samples through a voter-based voting system.
This tool was developed to help researchers collect emotional annotations efficiently while reducing time and cost.

---

## 🧠 Overview

The labeling software allows users (voters) to listen to audio recordings and vote on the perceived emotion.
It supports **two levels of emotional strength** — *Strong* and *Weak* — each including the following options:

* **Happy**
* **Neutral**
* **Sad**
* **Angry**
* **None** — for unclear or unrecognizable emotions

Users can:

* Register personal information (name, gender, age)
* Listen to and stop audio playback
* Vote for emotions
* Save the results as **CSV** or **ZIP** files for analysis

---

## 🧩 Features

* 🎧 Audio playback with play/stop controls
* 🗳️ Simple voting interface for strong and weak emotions
* 🧾 Automatic voter info recording
* 💾 Saves results as CSV or ZIP files
* 🌐 Supports remote use for distributed data labeling
* 🧮 Automatically names saved files by audio filename

---

## 📦 Installation
1. Navigate to the `setup` folder:
2. Run the installer:

   ```bash
   setup.msi
   ```
3. Follow the on-screen instructions to complete installation.

---

## 🚀 Usage

1. Launch the app after installation.
2. Enter your **name**, **gender**, and **age**.
3. Play an audio file and select:

   * One **Strong emotion** (required)
   * One **Weak emotion** (optional)
4. Click **Next** to move to the next sample.
5. When done, open **Tools → Save Results** to export your work as a `.csv` or `.zip` file.

---

## 📁 Output Format

| Column            | Description                      |
| ----------------- | -------------------------------- |
| `audio_file_name` | Name of the processed audio file |
| `strong_emotion`  | Selected strong emotion          |
| `weak_emotion`    | Selected weak emotion (optional) |
| `voter_name`      | Voter’s name                     |
| `gender`          | Voter’s gender                   |
| `age`             | Voter’s age                      |
| `date`            | Labeling date                    |

---





Developed by Alireza Rahmati
