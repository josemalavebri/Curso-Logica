---
fecha: 2024-07-13
tipo:
  - c-shart
tags:
  - "#Comprendido"
  - Codigo
  - Secundario
---
#### Este código limpia los controles de un determinado formulario 

- Con esto se utiliza el fragmento de código

``` c#
Global.LimpiarControles(this);
```


* Recoge el argumento e itera los elementos que se le están pasando
``` c#
public static void LimpiarControles(Control parent)
{
    foreach (Control control in parent.Controls)
    {
        if (control is TextBox)
        {
            ((TextBox)control).Clear();
        }
        else if (control is ComboBox)
        {
            ((ComboBox)control).SelectedIndex = -1;
        }
        else if (control is CheckBox)
        {
            ((CheckBox)control).Checked = false;
        }
        else if (control is RadioButton)
        {
            ((RadioButton)control).Checked = false;
        }
        else if (control is ListBox)
        {
            ((ListBox)control).ClearSelected();
        }
        else if (control is RichTextBox)
        {
            ((RichTextBox)control).Text = string.Empty;
        }
        else if (control is DataGridView)
        {
            ((DataGridView)control).Rows.Clear();
        }
        // Llamada recursiva para limpiar controles dentro de contenedores
        if (control.HasChildren)
        {
            LimpiarControles(control);
        }
    }
}
    
```
