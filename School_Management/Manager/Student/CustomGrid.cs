using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Base.Handler;
using DevExpress.XtraGrid.Views.Base.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;

namespace School_Management.Manager.Student
{
    [ToolboxItem(true)]
    public class CustomGrid1 : GridControl
    {
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;

        protected override BaseView CreateDefaultView()
        {
            return CreateView("CustomCardView1");
        }

        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new CustomCardView1InfoRegistrator());
        }

        private void InitializeComponent()
        {
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this;
            this.gridView1.Name = "gridView1";
            // 
            // CustomGrid1
            // 
            this.MainView = this.gridView1;
            this.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }
    }

    public class CustomCardView1InfoRegistrator : CardInfoRegistrator
    {
        public override string ViewName => "CustomCardView1";

        public override BaseView CreateView(GridControl grid)
        {
            return new CustomCardView1(grid);
        }

        public override BaseViewInfo CreateViewInfo(BaseView view)
        {
            return new CustomCardView1Info(view as CustomCardView1);
        }

        public override BaseViewHandler CreateHandler(BaseView view)
        {
            return new CustomCardView1Handler(view as CustomCardView1);
        }

        public override BaseViewPainter CreatePainter(BaseView view)
        {
            return new CustomCardView1Painter(view as CustomCardView1);
        }
    }

    public class CustomCardView1 : DevExpress.XtraGrid.Views.Card.CardView
    {
        public CustomCardView1()
        {
        }

        public CustomCardView1(GridControl grid) : base(grid)
        {
        }

        protected override string ViewName => "CustomCardView1";
    }

    public class CustomCardView1Info : DevExpress.XtraGrid.Views.Card.ViewInfo.CardViewInfo
    {
        public CustomCardView1Info(DevExpress.XtraGrid.Views.Card.CardView view) : base(view)
        {
        }
    }

    public class CustomCardView1Handler : DevExpress.XtraGrid.Views.Card.Handler.CardHandler
    {
        public CustomCardView1Handler(DevExpress.XtraGrid.Views.Card.CardView view) : base(view)
        {
        }
    }

    public class CustomCardView1Painter : DevExpress.XtraGrid.Views.Card.Drawing.CardPainter
    {
        public CustomCardView1Painter(DevExpress.XtraGrid.Views.Card.CardView view) : base(view)
        {
        }
    }
}
