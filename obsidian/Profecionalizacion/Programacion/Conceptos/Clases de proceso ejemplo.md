---
modificado: 2024-09-12
tags:
  - Comprendido
Flujo-Regreso:
  - "[[Clases de proceso]]"
---




#### Sintaxis básica

```c#
public class ProcessClass
{
    // Propiedades necesarias para el proceso
    public string Property { get; set; }

    // Constructor para inicializar la clase
    public ProcessClass(/* parámetros necesarios */)
    {
        // Inicialización
    }

    // Método que ejecuta el proceso
    public void ExecuteProcess()
    {
        // Paso 1: Realizar una acción
        // Paso 2: Realizar otra acción
        // Paso 3: Finalizar el proceso
    }
}

```
#### Ejemplo básico
```c#
public class EmailProcess
{
    private string _recipient;
    private string _subject;
    private string _body;

    // Constructor para inicializar la clase
    public EmailProcess(string recipient, string subject, string body)
    {
        _recipient = recipient;
        _subject = subject;
        _body = body;
    }

    public bool SendEmail()
    {
        Console.WriteLine($"Enviando correo a {_recipient}");
        Console.WriteLine($"Asunto: {_subject}");
        Console.WriteLine($"Cuerpo: {_body}");

        return true;
    }

    public void LogActivity()
    {
        Console.WriteLine($"Correo enviado a {_recipient} con el asunto: {_subject}");
    }

    public void ExecuteProcess()
    {
        bool emailSent = SendEmail();
        if (emailSent)
        {
            LogActivity();
        }
        else
        {
            Console.WriteLine("Error al enviar el correo electrónico.");
        }
    }
}


```