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

    public class PreCacheImageCleanupPolicy : AbstractModel
    {
        
        /// <summary>
        /// <p>自动清理策略ID</p>
        /// </summary>
        [JsonProperty("CleanupPolicyId")]
        public string CleanupPolicyId{ get; set; }

        /// <summary>
        /// <p>自动清理策略名</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>策略启用配置</p>
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// <p>镜像仓库地址</p><p>精准匹配，空串表示不限域名</p>
        /// </summary>
        [JsonProperty("RegistryHost")]
        public string RegistryHost{ get; set; }

        /// <summary>
        /// <p>镜像仓库名</p><p>正则匹配，匹配 命名空间/仓库 完整路径，非锚定子串匹配，语法与 TCR 预热触发器一致；空串表示全部 Repo</p>
        /// </summary>
        [JsonProperty("RepoPattern")]
        public string RepoPattern{ get; set; }

        /// <summary>
        /// <p>闲置过期清理时间</p><p>规范化正数时长，例如 7d</p>
        /// </summary>
        [JsonProperty("IdleTTL")]
        public string IdleTTL{ get; set; }

        /// <summary>
        /// <p>策略创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>策略最近更新时间</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CleanupPolicyId", this.CleanupPolicyId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "RegistryHost", this.RegistryHost);
            this.SetParamSimple(map, prefix + "RepoPattern", this.RepoPattern);
            this.SetParamSimple(map, prefix + "IdleTTL", this.IdleTTL);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

