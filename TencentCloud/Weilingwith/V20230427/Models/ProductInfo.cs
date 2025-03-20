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

namespace TencentCloud.Weilingwith.V20230427.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProductInfo : AbstractModel
    {
        
        /// <summary>
        /// 工作空间id
        /// </summary>
        [JsonProperty("WorkspaceId")]
        public long? WorkspaceId{ get; set; }

        /// <summary>
        /// 产品PID
        /// </summary>
        [JsonProperty("ProductId")]
        public long? ProductId{ get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        [JsonProperty("DeviceTypeName")]
        public string DeviceTypeName{ get; set; }

        /// <summary>
        /// 设备类型id
        /// </summary>
        [JsonProperty("DeviceTypeId")]
        public string DeviceTypeId{ get; set; }

        /// <summary>
        /// 产品属性，如：网关（1）、直连设备（2）、子设备（3）
        /// </summary>
        [JsonProperty("Attribute")]
        public long? Attribute{ get; set; }

        /// <summary>
        /// 产品型号
        /// </summary>
        [JsonProperty("ProductType")]
        public string ProductType{ get; set; }

        /// <summary>
        /// 产品能力:信令数据、音视频。二进制数值中第0位表示信令数据、第1位表示音视频 。1（信令数据），3（具有信令数据以及音视频能力）。
        /// </summary>
        [JsonProperty("ProductAbility")]
        public long? ProductAbility{ get; set; }

        /// <summary>
        /// 生产厂商
        /// </summary>
        [JsonProperty("Manufacturer")]
        public string Manufacturer{ get; set; }

        /// <summary>
        /// 维保厂商
        /// </summary>
        [JsonProperty("MaintenanceMfr")]
        public string MaintenanceMfr{ get; set; }

        /// <summary>
        /// 物模型名称
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// 物模型id
        /// </summary>
        [JsonProperty("ModelId")]
        public string ModelId{ get; set; }

        /// <summary>
        /// 物模型类型，产品模型/标准模型
        /// </summary>
        [JsonProperty("ModelType")]
        public long? ModelType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
            this.SetParamSimple(map, prefix + "DeviceTypeName", this.DeviceTypeName);
            this.SetParamSimple(map, prefix + "DeviceTypeId", this.DeviceTypeId);
            this.SetParamSimple(map, prefix + "Attribute", this.Attribute);
            this.SetParamSimple(map, prefix + "ProductType", this.ProductType);
            this.SetParamSimple(map, prefix + "ProductAbility", this.ProductAbility);
            this.SetParamSimple(map, prefix + "Manufacturer", this.Manufacturer);
            this.SetParamSimple(map, prefix + "MaintenanceMfr", this.MaintenanceMfr);
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamSimple(map, prefix + "ModelId", this.ModelId);
            this.SetParamSimple(map, prefix + "ModelType", this.ModelType);
        }
    }
}

