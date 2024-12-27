using MathNet.Numerics.LinearRegression;

double[] studyHours = new double[] { 5, 10, 15, 20, 25, 30, 35 };
double[] examScores = new double[] { 50, 60, 70, 80, 85, 90, 95 };
double[][] inputMatrix = new double[studyHours.Length][];
for (int i = 0; i < studyHours.Length; i++)
{
    inputMatrix[i] = new double[] { 1.0, studyHours[i] };

}
var parameters = MultipleRegression.QR(inputMatrix, examScores, false);
double intercepto = parameters[0];
double slope = parameters[1];
double prediccionScore = slope * 18 + intercepto;
Console.WriteLine($"El puntaje para un estudiante que estudia 18 horas por semana es {prediccionScore}");
