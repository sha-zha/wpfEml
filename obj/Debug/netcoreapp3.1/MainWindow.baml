   M S B A M L   `   `   `  ����C  ?wpfEmail, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:wpfEmailwpfEmail  5   	       wpfEmail.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:wpfEmail     5   	     � Title$  
MainWindow��5   	   $	��700��6   $	��800��6)   .��5	      � $��20q�6    � RowDefinitions 5
   
   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ source��5      $��	1,32,10,0q�6#   $	��Top=�66   $��
Nirmala UI)�6�   $��18(�6�   $��Normal$�6�   ���	#FFF7F7F7���	#FF424242��5      �� 5       �� EndPoint$	 0,1&�6&   .��5      �  � Color$ 	#FFF0F0F0��6#   � 5      $ 	#FFF7F7F7��6#    � Offset$ 1Q�65   5      5      �� 5   
   -   5         ��Name$
 from��5       �� TextWrapping$
 Wrap=�6    $��
-5,189,5,0q�64   $	��Top=�6H    �� 
IsReadOnly$
 True��6`   $��30��6r   ���	#FFF7F7F7���	#FFF7F7F7$	��A :��6�   ���	#FFC8C8C8$��
Nirmala UI)�6�   $��18(�6�   �� 5   
   -   5        $ to��5      $
 Wrap=�6   $��
-5,129,5,0q�62   $	��Top=�6F   $
 True��6^   $��30��6p   ���	#FFF7F7F7���	#FFF7F7F7$
��De :��6�   ���	#FFC8C8C8$��
Nirmala UI)�6�   $��18(�6�   �� 5   
   -   5        $ subject��5      $
 Wrap=�6#   $��	0,244,0,0q�67   $	��Top=�6J   $
 True��6b   $��30��6t   ���	#FFF7F7F7���	#FFF7F7F7$��Sujet :��6�   ���	#FFC8C8C8$��
Nirmala UI)�6�   $��18(�6�   �� 5   
   -   5        $
 date��5      $��Center=�6    $��0,89,0,0q�6=   $��Envoie inconnue��6O   $
 Wrap=�6f   $	��Top=�6z   $	��750��6�   $��25��6�   �� 5   
   -   5        $ textBody��5      $
 Wrap=�6$   $��	0,334,0,0q�68   $	��Top=�6K   $
 True��6c   $	��200��6u   $
��auto��6�   ���	#FFF7F7F7���	#FFC8C8C8���	#FFF7F7F7$��	Message :��6�   $��
Nirmala UI)�6�   $��18(�6  �� 5   
   -   5        $ files��5      $
 Wrap=�6!   $��	0,554,0,0q�65   $��Disabled=�6H   $
��Auto=�5   
   $	��Top=�6:   $
 True��6R   $	��150��6g   $
��auto��6w   ���	#FFF7F7F7���	#FFF7F7F7���	#FFC8C8C8$��Pièce(s) jointe(s) :��6�   $��
Nirmala UI)�6�   $��18(�6   5      5      