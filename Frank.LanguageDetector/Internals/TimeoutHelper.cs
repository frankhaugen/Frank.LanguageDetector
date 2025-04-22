namespace Frank.LanguageDetector.Internals;

public static class TimeoutHelper
{
    /// <summary>
    /// Executes a synchronous action with a specified timeout.
    /// </summary>
    /// <param name="action">The action to execute.</param>
    /// <param name="timeout">The maximum duration to wait for the action to complete.</param>
    /// <exception cref="ArgumentNullException">Thrown if the action is null.</exception>
    /// <exception cref="TimeoutException">Thrown if the action does not complete within the timeout.</exception>
    public static void ExecuteWithTimeout(Action action, TimeSpan timeout)
    {
        if (action == null)
            throw new ArgumentNullException(nameof(action));

        Task task = Task.Run(action);

        var completedInTime = task.Wait(timeout);
        if (!completedInTime)
        {
            throw new TimeoutException("The operation has timed out.");
        }
    }

    /// <summary>
    /// Executes a synchronous function with a specified timeout and returns its result.
    /// </summary>
    /// <typeparam name="T">The return type of the function.</typeparam>
    /// <param name="func">The function to execute.</param>
    /// <param name="timeout">The maximum duration to wait for the function to complete.</param>
    /// <returns>The result of the function.</returns>
    /// <exception cref="ArgumentNullException">Thrown if the function is null.</exception>
    /// <exception cref="TimeoutException">Thrown if the function does not complete within the timeout.</exception>
    public static T ExecuteWithTimeout<T>(Func<T> func, TimeSpan timeout)
    {
        if (func == null)
            throw new ArgumentNullException(nameof(func));

        var task = Task.Run(func);

        var completedInTime = task.Wait(timeout);
        if (!completedInTime)
        {
            throw new TimeoutException("The operation has timed out.");
        }

        // Ensure any exceptions/cancellations are observed
        return task.Result;
    }

    /// <summary>
    /// Executes a synchronous action with a specified timeout and supports cooperative cancellation.
    /// </summary>
    /// <param name="action">The action to execute.</param>
    /// <param name="timeout">The maximum duration to wait for the action to complete.</param>
    /// <param name="cancellationToken">A token to observe cancellation requests.</param>
    /// <exception cref="ArgumentNullException">Thrown if the action is null.</exception>
    /// <exception cref="TimeoutException">Thrown if the action does not complete within the timeout.</exception>
    /// <exception cref="OperationCanceledException">Thrown if cancellation is requested.</exception>
    public static void ExecuteWithTimeout(Action<CancellationToken> action, TimeSpan timeout, CancellationToken cancellationToken)
    {
        if (action == null)
            throw new ArgumentNullException(nameof(action));

        using (CancellationTokenSource cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken))
        {
            Task task = Task.Run(() => action(cts.Token), cts.Token);

            if (!task.Wait(timeout))
            {
                cts.Cancel(); // Request cancellation
                throw new TimeoutException("The operation has timed out and cancellation was requested.");
            }

            // If the task was canceled externally, propagate the cancellation
            task.Wait(cancellationToken);
        }
    }

    /// <summary>
    /// Executes a synchronous function with a specified timeout and supports cooperative cancellation.
    /// </summary>
    /// <typeparam name="T">The return type of the function.</typeparam>
    /// <param name="func">The function to execute.</param>
    /// <param name="timeout">The maximum duration to wait for the function to complete.</param>
    /// <param name="cancellationToken">A token to observe cancellation requests.</param>
    /// <returns>The result of the function.</returns>
    /// <exception cref="ArgumentNullException">Thrown if the function is null.</exception>
    /// <exception cref="TimeoutException">Thrown if the function does not complete within the timeout.</exception>
    /// <exception cref="OperationCanceledException">Thrown if cancellation is requested.</exception>
    public static T ExecuteWithTimeout<T>(Func<CancellationToken, T> func, TimeSpan timeout, CancellationToken cancellationToken)
    {
        if (func == null)
            throw new ArgumentNullException(nameof(func));

        using (CancellationTokenSource cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken))
        {
            var task = Task.Run(() => func(cts.Token), cts.Token);

            if (!task.Wait(timeout))
            {
                cts.Cancel(); // Request cancellation
                throw new TimeoutException("The operation has timed out and cancellation was requested.");
            }

            // If the task was canceled externally, propagate the cancellation
            return task.Result;
        }
    }
}