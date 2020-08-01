using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using TDDBC2020;

namespace UnitTestProject_TDDBC2020
{
    /// <summary>
    /// TDDBC2020 �����e�X�g
    /// </summary>
    [TestClass]
    public class RangeTest
    {
        [TestMethod]
        public void �p�����[�^�ɐ���1�Ɛ���2���w�肵�Đ�����Ԃ̃I�u�W�F�N�g�̃C���X�^���X���擾�ł���()
        {
            // ����
            // ���s
            TDDBC2020.Range range = new TDDBC2020.Range(1, 2);
            // ����
            Assert.IsNotNull(range);
            // �㏈��
        }

        /// <remarks>
        /// �w��̏����F"[���[�_,��[�_]"
        /// </remarks>
        [DataTestMethod()]
        [DataRow("[1,2]", 1, 2)]
        [DataRow("[0,999]", 0, 999)]
        [DataRow("[-999,0]", -999, 0)]
        public void ������\�����w��̏����`���ŕԂ���(string expected,int lower, int upper)
        {
            // ����
            TDDBC2020.Range range = new TDDBC2020.Range(lower, upper);
            // ���s
            // ����
            Assert.AreEqual(expected, range.ToString());
            // �㏈��
        }

        /// <remarks>
        /// ������O�FArgumentException
        /// </remarks>
        [TestMethod]
        public void ���[�_0��[�_999�Ő�����Ԃ̃I�u�W�F�N�g���쐬����Ɨ�O���������Ȃ�()
        {
            // ����
            try
            {
                // ���s
                TDDBC2020.Range range = new TDDBC2020.Range(0, 999);
            }
            catch(ArgumentException)
            {
                // ����
                Assert.Fail();
            }
            // �㏈��
        }

        /// <remarks>
        /// ������O�FArgumentException
        /// </remarks>
        [TestMethod]
        public void ���[�_�}�C�i�X999��[�_0�Ő�����Ԃ̃I�u�W�F�N�g���쐬����Ɨ�O���������Ȃ�()
        {
            // ����
            try
            {
                // ���s
                TDDBC2020.Range range = new TDDBC2020.Range(-999, 0);
            }
            catch (ArgumentException)
            {
                // ����
                Assert.Fail();
            }
            // �㏈��
        }

        /// <remarks>
        /// ������O�FArgumentException
        /// </remarks>
        [DataTestMethod()]
        [DataRow(0,999)]
        [DataRow(-999,0)]
        public void ��[�_��艺�[�_���������ꍇ��OException���������Ȃ�()
        {
            // ����
            try
            {
                // ���s
                TDDBC2020.Range range = new TDDBC2020.Range(-999, 0);
            }
            catch (ArgumentException)
            {
                // ����
                Assert.Fail();
            }
            // �㏈��
        }
    }
}
