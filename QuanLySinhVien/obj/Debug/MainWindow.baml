   M S B A M L   `   `   `  ����I  EQuanLySinhVien, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:QuanLySinhVienQuanLySinhVien  5   	       QuanLySinhVien.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:QuanLySinhVien     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��1* �6   6*   �� 5      $��6* �6   6*   �� 5      $��1* �6   6*   .+�5   
   �� $��Center=�6   $��0��61   $��30(�6>   
����  �$��0,10,0,0q�6^   �� 6r   .�6w   Quản Lý Danh Mục6�   6�   � 5   
   $��1��6    5      �� 5      $��1* �6    6.   �� 5      $��9* �6    6.   .+�5      � $��0��6   $��Right=�6     � ColumnDefinitions 5      �� 5      $��2* �6'   64   �� 5      $��2* �6'   64   �� 5      $��2* �6'   64   .+�5      �� $��
-794,0,0,0q�6   $��12(�60   
Tim Kiem6H   �� 5      -   5         ��Name$ timten��5      $��-700,0,514,0q�6,   �� 5      $��-482,0,392,0q�6   $	��15 (�63   
gioitinh6M   �� 5      -   5         ��Name$ Goitinh��5      $��-400,0,300,0q�6,   .@�5      �� $	��nam��6#   �� 5       $��nu��6#   5!      �� 5#      -   5        $��-252,0,156,0q�5#   /   .��6E   
Tim Kiem6O   5$      � 5%      $��1��6   .+�5&      &   System.Windows.Controls.DataGrid  -   5        $��
datagridSV��5&      $��Center=�6-   $	��243��6J   $��Center=�6W      
IsReadOnly .    AutoGenerateColumns .     SelectionMode$ Single=�6�   $	��800��6�      Columns 5'      0  *System.Windows.Controls.DataGridTextColumn  5(      -   5        colMaSv��,  &System.Windows.Controls.DataGridColumn	   Header$	 Ma sinh vien��5(   W   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 120 6m   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   �� *MaSV+6{     5)      -   5        colTenSv��$	 Ten Sinh Vien��5)   Y   $	
 120 6p    6?   �� *TenSV+6~     5*      -   5        
colLop��$		 Lop��5*   U   $	
 120 6b    6=   �� *Lop+6p     5+      -   5        colGioiTinh��$	 	Gioi Tinh��5+   _   $	
 120 6r    6B   �� *
GioiTinh+6�     5,      -	   5        colDiem��$	 Diem Ren Luyen��5,   _   $	
 120 6w    6>   �� *DiemRenLuyen+6�   5.      5/      51      �� 52   
   $��2��6    �� Orientation$ 
Horizontal=�6"   .+�53      � .+�54      �� -
   5        $��70,0,-149,21q�54      $��80��60   $��30��6;   .��6V   Them6\   �� 55      -   5        $��237,0,-320,21q�55      $��80��60   $��30��6;   .��6Y   Sua6^   �� 56      -   5        $��453,2,-520,22q�56      $��80��60   $��30��6;   .��6]   Xoa6b   �� 57      $��647,2,-709,22q�6   $��80��60   $��30��6;   .��6H   Thoat6O   58      59      5:      5;      