# ActiVR

The ActiVR Server is based on open source code by Microsoft - https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/BluetoothLE

This application enumerates all Bluetooth Low Energy (BLE) devices and receives raw data sent from them. Therefore, 
the application can connect to and receive data from activity trackers like the Polar H7 and Fitbit heart-rate monitors
that use BLE to connect with smartphones, as they are small and low-powered devices. 
The ActiVR server application uses Websockets to send data to other applications, such as VR games made in Unity.
