   M S B A M L   `   `   `  ����F  BfirstWpfapp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:firstWpfappfirstWpfapp  5   	        firstWpfapp.ContactsBasket   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:firstWpfapp     5   	     � Title$  Contacts Basket��5   	   $��615.773��6!   $��673.857��62   ���	#FF2E004D$��699.857��6Y   $��489.202��6l    � WindowStyle$ ThreeDBorderWindow=�6�   $y�Visible=�6�    � 
ResizeMode$ NoResize=�6�    � SizeToContent$ WidthAndHeight=�6�   .��5
      � $��0,0,0,0q�6   .+�5   
   � -   5         �Name$
 grid��5      $
��Left=�6   $	��587��69   $	��Top=�6F   $	��693��6^   ��5      �� 5      .��5      �  � Color$
 Pink��6#    � Offset$ 0.258Q�60   � 5      $ 	#FF2E004D��6#   $ 0.508Q�65   � 5      $
 Pink��6#   $ 0.705Q�60   5      .+�5      � $
��Left=�6   $	��362��6.   $��232,154,0,0q�6;   $	��Top=�6P   $	��247��6h   ��5      
� 5      .��5      � $ Transparent��6'   $ 0.379Q�6;   � 5      $ Transparent��6'   $	 1.2Q�6;   5      .+�5      �� -   5         ��Name$ txtFirstName��5   D   
�������$	��2.5q�6.   $��Center=�6Z   $��30��6~   $��10,165,10,0q�6�    �� TextWrapping$
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $��
Lato Light)�6�   $��16(�6�   
������ 
�������6  �� 5      -   5        $ txtLastName��5   D   
�������$	��2.5q�6.   $��Center=�6Y   $
��Left=�6~   $��31��6�   $��
10,213,0,0q�6�   $
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��227��6�   $��
Lato Light)�6�   $��16(�6  
������ 
�������68  �� 5      -   5        $ 
txtCompany��5   D   
�������$	��2.5q�6.   $��Center=�6X   $��31��6|   $��10,261,10,0q�6�   $
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $��
Lato Light)�6�   $��16(�6�   
������ 
�������6  �� 5      -   5        $ txtPosition��5   D   
�������$	��2.5q�6.   $��Center=�6Y   $
��Left=�6}   $��30��6�   $��
10,310,0,0q�6�   $
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��227��6�   $��
Lato Light)�6�   $��16(�6  
������ 
�������67  5      �� 5      -   5        	 ��Name$	 	usersList��5      $
��Left=�6+   $��227,107,0,0q�6F   $	��Top=�6[   $	��252��6s   $��24��6   $��Visible=�6�   
 �� MaxDropDownHeight$	
 190��6�   �� 5       -   5         ��Name$ lblSelectUser��5       $��Browse Contacts��6+   $��Center=�6E   $
��Left=�6i   $��
227,61,0,0q�6�   $	��Top=�6�   $��
Lato Light)�6�   $��24(�6�   
�������$��41��6�   $	��247��6�   �� 5!      $*��$C:\Users\my\Desktop\profile icon.png��6   $
��Left=�6B   $	��166��6]   $��256,154,0,0q�6j   $	��Top=�6   $	��218��6�    J� RenderTransformOrigin$ -0.102,0.562&�6�   �� 5"      $��
Lato Light)�6   $��18(�6,   
�������$��30��6M   $	��144��6Y   $��Center=�6e   $��
First Name��6�   $
��Left=�6�   $��
83,320,0,0q�6�   $	��Top=�6�   �� 5#      $��
Lato Light)�6   $��18(�6,   
�������$��30��6M   $	��144��6Y   $��Center=�6e   $��	Last Name��6�   $
��Left=�6�   $��
83,370,0,0q�6�   $	��Top=�6�   �� 5$      $��
Lato Light)�6   $��18(�6,   
�������$��30��6M   $	��144��6Y   $��Center=�6e   $��Company Name��6�   $
��Left=�6�   $��
83,418,0,0q�6�   $	��Top=�6�   �� 5%      $��
Lato Light)�6   $��18(�6,   
�������$��30��6M   $	��144��6Y   $��Center=�6e   $��Position��6�   $
��Left=�6�   $��
83,466,0,0q�6�   $	��Top=�6�   5'      �� 5(   
   -   5         ��Name$ 	btnGoBack��5(      $
��Left=�6$   $	��Top=�6?   $��77��6W   $��300,530,0,0q�6b   
������ 
������ $��38��6�   .��5)      �� $��E:\appImages\btnBack.png��6   5*      5+      5,      