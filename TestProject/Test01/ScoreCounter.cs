using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore(filePath);
        }


        //成績データを読み込み、Studentオブジェクトのリストを返す 
        private static IEnumerable<Student> ReadScore(string filePath) {
            var students = new List<Student>();    //学生データを格納する
            var lines = File.ReadAllLines(filePath);   //ファイルからすべてのデータを読み込む

            foreach (var line in lines)  //すべての行から一行ずつ取り出す
            {
                var items = line.Split(',');   //区切りで項目別に分ける
                var student = new Student    //Studentインスタンスを生成
                {
                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2])
                };
                students.Add(student);    //Studentインスタンスをコレクションに追加
            }

            return students;
        }

        //科目別の点数の集計を求める
        public IDictionary<string, int> GetPerStudentScore() {
            var dict = new SortedDictionary<string, int>();
            foreach (var student in _score) {
                if (dict.ContainsKey(student.Subject))
                    dict[student.Subject] += student.Score; //科目名が既に存在する（加算）
                else
                    dict[student.Subject] = student.Score;  //科目名が存在しない（新規格納）
            }
            return dict;
        }
    }
}
