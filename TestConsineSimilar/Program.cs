using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

TestCosine();

static void TestCosine()
{
    int numVectors = 10000;
    int vectorSize = 2048;
    int topN = 10; // Số lượng vector giống nhất cần lấy ra

    // Tạo dữ liệu ngẫu nhiên (5000 vector, mỗi vector có 2048 phần tử)
    Random rand = new Random();
    double[][] data = new double[numVectors][];
    for (int i = 0; i < numVectors; i++)
    {
        data[i] = GenerateRandomVector(vectorSize, rand);
    }

    // Tạo query vector
    double[] query = GenerateRandomVector(vectorSize, rand);


    var t1 = Stopwatch.StartNew();
    // Tính toán Cosine Similarity cho từng vector
    double[] similarities = new double[numVectors];
    for (int i = 0; i < numVectors; i++)
    {
        similarities[i] = CosineSimilarity(data[i], query);
    }
    // Parallel.For(0, numVectors, new ParallelOptions
    // {
    //     MaxDegreeOfParallelism = 16
    // }, i =>
    // {
    //     similarities[i] = CosineSimilarity(data[i], query);
    // });

    // Lấy top-N vector giống nhất (sắp xếp giảm dần)
    int[] topNIndices = GetTopNSimilarVectors(similarities, topN);

    Console.WriteLine(t1.ElapsedMilliseconds);
    // In kết quả
    Console.WriteLine("Top " + topN + " vectors giống nhất:");
    for (int i = 0; i < topN; i++)
    {
        Console.WriteLine($"Index: {topNIndices[i]}, Similarity: {similarities[topNIndices[i]]:F4}");
    }
}
static double CosineSimilarity(double[] v1, double[] v2)
{
    double dotProduct = 0.0;
    double norm1 = 0.0;
    double norm2 = 0.0;

    for (int i = 0; i < v1.Length; i++)
    {
        dotProduct += v1[i] * v2[i];
        norm1 += v1[i] * v1[i];
        norm2 += v2[i] * v2[i];
    }

    return dotProduct / (Math.Sqrt(norm1) * Math.Sqrt(norm2));
}

// Hàm tạo vector ngẫu nhiên
static double[] GenerateRandomVector(int size, Random rand)
{
    double[] vector = new double[size];
    for (int i = 0; i < size; i++)
    {
        vector[i] = rand.NextDouble();
    }
    return vector;
}

// Hàm lấy top-N vector có độ tương đồng cao nhất
static int[] GetTopNSimilarVectors(double[] similarities, int topN)
{
    int[] indices = new int[similarities.Length];
    for (int i = 0; i < indices.Length; i++)
    {
        indices[i] = i;
    }

    // Sắp xếp giảm dần theo cosine similarity
    Array.Sort(indices, (a, b) => similarities[b].CompareTo(similarities[a]));

    // Trả về top-N index
    int[] topNIndices = new int[topN];
    Array.Copy(indices, topNIndices, topN);
    return topNIndices;
}

// Hàm tính Cosine Similarity
static double CosineSimilarity1(double[] v1, double[] v2)
{
    double dotProduct = v1.Zip(v2, (a, b) => a * b).Sum();
    double norm1 = Math.Sqrt(v1.Sum(a => a * a));
    double norm2 = Math.Sqrt(v2.Sum(b => b * b));
    return dotProduct / (norm1 * norm2);
}
