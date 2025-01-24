using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Documents;

namespace WSC.WebTextFinder.Behaviors;

public static class RichTextBoxBehavior {
    public static readonly DependencyProperty BindableDocumentProperty =
        DependencyProperty.RegisterAttached(
            "BindableDocument",
            typeof(ObservableCollection<Paragraph>),
            typeof(RichTextBoxBehavior),
            new PropertyMetadata(null, OnBindableDocumentChanged));

    public static void SetBindableDocument(DependencyObject obj, ObservableCollection<Paragraph> value) {
        obj.SetValue(BindableDocumentProperty, value);
    }

    public static ObservableCollection<Paragraph> GetBindableDocument(DependencyObject obj) {
        return (ObservableCollection<Paragraph>)obj.GetValue(BindableDocumentProperty);
    }

    private static void OnBindableDocumentChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) {
        if (d is RichTextBox richTextBox) {
            if (e.OldValue is ObservableCollection<Paragraph> oldCollection) {
                oldCollection.CollectionChanged -= (sender, args) => UpdateRichTextBox(richTextBox, sender as ObservableCollection<Paragraph>);
            }

            if (e.NewValue is ObservableCollection<Paragraph> newCollection) {
                newCollection.CollectionChanged += (sender, args) => UpdateRichTextBox(richTextBox, sender as ObservableCollection<Paragraph>);
                UpdateRichTextBox(richTextBox, newCollection);
            }
        }
    }

    private static void UpdateRichTextBox(RichTextBox richTextBox, ObservableCollection<Paragraph> collection) {
        if (collection == null) return;

        richTextBox.Document.Blocks.Clear();
        foreach (var paragraph in collection) {
            richTextBox.Document.Blocks.Add(paragraph);
        }
        richTextBox.ScrollToEnd();
    }
}
