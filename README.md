# AsyncCharting
Playing around with asynchronously charting data in C#. Goals are as follows:
- Create simulated data source with Ivi simulation driver. Ideas include:
  - Agilent RF Power Meter
  - Agilent 34970 Data Acquisition Unit
- Write asynchronous wrapper function for data acquisition from both
- Connect asynchronous function to asynchronous command in VM
- Show that data can be live-plotted while keeping the UI responsive
