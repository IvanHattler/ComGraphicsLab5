   M S B A M L   `   `   `  ����c  _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity  5   	   ? ;Lab5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Lab5Lab5 5   	   1clr-namespace:Lab5.ViewModelsLab5.ViewModels 5   	      Lab5.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5   	   $localclr-namespace:Lab5     5   	   0local1clr-namespace:Lab5.ViewModels     5   	      grayWindowStyle#���   66     � Icon$  	Icon1.ico��5	       � WindowStartupLocation$ CenterScreen=�6+    � Title$ 
MainWindow��5
   	   $	��725��6   $
��1000��6)    � DataContext 5      # Lab5.ViewModels.MainViewModel  5   
   6!   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6-   �� 5      6   .+�5   
   o� $��0��6   .@�5      m� $
��Draw��6    m� Command 6%   �� *Draw+6@   m� 5      $��Palette��6    6(   �� *ColorCommand+6K   m� 5      $��Clear��6    6&   �� *Clear+6B   m� 5      $��Apply affine transform��6    67   �� *ApplyAffine+6Y   5      �� 5   
    �� Orientation$ 
Horizontal=�6   $��1��6.   .+�5      �� 
���   �$��1q�6)   ._�5      �� .��6   Camera parametres:6,   5      �� 5      .��6   Alfa:6   �� 5      $��0��6   6"   �� 5       $	��100��6    � Maximum$	 180Q�6!   $��3,3,0,3q�6K    �� TickPlacement$ TopLeft=�6\   	 � Value	 6/   �� 
 �� Path$

 Alfa�.   (System.Windows.Interactivity.Interaction   Triggers 5!      /   )System.Windows.Interactivity.EventTrigger  5"         	EventName$ PreviewMouseUp��6%   .   (System.Windows.Interactivity.TriggerBase   Actions. 5#      6   0System.Windows.Interactivity.InvokeCommandAction     Command 5$      �� $

 Draw�5&      5(      �� 5)      $	��180��6   6$   �� 5*      $��Beta:��6   6&   �� 5+      $��0��6   6"   �� 5,      $	��100��6   $	 180Q�6!   $��3,3,0,3q�6K   $ TopLeft=�6\   	 6/   �� $

 Beta� 5-        5.      $ PreviewMouseUp��6%   . 5/         50      �� $

 Draw�52      54      �� 55      $	��180��6   6$   �� 56       �� SelectedIndex 6   �� *SelectedIndex+��6?   �� *	ViewTypes+57      58      �� 59   
   $��2��6   $	��Top=�6!   $��0,-2,0,0q�69   
���   �6`   �� 5:   
   $��2��6   ��6   �� $
 Wb�  Lab5.ToggleMenu  5<   
   $��2��6M   $	��165��5>   5   $	��Top=�6B   $
��Left=�6Z   $	��165��6u      R 5<      �� *R+   
Resolution 6+   �� *
Resolution+   AlfaOt 5=      �� *AlfaOt+   AlfaDo 65   �� *AlfaDo+   BetaOt 6O   �� *BetaOt+   BetaDo 5>      �� *BetaDo+6u     Lab5.ToggleMenu1  5?   
   $��2��6   $	��189��6)   $	��Top=�66   $
��Left=�6N   $	��165��6i   $��	0,165,0,0q�6u      K 5@      �� *K+	   Dx 6,   �� *Dx+	   Dy 6>   �� *Dy+	   Dz 6P   �� *Dz+   AffineAngleX 5A      �� *AffineAngleX+   AffineAngleY 6B   �� *AffineAngleY+   AffineAngleZ 5B      �� *AffineAngleZ+6D   5C      5D      