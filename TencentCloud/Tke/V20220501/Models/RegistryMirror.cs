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

namespace TencentCloud.Tke.V20220501.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RegistryMirror : AbstractModel
    {
        
        /// <summary>
        /// <p>源仓库，例如 docker.io / registry.k8s.io</p>
        /// </summary>
        [JsonProperty("Registry")]
        public string Registry{ get; set; }

        /// <summary>
        /// <p>镜像加速地址列表，按顺序写入 hosts.toml</p>
        /// </summary>
        [JsonProperty("Endpoints")]
        public string[] Endpoints{ get; set; }

        /// <summary>
        /// <p>是否在 hosts.toml 中写入 override_path，为 true 时镜像 endpoints 路径不再追加 namespace 后缀</p>
        /// </summary>
        [JsonProperty("OverridePath")]
        public bool? OverridePath{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Registry", this.Registry);
            this.SetParamArraySimple(map, prefix + "Endpoints.", this.Endpoints);
            this.SetParamSimple(map, prefix + "OverridePath", this.OverridePath);
        }
    }
}

