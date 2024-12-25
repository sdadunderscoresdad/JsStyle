using System;
using static JsStyle.MethodControl.Global;

namespace JsStyle.MethodControl {

    public static class Debouncer {

        #region Action

        public static Action<T0> AsDebounce<T0>(this Action<T0> func, TimeSpan delay) {
            var lastCall = double.MinValue;
            var delayMilliseconds = delay.TotalMilliseconds;
            return arg0 => {
                var now = Timer.ElapsedMilliseconds;
                if (now - lastCall >= delayMilliseconds)
                    func(arg0);
                lastCall = now;
            };
        }

        public static Action AsDebounce(this Action func, TimeSpan delay) {
            var lastCall = double.MinValue;
            var delayMilliseconds = delay.TotalMilliseconds;
            return () => {
                var now = Timer.ElapsedMilliseconds;
                if (now - lastCall >= delayMilliseconds)
                    func();
                lastCall = now;
            };
        }

        #region More

        public static Action<T0, T1> AsDebounce<T0, T1>(this Action<T0, T1> func, TimeSpan delay) {
            var t = AsDebounce(((T0 arg0, T1 arg1) argTuple) => func(argTuple.arg0, argTuple.arg1), delay);
            return (arg0, arg1) => t((arg0, arg1));
        }

        public static Action<T0, T1, T2> AsDebounce<T0, T1, T2>(this Action<T0, T1, T2> func, TimeSpan delay) {
            var t = AsDebounce(((T0 arg0, T1 arg1, T2 arg2) argTuple) => func(argTuple.arg0, argTuple.arg1, argTuple.arg2), delay);
            return (arg0, arg1, arg2) => t((arg0, arg1, arg2));
        }

        public static Action<T0, T1, T2, T3> AsDebounce<T0, T1, T2, T3>(this Action<T0, T1, T2, T3> func, TimeSpan delay) {
            var t = AsDebounce(((T0 arg0, T1 arg1, T2 arg2, T3 arg3) argTuple) => func(argTuple.arg0, argTuple.arg1, argTuple.arg2, argTuple.arg3), delay);
            return (arg0, arg1, arg2, arg3) => t((arg0, arg1, arg2, arg3));
        }

        public static Action<T0, T1, T2, T3, T4> AsDebounce<T0, T1, T2, T3, T4>(this Action<T0, T1, T2, T3, T4> func, TimeSpan delay) {
            var t = AsDebounce(((T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) argTuple) => func(argTuple.arg0, argTuple.arg1, argTuple.arg2, argTuple.arg3, argTuple.arg4), delay);
            return (arg0, arg1, arg2, arg3, arg4) => t((arg0, arg1, arg2, arg3, arg4));
        }

        public static Action<T0, T1, T2, T3, T4, T5> AsDebounce<T0, T1, T2, T3, T4, T5>(this Action<T0, T1, T2, T3, T4, T5> func, TimeSpan delay) {
            var t = AsDebounce(((T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) argTuple) => func(argTuple.arg0, argTuple.arg1, argTuple.arg2, argTuple.arg3, argTuple.arg4, argTuple.arg5), delay);
            return (arg0, arg1, arg2, arg3, arg4, arg5) => t((arg0, arg1, arg2, arg3, arg4, arg5));
        }

        public static Action<T0, T1, T2, T3, T4, T5, T6> AsDebounce<T0, T1, T2, T3, T4, T5, T6>(this Action<T0, T1, T2, T3, T4, T5, T6> func, TimeSpan delay) {
            var t = AsDebounce(((T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) argTuple) => func(argTuple.arg0, argTuple.arg1, argTuple.arg2, argTuple.arg3, argTuple.arg4, argTuple.arg5, argTuple.arg6), delay);
            return (arg0, arg1, arg2, arg3, arg4, arg5, arg6) => t((arg0, arg1, arg2, arg3, arg4, arg5, arg6));
        }

        public static Action<T0, T1, T2, T3, T4, T5, T6, T7> AsDebounce<T0, T1, T2, T3, T4, T5, T6, T7>(this Action<T0, T1, T2, T3, T4, T5, T6, T7> func, TimeSpan delay) {
            var t = AsDebounce(((T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) argTuple) => func(argTuple.arg0, argTuple.arg1, argTuple.arg2, argTuple.arg3, argTuple.arg4, argTuple.arg5, argTuple.arg6, argTuple.arg7), delay);
            return (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7) => t((arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7));
        }

