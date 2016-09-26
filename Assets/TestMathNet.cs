using UnityEngine;
using System.Collections;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

public class TestMathNet : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Matrix<double> A = DenseMatrix.OfArray(new double[,] {
                                                                    {1,1,1,1},
                                                                    {1,2,3,4},
                                                                    {4,3,2,1}});
        Debug.Log("Mat: " + A);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
