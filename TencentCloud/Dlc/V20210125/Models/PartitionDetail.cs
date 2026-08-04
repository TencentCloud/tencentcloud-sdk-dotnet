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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PartitionDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>分区编码</p>
        /// </summary>
        [JsonProperty("PartitionCode")]
        public string PartitionCode{ get; set; }

        /// <summary>
        /// <p>分区名称</p>
        /// </summary>
        [JsonProperty("PartitionName")]
        public string PartitionName{ get; set; }

        /// <summary>
        /// <p>分区描述</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>地域</p>
        /// </summary>
        [JsonProperty("Region")]
        public long? Region{ get; set; }

        /// <summary>
        /// <p>产品信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProductInfo")]
        public string ProductInfo{ get; set; }

        /// <summary>
        /// <p>资源池编码</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourcePoolCode")]
        public string ResourcePoolCode{ get; set; }

        /// <summary>
        /// <p>资源配额列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceQuota")]
        public ResourceQuota[] ResourceQuota{ get; set; }

        /// <summary>
        /// <p>付费模式</p>
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// <p>续费标志</p>
        /// </summary>
        [JsonProperty("RenewFlag")]
        public long? RenewFlag{ get; set; }

        /// <summary>
        /// <p>调度器类型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Scheduler")]
        public string Scheduler{ get; set; }

        /// <summary>
        /// <p>状态</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PartitionCode", this.PartitionCode);
            this.SetParamSimple(map, prefix + "PartitionName", this.PartitionName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "ProductInfo", this.ProductInfo);
            this.SetParamSimple(map, prefix + "ResourcePoolCode", this.ResourcePoolCode);
            this.SetParamArrayObj(map, prefix + "ResourceQuota.", this.ResourceQuota);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "Scheduler", this.Scheduler);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

