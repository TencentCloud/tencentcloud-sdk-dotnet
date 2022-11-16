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

namespace TencentCloud.Eis.V20210601.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RuntimeMC : AbstractModel
    {
        
        /// <summary>
        /// 环境id
        /// </summary>
        [JsonProperty("RuntimeId")]
        public long? RuntimeId{ get; set; }

        /// <summary>
        /// 主账号uin
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 环境名称，用户输入，同一uin内唯一
        /// </summary>
        [JsonProperty("DisplayName")]
        public string DisplayName{ get; set; }

        /// <summary>
        /// 环境所在地域，tianjin，beijiing，guangzhou等
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 环境类型：0: sandbox, 1:shared, 2:private 3: trial
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// 运行时状态：1:running, 2:deleting, 3:creating, 4:scaling, 5:unavailable, 6:deleted, 7:errored
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 环境创建时间
        /// </summary>
        [JsonProperty("CreatedAt")]
        public long? CreatedAt{ get; set; }

        /// <summary>
        /// 环境更新时间
        /// </summary>
        [JsonProperty("UpdatedAt")]
        public long? UpdatedAt{ get; set; }

        /// <summary>
        /// 环境资源配置，worker总配额，0:0vCore0G, 1:1vCore2G, 2:2vCore4G, 4:4vCore8G, 8:8vCore16G, 12:12vCore24G, 16:16vCore32G, 100:unlimited
        /// </summary>
        [JsonProperty("WorkerSize")]
        public long? WorkerSize{ get; set; }

        /// <summary>
        /// 环境资源配置，worker副本数
        /// </summary>
        [JsonProperty("WorkerReplica")]
        public long? WorkerReplica{ get; set; }

        /// <summary>
        /// 正在运行的应用实例数量
        /// </summary>
        [JsonProperty("RunningInstanceCount")]
        public long? RunningInstanceCount{ get; set; }

        /// <summary>
        /// 已使用cpu核数
        /// </summary>
        [JsonProperty("CpuUsed")]
        public float? CpuUsed{ get; set; }

        /// <summary>
        /// cpu核数上限
        /// </summary>
        [JsonProperty("CpuLimit")]
        public float? CpuLimit{ get; set; }

        /// <summary>
        /// 已使用内存 MB
        /// </summary>
        [JsonProperty("MemoryUsed")]
        public float? MemoryUsed{ get; set; }

        /// <summary>
        /// 内存上限 MB
        /// </summary>
        [JsonProperty("MemoryLimit")]
        public float? MemoryLimit{ get; set; }

        /// <summary>
        /// 环境过期时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExpiredAt")]
        public long? ExpiredAt{ get; set; }

        /// <summary>
        /// 收费类型：0:缺省，1:自助下单页购买(支持续费/升配等操作)，2:代销下单页购买
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChargeType")]
        public long? ChargeType{ get; set; }

        /// <summary>
        /// 资源限制类型：0:无限制，1:有限制
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceLimitType")]
        public long? ResourceLimitType{ get; set; }

        /// <summary>
        /// 是否开启自动续费
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AutoRenewal")]
        public bool? AutoRenewal{ get; set; }

        /// <summary>
        /// 扩展组件列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkerExtensions")]
        public RuntimeExtensionMC[] WorkerExtensions{ get; set; }

        /// <summary>
        /// 环境类型：0: sandbox, 1:shared, 2:private 3: trial
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuntimeType")]
        public long? RuntimeType{ get; set; }

        /// <summary>
        /// 环境运行类型：0:运行时类型、1:api类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuntimeClass")]
        public long? RuntimeClass{ get; set; }

        /// <summary>
        /// 已使用出带宽 Mbps
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BandwidthOutUsed")]
        public float? BandwidthOutUsed{ get; set; }

        /// <summary>
        /// 出带宽上限 Mbps
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BandwidthOutLimit")]
        public float? BandwidthOutLimit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuntimeId", this.RuntimeId);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "DisplayName", this.DisplayName);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "UpdatedAt", this.UpdatedAt);
            this.SetParamSimple(map, prefix + "WorkerSize", this.WorkerSize);
            this.SetParamSimple(map, prefix + "WorkerReplica", this.WorkerReplica);
            this.SetParamSimple(map, prefix + "RunningInstanceCount", this.RunningInstanceCount);
            this.SetParamSimple(map, prefix + "CpuUsed", this.CpuUsed);
            this.SetParamSimple(map, prefix + "CpuLimit", this.CpuLimit);
            this.SetParamSimple(map, prefix + "MemoryUsed", this.MemoryUsed);
            this.SetParamSimple(map, prefix + "MemoryLimit", this.MemoryLimit);
            this.SetParamSimple(map, prefix + "ExpiredAt", this.ExpiredAt);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
            this.SetParamSimple(map, prefix + "ResourceLimitType", this.ResourceLimitType);
            this.SetParamSimple(map, prefix + "AutoRenewal", this.AutoRenewal);
            this.SetParamArrayObj(map, prefix + "WorkerExtensions.", this.WorkerExtensions);
            this.SetParamSimple(map, prefix + "RuntimeType", this.RuntimeType);
            this.SetParamSimple(map, prefix + "RuntimeClass", this.RuntimeClass);
            this.SetParamSimple(map, prefix + "BandwidthOutUsed", this.BandwidthOutUsed);
            this.SetParamSimple(map, prefix + "BandwidthOutLimit", this.BandwidthOutLimit);
        }
    }
}

