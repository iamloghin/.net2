namespace CarService.Common
{
    /// <summary>
    /// Class ValidationResponse.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ValidationResponse<T>
    {
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ValidationResponse{T}"/> is successful.
        /// </summary>
        /// <value><c>true</c> if successful; otherwise, <c>false</c>.</value>
        public bool Successful { get; set; }
        /// <summary>
        /// Gets or sets the information.
        /// </summary>
        /// <value>The information.</value>
        public T Information { get; set; }
    }
}
