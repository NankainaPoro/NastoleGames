   M S B A M L   `   `   `  ����G  CNastoleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:NastoleGames.ViewNastoleGames.View  5   	   "    NastoleGames.View.WinCatalog   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:NastoleGames.View     5   	     � Title$  
WinCatalog��5   	   $	��450��6   $	��800��6)   .��5	      � $
��auto��6   $
��auto��6    � RowDefinitions 5
   
   �� 5      $
��1.1* �6    �� 5      $��5* �6    �� 5      $
��0.8* �6    .+�5   
   �� -   5         ��Name$ 
ButCatalog��5      $/��)Возврат в главное меню��6%   $��0��6_   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	lvCatalog��5      $��1��6&      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$  ��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 3* 6/   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   ��  �� Path$
 Name�5      5      5      