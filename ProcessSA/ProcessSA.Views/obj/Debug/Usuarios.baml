   M S B A M L   `   `   `  ����J  FProcessSA.Views, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ProcessSA.ViewsProcessSA.Views  5          ProcessSA.Views.Usuarios   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:ProcessSA.Views     5      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=null;Controls,http://metro.mahapps.com/winfx/xaml/controls  5
        N� Title$  VentUsuarios��5      $
��auto��6   $	��600��6)      MaterialDesignBody#���   5      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5      .��5      � $
��auto��6   $
��auto��6   $��Stretch=�6&   $��Stretch=�6B    � RowDefinitions 5   
   �� 5      $��0* �6   �� 5      .+�5   
   � $��0,0,0,0q�6   $��1��6    $��Stretch=�6-   $��Stretch=�6I    � ColumnDefinitions 5      �� 5      $
��158* �6#   �� 5      $
��138* �6#   �� 5      $
��237* �6#   �� 5      $
��138* �6#   �� 5      $
��129* �6#    5!      �� 5"      $	��38* �6    �� 5#      $
��240* �6    �� 5$      $	��67* �6    �� 5%      $
��104* �6    .+�5'      � $��23,12,18,26q�6   $��2��6(   $��2��65   $��3��6F    5(      �� 5)      $
��140* �6'   �� 5*      $
��183* �6'   �� 5+      $
��169* �6'    5-      �� 5.      $	��73* �6$   �� 5/      $	��69* �6$   �� 50      $	��67* �6$   .+�52      �� -   5         ��Name$ txtRut��52      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$	 Rut��6*    % !MaterialDesignFloatingHintTextBox#��[ 6P   $��18,16,13,13q�6�   $��15(�6�   6�   �� 53      -   5        $ 	txtNombre��53      $ Nombre��6-   #��[ 6U   $��18,16,13,13q�6�   $��1��6�   $��15(�6�   �� 54      -   5        $ txtApellido��54      $ Apellido��6/   #��[ 6Y   $��18,16,13,13q�6�   $��2��6�   $��15(�6�   �� 55      -   5        $ txtNombreUsuario��55      $ Nombre usuario��64   #��[ 6d   $��18,10,13,13q�6�   $��15(�6�   $��1��6�   �� 56      -   5        $ txtContraseña��56      $ Contraseña��61   #��[ 6]   $��18,10,13,13q�6�   $��1��6�   $��1��6�   $��15(�6�   �� 57      -   5        	 ��Name$	 cboRol��57      $	 Rol��6+   $��72��6P   $��18,16,13,13q�6^    & "MaterialDesignFloatingHintComboBox#��[ 6s   $��48��6�   $��Bottom=�6�   $��1��6�   $��2��6�   $��15(�6�   �� 58      -   5        $ txtEmail��58      $ Email��6,   #��[ 6T   $��18,10,13,13q�6�   $��2��6�   $��15(�6�   �� 59      -   5        $ txtTelefono��59      $ 	Teléfono��6/   #��[ 6Y   $��18,10,13,13q�6�   $��2��6�   $��1��6�   $��15(�6�   6�   5:      &   System.Windows.Controls.DataGrid  5<      -	   5        
  Name$
 
gdUsuarios��5=         CanUserSortColumns .     CanUserAddRows .  $��13,33,17,27q�5<   q   $	��400��6�      AutoGenerateColumns .     CanUserResizeColumns .     
IsReadOnly . $��3��5=   p      CanUserReorderColumns .     HeadersVisibility$ Column=�6�   $��1��6�   ��5<      ��  �� Source$ usuarios��   Columns 5>      0  *System.Windows.Controls.DataGridTextColumn  5?      ,  &System.Windows.Controls.DataGridColumn   Header$   Rut  ��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   �� *
RutUsuario+  5@      $ 
  Nombre  ��6)    6=   �� *NombreUsuario+  5A      $   Apellido  ��6)    6?   �� *ApellidoUsuario+  5B      $   Nombre de Usuario  ��6)    6H   �� *NombreUsuario+  5C      $   Contraseña  ��6)    6A   �� *Contraseña+  5D      $   Rol  ��6)    6:   �� *Rol+  5E      $   Correo Electrónico  ��6)    6I   �� *MailContacto+  5F      $   Teléfono  ��6)    6?   �� *
Telefono+5H      �� 5J      -
   5         ��Name$ 
btnAgregar��5J        MaterialDesignRaisedButton#��[ 6)   $��3��6]   $��14,20,15,18q�6m    � ToolTip$ Nuevo Usuario��6�   $��2��6�   $
��Auto��6�   .��5K      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]   Kind$ 	PersonAdd=�6*   $��41��6<   $��41��6H   5L      �� 5M      -   5        $ btnActualizar��5M      #��[ 6,   $��
13,19,7,19q�6`   $ Actualizar Usuario��6t   $��2��6�   $
��Auto��6�   $��4��6�   .��5N        $
 Sync=�6*   $��43��67   $��39��6C   5O      �� 5P      -   5        $ 	btnBuscar��5P      #��[ 6(   $��15,45,14,43q�6\   $ Buscar Usuario��6q   $��3��6�   $
��Auto��6�   $��3��6�   .��5Q        $ Search=�6*   $��51��69   $��46��6E   5R      �� 5S      -   5        $ btnEliminar��5S      #��[ 6*   $��
13,46,7,42q�6^   $ Borrar Usuario��6r   $��3��6�   $
��Auto��6�   $��4��6�   .��5T        $ Delete=�6*   $��41��69   $��41��6E   
���   �6P   5U      �� 5V      -   5        $ txtFiltroNombre��5V      $��0��6/    �� TextWrapping$
 Wrap=�6?   $	��Top=�6S   $��15(�6k   $ Filtro Nombre��6y   $��27��6�   $��	27,8,11,0q�6�   �� 5W      -   5        $	 cboFiltroRol��5W   C   $ 
Filtro Rol��6   $��	10,8,11,0q�6Y   $	��Top=�6l   $��27��6�   $��1��6�   $��15(�6�   �� 5X      -   5        $ txtFiltroRut��5X      $��2��6,   $
��Left=�6<   $��27��6W   $��10,8,0,0q�6c   $
 Wrap=�6u   $	��Top=�6�   $	��164��6�   $ 
Filtro Rut��6�   $��15(�6�   �� 5Y      -   5        $ LimpiarFiltro��5Y      #��[ 6,   $��2��6`   $��	180,3,6,9q�6p   $ Limpiar Filtros��6�   $
��Auto��6�   .��5Z        $ Restore=�6*   $��29��6:   $��22��6F   $��Right=�6Q   5[      5\      5]      5^      