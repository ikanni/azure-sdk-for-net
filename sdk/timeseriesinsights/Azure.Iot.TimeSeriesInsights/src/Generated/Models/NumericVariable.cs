// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Iot.TimeSeriesInsights
{
    /// <summary> Numeric variable represents a single continuous numeric signal that can be reconstructed using interpolation. </summary>
    public partial class NumericVariable : TimeSeriesVariable
    {
        /// <summary> Initializes a new instance of NumericVariable. </summary>
        /// <param name="value"> Value time series expression is used to represent the value of the signal that is going to be aggregated or interpolated. For example, temperature values from the event is represented like this: &quot;$event.Temperature.Double&quot;. </param>
        /// <param name="aggregation"> Aggregation time series expression when kind is &quot;numeric&quot; is used to represent the aggregation that needs to be performed on the $value expression. This requires $value to be specified and can only use $value inside the aggregate functions. For example, aggregation for calculating minimum of the $value is written as: &quot;min($value)&quot;. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> or <paramref name="aggregation"/> is null. </exception>
        public NumericVariable(TimeSeriesExpression value, TimeSeriesExpression aggregation)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }
            if (aggregation == null)
            {
                throw new ArgumentNullException(nameof(aggregation));
            }

            Value = value;
            Aggregation = aggregation;
            Kind = "numeric";
        }

        /// <summary> Initializes a new instance of NumericVariable. </summary>
        /// <param name="kind"> Allowed &quot;kind&quot; values are - &quot;numeric&quot; or &quot;aggregate&quot;. While &quot;numeric&quot; allows you to specify value of the reconstructed signal and the expression to aggregate them, the &quot;aggregate&quot; kind lets you directly aggregate on the event properties without specifying value. </param>
        /// <param name="filter"> Filter over the events that restricts the number of events being considered for computation. Example: &quot;$event.Status.String=&apos;Good&apos;&quot;. Optional. </param>
        /// <param name="value"> Value time series expression is used to represent the value of the signal that is going to be aggregated or interpolated. For example, temperature values from the event is represented like this: &quot;$event.Temperature.Double&quot;. </param>
        /// <param name="interpolation"> The interpolation operation to be performed on the raw data points. Currently, only sampling of interpolated time series is allowed. Allowed aggregate function - eg: left($value). Can be null if no interpolation needs to be applied. </param>
        /// <param name="aggregation"> Aggregation time series expression when kind is &quot;numeric&quot; is used to represent the aggregation that needs to be performed on the $value expression. This requires $value to be specified and can only use $value inside the aggregate functions. For example, aggregation for calculating minimum of the $value is written as: &quot;min($value)&quot;. </param>
        internal NumericVariable(string kind, TimeSeriesExpression filter, TimeSeriesExpression value, InterpolationOperation interpolation, TimeSeriesExpression aggregation) : base(kind, filter)
        {
            Value = value;
            Interpolation = interpolation;
            Aggregation = aggregation;
            Kind = kind ?? "numeric";
        }

        /// <summary> Value time series expression is used to represent the value of the signal that is going to be aggregated or interpolated. For example, temperature values from the event is represented like this: &quot;$event.Temperature.Double&quot;. </summary>
        public TimeSeriesExpression Value { get; set; }
        /// <summary> The interpolation operation to be performed on the raw data points. Currently, only sampling of interpolated time series is allowed. Allowed aggregate function - eg: left($value). Can be null if no interpolation needs to be applied. </summary>
        public InterpolationOperation Interpolation { get; set; }
        /// <summary> Aggregation time series expression when kind is &quot;numeric&quot; is used to represent the aggregation that needs to be performed on the $value expression. This requires $value to be specified and can only use $value inside the aggregate functions. For example, aggregation for calculating minimum of the $value is written as: &quot;min($value)&quot;. </summary>
        public TimeSeriesExpression Aggregation { get; set; }
    }
}
