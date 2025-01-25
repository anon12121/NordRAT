using System;
using System.Collections;
using System.Windows.Forms;

namespace Server.Helper
{
	// Token: 0x02000039 RID: 57
	public class ListViewColumnSorter : IComparer
	{
		// Token: 0x0600018F RID: 399 RVA: 0x0000EAE9 File Offset: 0x0000CCE9
		public ListViewColumnSorter()
		{
			this.ColumnToSort = 0;
			this.OrderOfSort = SortOrder.None;
			this.ObjectCompare = new CaseInsensitiveComparer();
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0000EB0C File Offset: 0x0000CD0C
		public int Compare(object x, object y)
		{
			ListViewItem listViewItem = (ListViewItem)x;
			ListViewItem listViewItem2 = (ListViewItem)y;
			int num = this.ObjectCompare.Compare(listViewItem.SubItems[this.ColumnToSort].Text, listViewItem2.SubItems[this.ColumnToSort].Text);
			if (this.OrderOfSort == SortOrder.Ascending)
			{
				return num;
			}
			if (this.OrderOfSort == SortOrder.Descending)
			{
				return -num;
			}
			return 0;
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000192 RID: 402 RVA: 0x0000EB80 File Offset: 0x0000CD80
		// (set) Token: 0x06000191 RID: 401 RVA: 0x0000EB77 File Offset: 0x0000CD77
		public int SortColumn
		{
			get
			{
				return this.ColumnToSort;
			}
			set
			{
				this.ColumnToSort = value;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000194 RID: 404 RVA: 0x0000EB91 File Offset: 0x0000CD91
		// (set) Token: 0x06000193 RID: 403 RVA: 0x0000EB88 File Offset: 0x0000CD88
		public SortOrder Order
		{
			get
			{
				return this.OrderOfSort;
			}
			set
			{
				this.OrderOfSort = value;
			}
		}

		// Token: 0x04000122 RID: 290
		private int ColumnToSort;

		// Token: 0x04000123 RID: 291
		private SortOrder OrderOfSort;

		// Token: 0x04000124 RID: 292
		private CaseInsensitiveComparer ObjectCompare;
	}
}