        public static Action<T0, T1, T2, T3, T4, T5, T6, T7, T8> AsDebounce<T0, T1, T2, T3, T4, T5, T6, T7, T8>(this Action<T0, T1, T2, T3, T4, T5, T6, T7, T8> func, TimeSpan delay) {
            var t = AsDebounce(((T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) argTuple) => func(argTuple.arg0, argTuple.arg1, argTuple.arg2, argTuple.arg3, argTuple.arg4, argTuple.arg5, argTuple.arg6, argTuple.arg7, argTuple.arg8), delay);
            return (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) => t((arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));
        }

        public static Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> AsDebounce<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> func, TimeSpan delay) {
            var t = AsDebounce(((T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) argTuple) => func(argTuple.arg0, argTuple.arg1, argTuple.arg2, argTuple.arg3, argTuple.arg4, argTuple.arg5, argTuple.arg6, argTuple.arg7, argTuple.arg8, argTuple.arg9), delay);
            return (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) => t((arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));
        }

        public static Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> AsDebounce<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> func, TimeSpan delay) {
            var t = AsDebounce(((T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) argTuple) => func(argTuple.arg0, argTuple.arg1, argTuple.arg2, argTuple.arg3, argTuple.arg4, argTuple.arg5, argTuple.arg6, argTuple.arg7, argTuple.arg8, argTuple.arg9, argTuple.arg10), delay);
            return (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => t((arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));
        }

        public static Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> AsDebounce<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> func, TimeSpan delay) {
            var t = AsDebounce(((T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) argTuple) => func(argTuple.arg0, argTuple.arg1, argTuple.arg2, argTuple.arg3, argTuple.arg4, argTuple.arg5, argTuple.arg6, argTuple.arg7, argTuple.arg8, argTuple.arg9, argTuple.arg10, argTuple.arg11), delay);
            return (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) => t((arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));
        }

        public static Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> AsDebounce<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> func, TimeSpan delay) {
            var t = AsDebounce(((T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) argTuple) => func(argTuple.arg0, argTuple.arg1, argTuple.arg2, argTuple.arg3, argTuple.arg4, argTuple.arg5, argTuple.arg6, argTuple.arg7, argTuple.arg8, argTuple.arg9, argTuple.arg10, argTuple.arg11, argTuple.arg12), delay);
            return (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => t((arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));
        }

        public static Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> AsDebounce<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> func, TimeSpan delay) {
            var t = AsDebounce(((T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) argTuple) => func(argTuple.arg0, argTuple.arg1, argTuple.arg2, argTuple.arg3, argTuple.arg4, argTuple.arg5, argTuple.arg6, argTuple.arg7, argTuple.arg8, argTuple.arg9, argTuple.arg10, argTuple.arg11, argTuple.arg12, argTuple.arg13), delay);
            return (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) => t((arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));
        }

        public static Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> AsDebounce<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> func, TimeSpan delay) {
            var t = AsDebounce(((T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) argTuple) => func(argTuple.arg0, argTuple.arg1, argTuple.arg2, argTuple.arg3, argTuple.arg4, argTuple.arg5, argTuple.arg6, argTuple.arg7, argTuple.arg8, argTuple.arg9, argTuple.arg10, argTuple.arg11, argTuple.arg12, argTuple.arg13, argTuple.arg14), delay);
            return (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) => t((arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));
        }

        public static Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> AsDebounce<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> func, TimeSpan delay) {
            var t = AsDebounce(((T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) argTuple) => func(argTuple.arg0, argTuple.arg1, argTuple.arg2, argTuple.arg3, argTuple.arg4, argTuple.arg5, argTuple.arg6, argTuple.arg7, argTuple.arg8, argTuple.arg9, argTuple.arg10, argTuple.arg11, argTuple.arg12, argTuple.arg13, argTuple.arg14, argTuple.arg15), delay);
            return (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => t((arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));
        }

        #endregion More

        #endregion Action

        #region Func

        public static TryFunc<T0, TResult> AsDebounce<T0, TResult>(this Func<T0, TResult> func, TimeSpan delay) {
            var lastCall = long.MinValue;
            var delayMilliseconds = delay.TotalMilliseconds;
            return (T0 arg0, out TResult result) => {
                var now = Timer.ElapsedMilliseconds;
                var isSuccess = false;
                if (now - lastCall >= delayMilliseconds) {
                    isSuccess = true;
                    result = func(arg0);
                } else result = default;
                lastCall = now;
                return isSuccess;
            };
        }

        public static TryFunc<TResult> AsDebounce<TResult>(this Func<TResult> func, TimeSpan delay) {
            var lastCall = long.MinValue;
            var delayMilliseconds = delay.TotalMilliseconds;
            return (out TResult result) => {
                var now = Timer.ElapsedMilliseconds;
                var isSuccess = false;
                if (now - lastCall >= delayMilliseconds) {
                    isSuccess = true;
                    result = func();
                } else result = default;
                lastCall = now;
                return isSuccess;
            };
        }

        #region More

        public static TryFunc<T0, T1, TResult> AsDebounce<T0, T1, TResult>(this Func<T0, T1, TResult> func, TimeSpan delay) {
            var t = AsDebounce(((T0 arg0, T1 arg1) argTuple) => func(argTuple.arg0, argTuple.arg1), delay);
            return (T0 arg0, T1 arg1, out TResult result) => {
                var isSuccess = t((arg0, arg1), out TResult _result);
                result = isSuccess ? _result : default;
                return isSuccess;
            };
        }

        public static TryFunc<T0, T1, T2, TResult> AsDebounce<T0, T1, T2, TResult>(this Func<T0, T1, T2, TResult> func, TimeSpan delay) {
            var t = AsDebounce(((T0 arg0, T1 arg1, T2 arg2) argTuple) => func(argTuple.arg0, argTuple.arg1, argTuple.arg2), delay);
            return (T0 arg0, T1 arg1, T2 arg2, out TResult result) => {
                var isSuccess = t((arg0, arg1, arg2), out TResult _result);
                result = isSuccess ? _result : default;
                return isSuccess;
            };
        }

        public static TryFunc<T0, T1, T2, T3, TResult> AsDebounce<T0, T1, T2, T3, TResult>(this Func<T0, T1, T2, T3, TResult> func, TimeSpan delay) {
            var t = AsDebounce(((T0 arg0, T1 arg1, T2 arg2, T3 arg3) argTuple) => func(argTuple.arg0, argTuple.arg1, argTuple.arg2, argTuple.arg3), delay);
            return (T0 arg0, T1 arg1, T2 arg2, T3 arg3, out TResult result) => {
                var isSuccess = t((arg0, arg1, arg2, arg3), out TResult _result);
                result = isSuccess ? _result : default;
                return isSuccess;
            };
        }

        public static TryFunc<T0, T1, T2, T3, T4, TResult> AsDebounce<T0, T1, T2, T3, T4, TResult>(this Func<T0, T1, T2, T3, T4, TResult> func, TimeSpan delay) {
            var t = AsDebounce(((T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) argTuple) => func(argTuple.arg0, argTuple.arg1, argTuple.arg2, argTuple.arg3, argTuple.arg4), delay);
            return (T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, out TResult result) => {
                var isSuccess = t((arg0, arg1, arg2, arg3, arg4), out TResult _result);
                result = isSuccess ? _result : default;
                return isSuccess;
            };
        }

        public static TryFunc<T0, T1, T2, T3, T4, T5, TResult> AsDebounce<T0, T1, T2, T3, T4, T5, TResult>(this Func<T0, T1, T2, T3, T4, T5, TResult> func, TimeSpan delay) {
            var t = AsDebounce(((T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) argTuple) => func(argTuple.arg0, argTuple.arg1, argTuple.arg2, argTuple.arg3, argTuple.arg4, argTuple.arg5), delay);
            return (T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, out TResult result) => {
                var isSuccess = t((arg0, arg1, arg2, arg3, arg4, arg5), out TResult _result);
                result = isSuccess ? _result : default;
                return isSuccess;
            };
        }

        public static TryFunc<T0, T1, T2, T3, T4, T5, T6, TResult> AsDebounce<T0, T1, T2, T3, T4, T5, T6, TResult>(this Func<T0, T1, T2, T3, T4, T5, T6, TResult> func, TimeSpan delay) {
            var t = AsDebounce(((T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) argTuple) => func(argTuple.arg0, argTuple.arg1, argTuple.arg2, argTuple.arg3, argTuple.arg4, argTuple.arg5, argTuple.arg6), delay);
            return (T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, out TResult result) => {
                var isSuccess = t((arg0, arg1, arg2, arg3, arg4, arg5, arg6), out TResult _result);
                result = isSuccess ? _result : default;
                return isSuccess;
            };
        }

        public static TryFunc<T0, T1, T2, T3, T4, T5, T6, T7, TResult> AsDebounce<T0, T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T0, T1, T2, T3, T4, T5, T6, T7, TResult> func, TimeSpan delay) {
            var t = AsDebounce(((T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) argTuple) => func(argTuple.arg0, argTuple.arg1, argTuple.arg2, argTuple.arg3, argTuple.arg4, argTuple.arg5, argTuple.arg6, argTuple.arg7), delay);
            return (T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, out TResult result) => {
                var isSuccess = t((arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7), out TResult _result);
                result = isSuccess ? _result : default;
                return isSuccess;
            };
        }

        public static TryFunc<T0, T1, T2, T3, T4, T5, T6, T7, T8, TResult> AsDebounce<T0, T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, TResult> func, TimeSpan delay) {
            var t = AsDebounce(((T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) argTuple) => func(argTuple.arg0, argTuple.arg1, argTuple.arg2, argTuple.arg3, argTuple.arg4, argTuple.arg5, argTuple.arg6, argTuple.arg7, argTuple.arg8), delay);
            return (T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, out TResult result) => {
                var isSuccess = t((arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8), out TResult _result);
                result = isSuccess ? _result : default;
                return isSuccess;
            };
        }

        public static TryFunc<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> AsDebounce<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func, TimeSpan delay) {
            var t = AsDebounce(((T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) argTuple) => func(argTuple.arg0, argTuple.arg1, argTuple.arg2, argTuple.arg3, argTuple.arg4, argTuple.arg5, argTuple.arg6, argTuple.arg7, argTuple.arg8, argTuple.arg9), delay);
            return (T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, out TResult result) => {
                var isSuccess = t((arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9), out TResult _result);
                result = isSuccess ? _result : default;
                return isSuccess;
            };
        }

        public static TryFunc<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> AsDebounce<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func, TimeSpan delay) {
            var t = AsDebounce(((T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) argTuple) => func(argTuple.arg0, argTuple.arg1, argTuple.arg2, argTuple.arg3, argTuple.arg4, argTuple.arg5, argTuple.arg6, argTuple.arg7, argTuple.arg8, argTuple.arg9, argTuple.arg10), delay);
            return (T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, out TResult result) => {
                var isSuccess = t((arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10), out TResult _result);
                result = isSuccess ? _result : default;
                return isSuccess;
            };
        }

        public static TryFunc<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> AsDebounce<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func, TimeSpan delay) {
            var t = AsDebounce(((T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) argTuple) => func(argTuple.arg0, argTuple.arg1, argTuple.arg2, argTuple.arg3, argTuple.arg4, argTuple.arg5, argTuple.arg6, argTuple.arg7, argTuple.arg8, argTuple.arg9, argTuple.arg10, argTuple.arg11), delay);
            return (T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, out TResult result) => {
                var isSuccess = t((arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11), out TResult _result);
                result = isSuccess ? _result : default;
                return isSuccess;
            };
        }

        public static TryFunc<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> AsDebounce<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func, TimeSpan delay) {
            var t = AsDebounce(((T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) argTuple) => func(argTuple.arg0, argTuple.arg1, argTuple.arg2, argTuple.arg3, argTuple.arg4, argTuple.arg5, argTuple.arg6, argTuple.arg7, argTuple.arg8, argTuple.arg9, argTuple.arg10, argTuple.arg11, argTuple.arg12), delay);
            return (T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, out TResult result) => {
                var isSuccess = t((arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12), out TResult _result);
                result = isSuccess ? _result : default;
                return isSuccess;
            };
        }

        public static TryFunc<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> AsDebounce<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func, TimeSpan delay) {
            var t = AsDebounce(((T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) argTuple) => func(argTuple.arg0, argTuple.arg1, argTuple.arg2, argTuple.arg3, argTuple.arg4, argTuple.arg5, argTuple.arg6, argTuple.arg7, argTuple.arg8, argTuple.arg9, argTuple.arg10, argTuple.arg11, argTuple.arg12, argTuple.arg13), delay);
            return (T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, out TResult result) => {
                var isSuccess = t((arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13), out TResult _result);
                result = isSuccess ? _result : default;
                return isSuccess;
            };
        }

        public static TryFunc<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> AsDebounce<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func, TimeSpan delay) {
            var t = AsDebounce(((T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) argTuple) => func(argTuple.arg0, argTuple.arg1, argTuple.arg2, argTuple.arg3, argTuple.arg4, argTuple.arg5, argTuple.arg6, argTuple.arg7, argTuple.arg8, argTuple.arg9, argTuple.arg10, argTuple.arg11, argTuple.arg12, argTuple.arg13, argTuple.arg14), delay);
            return (T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, out TResult result) => {
                var isSuccess = t((arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14), out TResult _result);
                result = isSuccess ? _result : default;
                return isSuccess;
            };
        }

        public static TryFunc<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> AsDebounce<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func, TimeSpan delay) {
            var t = AsDebounce(((T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) argTuple) => func(argTuple.arg0, argTuple.arg1, argTuple.arg2, argTuple.arg3, argTuple.arg4, argTuple.arg5, argTuple.arg6, argTuple.arg7, argTuple.arg8, argTuple.arg9, argTuple.arg10, argTuple.arg11, argTuple.arg12, argTuple.arg13, argTuple.arg14, argTuple.arg15), delay);
            return (T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, out TResult result) => {
                var isSuccess = t((arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15), out TResult _result);
                result = isSuccess ? _result : default;
                return isSuccess;
            };
        }

        #endregion More

        #endregion Func
    }
}