Namespace My

    ' I seguenti eventi sono disponibili per MyApplication:
    ' 
    ' Startup: generato all'avvio dell'applicazione, prima della creazione del form di avvio.
    ' Shutdown: generato dopo la chiusura di tutti i form dell'applicazione. L'evento non è generato se l'applicazione termina in modo anormale.
    ' UnhandledException: generato se l'applicazione rileva un'eccezione non gestita.
    ' StartupNextInstance: generato quando si avvia un'applicazione istanza singola e l'applicazione è già attiva. 
    ' NetworkAvailabilityChanged: generato quando la connessione di rete è connessa o disconnessa.
    Partial Friend Class MyApplication
        Protected Overrides Function OnInitialize(ByVal commandLineArgs As System.Collections.ObjectModel.ReadOnlyCollection(Of String)) As Boolean

            ' Set the display time to 12000 milliseconds (12 seconds). 

            Me.MinimumSplashScreenDisplayTime = 5000

            Return MyBase.OnInitialize(commandLineArgs)

        End Function
    End Class


End Namespace

