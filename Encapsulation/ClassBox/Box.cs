namespace ClassBox
{
    using System.Text;
    using System;

    public class Box
    {
        private double lenght;
        private double width;
        private double height;

        public Box(double boxLenght, double boxWidth, double boxHeight)
        {
            this.Lenght = boxLenght;
            this.Width = boxWidth;
            this.Height = boxHeight;
        }

        public double Lenght
        {
            get => this.lenght;
            private set
            {
                if (ValidateData(value))
                {
                    this.lenght = value;
                }
                else
                {
                    throw new ArgumentException($"Length cannot be zero or negative.");
                }
            }
        }

        public double Width
        {
            get => this.width;
            private set
            {
                if (ValidateData(value))
                {
                    this.width = value;
                }
                else
                {
                    throw new ArgumentException($"Width cannot be zero or negative.");
                }
            }
        }

        public double Height
        {
            get => this.height;
            private set
            {
                if (ValidateData(value))
                {
                    this.height = value;
                }
                else
                {
                    throw new ArgumentException($"Height cannot be zero or negative.");
                }
            }
        }

        private bool ValidateData(double value)
        {
            if (value <= 0)
            {
                return false;
            }

            return true;
        }

        private double GetSurfaceArea()
        {
            double surfaceArea =
                2 * (this.lenght * this.width) +
                2 * (this.lenght * this.height) +
                2 * (this.width * this.height);

            return surfaceArea;
        }

        private double GetLateralSurfaceArea()
        {
            double lateralSurfaceArea =
                2 * (this.lenght * this.height) +
                2 * (this.width * this.height);

            return lateralSurfaceArea;
        }

        private double GetVolume()
        {
            double volume = this.lenght * this.width * this.height;

            return volume;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"Surface Area - {this.GetSurfaceArea():f2}");
            result.AppendLine($"Lateral Surface Area - {this.GetLateralSurfaceArea():f2}");
            result.Append($"Volume - {this.GetVolume():f2}");

            return result.ToString();
        }
    }
}
