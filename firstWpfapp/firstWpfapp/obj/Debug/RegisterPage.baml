   M S B A M L   `   `   `  ����F  BfirstWpfapp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:firstWpfappfirstWpfapp  5   	       firstWpfapp.RegisterPage   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:firstWpfapp     5   	     � Title$  Register Page��5   	   $��748.202��6   $��676.857��60   $��699.857��6@   $��489.202��6S    � WindowStyle$ ThreeDBorderWindow=�6g   $y�Visible=�6�    � 
ResizeMode$ NoResize=�6�    � SizeToContent$ WidthAndHeight=�6�   .��5	      � $	��719��6   $	��Top=�6    � RowDefinitions 5
   
   �� 5      $
��484* �6   �� 5      $	��49* �6   ��5   
   �� 5      .��5      �  � Color$
 Pink��6    � Offset$ 0.258Q�6,   � 5      $ 	#FF2E004D��6   $ 0.508Q�61   � 5      $
 Pink��6   $ 0.705Q�6,   5      .+�5   
   � $
��Left=�6   $	��647��6*   $��	25,62,0,0q�67   $	��Top=�6J   $	��659��6b   $��2��6n   .+�5      �� $
��Left=�6   $	��115��6/   $��224,-48,0,0q�6<   $	��Top=�6Q   $	��229��6i   $��E:\appImages\logo.png��6u   �� 5      -   5         ��Name$ 
btnSupport��5      $
��Left=�6)   $��
24,522,0,0q�6D   $	��Top=�6X   $��36��6p   $��35��6�   ��6{   Z� ��6�   Z� ��6�   Z� 6�   �� 5      -   5         ��Name$ lblDisplayFirstName��5      $��
First Name��62   $��Center=�6G   $
��Left=�6k   $��	79,99,0,0q�6�   $	��Top=�6�   $��97��6�   $��36��6�   $��
Lato Light)�6�   $��16(�6�   $
��Bold"�6�   
�������6   �� 5      -   5        	 ��Name$	 txtDisplayFirstName��5      $
��Left=�64   $��36��6O   $��
83,135,0,0q�6[   
 �� TextWrapping$

 Wrap=�6o   $�� ��6�   $	��Top=�6�   $	��235��6�   $��Center=�6�   
�������$��1q�6�   $��
Lato Light)�6�   $��16(�6  
������ 
�������6:  �� 5      -   5        $ lblDisplayLastName��5      $��	Last Name��60   $��Center=�6D   $
��Left=�6h   $��
323,99,0,0q�6�   $	��Top=�6�   $	��121��6�   $��36��6�   $��
Lato Light)�6�   $��16(�6�   $
��Bold"�6�   
������� J� RenderTransformOrigin$ 0.223,0.333&�6  �� 5      -   5        $	 txtDisplayLastName��5   �   $��Center=�6   
�������$��1q�6N   $��
Lato Light)�6b   $��16(�6z   
������ 
�������$
��Left=�6�   $��36��6�   $��351,135,0,0q�6�   $

 Wrap=�6  $�� ��6   $	��Top=�6(  $	��235��6@  �� 5       -   5        $ lblCompanyName��5       $��Company Name��6,   $��Center=�6C   $
��Left=�6g   $��
79,188,0,0q�6�   $	��Top=�6�   $	��123��6�   $��36��6�   $��
Lato Light)�6�   $��16(�6�   $
��Bold"�6�   
�������6�   �� 5!      -   5        $	 txtCompanyName��5!   �   $��Center=�6   
�������$��1q�6N   $��
Lato Light)�6b   $��16(�6z   
������ 
�������$
��Left=�6�   $��36��6�   $��
83,229,0,0q�6�   $

 Wrap=�6  $�� ��6  $	��Top=�6#  $	��236��6;  �� 5#      -   5        $ lblPosition��5#      $��Position��6)   $��Center=�6<   $
��Left=�6`   $��324,193,0,0q�6{   $	��Top=�6�   $��97��6�   $��36��6�   $��
Lato Light)�6�   $��16(�6�   $
��Bold"�6�   
�������6�   �� 5$      -	   5        $	 txtPosition��5$   �   $��Center=�6   
�������$��1q�6N   $��
Lato Light)�6b   $��16(�6z   
������ 
�������$
��Left=�6�   $��36��6�   $��351,229,0,0q�6�   $

 Wrap=�6  $�� ��6  $	��Top=�6!  $	��236��69  �� 5&      -
   5        $ lblName��5&      $��Username��6%   $��Center=�68   $
��Left=�6\   $��157,318,0,0q�6w   $	��Top=�6�   $��89��6�   $��36��6�   $��
Lato Light)�6�   $��16(�6�   $
��Bold"�6�   
�������6�   �� 5'      -   5        $	 txtName��5'   �   $��Center=�6   
�������$��1q�6N   $��
Lato Light)�6b   $��16(�6z   
�������$
��Left=�6�   $��36��6�   $��259,311,0,0q�6�   $

 Wrap=�6�   $�� ��6�   $	��Top=�6  $	��236��6  
������ 6(  �� 5)      -   5        $ lblPassword��5)      $��Password��6+   $��Center=�6>   $
��Left=�6b   $��157,352,0,0q�6}   $	��Top=�6�   $��87��6�   $��35��6�   $ 0.701,0.429&�6�   $��
Lato Light)�6�   $��16(�6�   $
��Bold"�6  
�������6  G� 5*      -   5         G�Name$ txtPassword��5*   �   $��Center=�6   
�������$��1q�6R   $��
Lato Light)�6f   $��16(�6~   
������ 
�������$
��Left=�6�   $��35��6�   $��259,352,0,0q�6�   $	��Top=�6
  $	��236��6"  �� 5,      -   5        $ lblConfirmPass��5,      $��Confirm Password��6/   $��Center=�6J   $
��Left=�6n   $��102,392,0,0q�6�   $	��Top=�6�   $��33��6�   $	��144��6�   $��
Lato Light)�6�   $��16(�6�   $
��Bold"�6�   
�������6  G� 5-      -   5        $ txtConfirmPassword��5-   �   $��Center=�6   
�������$��1q�6R   $��
Lato Light)�6f   $��16(�6~   
������ 
�������$
��Left=�6�   $��36��6�   $��259,392,0,0q�6�   $	��Top=�6  $	��236��6)  �� 5/      -   5        $ btnReg��5/   =   
�������$��2q�6)   $��Register��6M   $
��Left=�6`   $��124,522,0,0q�6{   $	��Top=�6�   $	��211��6�   $��35��6�   $��
Lato Light)�6�   $��16(�6�   
������ 
�������6  �� 50      -   5        $ btnExit��50   =   
�������$��2q�6)   $
��Exit��6N   $
��Left=�6]   $��340,522,0,0q�6x   $	��Top=�6�   $	��207��6�   $��35��6�   $ 0,-0.4&�6�   $��
Lato Light)�6�   $��16(�6�   
������ 
�������6/  �� 51      -   5        $	 lbl��51      $�� ��6!   $
��Left=�6,   $	��Top=�6G   $��102,457,0,0q�6_   $��16(�6t   $��
Lato Light)�6�   $
��Bold"�6�   
�������
������ $ -0.214,1&�6�   $	��393��6�   $��Center=�6  53      55      56      