# Project Description
Extends OpenFileDialog and SaveFileDialog Using Windows Forms or WPF.

**This project contains the source code for the articles published on codeproject**

If you used WinForms or WPF, chances are that at some point you wanted to extend the
OpenFileDialog or SaveFileDialog, but you gave up because there is no easy way to do 
it, especially if you wanted to add some new graphical elements. 
The source code provided makes customization of these dialogs very easy, and shows 
how to call it for a quick ramp up.

I’ve included the equivalent VB.NET code in the downloadable zip file for the VB folks.

# How to use it

## For Windows Forms
![Screenshot of Windows Forms sample program](http://www.codeproject.com/KB/dialog/CustomizeFileDialog/saveas.jpg)

To start using it, you can drop the code in your project or just add a reference to the FileDlgExtenders.dll assembly or to FileDlgExtenders project. If you choose the latter, build the solution before you move forward, because you need the base class at design
 time. To make things as easy as possible, select &#39;Add User Control&#39; to your project, than pick &#39;Inherited User Control&#39; and finally select FileDialogControlBase from the list.

## For WPF
![Screenshot of Windows Forms sample program](http://www.codeproject.com/KB/dialog/WPFCustomFileDialog/SelectFile.PNG)

[Implement IWindowExt](http://www.codeproject.com/Articles/42008/Extend-OpenFileDialog-and-SaveFileDialog-Using-WPF#heading0005) or
[Inherit from the WindowAddOnBase or the ControlAddOnBase Class](http://www.codeproject.com/Articles/42008/Extend-OpenFileDialog-and-SaveFileDialog-Using-WPF#heading0007)

# More about it
A lot of additional information can be found on codeproject for 
[WPF](http://www.codeproject.com/Articles/42008/Extend-OpenFileDialog-and-SaveFileDialog-Using-WPF)
and [Windows Forms](http://www.codeproject.com/Articles/19566/Extend-OpenFileDialog-and-SaveFileDialog-the-easy)
