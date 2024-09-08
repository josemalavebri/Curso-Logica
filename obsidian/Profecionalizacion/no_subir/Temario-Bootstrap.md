---
modificado: 2024-09-06
tags:
  - Comprendido
Regreso:
  - "[[Bootstrap]]"
---
## **1. Introducción a Bootstrap**

### 1.1. ¿Qué es Bootstrap?

+ [[Definición y propósito de Bootstrap]].
- [[Historia y evolución de Bootstrap]].
- [[Ventajas y desventajas de usar Bootstrap en proyectos web.]]

### 1.2. Instalación y Configuración

- Descargar e instalar Bootstrap (CDN vs instalación local).
- Integración en proyectos existentes.
- Visión general de la estructura de archivos de Bootstrap.

---

## **2. Conceptos Básicos de Bootstrap**

### 2.1. Contenedores

- Tipos de contenedores: `container` y `container-fluid`.
- Diferencias entre contenedores fijos y fluidos.

### 2.2. Sistema de Grid (Grid System)

- Concepto de grid en Bootstrap.
- Rejillas con clases flexibles.
- Colapsar columnas en diferentes tamaños de pantalla (`col-sm`, `col-md`, `col-lg`, etc.).
- Alineación y distribución de columnas.

### 2.3. Tipografía

- Tipografías predeterminadas de Bootstrap.
- Estilos de texto (`text-left`, `text-center`, `text-right`, etc.).
- Tamaños de encabezados y párrafos.
- Utilidades de tipografía como `text-muted`, `lead`, etc.

---

## **3. Componentes Básicos**

### 3.1. Botones

- Clases para botones (`btn`, `btn-primary`, `btn-secondary`, etc.).
- Tamaños y colores de botones.
- Botones de grupo (Button Groups).
### 3.2. Formularios

- Formularios básicos: campos de texto, radio buttons, checkboxes, dropdowns.
- Formularios personalizados con `input-group`.
- Estilos de validación de formularios.
### 3.3. Navegación

- Barra de navegación (`navbar`).
- Menús desplegables (`dropdowns`).
- Paginación (`pagination`).
- Navegación de pestañas y acordeones.

---
## **4. Diseño Responsivo**

### 4.1. Clases Responsivas

- Mostrar y ocultar elementos en dispositivos específicos (`d-none`, `d-sm-block`, etc.).
- Clases de alineación y espaciado responsivo.

### 4.2. Imágenes y Medios

- Imágenes responsivas (`img-fluid`).
- Estilos de imágenes (clase `rounded`, `img-thumbnail`).
- Contenedores de medios (`media`, `media-body`).

### 4.3. Flexbox en Bootstrap

- Concepto de Flexbox.
- Clases flexibles para alineación y distribución de elementos.
- Uso de `align-items`, `justify-content`, y `flex-grow`.

---

## **5. Componentes Avanzados**

### 5.1. Tarjetas (Cards)

- Creación de tarjetas básicas con `card`.
- Tarjetas con imágenes, listas y pies de página.
- Tarjetas en grillas y flexbox.

### 5.2. Modal

- Creación y configuración de ventanas modales.
- Métodos de interacción con modales (abrir, cerrar, eventos).

### 5.3. Alerts y Badges

- Creación de alertas (`alert`).
- Personalización y tipos de alertas.
- Insignias (`badge`) para notificaciones y conteos.

### 5.4. Listas de Grupos (List Groups)

- Creación de listas con `list-group`.
- Listas con enlaces y botones.
- Listas con contenido personalizado.

---

## **6. Personalización de Bootstrap**

### 6.1. Temas y Variables de Bootstrap

- Introducción a las variables de Sass en Bootstrap.
- Sobrescribir y personalizar variables predeterminadas.
- Crear temas personalizados usando Sass.

### 6.2. Bootstrap Icons

- Introducción a Bootstrap Icons.
- Uso de iconos en componentes y formularios.

### 6.3. Extender Bootstrap

- Uso de clases personalizadas.
- Combinar Bootstrap con CSS personalizado.
- Integración de JavaScript o jQuery con componentes de Bootstrap.

---

## **7. Bootstrap y JavaScript**

### 7.1. Integración de JavaScript en Bootstrap

- Uso de plugins de JavaScript en Bootstrap.
- Dependencias de jQuery y Popper.js.
- Interacciones con elementos dinámicos.

### 7.2. Tooltips y Popovers

- Crear tooltips (`data-toggle="tooltip"`).
- Crear popovers (`data-toggle="popover"`).

### 7.3. Carouseles

- Creación de sliders de imágenes con `carousel`.
- Opciones de personalización y configuración de carouseles.

### 7.4. Colapsar y Desplegar Elementos

- Uso del componente `collapse`.
- Interacción con menús y acordeones.

---

## **8. Buenas Prácticas y Proyecto Final**

### 8.1. Buenas Prácticas con Bootstrap

- Optimización de la carga de Bootstrap.
- Evitar la sobresaturación de clases.
- Técnicas de accesibilidad en Bootstrap.

### 8.2. Proyecto Final

- Creación de una página web completa usando Bootstrap.
- Implementar todos los conceptos vistos: grid, tipografía, formularios, modales, etc.
- Personalización y optimización del sitio.



## **Introducción al Diseño Responsivo en Bootstrap**

### 1.1. ¿Qué es el Diseño Responsivo?

