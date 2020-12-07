using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CisWindowsFormsApp
{
    public static class CommonMessageHelper
    {
        public static DialogResult ContactAdminError()
        {
            return MessageBox.Show("Terjadi kesalahan pada system, silakan hubungi Administrator.", 
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult ConfirmDelete()
        {
            return MessageBox.Show("Yakin akan menghapus data ini?", 
                "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static void DataNotFound(string notFoundData)
        {
            MessageBox.Show("Data " + notFoundData + " tidak ditemukan. Silakan klik Reload ulangi langkah tadi."
                   , "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void DataHasBeenUpdatedPriorToSave(string updatedData)
        {
            MessageBox.Show("Data " + updatedData + " telah diupdate sebelumnya. Silakan klik Reload dan ulangi langkah tadi."
                   , "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void DataCannotBeEmpty(string mandatoryData)
        {
            MessageBox.Show("Data " + mandatoryData + " tidak boleh kosong."
                      , "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void DataAlreadyExist(string existingData)
        {
            MessageBox.Show("Data " + existingData + " sudah ada. Silakan gunakan kombinasi yang lain."
                    , "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ReferredDataNotSet(string referredData)
        {
            MessageBox.Show("Data referensi " + referredData + " belum diset. Silakan siapkan referensi sebelum menambahakan data."
                   , "Peringatann", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ReferredDataCannotBeDeleted()
        {
            MessageBox.Show("Data yang telah direferensi oleh data lain tidak boleh dihapus."
                            , "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void NoMoreResultFound()
        {
            MessageBox.Show("Hasil pencarian tidak ditemukan lagi."
                            , "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void NoAccess()
        {
            MessageBox.Show("Anda tidak memiliki izin untuk mengakses data ini."
                            , "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void DataSavedSuccessfully()
        {
            MessageBox.Show("Data telah berhasil disimpan."
                            , "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
