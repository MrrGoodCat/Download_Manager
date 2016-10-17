using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DownloadManager
{
    public partial class DownloadManagerForm : Form
    {
        private Thread threadDownload;
        private Stream streamResponse;
        private Stream streamLocal;
        private HttpWebRequest webRequest;
        private HttpWebResponse webResponse;
        private static int persentProgress;
        private delegate void UpdateProgressCallback(Int64 bytesRead, Int64 totalBytes);

        public DownloadManagerForm()
        {
            InitializeComponent();
        }


        private void UpdateProgress(Int64 bytesRead, Int64 totalBytes)
        {
            persentProgress = Convert.ToInt32((bytesRead * 100) / totalBytes);
            progressBarDownload.Value = persentProgress;
            lableProgress.Text = $"Download {bytesRead} out of {totalBytes} - {persentProgress}%";
        }

        private void Download()
        {
            using (WebClient webClientDownload = new WebClient())
            {
                try
                {
                    webRequest = (HttpWebRequest)WebRequest.Create(textBoxDownloadURL.Text);
                    //webRequest.Credentials = CredentialCache.DefaultCredentials;
                    webResponse = (HttpWebResponse)webRequest.GetResponse();
                    Int64 fileSize = Int64.Parse(webResponse.ContentLength.ToString());

                    streamResponse = webClientDownload.OpenRead(textBoxDownloadURL.Text);
                    streamLocal = new FileStream(textBoxDownloadPath.Text, FileMode.Create, FileAccess.Write, FileShare.None);
                    int bytesSize = 0;
                    byte[] downloadBuffer = new byte[2048];

                    while ((bytesSize = streamResponse.Read(downloadBuffer, 0, downloadBuffer.Length)) > 0)
                    {
                        streamLocal.Write(downloadBuffer, 0, bytesSize);
                        Invoke(new UpdateProgressCallback(UpdateProgress), new object[] { streamLocal.Length, fileSize });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Some error: \n{ex}");
                }
                finally
                {
                    streamResponse.Close();
                    streamLocal.Close();
                }
            }
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            lableProgress.Text = "Download Starting";
            threadDownload = new Thread(Download);
            threadDownload.Start();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            webResponse.Close();
            streamResponse.Close();
            streamLocal.Close();
            threadDownload.Abort();
            progressBarDownload.Value = 0;
            lableProgress.Text = "Download Stoppet";
        }
    }
}
