   M S B A M L   `   `   `  ����B  >WpfApp3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp3WpfApp3  5   	   H DClassLibrary1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullD2clr-namespace:ClassLibrary1;assembly=ClassLibrary1ClassLibrary1 5   	       WpfApp3.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp3     5   	   Eshared2clr-namespace:ClassLibrary1;assembly=ClassLibrary1     5   	   Gsdk9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	     � Title$  
MainWindow��5
   	   $	��450��6   $	��800��6)    � 	Resources 5        WpfApp3.Converter   ConvertIntToColor �� DataType   ClassLibrary1.EntryFieldVM �� 
TargetType �� Property �� Value  Key �� Triggers P� Property P� Value	 �� Path
 �� Self �� RelativeSource ��Name  ValidatingControl �� Mode" �� ValidatesOnNotifyDataErrors��%^  &	        (��      5      *, +)7  7  7    5   
   6   �� 5   
   "  6   .R�5      �� $��20,10q�6    5      ���� 5      '��       " ��6   .�5      ��  � ��$ 0,10,0,0q�63   5      �� 5      '��       " ��6   ValidatingControl  5      P� 5       �@=�HasError . . �5   "   ��  �@�ToolTip 6<   �� $)	 #(Validation.Errors)[0].ErrorContent�# Z
 5      5      5      .+�5      �� ��6   �� *
Username+68   �� 5      $
 text��6E   8��  ��6S   �� *Username_Entry+$ TwoWay=� . .��6�   5       �� 5!      ��6   �� *
Password+67   �� 5"      8�� ��6E   �� *Password_Entry+$ TwoWay=� . �� 5#      ��6   �� *Email+64   �� 5$      8�� ��6E   �� *Email_Entry+$ TwoWay=� . 5%      5&      5'      .��5)      �  � RowDefinitions 5*   
   �� 5+      6   �� 5,      6   �� 5-      6    � ColumnDefinitions 5/   
   �� 50      6!   �� 51      6!   .+�53   
   �� $��3��6   $��UniformToFill=�6!    J� Opacity$ .9Q�69   $��Center=�6F   $��Center=�6a   ��54      �� 55       �� 	UriSource$ /Images/coffee.jpg?�6   6?   57      �� 58   
   $��1��6   $��0��6    $��Center=�6-   
���E��$��Center=�6a   $��10q�6~   $��32(�6�   $��Yu Gothic UI Light)�6�    �� ContentStringFormat$ {0:C}��6�   .��6�   
Mocha Coda6�   �� 59   
   $��1��6   $��1��6%   $��2��62   .+�5:      ��  �� DisplayMemberPath$  ��63   ��6   �� 63   �� 5;      $��Center=�6   $��Center=�61   $
��0,50q�6L   $��@Ammon Riley��6Z   ��6q   �� *converterDemo+ �� 	Converter# [  5<      5=      5>      