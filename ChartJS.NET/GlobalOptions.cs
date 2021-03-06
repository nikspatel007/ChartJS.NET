﻿using ChartJS.NET.Infrastructure;
using ChartJS.NET.Models;

namespace ChartJS.NET
{
    public class GlobalOptions
    {
        /// <summary>
        ///     Whether to animate the chart
        /// </summary>
        public bool? Animate { get; set; }

        /// <summary>
        ///     Number of animation steps
        /// </summary>
        public int? AnimationSteps { get; set; }

        /// <summary>
        ///     Animation easing effect;
        ///     Possible effects are:
        ///     easeInOutQuart, linear, easeOutBounce, easeInBack, easeInOutQuad,
        ///     easeOutQuart, easeOutQuad, easeInOutBounce, easeOutSine, easeInOutCubic,
        ///     easeInExpo, easeInOutBack, easeInCirc, easeInOutElastic, easeOutBack,
        ///     easeInQuad, easeInOutExpo, easeInQuart, easeOutQuint, easeInOutCirc,
        ///     easeInSine, easeOutExpo, easeOutCirc, easeOutCubic, easeInQuint,
        ///     easeInElastic, easeInOutSine, easeInOutQuint, easeInBounce,
        ///     easeOutElastic, easeInCubic
        /// </summary>
        public Enums.AnimationEasing AnimationEasing { get; set; }

        /// <summary>
        ///     Show the scale
        /// </summary>
        public bool? ShowScale { get; set; }

        /// <summary>
        ///     Add hardcoded scale
        /// </summary>
        public bool? ScaleOverride { get; set; }

        /// <summary>
        ///     The number of steps in hard coded scale; applies if ScaleOverride is set to true
        /// </summary>
        public double? scaleSteps { get; set; }

        /// <summary>
        ///     The value jump in a hard coded scale; applies if ScaleOverride is set to true
        /// </summary>
        public double? scaleStepWidth { get; set; }

        /// <summary>
        ///     The scale start value in a hard coded scale; applies if ScaleOverride is set to true
        /// </summary>
        public double? scaleStartValue { get; set; }

        /// <summary>
        ///     Whether or not the chart is responsive and resizes with the browser size
        /// </summary>
        public bool? Responsive { get; set; }

        /// <summary>
        ///     Whether to maintain the starting aspect ratio or not when responsive;
        ///     if set to false, will take up entire container
        /// </summary>
        public bool? MaintainAspectRatio { get; set; }

        /// <summary>
        ///     Whether or not to draw tooltips on the canvas or not
        /// </summary>
        public bool? ShowToolTips { get; set; }

        /// <summary>
        ///     Whether or not to execute the customToolTips function instead of drawing the default tooltips
        /// </summary>
        public bool? ShowCustomToolTips { get; set; }

        /// <summary>
        ///     Properties if Custom Tool Tips are to be used
        /// </summary>
        public CustomToolTip CustomToolTipOptions { get; set; }

        /// <summary>
        ///     Function that will fire on animation progression
        /// </summary>
        public string OnAnimationProgress { get; set; }

        /// <summary>
        ///     Function that will fire on animation completion
        /// </summary>
        public string OnAnimationComplete { get; set; }

        /// <summary>
        ///     HTML template for the legend
        /// </summary>
        public string LegendTemplate { get; set; }
    }
}