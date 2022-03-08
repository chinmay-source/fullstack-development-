import pyautogui
import time
pyautogui.FAILSAFE = False
from win32api import GetSystemMetrics
import os
print("SalesMate + Backup Manu Test")



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
pyautogui.sleep(2)  #wait for two seconds
print("Now press Esc for full screen mode  ")
pyautogui.press("Esc")
print("open for printing bar code ")
pyautogui.hotkey('Ctrl','b')
pyautogui.sleep(2)

pyautogui.leftClick(x=1286, y=364)
pyautogui.typewrite("skin care")

pyautogui.sleep(2)

pyautogui.leftClick(x=1316, y=406)
pyautogui.typewrite("Biotique")

pyautogui.sleep(2)

pyautogui.leftClick(x=1303, y=461)
pyautogui.typewrite("200")
pyautogui.leftClick(x=1384, y=810)

pyautogui.sleep(2)

pyautogui.typewrite("Biotique product")
pyautogui.sleep(2)

pyautogui.press('enter')
pyautogui.sleep(2)
pyautogui.leftClick(x=1484, y=900)
pyautogui.sleep(2)
pyautogui.leftClick(x=18, y=34)
pyautogui.sleep(2)
pyautogui.leftClick(x=152, y=472)











