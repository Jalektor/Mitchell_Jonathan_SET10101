   M S B A M L   `   `   `  ����P  LKwikMedical.Emergency, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:KwikMedical.EmergencyKwikMedical.Emergency  5   	   &     KwikMedical.Emergency.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:KwikMedical.Emergency     5   	   
����� �  � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)   .��5
      � .+�5   
   �� $(��"Kwik Medical Emergency Call System��6   $
��Left=�6=   $��
225,10,0,0q�6X   $	��Top=�6l   $	��350��6�   $��20(�6�   �� 5   
   $��Patient Name:��6   $
��Left=�6(   $��	10,80,0,0q�6C   $	��Top=�6V   
�������6n   �� 5   
   -   5         ��Name$ 	tBoxPName��5      $
��Left=�6%   $��25��6@   $��
120,81,0,0q�6L   $��
Enter Name��6`   $	��Top=�6r   $	��200��6�   �� 5   
   $��Date of Birth:��6   $
��Left=�6)   $��
400,80,0,0q�6D   $	��Top=�6X   
�������$��84��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$
 pDOB��5      $
��Left=�6#   $��
520,80,0,0q�6>   $	��Top=�6R   $	��200��6j   �� 5   
   $��NHS Registration Number:��6   $
��Left=�63   $��
10,140,0,0q�6N   $	��Top=�6b   
�������6z   �� 5   
   -   5        $ 
tBoxNHSNos��5      $
��Left=�6&   $��25��6A   $��200,140,0,0q�6M   $��Enter number��6b   $	��Top=�6v   $	��140��6�   �� 5   
   $��Address��6   $
��Left=�6"   $��
10,195,0,0q�6=   $	��Top=�6Q   
�������6i   �� 5   
   -   5        $ 	tBosPAddr��5      $
��Left=�6%   $��25��6@   $��120,195,0,0q�6L   $��Address Here��6a   $	��Top=�6u   $	��275��6�   �� 5   
   $��Medical Condition:��6   $
��Left=�6-   $��
10,285,0,0q�6H   $	��Top=�6\   
�������6t   �� 5   
   -   5        $ tBoxMedCond��5      $
��Left=�6'   $��75��6B   $��150,285,0,0q�6N    �� TextWrapping$
 Wrap=�6c   $!��Insert Medical Condition(s)��6w   $	��Top=�6�   $	��630��6�   �� 5   
   -   5        $��Send Information��5      $
��Left=�6,   $��325,375,0,0q�6G   $	��Top=�6\   $	��150��6t   $��18(�6�   6�   5      5      