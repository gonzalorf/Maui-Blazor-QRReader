# QR Reader for MAUI + Blazor Demo

Key concepts:
* CameraBarcodeReaderView is created at runtime when needed to read a QR code. Because sometimes it freezes if is left active but hidden.
* Dependency injection to communicate between MAUI and Blazor parts.

Capture:
Reader is a MAUI component, is not a Blazor (html) element:
![Reader is a MAUI component, is not a Blazor (html) element](https://github.com/gonzalorf/Maui-Blazor-QRReader/blob/master/capture.jpeg)