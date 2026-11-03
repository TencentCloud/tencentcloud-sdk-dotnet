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

namespace TencentCloud.Cngw.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAIGWCustomGuardrailPolicyResult : AbstractModel
    {
        
        /// <summary>
        /// <p>本次配置同步是否全部成功。即使云 API 未返回 Response.Error，仍须检查此值、SyncStatus 和 FailedResources。</p>
        /// </summary>
        [JsonProperty("Success")]
        public bool? Success{ get; set; }

        /// <summary>
        /// <p>变更后的策略</p>
        /// </summary>
        [JsonProperty("Policy")]
        public CustomGuardrailPolicy Policy{ get; set; }

        /// <summary>
        /// <p>本次同步成功的业务资源引用；Modify 返回的不是严格的新增差集。</p>
        /// </summary>
        [JsonProperty("AddedResources")]
        public CustomGuardrailResourceRef[] AddedResources{ get; set; }

        /// <summary>
        /// <p>与修改前相比移除的 Route 绑定数量；一个业务资源可有多条 Route，因此不等于业务资源数量。</p>
        /// </summary>
        [JsonProperty("RemovedCount")]
        public long? RemovedCount{ get; set; }

        /// <summary>
        /// <p>失败资源及原因；非空表示配置同步仍需处理，不要因 HTTP 200 判定全部成功。</p>
        /// </summary>
        [JsonProperty("FailedResources")]
        public CustomGuardrailSyncFailure[] FailedResources{ get; set; }

        /// <summary>
        /// <p>同步状态：pending 待同步，synced 已完成本次配置同步，partial 部分失败，failed 失败。需结合 FailedResources/SyncError；synced 不等于已完成所有数据面实例的业务端到端验证。</p>
        /// </summary>
        [JsonProperty("SyncStatus")]
        public string SyncStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Success", this.Success);
            this.SetParamObj(map, prefix + "Policy.", this.Policy);
            this.SetParamArrayObj(map, prefix + "AddedResources.", this.AddedResources);
            this.SetParamSimple(map, prefix + "RemovedCount", this.RemovedCount);
            this.SetParamArrayObj(map, prefix + "FailedResources.", this.FailedResources);
            this.SetParamSimple(map, prefix + "SyncStatus", this.SyncStatus);
        }
    }
}

