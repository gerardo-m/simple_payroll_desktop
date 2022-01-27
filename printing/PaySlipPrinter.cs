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
        private Font boldFont;
        private StringFormat centeredText;
        private StringFormat leftText;
        private StringFormat rightText;

        private float leftMargin;
        private float topMargin;
        private float height;
        private float width;
        private float currentYPosition;
        private Graphics drawer;

        private int copyCount;
        private int currentCopy;
        private bool pageHasSpace;

        public PaySlipPrinter(PaySlip paySlip, int copyCount = 2)
        {
            this.paySlip = paySlip;
            mainFontSize = 10;
            mainFont = new Font("Arial", mainFontSize);
            mainBrush = Brushes.Black;
            mainPen = Pens.Black;
            boldFont = new Font("Arial", mainFontSize, FontStyle.Bold);
            centeredText = new StringFormat();
            centeredText.Alignment = StringAlignment.Center;
            leftText = new StringFormat();
            leftText.Alignment = StringAlignment.Near;
            leftText.LineAlignment = StringAlignment.Center;
            rightText = new StringFormat();
            rightText.Alignment = StringAlignment.Far;
            rightText.LineAlignment = StringAlignment.Center;
            this.copyCount = copyCount;
            currentCopy = 0;
            pageHasSpace = true;
        }

        public PrintDocument buildDocument()
        {
            PrintDocument document = new PrintDocument();
            document.PrintPage += new PrintPageEventHandler(printPageEventHandler);
            return document;
        }

        public void printPageEventHandler(object sender, PrintPageEventArgs eventArgs)
        {
            pageHasSpace = true;
            setupInitialValues(eventArgs);
            while(currentCopy < copyCount)
                if (pageHasSpace)
                    printCopy();
                else
                {
                    eventArgs.HasMorePages = true;
                    return;
                }
        }

        private void setupInitialValues(PrintPageEventArgs eventArgs)
        {
            leftMargin = eventArgs.MarginBounds.Left;
            topMargin = eventArgs.MarginBounds.Top;
            height = eventArgs.MarginBounds.Height;
            width = eventArgs.MarginBounds.Width;
            currentYPosition = topMargin;
            drawer = eventArgs.Graphics;
        }

        private void printCopy()
        {
            drawHeader();
            drawWorkerData();
            drawTable();
            float signatureYPosition = getPageSignatureYPosition(SignaturesPosition.Middle);
            SignaturesPosition signaturesPosition;
            if (currentYPosition >= signatureYPosition)
            {
                signaturesPosition = SignaturesPosition.Bottom;
                pageHasSpace = false;
            }
            else
            {
                signaturesPosition = SignaturesPosition.Middle;
                currentYPosition = topMargin + (height / 2) + mainFont.GetHeight();
            }
            drawSignatureLines(signaturesPosition);
            currentCopy++;
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
            string workerData = $"{paySlip.Payroll.Worker.Denomination.Name}: {paySlip.WorkerFullName} - {paySlip.WorkerCI}";
            drawer.DrawString(workerData, mainFont, mainBrush, rectangle, leftText);
            currentYPosition += mainFont.GetHeight() * 2;
        }

        private void drawTable()
        {
            // TODO add localization
            RectangleF rectangle = new RectangleF(leftMargin, currentYPosition, width, mainFont.GetHeight() * 2);
            drawer.DrawLine(mainPen, rectangle.X, rectangle.Y, rectangle.X + rectangle.Width, rectangle.Y);
            drawer.DrawLine(mainPen, rectangle.X, rectangle.Y + rectangle.Height, rectangle.X + rectangle.Width, rectangle.Y + rectangle.Height);
            drawer.DrawString("Concepto", mainFont, mainBrush, rectangle, leftText);
            drawer.DrawString("Monto", mainFont, mainBrush, rectangle, rightText);
            currentYPosition += mainFont.GetHeight() * 3;

            drawDetailRow(paySlip.TrackedWorkConcept, paySlip.TrackedWorkAmount, mainFont);

            drawExtras();

            rectangle = new RectangleF(leftMargin, currentYPosition, width, mainFont.GetHeight() * 2);
            drawer.DrawLine(mainPen, rectangle.X, rectangle.Y, rectangle.X + rectangle.Width, rectangle.Y);
            drawer.DrawLine(mainPen, rectangle.X, rectangle.Y + rectangle.Height, rectangle.X + rectangle.Width, rectangle.Y + rectangle.Height);

            drawDetailRow("Total", paySlip.PayrollTotal, mainFont , 2);
            currentYPosition += mainFont.GetHeight();
            drawDetailRow("Pagado previamente", paySlip.PreviouslyPaid, mainFont );
            drawDetailRow("A pagar", paySlip.Amount, boldFont);
            drawDetailRow("Saldo", paySlip.ToBePaid, mainFont);

            // TODO print Total row
        }

        private void drawExtras()
        {
            foreach (Extra extra in paySlip.Extras)
                drawDetailRow(extra.Concept, extra.Amount, mainFont);
        }

        private void drawDetailRow(string concept, decimal amount, Font font, int heightRate = 1)
        {
            RectangleF rectangle = new RectangleF(leftMargin, currentYPosition, width, font.GetHeight() * heightRate);
            drawer.DrawString(concept, font, mainBrush, rectangle, leftText);
            drawer.DrawString(amount.ToString("#0.00"), font, mainBrush, rectangle, rightText);
            currentYPosition += font.GetHeight() * 2;
        }

        private void drawSignatureLines(SignaturesPosition position)
        {
            int lineSize = 150;
            float yPosition = getPageSignatureYPosition(position);
            RectangleF rectangle = new RectangleF(leftMargin, yPosition, lineSize, mainFont.GetHeight());
            drawer.DrawLine(mainPen, rectangle.X, rectangle.Y, rectangle.X + lineSize, rectangle.Y);
            drawer.DrawString("RECIBIDO", mainFont, mainBrush, rectangle, centeredText);
            rectangle = new RectangleF(leftMargin + width - lineSize, yPosition, lineSize, mainFont.GetHeight());
            drawer.DrawLine(mainPen, rectangle.X, rectangle.Y, rectangle.X + lineSize, rectangle.Y);
            drawer.DrawString("ENTREGADO POR", mainFont, mainBrush, rectangle, centeredText);
        }

        private float getPageSignatureYPosition(SignaturesPosition position)
        {
            if (position == SignaturesPosition.Middle)
                return topMargin + (height / 2) - mainFont.GetHeight() * 3;
            else
                return topMargin + height - mainFont.GetHeight();
        }
    }
}
