using System.Diagnostics;

namespace JsStyle.MethodControl {

    public static class Global {
        public static readonly Stopwatch Timer = Stopwatch.StartNew();

        #region TryFunc

        public delegate bool TryFunc<TResult>(out TResult result);

        public delegate bool TryFunc<T0, TResult>(T0 arg0, out TResult result);

        public delegate bool TryFunc<T0, T1, TResult>(T0 arg0, T1 arg1, out TResult result);

        public delegate bool TryFunc<T0, T1, T2, TResult>(T0 arg0, T1 arg1, T2 arg2, out TResult result);

        public delegate bool TryFunc<T0, T1, T2, T3, TResult>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, out TResult result);

        public delegate bool TryFunc<T0, T1, T2, T3, T4, TResult>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, out TResult result);

        public delegate bool TryFunc<T0, T1, T2, T3, T4, T5, TResult>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, out TResult result);

        public delegate bool TryFunc<T0, T1, T2, T3, T4, T5, T6, TResult>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, out TResult result);

        public delegate bool TryFunc<T0, T1, T2, T3, T4, T5, T6, T7, TResult>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, out TResult result);

        public delegate bool TryFunc<T0, T1, T2, T3, T4, T5, T6, T7, T8, TResult>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, out TResult result);

        public delegate bool TryFunc<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, out TResult result);

        public delegate bool TryFunc<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, out TResult result);

        public delegate bool TryFunc<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, out TResult result);

        public delegate bool TryFunc<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, out TResult result);

        public delegate bool TryFunc<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, out TResult result);

        public delegate bool TryFunc<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, out TResult result);

        public delegate bool TryFunc<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, out TResult result);

        #endregion TryFunc
    }
}