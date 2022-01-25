using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;
using simple_payroll_desktop.entities;
using System.Drawing;

namespace simple_payroll_desktop.printing
{

    public enum SignaturesPosition
    {
        Middle,
        Bottom
    }
    public class PaySlipPrinter
    {

        private PaySlip paySlip;

        private Font mainFont;
        private int mainFontSize;
        private Brush mainBrush;
        private Pen mainPen;
        private StringFormat centeredText;
        private StringFormat leftText;
        private StringFormat rightText;

        private float leftMargin;
        private float topMargin;
        private float height;
        private float width;
        private float currentYPosition;
        private Graphics drawer;

        public PaySlipPrinter(PaySlip paySlip)
        {
            this.paySlip = paySlip;
            mainFontSize = 10;
            mainFont = new Font("Arial", mainFontSize);
            mainBrush = Brushes.Black;
            mainPen = Pens.Black;
            centeredText = new StringFormat();
            centeredText.Alignment = StringAlignment.Center;
            leftText = new StringFormat();
            leftText.Alignment = StringAlignment.Near;
            leftText.LineAlignment = StringAlignment.Center;
            rightText = new StringFormat();
            rightText.Alignment = StringAlignment.Far;
            rightText.LineAlignment = StringAlignment.Center;
        }

        public PrintDocument buildDocument()
        {
            PrintDocument document = new PrintDocument();
            document.PrintPage += new PrintPageEventHandler(printPageEventHandler);
            return document;
        }

        public void printPageEventHandler(object sender, PrintPageEventArgs eventArgs)
        {
            leftMargin = eventArgs.MarginBounds.Left;
            topMargin = eventArgs.MarginBounds.Top;
            height = eventArgs.MarginBounds.Height;
            width = eventArgs.MarginBounds.Width;
            currentYPosition = topMargin;
            drawer = eventArgs.Graphics;
            drawHeader();
            drawWorkerData();
            drawTable();
            drawSignatureLines(SignaturesPosition.Middle);
        }

        private void drawHeader()
        {
            // TODO put the name of the company in  preferences and actual date
            RectangleF rectangle = new RectangleF(leftMargin, currentYPosition, width, mainFont.GetHeight());
            drawer.DrawString("TRAMEM", mainFont, mainBrush, rectangle, centeredText);
            drawer.DrawString("04/01/2022", mainFont, mainBrush, rectangle, leftText);
            paySlip.Id = 10; // TODO remove this
            drawer.DrawString(paySlip.Id.ToString("000000"), mainFont, mainBrush, rectangle, rightText);
            currentYPosition += mainFont.GetHeight() * 2;
        }

        private void drawWorkerData()
        {
            // TODO add the denomination
            RectangleF rectangle = new RectangleF(leftMargin, currentYPosition, width, mainFont.GetHeight());
            string workerData = $"Worker: {paySlip.WorkerFullName} - {paySlip.WorkerCI}";
            drawer.DrawString(workerData, mainFont, mainBrush, rectangle, leftText);
            currentYPosition += mainFont.GetHeight() * 2;
        }

        private void drawTable()
        {
            // TODO add localization
            RectangleF rectangle = new RectangleF(leftMargin, currentYPosition, width, mainFont.GetHeight() * 2);
            drawer.DrawLine(mainPen, rectangle.X, rectangle.Y, rectangle.X + rectangle.Width, rectangle.Y);
            drawer.DrawLine(mainPen, rectangle.X, rectangle.Y + rectangle.Height, rectangle.X + rectangle.Width, rectangle.Y + rectangle.Height);
            drawer.DrawString("Concept", mainFont, mainBrush, rectangle, leftText);
            drawer.DrawString("Amount", mainFont, mainBrush, rectangle, rightText);
            currentYPosition += mainFont.GetHeight() * 4;

            drawDetailRow(paySlip.TrackedWorkConcept, paySlip.TrackedWorkAmount);

            drawExtras();

            rectangle = new RectangleF(leftMargin, currentYPosition, width, mainFont.GetHeight() * 2);
            drawer.DrawLine(mainPen, rectangle.X, rectangle.Y, rectangle.X + rectangle.Width, rectangle.Y);
            drawer.DrawLine(mainPen, rectangle.X, rectangle.Y + rectangle.Height, rectangle.X + rectangle.Width, rectangle.Y + rectangle.Height);

            drawDetailRow("Total", paySlip.PayrollTotal);
            drawDetailRow("Pagado previamente", paySlip.PreviouslyPaid);
            drawDetailRow("A pagar", paySlip.Amount);
            drawDetailRow("Saldo", paySlip.ToBePaid);

            // TODO print Total row
        }

        private void drawExtras()
        {
            foreach (Extra extra in paySlip.Extras)
                drawDetailRow(extra.Concept, extra.Amount);
        }

        private void drawDetailRow(string concept, decimal amount)
        {
            RectangleF rectangle = new RectangleF(leftMargin, currentYPosition, width, mainFont.GetHeight());
            drawer.DrawString(concept, mainFont, mainBrush, rectangle, leftText);
            drawer.DrawString(amount.ToString("#,00"), mainFont, mainBrush, rectangle, rightText);
            currentYPosition += mainFont.GetHeight() * 2;
        }

        private void drawSignatureLines(SignaturesPosition position)
        {
            // TODO USE the position argument
            int lineSize = 150;
            float yPosition = topMargin + (height / 2) - mainFont.GetHeight() * 3;
            RectangleF rectangle = new RectangleF(leftMargin, yPosition, lineSize, mainFont.GetHeight());
            drawer.DrawLine(mainPen, rectangle.X, rectangle.Y, rectangle.X + lineSize, rectangle.Y);
            drawer.DrawString("RECIBIDO", mainFont, mainBrush, rectangle, centeredText);
            rectangle = new RectangleF(leftMargin + width - lineSize, yPosition, lineSize, mainFont.GetHeight());
            drawer.DrawLine(mainPen, rectangle.X, rectangle.Y, rectangle.X + lineSize, rectangle.Y);
            drawer.DrawString("ENTREGADO POR", mainFont, mainBrush, rectangle, centeredText);
        }
    }
}
