   M S B A M L   `   `   `  ????A  =client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:clientclient  5   	       client.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:client     5   	     ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)   .??5	      ? .+?5
   
   ?? -   5         ??Name$ btnLoadUsers??5
      $??
Load users??6(   $
??Left=?6=   $??
505,22,0,0q?6X   $	??Top=?6l   6?   ?? 5   
   $??Username??6   $
??Left=?6#   $??	32,24,0,0q?6>   $	??Top=?6Q   $??25??6i   ?? 5   
   $??Email??6   $
??Left=?6    $??	57,49,0,0q?6;   $	??Top=?6N   ?? 5   
   $??Fullname??6   $
??Left=?6#   $??	37,75,0,0q?6>   $	??Top=?6Q   ?? 5   
   $
??Role??6   $
??Left=?6   $??
62,101,0,0q?6:   $	??Top=?6N   ?? 5   
   -   5         ??Name$ txtUsername??5      $
??Left=?6'   $??
100,28,0,0q?6B    ?? TextWrapping$
 Wrap=?6V   $?? ??6j   $	??Top=?6r   $	??200??6?   ?? 5   
   -   5        $ txtFullname??5      $
??Left=?6'   $??
100,79,0,0q?6B   $
 Wrap=?6V   $?? ??6j   $	??Top=?6r   $	??200??6?   ?? 5   
   -   5        $ txtRole??5      $
??Left=?6#   $??100,105,0,0q?6>   $
 Wrap=?6S   $?? ??6g   $	??Top=?6o   $	??200??6?   ?? 5   
   -   5        $ txtEmail??5      $
??Left=?6$   $??
100,53,0,0q?6?   $
 Wrap=?6S   $?? ??6g   $	??Top=?6o   $	??200??6?   ?? 5   
   -   5        $ btnSaveUser??5      $??	Save user??6&   $
??Left=?6:   $??133,141,0,0q?6U   $	??Top=?6j    J? RenderTransformOrigin$ 0.227,-0.99&?6?   6?   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgUser??5      $??322,79,30,138q?6#      AutoGenerateColumns$ False??5      ??5      ??    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Username??6%   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 67   ?? 
 ?? Path$
 Username?  5      $ Email??6%   	 64   ?? $
 Email?  5      $ Fullname??6%   	 67   ?? $
 Fullname?  5      $
 Role??6%   	 63   ?? $

 Role?4  .System.Windows.Controls.DataGridTemplateColumn  5      $
 Edit??6)      CellTemplate 5      ?? 5      .R?5      ?? -   5        .??5   ?   Edit5!      5"      5$        5%      $ Delete??6)    5&      ?? 5'      .R?5(      ?? -	   5        .??5(   A   Delete5*      5+      5-      5/      51      52      