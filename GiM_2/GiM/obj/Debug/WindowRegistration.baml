   M S B A M L   `   `   `  ����  GiM    GiM.WindowRegistration   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$  WindowRegistration��5   	   $	��640��6$   $	��480��61    � 
ResizeMode$ NoResize=�6=    � WindowStyle$
 None=�6|   .��5      � ���	#FFEAEAEA � RowDefinitions 5   
   �� 5      $	��41* �6   �� 5      $	��78* �6   �� 5	      $	��42* �6   �� 5
      $	��63* �6   �� 5      $	��55* �6   �� 5      $	��53* �6   �� 5      $	��55* �6   �� 5      $	��52* �6   �� 5      $
��111* �6   �� 5      $	��90* �6    � ColumnDefinitions 5   
   �� 5      $	��18* �6   �� 5      $	��62* �6   �� 5      $	��62* �6   �� 5      $
��193* �6   �� 5      $
��116* �6   �� 5      $	��29* �6   .+�5   
   �� $��Center=�6   $
��Wrap=�61   $��Registration��6E   $	��Top=�6Y   
���   �$��36(�6�   $��Microsoft JhengHei Light)�6�   $��2��6�   $��58��6�   $	��220��6�   $��
15,10,20,0q�6�   $��1��6�   $��2��6  �� 5   
   $
��Left=�6   $
��Wrap=�6/   $��
First name��6C   $	��Top=�6U   $��Microsoft JhengHei Light)�6m   $��14(�6�   $��43��6�   $	��122��6�   $��2��6�   $��2,0,0,0q�6�   $��1��6�   $��2��6�   $��2��6�   �� 5   
   $
��Left=�6   $
��Wrap=�60   $��	Last name��6D   $	��Top=�6U   $��Microsoft JhengHei Light)�6m   $��14(�6�   $��32��6�   $	��122��6�   $��3��6�   $��	10,10,0,0q�6�   $��3��6�   �� 5   
   $
��Left=�6   $
��Wrap=�60   $��	User name��6D   $	��Top=�6U   $��Microsoft JhengHei Light)�6m   $��14(�6�   $��32��6�   $	��122��6�   $��4��6�   $��5,0,0,0q�6�   $��3��6�   �� 5   
   $
��Left=�6   $
��Wrap=�60   $��Email��6D   $	��Top=�6Q   $��Microsoft JhengHei Light)�6i   $��14(�6�   $��32��6�   $	��122��6�   $��5��6�   $��	10,10,0,0q�6�   $��3��6�   �� 5    
   $
��Left=�6   $
��Wrap=�61   $��Password��6E   $	��Top=�6U   $��Microsoft JhengHei Light)�6m   $��14(�6�   $��32��6�   $	��122��6�   $��6��6�   $��5,0,0,0q�6�   $��3��6�   �� 5!   
   $
��Left=�6   $
��Wrap=�61   $��Repeat ��6E   $	��Top=�6T   $��Microsoft JhengHei Light)�6l   $��14(�6�   $��32��6�   $	��122��6�   $��7��6�   $��5,1,0,0q�6�   $��3��6�   �� 5"   
   -   5         ��Name$ tb_first_name��5"      $
��Left=�6+   $��17��6F    �� TextWrapping$
 Wrap=�6R   $	��Top=�6f   $	��205��6~   ���	#FFB4B4B4$��Microsoft JhengHei Light)�6�   $��3��6�   $��2��6�   $��2��6�   $��0,10,0,0q�6�   �� 5#   
   -   5        $ tb_last_name��5#      $
��Left=�6*   $��17��6E   $
 Wrap=�6Q   $	��Top=�6e   $	��205��6}   ���	#FFB4B4B4$��3��6�   $��3��6�   $��2��6�   �� 5$   
   -   5        $ tb_user_name��5$      $
��Left=�6*   $��17��6E   $
 Wrap=�6Q   $	��Top=�6e   $	��205��6}   ���	#FFB4B4B4$��3��6�   $��4��6�   $��2��6�   �� 5%   
   -   5        $ tb_email��5%      $
��Left=�6&   $��17��6A   $
 Wrap=�6M   $	��Top=�6a   $	��205��6y   ���	#FFB4B4B4$��3��6�   $��5��6�   $��2��6�   �� 5&   
   -   5         ��Name$ btn_Perform_Reg��5&      $��Registrate!��6*   $
��Left=�6@   $��	125,1,0,0q�6[   $	��Top=�6n   $��80��6�   ���	#FF535353
�������$��Microsoft JhengHei Light)�6�   $��3��6�   $��20��6  $��9��6  $��2��6(  G� 5'   
   -   5         G�Name$ pb_password��5'      $
��Left=�6,   $��17��6G   $	��Top=�6S   $	��205��6k   ���	#FFB4B4B4$��3��6�   $��6��6�   $��2��6�   G� 5(   
   -   5        $ pb_repassword��5(      $
��Left=�6.   $��17��6I   $	��Top=�6U   $	��205��6m   ���	#FFB4B4B4$��3��6�   $��7��6�   $��2��6�   �� 5)   
   -	   5        $ 	btn_close��5)      $��X��6$   $
��Left=�60   $	��Top=�6K   $��19��6c   $��0q�6n   $��Microsoft YaHei Light)�6�   $��20��6�   $��16(�6�   $��Center=�6�   $��Center=�6  	 �� IsCancel	 . $��9��6D  $��5,1,0,0q�6Q  $��2��6b  ��6�   Z� 6b  5*      5+      