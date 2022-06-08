using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeviceManagerLKDS
{
    public partial class UserControl_ATS : UserControl
    {
        public UserControl_ATS()
        {
            InitializeComponent();
        }
        public void SetData(byte[] array)
        {

            //string str =dlajskldj.GetNameOfEnum();

            if (array.Length >= 32)
            {
                ClassDeviceInfo.CAN_Devices type = (ClassDeviceInfo.CAN_Devices)array[1];
                ClassDeviceInfo.Device_Status status = (ClassDeviceInfo.Device_Status)array[0];
                if (type == ClassDeviceInfo.CAN_Devices.ATS)
                {
                    device_status_tb.Text = status.GetNameOfEnum();
                    device_name_tb.Text = type.GetNameOfEnum();

                    in_1_pb_sk1.BackColor = ((array[3] & 0x01) != 0) ? Color.Green : Color.White;
                    in_2_pb_sk1.BackColor = ((array[3] & 0x02) != 0) ? Color.Green : Color.White;
                    in_3_pb_sk1.BackColor = ((array[3] & 0x04) != 0) ? Color.Green : Color.White;
                    in_4_pb_sk1.BackColor = ((array[3] & 0x08) != 0) ? Color.Green : Color.White;
                    in_1_pb_sk2.BackColor = ((array[2] & 0x10) != 0) ? Color.Green : Color.White;
                    in_2_pb_sk2.BackColor = ((array[2] & 0x020) != 0) ? Color.Green : Color.White;
                    in_3_pb_sk2.BackColor = ((array[2] & 0x40) != 0) ? Color.Green : Color.White;
                    in_4_pb_sk2.BackColor = ((array[2] & 0x80) != 0) ? Color.Green : Color.White;

                    in_1_pb_ts1.BackColor = ((array[5] & 0x01) != 0) ? Color.Green : Color.White;
                    in_2_pb_ts1.BackColor = ((array[5] & 0x02) != 0) ? Color.Green : Color.White;
                    in_3_pb_ts1.BackColor = ((array[5] & 0x04) != 0) ? Color.Green : Color.White;
                    in_4_pb_ts1.BackColor = ((array[5] & 0x08) != 0) ? Color.Green : Color.White;
                    in_1_pb_ts2.BackColor = ((array[4] & 0x010) != 0) ? Color.Green : Color.White;
                    in_2_pb_ts2.BackColor = ((array[4] & 0x020) != 0) ? Color.Green : Color.White;
                    in_3_pb_ts2.BackColor = ((array[4] & 0x040) != 0) ? Color.Green : Color.White;
                    in_4_pb_ts2.BackColor = ((array[4] & 0x080) != 0) ? Color.Green : Color.White;

                    software_version_tb.Text = $"{array[8]}.{array[9]}.{array[10]}";
                }
            }
        }


    }
}
