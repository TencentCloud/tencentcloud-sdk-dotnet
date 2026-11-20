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

    public class CreatePreCacheImageCleanupPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>策略名</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>闲置过期时间</p><p>参数格式：正数 m/h/d</p>
        /// </summary>
        [JsonProperty("IdleTTL")]
        public string IdleTTL{ get; set; }

        /// <summary>
        /// <p>镜像仓库地址</p><p>入参限制：精准匹配，不传或空串表示不限，最多 255 字符</p>
        /// </summary>
        [JsonProperty("RegistryHost")]
        public string RegistryHost{ get; set; }

        /// <summary>
        /// <p>镜像仓库名</p><p>入参限制：正则匹配，最多 256 字符，编译后指令数不超过 128，账号全部启用策略合计不超过 1280；不传或空串表示全部 Repo</p>
        /// </summary>
        [JsonProperty("RepoPattern")]
        public string RepoPattern{ get; set; }

        /// <summary>
        /// <p>策略启用配置</p><p>枚举值：</p><ul><li>true： 启用策略</li><li>false： 禁用策略</li></ul><p>默认值：true</p>
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "IdleTTL", this.IdleTTL);
            this.SetParamSimple(map, prefix + "RegistryHost", this.RegistryHost);
            this.SetParamSimple(map, prefix + "RepoPattern", this.RepoPattern);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
        }
    }
}

