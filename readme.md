# QR Reader for MAUI + Blazor Demo

Key concepts:
* CameraBarcodeReaderView is created at runtime when needed to read a QR code. Because sometimes it freezes if left active but hidden.
* Dependency injection to communicate between MAUI and Blazor parts.
