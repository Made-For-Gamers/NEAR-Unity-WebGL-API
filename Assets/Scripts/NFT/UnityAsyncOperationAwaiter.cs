using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;

//Extension providing async/await for UnityWebRequest
public static class ExtensionMethods
{
    public static TaskAwaiter GetAwaiter(this AsyncOperation asyncOp)
    {
        var tcs = new TaskCompletionSource<object>();
        asyncOp.completed += obj => { tcs.SetResult(null); };
        return ((Task)tcs.Task).GetAwaiter();
    }
}