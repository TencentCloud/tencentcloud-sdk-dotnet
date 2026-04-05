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

namespace TencentCloud.Ga2.V20250115.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GlobalAcceleratorSet : AbstractModel
    {
        
        /// <summary>
        /// <p>全球加速实例ID。</p>
        /// </summary>
        [JsonProperty("GlobalAcceleratorId")]
        public string GlobalAcceleratorId{ get; set; }

        /// <summary>
        /// <p>全球加速实例名称。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>全球加速实例描述。</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>全球加速实例创建时间。</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>全球加速实例状态。</p>
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// <p>全球加速实例付费类型。</p>
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// <p>全球加速实例DdosId。</p>
        /// </summary>
        [JsonProperty("DdosId")]
        public string DdosId{ get; set; }

        /// <summary>
        /// <p>所属加速实例监听器个数。</p>
        /// </summary>
        [JsonProperty("ListenerCounts")]
        public ulong? ListenerCounts{ get; set; }

        /// <summary>
        /// <p>所属加速实例加速地域个数。</p>
        /// </summary>
        [JsonProperty("AcceleratorAreaCounts")]
        public ulong? AcceleratorAreaCounts{ get; set; }

        /// <summary>
        /// <p>全球加速实例状态。</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>域名。</p>
        /// </summary>
        [JsonProperty("Cname")]
        public string Cname{ get; set; }

        /// <summary>
        /// <p>跨境类型；HighQuality（精品跨境）、Unicom（联通跨境）、NotAvailable（未开通）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CrossBorderType")]
        public string CrossBorderType{ get; set; }

        /// <summary>
        /// <p>标签信息。</p>
        /// </summary>
        [JsonProperty("TagSet")]
        public Tag[] TagSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GlobalAcceleratorId", this.GlobalAcceleratorId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamSimple(map, prefix + "DdosId", this.DdosId);
            this.SetParamSimple(map, prefix + "ListenerCounts", this.ListenerCounts);
            this.SetParamSimple(map, prefix + "AcceleratorAreaCounts", this.AcceleratorAreaCounts);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Cname", this.Cname);
            this.SetParamSimple(map, prefix + "CrossBorderType", this.CrossBorderType);
            this.SetParamArrayObj(map, prefix + "TagSet.", this.TagSet);
        }
    }
}

