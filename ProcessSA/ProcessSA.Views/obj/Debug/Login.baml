   M S B A M L   `   `   `  ����J  FProcessSA.Views, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ProcessSA.ViewsProcessSA.Views  5          ProcessSA.Views.Login   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:ProcessSA.Views     5      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=null;Controls,http://metro.mahapps.com/winfx/xaml/controls  5
        N� Title$  	ventLogin��5      $
��auto��6   $	��600��6&      MaterialDesignBody#���   5      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5      .��5      � $
��auto��6   $
��auto��6   $��Stretch=�6&   $��Stretch=�6B    � RowDefinitions 5   
   �� 5      $
��140* �6   �� 5      $	��40* �6   �� 5      $	��40* �6   �� 5      $	��40* �6   �� 5      $	��40* �6    � ColumnDefinitions 5   
   �� 5      $
��300* �6   �� 5      $
��500* �6   �� 5      $
��300* �6   .+�5!   
   � $��0��6   $��1��6   .+�5"      �� $��Recursos\vertical.png��6    J� RenderTransformOrigin$ 0.5,0.5&�63   5#      � 5$   
   $��	80,0,80,0q�6   $��1��6"   $��1��60   .+�5%      �� -   5         ��Name$ UsuarioLogin��5%      )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 Nombre de Usuario��6,    % !MaterialDesignFloatingHintTextBox#��[ 6_   $��18,10,13,13q�6�   $��15(�6�   5&      � 5'   
   $��	80,0,80,0q�6   $��2��6"   $��1��6/   .+�5)      G� -   5        
 G�Name$
 ContraseñaLogin��5)      $	 Contraseña��63    ) %MaterialDesignFloatingHintPasswordBox#��[ 6_   $��18,10,13,13q�6�   $��15(�6�   5*      � 5+   
   $��	80,0,80,5q�6   $��3��6"   $��1��6/   .+�5,      �� -   5         ��Name$ IniciarSesion��5,        MaterialDesignRaisedButton#��[ 6,    � ToolTip$ Iniciar Sesión��6`   $��18,10,13,13q�6y   $��50��6�   .��5-      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]   Kind$
 User=�6*   $��35��66   $��35��6B   5.      5/      53      54      