namespace CarService.WPF.Common
{
    using System.Windows.Controls;

    public static class CommonItem
    {
        private static Frame mainPanelFrame = null;
        private static TextBlock mainTextBlock = null;

        public static Frame SetFrame(ref Frame frame) => mainPanelFrame ?? (mainPanelFrame = frame);
        public static Frame GetFrame() => mainPanelFrame;

        public static TextBlock SetTextBox(ref TextBlock textBlock) => mainTextBlock ?? (mainTextBlock = textBlock);
        public static TextBlock GetTextBox() => mainTextBlock;
    }
}
