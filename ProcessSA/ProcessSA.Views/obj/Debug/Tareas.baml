   M S B A M L   `   `   `  ����J  FProcessSA.Views, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ProcessSA.ViewsProcessSA.Views  5          ProcessSA.Views.Tareas   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:ProcessSA.Views     5      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=null;Controls,http://metro.mahapps.com/winfx/xaml/controls  5
        N� Title$  
ventTareas��5      $
��auto��6   $	��600��6'      MaterialDesignBody#���   5      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
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
��129* �6#    5!      �� 5"      $��0* �6    �� 5#      $
��240* �6    �� 5$      $	��67* �6    �� 5%      $
��104* �6    .+�5'      � $��23,12,18,26q�6   $��2��6(   $��2��65   $��3��6F    5(      �� 5)      $
��140* �6'   �� 5*      $
��183* �6'   �� 5+      $
��169* �6'    5-      �� 5.      $	��69* �6$   �� 5/      $	��69* �6$   �� 50      $	��69* �6$   .+�52      �� -   5         ��Name$ txtNombreTarea��52      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Nombre Tarea��62    % !MaterialDesignFloatingHintTextBox#��[ 6`   $��18,10,13,13q�6�   $��15(�6�   $��0��6�   $��0��6�   �� 53      -   5        	 ��Name$	 cboRolTarea��53      $	 Rol��60   $��72��6U   $��18,10,13,13q�6c    & "MaterialDesignFloatingHintComboBox#��[ 6x   $��Bottom=�6�   $��0��6�   $��1��6�   $��15(�6�   �� 54      -   5        $	 cboResponsableTarea��54      $ Responsable��68   $��72��6e   #��[ 6s   $��18,10,13,13q�6�   $��Bottom=�6�   $��0��6�   $��2��6�   $��15(�6�   (  "System.Windows.Controls.DatePicker  55      -   5        
  Name$
 dpFechaInicio��55      $ Fecha Inicio��64    ( $MaterialDesignFloatingHintDatePicker#��[ 6b   $��0��6�   $��1��6�   $��Stretch=�6�   $��15(�6�   $��18,10,13,13q�6�   )  #MaterialDesignThemes.Wpf.TimePicker  56      -   5          Name$ 
HoraInicio��56   R   $��18,10,13,13q�6,      	Is24Hours . $ Hora Inicio��6f    ( $MaterialDesignFloatingHintTimePicker#��[ 6�   $��15(�6�   $��1��6�   $��1��6�   $��Stretch=�6�     57      -   5        $
 
dpFechaFin��57      $ Fecha Finalización��61   #��[ 6e   $��0��6�   $��2��6�   $��Stretch=�6�   $��15(�6�   $��18,10,13,13q�6�     58      -   5        $ HoraFin��58   R   $��18,10,13,13q�6,    . $ Hora Fin��6c   #��[ 6�   $��15(�6�   $��1��6�   $��2��6�   $��Stretch=�6�   �� 59      -   5        $ txtObservaciones��59      $ Observaciones��64    �� MaxLines$	 300��6c    �� 	MaxLength$	 250��6r    * &MaterialDesignOutlinedTextFieldTextBox#��[ 6�    �� AcceptsReturn .  �� TextWrapping$
 Wrap=�6�   " �� VerticalScrollBarVisibility$
 Auto=�6�   $��18,10,13,13q�6q  $��15(�6�  $��2��6�  $��2��6�  $��1��6�  {�6  �� *	IsChecked+ �� ElementName$; 5MaterialDesignOutlinedTextFieldTextBoxEnabledComboBox��6�  5:      &   System.Windows.Controls.DataGrid  5=      -	   5          Name$ gdTareas��5>         CanUserSortColumns .     CanUserAddRows .  $��13,33,17,27q�5=   o   $	��400��6�      AutoGenerateColumns .     CanUserResizeColumns .     
IsReadOnly . $��3��5>   n      CanUserReorderColumns .     HeadersVisibility$ Column=�6�   $��1��6�   ��5=      ��  �� Source$ tareas��   Columns 5?      0  *System.Windows.Controls.DataGridTextColumn  5@      ,  &System.Windows.Controls.DataGridColumn   Header$   Nombre Tarea  ��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6C   �� *NombreTarea+  5A      $   Encargado  ��6)    6@   �� *EncargadoTarea+  5B      $   Fecha Inicio  ��6)    6C   �� *FechaInicio+  5C      $   Hora Inicio  ��6)    6B   �� *
HRInicio+  5D      $   Fecha Fin  ��6)    6@   �� *
FechaFin+  5E      $   Hora Fin  ��6)    6?   �� *	HoraFin+  5F      $   Observaciones  ��6)    6D   �� *MailContacto+5H      �� 5K      -
   5         ��Name$ btnAgregarTarea��5K        MaterialDesignRaisedButton#��[ 6.   $��3��6b   $��14,20,15,18q�6r     � ToolTip$  Nueva Tarea��6�   $��2��6�   $
��Auto��6�   .��5L      '	  !MaterialDesignThemes.Wpf.PackIcon	  �
  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]! 
  Kind$! UserPlusOutline=�6*   $��41��6B   $��41��6N   5M      �� 5N      -   5        $ btnActualizarTarea��5N      #��[ 61   $��
13,19,7,19q�6e   $  Actualizar Tarea��6y   $��2��6�   $
��Auto��6�   $��4��6�   .��5O      	  $
! Sync=�6*   $��43��67   $��39��6C   5P      �� 5Q      -   5        $ btnBuscarTarea��5Q      #��[ 6-   $��15,45,14,43q�6a   $  Buscar Tarea��6v   $��3��6�   $
��Auto��6�   $��3��6�   .��5R      	  $! Search=�6*   $��51��69   $��46��6E   5S      �� 5T      -   5        $ btnEliminarTarea��5T      #��[ 6/   $��
13,46,7,42q�6c   $  Borrar Tarea��6w   $��3��6�   $
��Auto��6�   $��4��6�   .��5U      	  $! Delete=�6*   $��41��69   $��41��6E   
���   �6P   5V      5W      5X      5Y      