# HolmHub - Client  |   <img src="https://github.com/H0Im/HolmHub/blob/master/Resources/Building.png" width="100"/>

### *A Specstro company product*

<img src="https://github.com/H0Im/HolmHub/blob/master/Resources/HolmHub.png"/>

It's purpose to make it easier for the user to download and install files located on the Specstro remote server

<br>

### Planned features -  list

------

- **Simplistic overview over files on the remote server such as**
  - ***Software***
  - ***Games***
- **Storage** - *Analyzes disks to see what takes up the most of the disk space*
- **Antivirus** - *Easily run `Windows Defender` scans from the client*
- **Backup** - *Create schedule backup tasks to backup your files to your desired location*
- **Web** - *Quick access to Specstro webpage*

<br>

### Expanded features -  list

------

- **Appstore features**
  - **Left-click event**
    - *Checks if application is installed*
      - *`If No`: Install application to desired location*
      - *`If Yes`: Opens application*
  - **Right-click event**
    - *Opens Context menu with following options*
      - Run - *Runs application*
      - Uninstall - *Runs uninstall.exe*
      - Repair - *Uninstall + Install*
      - Update - *If new version = install*
      - AutoStart - *Add application to `shell:startup`*
      - Shortcut - *Creates shortcut to `%ShortcutLocation%`*
        - *User can define `%ShortcutLocation%` in Settings tab*

<br>

### Conundrum

------

##### Installing, uninstalling & updating

In order for the install & uninstall function to work, there needs to be a set of instructions on how this is performed, as not every program supports `silent install` and some programs are simply `copy & paste`. The same goes for uninstalling some application does not have an `uninstall.exe` 

Using `.ini` files attached to each app might be a solution 

Going for the `.ini` file solution also gives us the possibility to make an update feature. Adding a `version = dd.mm.yy.ver.sign` gives variable which we can store in a `version.ini` file on the local computer.

If we then implement a refresh function in the client, we can check if there are any newer versions on the remote server.

We can than add an update tab to list the apps that have new updates
