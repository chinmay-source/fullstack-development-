import pyautogui
pyautogui.FAILSAFE = False
from win32api import GetSystemMetrics
import os
print("SalesMate + Backup Manu Test")

print("Create a Database Backup directory called KGB")

path="D:/KGB"
if not os.path.exists(path):
    os.makedirs(path)

#get the width and height of the monitor
width= GetSystemMetrics(0)
height=GetSystemMetrics(1)
#click on the botton left to launch the start menu
pyautogui.click(0,height)


print("Select the SalesMate + Application")
pyautogui.typewrite("SalesMate+",0.1)
print("Press Enter Key to Launch SalesMate + Application and Wait for 10 Sec")
pyautogui.press("enter",1,10)
#Sometimes SalesMate + might take 10 seconds to load it . So 10 sec delay
print("Press Enter Key again to close the Tip Of the Day Dialog")
pyautogui.press("enter")
print("Now alt and f shortcut key in  Salesmate to invoke the File Root menu")
pyautogui.press(['alt','f'])
print("Now press 'b' to invoke the Backup Folder Dialog")
pyautogui.press("b")
print("Go to D Drive")
pyautogui.press("n",1,1)
print("Now press Right arrow Key to Expand the Tree")
pyautogui.press("right",1,1)
print("Go to KGB Folder")
pyautogui.typewrite("KGB")
print("Press Enter Key to Backup Data")
pyautogui.press("enter",1,2)
print("Press Enter Again to Close the OK Button")
pyautogui.press("enter")
