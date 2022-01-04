namespace ChaosHq.Polis.Sdk;


public interface IWebsocketClient
{
    public string AccessToken { get; set; }

    public IOauth2Client OAuth2Client { get; set; }

    /**
     * connect to websocket
     */
    public bool Connect(Action onEmitChain, Action? onMessage, Action? onJson, Action? onConnect, Action? onDisconnect);

    /**
     * send a TX
     */
    public void SendTx(string domain, int chainid, string fun, object[]? args);

    /**
     * confirm a TX
     */
    //public void ConfirmTx(); // (domain: string, chainid: number, fun: string, args?:any[]) => void;
    public void QueryTx(int chainid, string tx);


    /**
     * disconnect from exist websocket
     */
    public void Disconnect();

    public void CloseConfirmDialog();
}