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

    public class SmartRouterComponent : AbstractModel
    {
        
        /// <summary>
        /// <p>组件名称：{ServiceGroupId}-gateway / {ServiceGroupId}-scheduler</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>组件类型：&quot;Gateway&quot; / &quot;Scheduler&quot;</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>组件镜像（从 K8s Deployment 实时查询）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ImageInfo")]
        public ImageInfo ImageInfo{ get; set; }

        /// <summary>
        /// <p>期望配置（Replicas/Cpu/Memory/Env）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceConfig")]
        public SmartRouterResourceConfig ResourceConfig{ get; set; }

        /// <summary>
        /// <p>组件状态：CREATING 创建中 / CREATE_FAILED 创建失败 / Normal 正常运行中 / Stopped 已停止 / Stopping 停止中 / Abnormal 异常 / Pending 启动中 / Waiting 就绪中</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>资源规格（查询时回显用户创建/修改时的资源选择）。公有云场景展示：ChargeType / Zone / ResourceSupplyAttribute；内网版场景展示：QueueId</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceSpec")]
        public SmartRouterResourceSpec ResourceSpec{ get; set; }

        /// <summary>
        /// <p>业务状态（组件级计费状态，Gateway/Scheduler 独立判定）：Billing 计费中 / Normal 正常（未计费或已停止计费）/ WhitelistUsing 白名单使用中（免计费）</p>
        /// </summary>
        [JsonProperty("BusinessStatus")]
        public string BusinessStatus{ get; set; }

        /// <summary>
        /// <p>费用信息（组件级计费明细 JSON 字符串，格式与 Service.BillingInfo 一致，前端可复用同一渲染逻辑）</p>
        /// </summary>
        [JsonProperty("BillingInfo")]
        public string BillingInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "ImageInfo.", this.ImageInfo);
            this.SetParamObj(map, prefix + "ResourceConfig.", this.ResourceConfig);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamObj(map, prefix + "ResourceSpec.", this.ResourceSpec);
            this.SetParamSimple(map, prefix + "BusinessStatus", this.BusinessStatus);
            this.SetParamSimple(map, prefix + "BillingInfo", this.BillingInfo);
        }
    }
}

