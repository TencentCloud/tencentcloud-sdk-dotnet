/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Weilingwith.V20230427.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeviceDataInfo : AbstractModel
    {
        
        /// <summary>
        /// 设备ID， wid
        /// </summary>
        [JsonProperty("WID")]
        public string WID{ get; set; }

        /// <summary>
        /// 设备名称
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// 设备类型Id
        /// </summary>
        [JsonProperty("DeviceTypeCode")]
        public string DeviceTypeCode{ get; set; }

        /// <summary>
        /// 设备类型名称
        /// </summary>
        [JsonProperty("DeviceTypeName")]
        public string DeviceTypeName{ get; set; }

        /// <summary>
        /// 产品Id
        /// </summary>
        [JsonProperty("ProductId")]
        public long? ProductId{ get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// 产品能力:信令数据、音视频。二进制数值中第0位表示信令数据、第1位表示音视频 。1（信令数据），3（具有信令数据以及音视频能力）。
        /// </summary>
        [JsonProperty("ProductAbility")]
        public long? ProductAbility{ get; set; }

        /// <summary>
        /// 设备位置信息
        /// </summary>
        [JsonProperty("SpaceInfoSet")]
        public DeviceSpaceInfo[] SpaceInfoSet{ get; set; }

        /// <summary>
        /// 模型id
        /// </summary>
        [JsonProperty("ModelId")]
        public string ModelId{ get; set; }

        /// <summary>
        /// 模型名称
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// 设备标签名，非必填
        /// </summary>
        [JsonProperty("DeviceTagSet")]
        public string[] DeviceTagSet{ get; set; }

        /// <summary>
        /// 激活状态（1激活、0未激活）
        /// </summary>
        [JsonProperty("IsActive")]
        public long? IsActive{ get; set; }

        /// <summary>
        ///  激活时间
        /// </summary>
        [JsonProperty("ActiveTime")]
        public string ActiveTime{ get; set; }

        /// <summary>
        /// 推流状态（推流中、未推流） 仅摄像机有的状态
        /// </summary>
        [JsonProperty("IsLive")]
        public bool? IsLive{ get; set; }

        /// <summary>
        /// 设备所属父设备id（子设备才有）
        /// </summary>
        [JsonProperty("ParentWID")]
        public string ParentWID{ get; set; }

        /// <summary>
        /// 设备所有父设备名称（子设备才有）
        /// </summary>
        [JsonProperty("ParentWIDName")]
        public string ParentWIDName{ get; set; }

        /// <summary>
        /// 序列号
        /// </summary>
        [JsonProperty("SN")]
        public string SN{ get; set; }

        /// <summary>
        /// 设备点位坐标值
        /// </summary>
        [JsonProperty("Location")]
        public DeviceLocation Location{ get; set; }

        /// <summary>
        /// 自定义字段
        /// </summary>
        [JsonProperty("FieldList")]
        public CustomFieldInfo[] FieldList{ get; set; }

        /// <summary>
        /// 分组信息
        /// </summary>
        [JsonProperty("GroupInfo")]
        public string GroupInfo{ get; set; }

        /// <summary>
        /// 通信在/离线状态（online=normal+fault，offline）
        /// </summary>
        [JsonProperty("DeviceStatus")]
        public string DeviceStatus{ get; set; }

        /// <summary>
        /// 设备业务状态（normal、fault、offline）
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WID", this.WID);
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "DeviceTypeCode", this.DeviceTypeCode);
            this.SetParamSimple(map, prefix + "DeviceTypeName", this.DeviceTypeName);
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
            this.SetParamSimple(map, prefix + "ProductAbility", this.ProductAbility);
            this.SetParamArrayObj(map, prefix + "SpaceInfoSet.", this.SpaceInfoSet);
            this.SetParamSimple(map, prefix + "ModelId", this.ModelId);
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamArraySimple(map, prefix + "DeviceTagSet.", this.DeviceTagSet);
            this.SetParamSimple(map, prefix + "IsActive", this.IsActive);
            this.SetParamSimple(map, prefix + "ActiveTime", this.ActiveTime);
            this.SetParamSimple(map, prefix + "IsLive", this.IsLive);
            this.SetParamSimple(map, prefix + "ParentWID", this.ParentWID);
            this.SetParamSimple(map, prefix + "ParentWIDName", this.ParentWIDName);
            this.SetParamSimple(map, prefix + "SN", this.SN);
            this.SetParamObj(map, prefix + "Location.", this.Location);
            this.SetParamArrayObj(map, prefix + "FieldList.", this.FieldList);
            this.SetParamSimple(map, prefix + "GroupInfo", this.GroupInfo);
            this.SetParamSimple(map, prefix + "DeviceStatus", this.DeviceStatus);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

