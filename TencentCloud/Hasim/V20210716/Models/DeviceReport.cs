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

namespace TencentCloud.Hasim.V20210716.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeviceReport : AbstractModel
    {
        
        /// <summary>
        /// 移动设备ID
        /// </summary>
        [JsonProperty("Imei")]
        public string Imei{ get; set; }

        /// <summary>
        /// 经度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Lng")]
        public string Lng{ get; set; }

        /// <summary>
        /// 维度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Lat")]
        public string Lat{ get; set; }

        /// <summary>
        /// 运营商基站ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Lac")]
        public string Lac{ get; set; }

        /// <summary>
        /// 小区CellID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Cell")]
        public string Cell{ get; set; }

        /// <summary>
        /// 当前上报运营商ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Iccid")]
        public string Iccid{ get; set; }

        /// <summary>
        /// 信号强度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Rss")]
        public long? Rss{ get; set; }

        /// <summary>
        /// 运营商: 1 移动 2 联通 3 电信
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tele")]
        public long? Tele{ get; set; }

        /// <summary>
        /// 当前设备策略ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tid")]
        public long? Tid{ get; set; }

        /// <summary>
        /// 心跳间隔,单位秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Ping")]
        public long? Ping{ get; set; }

        /// <summary>
        /// 网络延迟,单位毫秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Delay")]
        public long? Delay{ get; set; }

        /// <summary>
        /// 高级日志启停状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Log")]
        public long? Log{ get; set; }

        /// <summary>
        /// 设备型号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DevType")]
        public string DevType{ get; set; }

        /// <summary>
        /// 设备型号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DevModel")]
        public string DevModel{ get; set; }

        /// <summary>
        /// 设备版本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// 设备刷新时间戳
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UploadTime")]
        public string UploadTime{ get; set; }

        /// <summary>
        /// 网络环境: 0 正常 1 弱网
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 每月第一次上报心跳时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MonthFirstTime")]
        public string MonthFirstTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Imei", this.Imei);
            this.SetParamSimple(map, prefix + "Lng", this.Lng);
            this.SetParamSimple(map, prefix + "Lat", this.Lat);
            this.SetParamSimple(map, prefix + "Lac", this.Lac);
            this.SetParamSimple(map, prefix + "Cell", this.Cell);
            this.SetParamSimple(map, prefix + "Iccid", this.Iccid);
            this.SetParamSimple(map, prefix + "Rss", this.Rss);
            this.SetParamSimple(map, prefix + "Tele", this.Tele);
            this.SetParamSimple(map, prefix + "Tid", this.Tid);
            this.SetParamSimple(map, prefix + "Ping", this.Ping);
            this.SetParamSimple(map, prefix + "Delay", this.Delay);
            this.SetParamSimple(map, prefix + "Log", this.Log);
            this.SetParamSimple(map, prefix + "DevType", this.DevType);
            this.SetParamSimple(map, prefix + "DevModel", this.DevModel);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "UploadTime", this.UploadTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "MonthFirstTime", this.MonthFirstTime);
        }
    }
}

