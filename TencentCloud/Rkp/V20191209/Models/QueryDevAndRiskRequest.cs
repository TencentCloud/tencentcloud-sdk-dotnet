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

namespace TencentCloud.Rkp.V20191209.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QueryDevAndRiskRequest : AbstractModel
    {
        
        /// <summary>
        /// 设备类型 0表示Android， 1表示IOS
        /// </summary>
        [JsonProperty("DevType")]
        public long? DevType{ get; set; }

        /// <summary>
        /// Android Imei号
        /// </summary>
        [JsonProperty("Imei")]
        public string Imei{ get; set; }

        /// <summary>
        /// Mac地址
        /// </summary>
        [JsonProperty("Mac")]
        public string Mac{ get; set; }

        /// <summary>
        /// android  Aid
        /// </summary>
        [JsonProperty("Aid")]
        public string Aid{ get; set; }

        /// <summary>
        /// Android Cid
        /// </summary>
        [JsonProperty("Cid")]
        public string Cid{ get; set; }

        /// <summary>
        /// 手机Imsi
        /// </summary>
        [JsonProperty("Imsi")]
        public string Imsi{ get; set; }

        /// <summary>
        /// Df 磁盘分区信息
        /// </summary>
        [JsonProperty("Df")]
        public string Df{ get; set; }

        /// <summary>
        /// 内核版本
        /// </summary>
        [JsonProperty("KernelVer")]
        public string KernelVer{ get; set; }

        /// <summary>
        /// 存储大小
        /// </summary>
        [JsonProperty("Storage")]
        public string Storage{ get; set; }

        /// <summary>
        /// 设备驱动指纹
        /// </summary>
        [JsonProperty("Dfp")]
        public string Dfp{ get; set; }

        /// <summary>
        /// 启动时间
        /// </summary>
        [JsonProperty("BootTime")]
        public string BootTime{ get; set; }

        /// <summary>
        /// 分辨率 水平*垂直 格式
        /// </summary>
        [JsonProperty("Resolution")]
        public string Resolution{ get; set; }

        /// <summary>
        /// 铃声列表
        /// </summary>
        [JsonProperty("RingList")]
        public string RingList{ get; set; }

        /// <summary>
        /// 字体列表
        /// </summary>
        [JsonProperty("FontList")]
        public string FontList{ get; set; }

        /// <summary>
        /// 传感器列表
        /// </summary>
        [JsonProperty("SensorList")]
        public string SensorList{ get; set; }

        /// <summary>
        /// CPU型号
        /// </summary>
        [JsonProperty("CpuType")]
        public string CpuType{ get; set; }

        /// <summary>
        /// 电池容量
        /// </summary>
        [JsonProperty("Battery")]
        public string Battery{ get; set; }

        /// <summary>
        /// 信通院广告ID
        /// </summary>
        [JsonProperty("Oaid")]
        public string Oaid{ get; set; }

        /// <summary>
        /// IOS 广告ID
        /// </summary>
        [JsonProperty("Idfa")]
        public string Idfa{ get; set; }

        /// <summary>
        /// IOS 应用ID
        /// </summary>
        [JsonProperty("Idfv")]
        public string Idfv{ get; set; }

        /// <summary>
        /// 设备名称
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// IOS手机型号
        /// </summary>
        [JsonProperty("IphoneModel")]
        public string IphoneModel{ get; set; }

        /// <summary>
        /// Android 指纹
        /// </summary>
        [JsonProperty("Fingerprint")]
        public string Fingerprint{ get; set; }

        /// <summary>
        /// Android序列号
        /// </summary>
        [JsonProperty("SerialId")]
        public string SerialId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DevType", this.DevType);
            this.SetParamSimple(map, prefix + "Imei", this.Imei);
            this.SetParamSimple(map, prefix + "Mac", this.Mac);
            this.SetParamSimple(map, prefix + "Aid", this.Aid);
            this.SetParamSimple(map, prefix + "Cid", this.Cid);
            this.SetParamSimple(map, prefix + "Imsi", this.Imsi);
            this.SetParamSimple(map, prefix + "Df", this.Df);
            this.SetParamSimple(map, prefix + "KernelVer", this.KernelVer);
            this.SetParamSimple(map, prefix + "Storage", this.Storage);
            this.SetParamSimple(map, prefix + "Dfp", this.Dfp);
            this.SetParamSimple(map, prefix + "BootTime", this.BootTime);
            this.SetParamSimple(map, prefix + "Resolution", this.Resolution);
            this.SetParamSimple(map, prefix + "RingList", this.RingList);
            this.SetParamSimple(map, prefix + "FontList", this.FontList);
            this.SetParamSimple(map, prefix + "SensorList", this.SensorList);
            this.SetParamSimple(map, prefix + "CpuType", this.CpuType);
            this.SetParamSimple(map, prefix + "Battery", this.Battery);
            this.SetParamSimple(map, prefix + "Oaid", this.Oaid);
            this.SetParamSimple(map, prefix + "Idfa", this.Idfa);
            this.SetParamSimple(map, prefix + "Idfv", this.Idfv);
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "IphoneModel", this.IphoneModel);
            this.SetParamSimple(map, prefix + "Fingerprint", this.Fingerprint);
            this.SetParamSimple(map, prefix + "SerialId", this.SerialId);
        }
    }
}

