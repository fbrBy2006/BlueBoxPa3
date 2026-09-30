# Blue Box PA3 — La última señal

Proyecto individual en Unity 6 y URP. El jugador atraviesa un laboratorio de investigación dañado, recupera siete celdas de energía y reactiva el núcleo para abrir la salida. La narración se comunica mediante luces, equipos volcados, una fuga química y daños en el entorno.

El profesor autorizó la modalidad individual; los requisitos de coordinación, reparto de roles y trabajo grupal no aplican.

## Generar la escena

1. Abre el proyecto con Unity 6.6.
2. Espera a que compile los scripts y termine de importar los recursos.
3. Selecciona **Blue Box > Build PA3 Prototype**. El constructor guarda `Assets/_Project/Scenes/BlueBoxLab.unity`, coloca la escena en Build Settings y comienza el horneado de iluminación.
4. Espera a que termine el horneado. Si Unity no lo inicia, elige **Blue Box > Bake PA3 Lighting**. También puedes abrir **Window > Rendering > Lighting** y pulsar **Generate Lighting**.
5. Abre `Assets/_Project/Scenes/BlueBoxLab.unity` y pulsa Play.

El generador reconstruye la escena; cualquier cambio manual hecho directamente en la escena debe trasladarse al constructor antes de volver a ejecutarlo.

## Controles

- WASD o flechas: caminar.
- Ratón: mirar.
- Espacio: saltar.
- E: interactuar con el núcleo cuando esté habilitado.
- R: reiniciar después de perder todas las vidas.
- Escape: liberar el cursor.

## Sistemas y recursos

- Cámara en primera persona con Cinemachine y secuencia de apertura de 8 segundos en Timeline. El cronómetro comienza al terminar la introducción.
- Siete celdas que requieren saltar; los bloques de peligro quitan una vida al tocar cualquier cara. El punto de control conserva el progreso de la ruta y sirve de reaparición.
- Celdas ampliadas con un área de captura generosa para hacer más fácil el salto. Música ambiental original y suave, en loop, generada dentro del proyecto.
- Núcleo bloqueado hasta recoger las siete celdas; al activarlo, abre la puerta y activa sus luces y vapor. Cruzar la salida muestra el resultado y guarda el mejor tiempo en el equipo.
- Catwalk lateral con escaleras, desniveles, consolas modulares, fuga química y recipientes volcados para orientar al jugador sin paneles narrativos.
- Prefabs de consola y bloque peligroso en `Assets/_Project/Prefabs`.
- Shader Graph propio de pulso cian HDR en `Assets/_Project/Shaders`: Time → Multiply → Sine → Add → Multiply → Emission; material asociado en `Assets/_Project/Materials`.
- Volume global URP configurado con Tonemapping, corrección de color, Bloom y viñeta sutil; luz direccional preparada para bake y luces locales en tiempo real.

## Archivos importantes

```text
Assets/_Project/Scenes/BlueBoxLab.unity
Assets/_Project/Prefabs/
Assets/_Project/Shaders/SG_ReactorPulse.shadergraph
Assets/_Project/Timeline/IntroCinematic.playable
Assets/_Project/Settings/Volumes/BlueBoxMood.asset
Assets/_Project/Audio/BlueBox_Ambient.wav
Assets/Editor/BlueBoxLevelBuilder.cs
Assets/Editor/BlueBoxWindowsBuild.cs
```

## Compilar para Windows

Espera a que Unity termine de compilar los scripts y el Shader Graph. En el menú **Blue Box**, selecciona **Build Windows EXE**. Unity guardará el ejecutable en `Builds/Windows/BlueBoxPA3.exe` y abrirá la carpeta al terminar. Prueba el `.exe` antes de entregarlo y comprime/envía la carpeta completa `Builds/Windows`, porque el jugador también necesita sus archivos `*_Data` y dependencias.

## Evidencias para la entrega individual

- Graba una demostración de 4–5 minutos usando el guion en `docs/Guion_Video_PA3.docx` (queda dentro de los rangos de 3–5 y 4–6 minutos de las dos versiones de la consigna revisadas).
- Completa el [informe individual editable](docs/PA3_Informe_Individual.docx), inserta las capturas señaladas y añade los enlaces reales del repositorio y del video.
- Incluye capturas del Shader Graph, Timeline, prefabs, Lighting y del juego en ejecución.
- Completa el informe y la bitácora individual con tu nombre, capturas y fechas reales de trabajo; no inventes reuniones ni integrantes.
- Si la entrega exige repositorio público, publícalo en la plataforma indicada por el curso y verifica que el enlace permita acceder al código. Esa publicación no se automatiza desde este proyecto.

## Aviso de verificación

Los archivos se preparan para Unity 6.6. El bake está guardado en `Assets/_Project/Scenes/BlueBoxLab/LightingData.asset` con siete pares de lightmaps. Abre el proyecto, confirma que Unity importe el Shader Graph y revisa la Console. Comprueba el efecto del Volume y el pulso en Game View, y prueba el recorrido antes de grabar. Si cambias las luces, ejecuta **Blue Box > Bake PA3 Lighting** otra vez y guarda la escena.
