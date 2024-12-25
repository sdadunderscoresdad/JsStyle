using System;
using System.Threading;
using System.Threading.Tasks;

namespace JsStyle.MethodControl {

    public static class ExecuteExtension {

        #region ExecuteAfter

        public static async Task ExecuteAfter(this Action func, TimeSpan delay, CancellationToken token = default) {
            try {
                await Task.Delay(delay, token);
                token.ThrowIfCancellationRequested();
                func();
            } catch (TaskCanceledException) { }
        }

        public static async Task ExecuteAfter<T0>(this Action<T0> func, TimeSpan delay, T0 arg0, CancellationToken token = default) {
            try {
                await Task.Delay(delay, token);
                token.ThrowIfCancellationRequested();
                func(arg0);
            } catch (TaskCanceledException) { }
        }

        #region More

        public static async Task ExecuteAfter<T0, T1>(this Action<T0, T1> func, TimeSpan delay, T0 arg0, T1 arg1, CancellationToken token = default) => await ExecuteAfter(() => func(arg0, arg1), delay, token);

        public static async Task ExecuteAfter<T0, T1, T2>(this Action<T0, T1, T2> func, TimeSpan delay, T0 arg0, T1 arg1, T2 arg2, CancellationToken token = default) => await ExecuteAfter(() => func(arg0, arg1, arg2), delay, token);

        public static async Task ExecuteAfter<T0, T1, T2, T3>(this Action<T0, T1, T2, T3> func, TimeSpan delay, T0 arg0, T1 arg1, T2 arg2, T3 arg3, CancellationToken token = default) => await ExecuteAfter(() => func(arg0, arg1, arg2, arg3), delay, token);

        public static async Task ExecuteAfter<T0, T1, T2, T3, T4>(this Action<T0, T1, T2, T3, T4> func, TimeSpan delay, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, CancellationToken token = default) => await ExecuteAfter(() => func(arg0, arg1, arg2, arg3, arg4), delay, token);

        public static async Task ExecuteAfter<T0, T1, T2, T3, T4, T5>(this Action<T0, T1, T2, T3, T4, T5> func, TimeSpan delay, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, CancellationToken token = default) => await ExecuteAfter(() => func(arg0, arg1, arg2, arg3, arg4, arg5), delay, token);

        public static async Task ExecuteAfter<T0, T1, T2, T3, T4, T5, T6>(this Action<T0, T1, T2, T3, T4, T5, T6> func, TimeSpan delay, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, CancellationToken token = default) => await ExecuteAfter(() => func(arg0, arg1, arg2, arg3, arg4, arg5, arg6), delay, token);

        public static async Task ExecuteAfter<T0, T1, T2, T3, T4, T5, T6, T7>(this Action<T0, T1, T2, T3, T4, T5, T6, T7> func, TimeSpan delay, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, CancellationToken token = default) => await ExecuteAfter(() => func(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7), delay, token);

        public static async Task ExecuteAfter<T0, T1, T2, T3, T4, T5, T6, T7, T8>(this Action<T0, T1, T2, T3, T4, T5, T6, T7, T8> func, TimeSpan delay, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, CancellationToken token = default) => await ExecuteAfter(() => func(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8), delay, token);

        public static async Task ExecuteAfter<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> func, TimeSpan delay, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, CancellationToken token = default) => await ExecuteAfter(() => func(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9), delay, token);

