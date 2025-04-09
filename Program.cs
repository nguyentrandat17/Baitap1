//Bài 1: Viết một hàm để tính tổng của tất cả các số chẵn trong một mảng.
int TinhTongChan(int[] arr)
{
    int tong = 0;
    foreach (int x in arr)
    {
        if (x % 2 == 0)
            tong += x;
    }
    return tong;
}

//Bài 2: Viết chương trình nhập vào mảng gồm n phần tử nhập từ bàn phím. Viết hàm để kiểm
//tra xem một số có phải là số nguyên tố hay không, hiển thị chỉ số và giá trị của những phần tử
//là số nguyên tố trong mảng.
bool LaSoNguyenTo(int n)
{
    if (n < 2) return false;
    for (int i = 2; i <= Math.Sqrt(n); i++)
    {
        if (n % i == 0)
            return false;
    }
    return true;
}

void InSoNguyenTo(int[] arr)
{
    Console.WriteLine("Các số nguyên tố trong mảng:");
    for (int i = 0; i < arr.Length; i++)
    {
        if (LaSoNguyenTo(arr[i]))
            Console.WriteLine($"Chỉ số: {i}, Giá trị: {arr[i]}");
    }
}

//Bài 3: Viết một hàm để đếm số lượng số âm và số dương trong một mảng gồm n phần tử nhập
//từ bàn phím.
void DemSoAmDuong(int[] arr, out int soAm, out int soDuong)
{
    soAm = 0;
    soDuong = 0;
    foreach (int x in arr)
    {
        if (x < 0) soAm++;
        else if (x > 0) soDuong++;
    }
}

//Bài 4: Viết hàm để tìm số lớn thứ hai trong một mảng các số nguyên.
int TimSoLonThuHai(int[] arr)
{
    int max = int.MinValue;
    int secondMax = int.MinValue;

    foreach (int x in arr)
    {
        if (x > max)
        {
            secondMax = max;
            max = x;
        }
        else if (x > secondMax && x < max)
        {
            secondMax = x;
        }
    }

    return secondMax;
}

//Bài 5: Viết hàm hoán vị 2 số nguyên a và b nhập từ bàn phím.
void HoanVi(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}

//Bài 6: Viết hàm sắp xếp mảng số thực n phần tử nhập từ bàn phím theo chiều tăng dần.
void SapXepTangDan(double[] arr)
{
    Array.Sort(arr); // Cách đơn giản nhất
}
