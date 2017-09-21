namespace WpfTreeView
{
    public class DirectoryItem
    {

        public DirectoryItemType Type { get; set; }
        public string FullPath { get; set; }
        public string Name { get { return Type == DirectoryItemType.Drive ? FullPath : DirectoryStructure.GetFileFolderName(FullPath); }}
    }
}
