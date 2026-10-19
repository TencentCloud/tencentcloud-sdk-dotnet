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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SmartRouterResourceSpec : AbstractModel
    {
        
        /// <summary>
        /// <p>付费模式：PREPAID（预付费）/ POSTPAID_BY_HOUR（后付费）。不传则默认 POSTPAID_BY_HOUR</p>
        /// </summary>
        [JsonProperty("ChargeType")]
        public string ChargeType{ get; set; }

        /// <summary>
        /// <p>预付费资源组 ID（ChargeType=PREPAID 时必填）</p>
        /// </summary>
        [JsonProperty("ResourceGroupId")]
        public string ResourceGroupId{ get; set; }

        /// <summary>
        /// <p>预付费资源组名称（output only，ChargeType=PREPAID 时有值，查询时回显）</p>
        /// </summary>
        [JsonProperty("ResourceGroupName")]
        public string ResourceGroupName{ get; set; }

        /// <summary>
        /// <p>可用区（如 ap-guangzhou-3），公有云场景用于指定机器来源</p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>资源队列 ID（内网版使用，标识任务所属的调度队列）</p>
        /// </summary>
        [JsonProperty("QueueId")]
        public string QueueId{ get; set; }

        /// <summary>
        /// <p>服务的优先级，可选范围 [0,9]，默认 0（内网版/私有化使用）</p>
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// <p>资源供应属性（潮汐/竞价等供应模式），公有云场景用于指定机器来源类型。仅区分供应来源，计费/部署/伸缩仍按后付费处理（ChargeType 恒为 POSTPAID_BY_HOUR）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceSupplyAttribute")]
        public ResourceSupplyAttribute ResourceSupplyAttribute{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
            this.SetParamSimple(map, prefix + "ResourceGroupId", this.ResourceGroupId);
            this.SetParamSimple(map, prefix + "ResourceGroupName", this.ResourceGroupName);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "QueueId", this.QueueId);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamObj(map, prefix + "ResourceSupplyAttribute.", this.ResourceSupplyAttribute);
        }
    }
}