        public static async Task ExecuteAfter<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> func, TimeSpan delay, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, CancellationToken token = default) => await ExecuteAfter(() => func(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10), delay, token);

        public static async Task ExecuteAfter<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> func, TimeSpan delay, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, CancellationToken token = default) => await ExecuteAfter(() => func(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11), delay, token);

        public static async Task ExecuteAfter<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> func, TimeSpan delay, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, CancellationToken token = default) => await ExecuteAfter(() => func(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12), delay, token);

        public static async Task ExecuteAfter<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> func, TimeSpan delay, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, CancellationToken token = default) => await ExecuteAfter(() => func(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13), delay, token);

        public static async Task ExecuteAfter<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> func, TimeSpan delay, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, CancellationToken token = default) => await ExecuteAfter(() => func(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14), delay, token);

        public static async Task ExecuteAfter<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> func, TimeSpan delay, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, CancellationToken token = default) => await ExecuteAfter(() => func(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15), delay, token);

        #endregion More

        #endregion ExecuteAfter

        #region ExecuteRepeatedly

        public static async Task ExecuteRepeatedly(Action func, TimeSpan delay, int maxExecuteCount = -1, CancellationToken token = default) {
            try {
                while (maxExecuteCount < 0 || maxExecuteCount-- > 0) {
                    token.ThrowIfCancellationRequested();
                    await ExecuteAfter(func, delay, token);
                }
            } catch (TaskCanceledException) { }
        }

        public static async Task ExecuteRepeatedly<T0>(Action<T0> func, TimeSpan delay, T0 arg0, int maxExecuteCount = -1, CancellationToken token = default) {
            try {
                while (maxExecuteCount < 0 || maxExecuteCount-- > 0) {
                    token.ThrowIfCancellationRequested();
                    await ExecuteAfter(func, delay, arg0, token);
                }
            } catch (TaskCanceledException) { }
        }

        #region More

        public static async Task ExecuteRepeatedly<T0, T1>(Action<T0, T1> func, TimeSpan delay, T0 arg0, T1 arg1, int maxExecuteCount = -1, CancellationToken token = default) => await ExecuteRepeatedly(() => func(arg0, arg1), delay, maxExecuteCount, token);

        public static async Task ExecuteRepeatedly<T0, T1, T2>(Action<T0, T1, T2> func, TimeSpan delay, T0 arg0, T1 arg1, T2 arg2, int maxExecuteCount = -1, CancellationToken token = default) => await ExecuteRepeatedly(() => func(arg0, arg1, arg2), delay, maxExecuteCount, token);

        public static async Task ExecuteRepeatedly<T0, T1, T2, T3>(Action<T0, T1, T2, T3> func, TimeSpan delay, T0 arg0, T1 arg1, T2 arg2, T3 arg3, int maxExecuteCount = -1, CancellationToken token = default) => await ExecuteRepeatedly(() => func(arg0, arg1, arg2, arg3), delay, maxExecuteCount, token);

        public static async Task ExecuteRepeatedly<T0, T1, T2, T3, T4>(Action<T0, T1, T2, T3, T4> func, TimeSpan delay, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, int maxExecuteCount = -1, CancellationToken token = default) => await ExecuteRepeatedly(() => func(arg0, arg1, arg2, arg3, arg4), delay, maxExecuteCount, token);

        public static async Task ExecuteRepeatedly<T0, T1, T2, T3, T4, T5>(Action<T0, T1, T2, T3, T4, T5> func, TimeSpan delay, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, int maxExecuteCount = -1, CancellationToken token = default) => await ExecuteRepeatedly(() => func(arg0, arg1, arg2, arg3, arg4, arg5), delay, maxExecuteCount, token);

        public static async Task ExecuteRepeatedly<T0, T1, T2, T3, T4, T5, T6>(Action<T0, T1, T2, T3, T4, T5, T6> func, TimeSpan delay, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, int maxExecuteCount = -1, CancellationToken token = default) => await ExecuteRepeatedly(() => func(arg0, arg1, arg2, arg3, arg4, arg5, arg6), delay, maxExecuteCount, token);

        public static async Task ExecuteRepeatedly<T0, T1, T2, T3, T4, T5, T6, T7>(Action<T0, T1, T2, T3, T4, T5, T6, T7> func, TimeSpan delay, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, int maxExecuteCount = -1, CancellationToken token = default) => await ExecuteRepeatedly(() => func(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7), delay, maxExecuteCount, token);

        public static async Task ExecuteRepeatedly<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Action<T0, T1, T2, T3, T4, T5, T6, T7, T8> func, TimeSpan delay, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, int maxExecuteCount = -1, CancellationToken token = default) => await ExecuteRepeatedly(() => func(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8), delay, maxExecuteCount, token);

        public static async Task ExecuteRepeatedly<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> func, TimeSpan delay, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, int maxExecuteCount = -1, CancellationToken token = default) => await ExecuteRepeatedly(() => func(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9), delay, maxExecuteCount, token);

        public static async Task ExecuteRepeatedly<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> func, TimeSpan delay, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, int maxExecuteCount = -1, CancellationToken token = default) => await ExecuteRepeatedly(() => func(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10), delay, maxExecuteCount, token);

        public static async Task ExecuteRepeatedly<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> func, TimeSpan delay, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, int maxExecuteCount = -1, CancellationToken token = default) => await ExecuteRepeatedly(() => func(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11), delay, maxExecuteCount, token);

        public static async Task ExecuteRepeatedly<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> func, TimeSpan delay, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, int maxExecuteCount = -1, CancellationToken token = default) => await ExecuteRepeatedly(() => func(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12), delay, maxExecuteCount, token);

        public static async Task ExecuteRepeatedly<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> func, TimeSpan delay, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, int maxExecuteCount = -1, CancellationToken token = default) => await ExecuteRepeatedly(() => func(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13), delay, maxExecuteCount, token);

        public static async Task ExecuteRepeatedly<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> func, TimeSpan delay, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, int maxExecuteCount = -1, CancellationToken token = default) => await ExecuteRepeatedly(() => func(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14), delay, maxExecuteCount, token);

        public static async Task ExecuteRepeatedly<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> func, TimeSpan delay, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, int maxExecuteCount = -1, CancellationToken token = default) => await ExecuteRepeatedly(() => func(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15), delay, maxExecuteCount, token);

        #endregion More

        #endregion ExecuteRepeatedly
    }
}