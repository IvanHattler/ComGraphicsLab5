   M S B A M L   `   `   `  ���� ?  ;Lab5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Lab5Lab5      Lab5.ToggleMenu   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     $localclr-namespace:Lab5       � 	Resources     expandAreaStyle �� 
TargetType �� Property �� Value �� Triggers �� Binding �� ElementName �� Value N� EnterActions	 �� TargetProperty	
 t� To g� Duration N� ExitActions��%�   &	        �� " ��.���  � ��$ 	0 0 150 0q� ��  �� *	IsChecked+$ expandButton�� True �� .���� $	 Margin�.��t� $
 0 0 0 0X�$ 0:0:0.2D� �� .���� $	 Margin�.��t� $
 	0 0 150 0X�$ 0:0:0.2D�.��� $��2��$	��Top=�$
��Left=�.+��� -    ��Name$ 
expandArea��#���   
�������._�� .+�d� -    d�Name$ expandButton��
�������$��15��$��Right=�� $��Right=�$	��133�� � RowDefinitions �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto �.+��� $��25��$��0,1,26,0q�.��
Parametres�� $��1��
�������$��3q�$
��Left=�._���  �� Orientation$ 
Horizontal=�.+��� $��26��$��27������  �� Path$ AlfaOt��� $��25��$��50��.��<Alfa<�� $��26��$��27������ $ AlfaDo��� $��2��
�������$��3q�$
��Left=�._��� $ 
Horizontal=�.+��� $��26��$��27������ $ BetaOt��� $��50��$��2��$��25��$��<Beta<���� $��26��$��27������ $ BetaDo��� $��3��
�������$��3q�$
��Left=�._��� $ 
Horizontal=�.+��� $��25��$��R:���� $��25��$��84��$��Center=�$	��0,2q����� *R+�� $��4��
�������$��3q�$
��Left=�._��� $ 
Horizontal=�.+��� $��25��$��Resolution:���� $��26��$��33��$��Center=�$	��0,2q����� *
Resolution+