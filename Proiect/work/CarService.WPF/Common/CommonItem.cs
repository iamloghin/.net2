namespace CarService.WPF.Common
{
    using System.Collections.Generic;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Media;

    public static class CommonItem
    {
        private static Frame mainPanelFrame = null;
        private static TextBlock mainTextBlock = null;
        public static IList<Page> PageInstent = new List<Page>();

        public static Frame SetFrame(ref Frame frame) => mainPanelFrame ?? (mainPanelFrame = frame);
        public static Frame GetFrame() => mainPanelFrame;

        public static TextBlock SetTextBox(ref TextBlock textBlock) => mainTextBlock ?? (mainTextBlock = textBlock);
        public static TextBlock GetTextBox() => mainTextBlock;

        public static IEnumerable<T> FindVisualChildren<T>(DependencyObject depObj) where T : DependencyObject
        {
            var objectsList = new List<T>();
            if (depObj == null) return objectsList;

            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(depObj); i++)
            {
                var child = VisualTreeHelper.GetChild(depObj, i);
                if (child is T dependencyObject)
                {
                    objectsList.Add(dependencyObject);
                }
                objectsList.AddRange(FindVisualChildren<T>(child));
            }
            return objectsList;
        }
    }
}
