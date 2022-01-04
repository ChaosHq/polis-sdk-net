namespace ChaosHq.Polis.Sdk;

public interface IHttpClient
{
    public void SendTx(); // (domain: string, chainid: number, func: string, args?:any[], succCallback?: Function, errCallback?: Function) => any;

    // confirmTx: (domain: string, chainid: number, func: string, args?:any[]) => any;

    public object QueryTx(int chainid, string tx, Action? succCallback, Action? errCallback);

    public Task<object> SendTxAsync(string domain, int chainid, Func<string, object[]> func, bool? disableTooltip);

    public Task<object> QueryTxAsync(int chainid, string tx, bool? disableTooltip);

    public void CloseConfirmDialog();
}