- Definición de diseño responsivo.
- Importancia del diseño responsivo en el desarrollo web moderno.
- Ventajas de usar Bootstrap para diseño responsivo.

### 1.2. Visión General de Breakpoints en Bootstrap

- Concepto de "breakpoints" en diseño responsivo.
- Breakpoints predeterminados en Bootstrap:
    - Extra pequeño (`xs`: <576px).
    - Pequeño (`sm`: ≥576px).
    - Mediano (`md`: ≥768px).
    - Grande (`lg`: ≥992px).
    - Extra grande (`xl`: ≥1200px).
    - XXL (`xxl`: ≥1400px).

### 1.3. Uso de Media Queries

- Cómo Bootstrap utiliza media queries para adaptarse a diferentes pantallas.
- Personalización de media queries en proyectos personalizados.

---

## **2. Sistema de Grillas (Grid System) en Bootstrap**

### 2.1. Estructura del Sistema de Grillas

- Concepto de filas (`row`) y columnas (`col`).
- Rejillas con 12 columnas: cómo funciona el sistema de grillas flexible.

### 2.2. Clases de Columna Basadas en Breakpoints

- `col-sm`, `col-md`, `col-lg`, `col-xl`, `col-xxl`.
- Creación de diseños adaptativos con columnas de diferentes tamaños.

### 2.3. Control de Ancho de Columnas

- Clases automáticas (`col-auto`).
- Definir tamaños de columna personalizados (`col-6`, `col-4`, etc.).

### 2.4. Alineación y Distribución en Grillas

- Alineación horizontal: `justify-content-start`, `justify-content-center`, `justify-content-end`.
- Alineación vertical: `align-items-start`, `align-items-center`, `align-items-end`.
- Distribución de columnas (`order`, `offset`, `g-0`, `g-2`).

---

## **3. Imágenes y Medios Responsivos**

### 3.1. Imágenes Responsivas

- Clase `img-fluid` para imágenes adaptables.
- Escalado de imágenes basado en el contenedor padre.

### 3.2. Videos Responsivos

- Uso de `embed-responsive` para videos.
- Escalado de vídeos de YouTube o iframe.

---

## **4. Utilidades Responsivas de Bootstrap**

### 4.1. Clases de Visibilidad

- Mostrar y ocultar elementos en diferentes dispositivos (`d-none`, `d-sm-block`, `d-lg-none`, etc.).
- Cómo controlar la visibilidad de un elemento en dispositivos específicos.

### 4.2. Clases de Espaciado Responsivo

- Margen y padding adaptativos (`m-sm-3`, `p-md-5`, etc.).
- Espaciado vertical y horizontal (`mt-4`, `mb-2`, `mx-auto`, etc.).

### 4.3. Clases de Texto Responsivo

- Alineación de texto responsivo (`text-start`, `text-center`, `text-end`).
- Clases para tamaño de texto en diferentes pantallas (`fs-sm`, `fs-lg`, etc.).

### 4.4. Alineación y Flexbox

- Clases flexibles (`d-flex`, `d-sm-flex`, `d-lg-none`).
- Alineación y distribución de elementos (`align-items-center`, `justify-content-between`).
- Uso de flexbox para crear layouts complejos y adaptables.

---

## **5. Diseño Responsivo con Formularios**

### 5.1. Formularios Adaptativos

- Formulario inline en pantallas pequeñas (`form-inline`).
- Formularios adaptados a columnas y grillas.

### 5.2. Inputs Responsivos

- Control de ancho de inputs y selects (`form-control-sm`, `form-control-lg`).
- Input groups adaptables para diferentes pantallas.

---

## **6. Navegación y Menús Responsivos**

### 6.1. Barra de Navegación (Navbar) Adaptativa

- Creación de `navbar` responsivas.
- Menús colapsables en pantallas pequeñas (`navbar-toggler`).
- Personalización del comportamiento del menú en dispositivos móviles.

### 6.2. Barra de Navegación Fija

- Navegación fija en la parte superior (`navbar-fixed-top`).
- Navegación fija en la parte inferior (`navbar-fixed-bottom`).

### 6.3. Menús de Pestañas Responsivas

- Menús de pestañas (`nav-tabs`, `nav-pills`) que se adaptan a diferentes pantallas.

---

## **7. Componentes Responsivos**

### 7.1. Tablas Responsivas

- Clase `table-responsive` para tablas con scroll en pantallas pequeñas.
- Personalización del diseño de tablas para móviles.

### 7.2. Tarjetas (Cards) Responsivas

- Tarjetas en grillas (`card-columns`) adaptativas.
- Cómo hacer que las tarjetas cambien de disposición en pantallas pequeñas.

### 7.3. Carouseles Responsivos

- Configuración de sliders de imágenes (`carousel`) para dispositivos móviles.
- Personalización de la transición y el comportamiento del carrusel en pantallas pequeñas.

---

## **8. Proyecto de Diseño Responsivo en Bootstrap**

### 8.1. Crear una Página Web Responsiva Completa

- Definir un layout adaptativo con el sistema de grillas.
- Incorporar imágenes, formularios y menús responsivos.
- Crear un diseño adaptable que cambie según el tamaño de pantalla.

### 8.2. Optimización para Móviles

- Técnicas avanzadas para mejorar la experiencia en dispositivos móviles.
- Uso de `viewport` y ajustes de zoom en pantallas pequeñas.