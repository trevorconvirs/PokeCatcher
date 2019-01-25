
using System.Windows;

namespace PokeCatcher
{
    /// <summary>
    /// base class to run any animation method when a boolean is set to true, and a
    /// reverse animation when set to false
    /// </summary>
    /// <typeparam name="Parent"></typeparam>
    public abstract class AnimateBaseProperty<Parent> : BaseAttachedProperty<Parent, bool>
        where Parent: BaseAttachedProperty<Parent,bool>, new()
    {

        #region Public Properties

        /// <summary>
        /// flage indicating if this is the first time this property has been loaded
        /// </summary>
        public bool FirstLoad { get; set; } = true;
        #endregion

        public override void OnValueUpdated(DependencyObject sender, object value)
        {
            // Get the framework element
            if (!(sender is FrameworkElement element))
                return;

            // don't fire if the value does not change
            if (sender.GetValue(ValueProperty) == value && !FirstLoad)
                return;

            // on first load
            if (FirstLoad)
            {
                // create a single self-unhookable event for the elements loaded event
                RoutedEventHandler onLoaded = null;
                onLoaded = (ss, ee) =>
                {
                    element.Loaded -= onLoaded;

                    // do desired animation
                    DoAnimation(element, (bool)value);

                    // no longer in first load
                    FirstLoad = false;
                };

                element.Loaded += onLoaded;
            }
            else
            {
                // do desired animation
                DoAnimation(element, (bool)value);
            }
        }

        /// <summary>
        /// the animation method that is fired when the value changes
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        protected virtual void DoAnimation(FrameworkElement element, bool value)
        {

        }
    }

    /// <summary>
    /// Animates a framework element sliding it in from the left on show
    /// sliding out to the left on hide
    /// </summary>
    public class AnimateSlideInFromLeftProperty : AnimateBaseProperty<AnimateSlideInFromLeftProperty>
    {
        protected override void DoAnimation(FrameworkElement element, bool value)
        {
            if (value)
            {
                // Animate in
            }
            else
            {
                // Animate out
            }
        }
    }
}
