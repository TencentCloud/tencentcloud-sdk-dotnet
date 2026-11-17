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

namespace TencentCloud.Ags.V20250920.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GPUResource : AbstractModel
    {
        
        /// <summary>
        /// <p>GPU 资源 ID，与沙箱 InstanceId、底层 VM ID 不同。</p>
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// <p>所属 GPU 资源组 ID。</p>
        /// </summary>
        [JsonProperty("ResourceGroupId")]
        public string ResourceGroupId{ get; set; }

        /// <summary>
        /// <p>GPU资源状态，大小写敏感：Delivering（准备中）、Active（已生效）、Isolated（已隔离）、Destroying（释放中）。不返回 Destroyed 和补偿完成的 Failed。</p>
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// <p>占用状态，大小写敏感：Idle（可领取）、Allocating（领取中）、InUse（使用中）、Returning（归还中）、Unavailable（暂不可用）。不能根据 InstanceId 是否存在判断是否空闲。</p>
        /// </summary>
        [JsonProperty("AllocationState")]
        public string AllocationState{ get; set; }

        /// <summary>
        /// <p>已绑定的最终 AGS 沙箱实例 ID；尚未绑定或未占用时可能不返回。</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>生效时间，未生效时可能不返回。</p>
        /// </summary>
        [JsonProperty("ActiveAt")]
        public string ActiveAt{ get; set; }

        /// <summary>
        /// <p>到期时间，未生效时可能不返回。</p>
        /// </summary>
        [JsonProperty("ExpireAt")]
        public string ExpireAt{ get; set; }

        /// <summary>
        /// <p>续费标记：0 不自动续费，1 自动续费，2 不再续费。</p>
        /// </summary>
        [JsonProperty("RenewFlag")]
        public long? RenewFlag{ get; set; }

        /// <summary>
        /// <p>安全的状态原因标识；空串表示无额外原因，PhysicalUnavailable 表示物理状态不可用，BindingPending 表示绑定身份尚待确认。未知值应作状态确认中处理。</p>
        /// </summary>
        [JsonProperty("StatusReason")]
        public string StatusReason{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "ResourceGroupId", this.ResourceGroupId);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "AllocationState", this.AllocationState);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ActiveAt", this.ActiveAt);
            this.SetParamSimple(map, prefix + "ExpireAt", this.ExpireAt);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "StatusReason", this.StatusReason);
        }
    }
}

