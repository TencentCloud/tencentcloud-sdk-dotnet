/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Mna.V20210119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeviceNetInfo : AbstractModel
    {
        
        /// <summary>
        /// 网络类型：
        /// 0:数据
        /// 1:Wi-Fi
        /// 2:有线
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// 启用/禁用
        /// </summary>
        [JsonProperty("DataEnable")]
        public bool? DataEnable{ get; set; }

        /// <summary>
        /// 上行限速
        /// </summary>
        [JsonProperty("UploadLimit")]
        public string UploadLimit{ get; set; }

        /// <summary>
        /// 下行限速
        /// </summary>
        [JsonProperty("DownloadLimit")]
        public string DownloadLimit{ get; set; }

        /// <summary>
        /// 接收实时速率
        /// </summary>
        [JsonProperty("DataRx")]
        public ulong? DataRx{ get; set; }

        /// <summary>
        /// 发送实时速率
        /// </summary>
        [JsonProperty("DataTx")]
        public ulong? DataTx{ get; set; }

        /// <summary>
        /// 运营商类型：
        /// 1: 中国移动；
        /// 2: 中国电信; 
        /// 3: 中国联通
        /// </summary>
        [JsonProperty("Vendor")]
        public long? Vendor{ get; set; }

        /// <summary>
        /// 连接状态：
        /// 0:无连接
        /// 1:连接中
        /// 2:已连接
        /// </summary>
        [JsonProperty("State")]
        public long? State{ get; set; }

        /// <summary>
        /// 公网IP
        /// </summary>
        [JsonProperty("PublicIp")]
        public string PublicIp{ get; set; }

        /// <summary>
        /// 信号强度/单位：dbm
        /// </summary>
        [JsonProperty("SignalStrength")]
        public long? SignalStrength{ get; set; }

        /// <summary>
        /// 数据网络类型：
        /// -1 ：无效值   
        /// 2：2G 
        /// 3：3G 
        /// 4：4G 
        /// 5：5G
        /// </summary>
        [JsonProperty("Rat")]
        public long? Rat{ get; set; }

        /// <summary>
        /// 网卡名
        /// </summary>
        [JsonProperty("NetInfoName")]
        public string NetInfoName{ get; set; }

        /// <summary>
        /// 下行实时速率（浮点数类型代替上一版本DataRx的整型）
        /// </summary>
        [JsonProperty("DownRate")]
        public float? DownRate{ get; set; }

        /// <summary>
        /// 上行实时速率（浮点数类型代替上一版本TxRate的整型）
        /// </summary>
        [JsonProperty("UpRate")]
        public float? UpRate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "DataEnable", this.DataEnable);
            this.SetParamSimple(map, prefix + "UploadLimit", this.UploadLimit);
            this.SetParamSimple(map, prefix + "DownloadLimit", this.DownloadLimit);
            this.SetParamSimple(map, prefix + "DataRx", this.DataRx);
            this.SetParamSimple(map, prefix + "DataTx", this.DataTx);
            this.SetParamSimple(map, prefix + "Vendor", this.Vendor);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "PublicIp", this.PublicIp);
            this.SetParamSimple(map, prefix + "SignalStrength", this.SignalStrength);
            this.SetParamSimple(map, prefix + "Rat", this.Rat);
            this.SetParamSimple(map, prefix + "NetInfoName", this.NetInfoName);
            this.SetParamSimple(map, prefix + "DownRate", this.DownRate);
            this.SetParamSimple(map, prefix + "UpRate", this.UpRate);
        }
    }
}

