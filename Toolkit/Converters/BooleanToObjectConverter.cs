﻿using System;
using System.Globalization;
using Xamarin.Forms;

namespace Xamarin.Toolkit.Converters
{
    /// <summary>
    /// Boolean to object converter.
    /// </summary>
    public class BooleanToObjectConverter<T> : IValueConverter
    {
        public static BooleanToObjectConverter<T> Instance { get; } = new BooleanToObjectConverter<T>();

        /// <summary>
        /// Init this instance.
        /// </summary>
        public static void Init()
        {
            var time = DateTime.UtcNow;
        }

        /// <summary>
        /// Gets or sets the false object.
        /// </summary>
        /// <value>The false object.</value>
        public T FalseObject { get; set; }

        /// <summary>
        /// Gets or sets the true object.
        /// </summary>
        /// <value>The true object.</value>
        public T TrueObject { get; set; }

        /// <param name="value">To be added.</param>
        /// <param name="targetType">To be added.</param>
        /// <param name="parameter">To be added.</param>
        /// <param name="culture">To be added.</param>
        /// <summary>
        /// Convert the specified value, targetType, parameter and culture.
        /// </summary>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) =>
            (bool)value ? TrueObject : FalseObject;

        /// <param name="value">To be added.</param>
        /// <param name="targetType">To be added.</param>
        /// <param name="parameter">To be added.</param>
        /// <param name="culture">To be added.</param>
        /// <summary>
        /// Converts the back.
        /// </summary>
        /// <returns>The back.</returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) =>
            ((T)value).Equals(TrueObject);
    }
}
