﻿using System.Windows.Forms;

namespace PhotoRenamer.Components
{
    interface ISpannedCell
    {
        int ColumnSpan { get; }
        int RowSpan { get; }
        DataGridViewCell OwnerCell { get; }
    }
}
