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

    public class UpdateSandboxToolRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>沙箱工具ID</p>
        /// </summary>
        [JsonProperty("ToolId")]
        public string ToolId{ get; set; }

        /// <summary>
        /// <p>沙箱工具描述，最大长度200字符</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>网络配置</p>
        /// </summary>
        [JsonProperty("NetworkConfiguration")]
        public NetworkConfiguration NetworkConfiguration{ get; set; }

        /// <summary>
        /// <p>标签</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>沙箱工具自定义配置</p>
        /// </summary>
        [JsonProperty("CustomConfiguration")]
        public CustomConfiguration CustomConfiguration{ get; set; }

        /// <summary>
        /// <p>桌面电脑环境类沙箱配置</p>
        /// </summary>
        [JsonProperty("ComputerConfiguration")]
        public ComputerConfiguration ComputerConfiguration{ get; set; }

        /// <summary>
        /// <p>按挂载名称更新沙箱工具已有镜像卷的镜像来源和镜像内目录。</p><p>入参限制：每项须提供已有镜像卷的 Name，以及 StorageSource.Image 中的 Reference 和 ImageRegistryType。同一请求中的 Name 须唯一。Reference 须包含镜像标签或 SHA-256 摘要。</p><p>取值参考：[{&quot;Name&quot;:&quot;runtime&quot;,&quot;StorageSource&quot;:{&quot;Image&quot;:{&quot;Reference&quot;:&quot;ccr.ccs.tencentyun.com/example/runtime:v2&quot;,&quot;ImageRegistryType&quot;:&quot;personal&quot;,&quot;SubPath&quot;:&quot;assets&quot;}}}]</p><p>省略本参数或传空数组时保留原配置。SubPath 省略时保留原目录，传空字符串时使用镜像根目录，传非空路径时使用指定目录。工具沿用原有 MountPath 和 ReadOnly，镜像摘要由服务解析。</p>
        /// </summary>
        [JsonProperty("StorageMounts")]
        public StorageMount[] StorageMounts{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ToolId", this.ToolId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamObj(map, prefix + "NetworkConfiguration.", this.NetworkConfiguration);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamObj(map, prefix + "CustomConfiguration.", this.CustomConfiguration);
            this.SetParamObj(map, prefix + "ComputerConfiguration.", this.ComputerConfiguration);
            this.SetParamArrayObj(map, prefix + "StorageMounts.", this.StorageMounts);
        }
    }
}

