   M S B A M L   `   `   `  ���� c  _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity  ? ;Lab5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Lab5Lab5 1clr-namespace:Lab5.ViewModelsLab5.ViewModels    Lab5.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     $localclr-namespace:Lab5     0local1clr-namespace:Lab5.ViewModels        grayWindowStyle#���     � Icon$  	Icon1.ico�� � WindowStartupLocation$ CenterScreen=� � Title$ 
MainWindow��$	��525��$	��700�� � DataContext # Lab5.ViewModels.MainViewModel  .���  � RowDefinitions �� $
��auto ��� $
��auto ��� .+�o� $��0��.@�m� $
��Draw�� m� Command �� *Draw+m� $��Palette�� �� *ColorCommand+m� $��Clear�� �� *Clear+��  �� Orientation$ 
Horizontal=�$��1��.+��� 
���   �$��1q�._��� .��Camera parametres:�� .��Alfa:�� $��0���� $	��100�� � Maximum$	 360Q�$��3,3,0,3q� �� TickPlacement$ BottomRight=�	 � Value	 �� 
 �� Path$

 Alfa�.   (System.Windows.Interactivity.Interaction   Triggers /   )System.Windows.Interactivity.EventTrigger     	EventName$ PreviewMouseUp��.   (System.Windows.Interactivity.TriggerBase   Actions. 6   0System.Windows.Interactivity.InvokeCommandAction     Command �� $

 Draw��� $	��360���� $��Beta:���� $��0���� $	��100��$	 360Q�$��3,3,0,3q�$ BottomRight=�	 �� $

 Beta�   $ PreviewMouseUp��.    �� $

 Draw��� $	��360���� $��2��$	��Top=�$��0,-2,0,0q�
���   ��� $��2������ $
 Wb�  Lab5.ToggleMenu  $��2��$��0,0,533,284q�   R �� *R+   
Resolution �� *
Resolution+   AlfaOt �� *AlfaOt+   AlfaDo �� *AlfaDo+   BetaOt �� *BetaOt+   BetaDo �� *BetaDo+