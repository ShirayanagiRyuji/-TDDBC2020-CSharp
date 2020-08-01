using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using TDDBC2020;

namespace UnitTestProject_TDDBC2020
{
    /// <summary>
    /// TDDBC2020 自動テスト
    /// </summary>
    [TestClass]
    public class RangeTest
    {
        [TestMethod]
        public void パラメータに整数1と整数2を指定して整数閉区間のオブジェクトのインスタンスが取得できる()
        {
            // 準備
            // 実行
            TDDBC2020.Range range = new TDDBC2020.Range(1, 2);
            // 検証
            Assert.IsNotNull(range);
            // 後処理
        }

        /// <remarks>
        /// 指定の書式："[下端点,上端点]"
        /// </remarks>
        [DataTestMethod()]
        [DataRow("[1,2]", 1, 2)]
        [DataRow("[0,999]", 0, 999)]
        [DataRow("[-999,0]", -999, 0)]
        public void 文字列表現を指定の書式形式で返せる(string expected,int lower, int upper)
        {
            // 準備
            TDDBC2020.Range range = new TDDBC2020.Range(lower, upper);
            // 実行
            // 検証
            Assert.AreEqual(expected, range.ToString());
            // 後処理
        }

        /// <remarks>
        /// 発生例外：ArgumentException
        /// </remarks>
        [TestMethod]
        public void 下端点0上端点999で整数閉区間のオブジェクトを作成すると例外が発生しない()
        {
            // 準備
            try
            {
                // 実行
                TDDBC2020.Range range = new TDDBC2020.Range(0, 999);
            }
            catch(ArgumentException)
            {
                // 検証
                Assert.Fail();
            }
            // 後処理
        }

        /// <remarks>
        /// 発生例外：ArgumentException
        /// </remarks>
        [TestMethod]
        public void 下端点マイナス999上端点0で整数閉区間のオブジェクトを作成すると例外が発生しない()
        {
            // 準備
            try
            {
                // 実行
                TDDBC2020.Range range = new TDDBC2020.Range(-999, 0);
            }
            catch (ArgumentException)
            {
                // 検証
                Assert.Fail();
            }
            // 後処理
        }

        /// <remarks>
        /// 発生例外：ArgumentException
        /// </remarks>
        [DataTestMethod()]
        [DataRow(0,999)]
        [DataRow(-999,0)]
        public void 上端点より下端点が小さい場合例外Exceptionが発生しない()
        {
            // 準備
            try
            {
                // 実行
                TDDBC2020.Range range = new TDDBC2020.Range(-999, 0);
            }
            catch (ArgumentException)
            {
                // 検証
                Assert.Fail();
            }
            // 後処理
        }
    }
}
