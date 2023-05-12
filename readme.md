# introduction

This project is the tool, designed to simplify adding or updating the TFS items using the outlook emails as a source.
it should work from any reasonably recent version of outlook (assuming 2013 and later) and TFS from 2017 or Azure Devops. 
(The project uses personal access tokens that were introduced in the TFS 2017).

# prerequisites
## .NET Framework 4.7.2
https://dotnet.microsoft.com/download/dotnet-framework/net472

(i have not tested but i assume higher would do too)

## VSTO Runtime 
https://www.microsoft.com/en-us/download/details.aspx?id=56961


# installation 


## option one

run the supplied OutlookTfsSetup.msi or setup.exe  if you dont have the msi infrastructure on your system.

select "current user"
the installation only works "for current user". 
i have not found  the way to remove "for everyone" option yet

restart outlook , the adding should be working.

if you want to have the tfs adding available for other users of the computer, follow the procedure similar to the 
option two below, the files should be in the folder C:\Program Files (x86)\Marat Bakirov\OutlookTfsConnector\

## option two

download the binaries.zip and unzip them into a folder "folder".

it is recommended to open powershell and run this command:

get-childitem "folder" | unblock-file

(see https://winaero.com/blog/how-to-unblock-files-downloaded-from-internet-in-windows-10/ for more detailed explanation)

download the OutlookTfsConnectorRegistrationTool.exe and run it 

press "register", it will open the file dialog, find the vsto file and select it 

restart outlook.

you might have this warning message

![warning image](https://raw.githubusercontent.com/maratbakirov/outlooktfsconnector/master/images/publishing%20warning.png)

it is normal you can just press install.


# setting up

you need to generate a personal access token from your tfs/azure devops the TFS.
the expiry date could be anything you are comfortable with, the rights should be read/write work items

open the link
https://yourtfs.visualstudio.com/_usersSettings/tokens
and create the token

![create token](https://raw.githubusercontent.com/maratbakirov/outlooktfsconnector/master/images/createtoken.png)

press the "settings" button on the main ribbon, enter the url for your project, the project name, your login and the token

![warning image](https://raw.githubusercontent.com/maratbakirov/outlooktfsconnector/master/images/settings.png)
press save and close.

to operate press the "add email to tfs" button. 

you have two options.

on the "add" tab you need to enter the url of the parent item.
the new item will be created as a child of the item you selected, the area and iteration would be copied from the parent. 

other option is to update an existing item in this case the text would be added as a discussion comment. 

you can also select which attachments you want to add and optionally add an attachment comment. 
the first "virtual" attachment is the whole message saved as MSG file.


# version history 
## 0.0.10
#48 add the adding to the "do not disable" list 


## 0.0.9
#49 issues connecting to the cloud devops from outlook

## 0.0.8
issue #46 fixed the logic of save and close button
issue $45 updated binaries so it works with the latest tfs

## 0.0.7
issue #43  The small issue with attachements comment anchor.
issue #44  fixing crashing on some attachements


## 0.0.6
The small issue with attachements comment has been corrected.


## 0.0.5
added an option to process regexp and automatically switch to the "update" tab.

## 0.0.4

issues closed

item urls are now working and copied to clipboard
the product now remembers the last choices for project/item type
you can now select the user story
some work on the installer 

# 0.0.3 
added the image size display

# 0.0.2
added the update item functionality, added an ability to embed from , date etc into the text

# 0.0.1
basic release


# thanks

original version taken from and then was updated and improved
http://amolpandey.com/2018/08/26/vsts-tfs-online-create-work-item-from-outlook-mail-integration-via-vsto/