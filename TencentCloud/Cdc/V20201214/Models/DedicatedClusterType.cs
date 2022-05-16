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

namespace TencentCloud.Cdc.V20201214.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DedicatedClusterType : AbstractModel
    {
        
        /// <summary>
        /// 配置id
        /// </summary>
        [JsonProperty("DedicatedClusterTypeId")]
        public string DedicatedClusterTypeId{ get; set; }

        /// <summary>
        /// 配置描述，对应描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 配置名称，对应计算资源类型
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 创建配置的时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 支持的存储类型列表
        /// </summary>
        [JsonProperty("SupportedStorageType")]
        public string[] SupportedStorageType{ get; set; }

        /// <summary>
        /// 支持的上连交换机的链路传输速率
        /// </summary>
        [JsonProperty("SupportedUplinkGiB")]
        public long?[] SupportedUplinkGiB{ get; set; }

        /// <summary>
        /// 支持的实例族列表
        /// </summary>
        [JsonProperty("SupportedInstanceFamily")]
        public string[] SupportedInstanceFamily{ get; set; }

        /// <summary>
        /// 地板承重要求(KG)
        /// </summary>
        [JsonProperty("Weight")]
        public long? Weight{ get; set; }

        /// <summary>
        /// 功率要求(KW)
        /// </summary>
        [JsonProperty("PowerDrawKva")]
        public float? PowerDrawKva{ get; set; }

        /// <summary>
        /// 显示计算资源规格详情，存储等资源不显示；对应规格
        /// </summary>
        [JsonProperty("ComputeFormatDesc")]
        public string ComputeFormatDesc{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DedicatedClusterTypeId", this.DedicatedClusterTypeId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamArraySimple(map, prefix + "SupportedStorageType.", this.SupportedStorageType);
            this.SetParamArraySimple(map, prefix + "SupportedUplinkGiB.", this.SupportedUplinkGiB);
            this.SetParamArraySimple(map, prefix + "SupportedInstanceFamily.", this.SupportedInstanceFamily);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamSimple(map, prefix + "PowerDrawKva", this.PowerDrawKva);
            this.SetParamSimple(map, prefix + "ComputeFormatDesc", this.ComputeFormatDesc);
        }
    }
}

