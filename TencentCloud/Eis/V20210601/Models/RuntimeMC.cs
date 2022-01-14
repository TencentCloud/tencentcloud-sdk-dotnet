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
        /// 运行时id
        /// </summary>
        [JsonProperty("RuntimeId")]
        public long? RuntimeId{ get; set; }

        /// <summary>
        /// 主账号uin
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 运行时名称，用户输入，同一uin内唯一
        /// </summary>
        [JsonProperty("DisplayName")]
        public string DisplayName{ get; set; }

        /// <summary>
        /// 运行时所在地域，tianjin，beijiing，guangzhou等
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 运行时类型：0: sandbox, 1:shared, 2:private
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// 运行时状态：1:running, 2:deleting, 3:creating, 4:scaling, 5:unavailable, 6:deleted, 7:errored
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 运行时创建时间
        /// </summary>
        [JsonProperty("CreatedAt")]
        public long? CreatedAt{ get; set; }

        /// <summary>
        /// 运行时更新时间
        /// </summary>
        [JsonProperty("UpdatedAt")]
        public long? UpdatedAt{ get; set; }

        /// <summary>
        /// 运行时资源配置，worker总配额，0:0vCore0G, 1:1vCore2G, 2:2vCore4G, 4:4vCore8G, 8:8vCore16G, 12:12vCore24G, 16:16vCore32G, 100:unlimited
        /// </summary>
        [JsonProperty("WorkerSize")]
        public long? WorkerSize{ get; set; }

        /// <summary>
        /// 运行时资源配置，worker副本数
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
        }
    }
}

