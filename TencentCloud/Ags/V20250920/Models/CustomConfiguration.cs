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

    public class CustomConfiguration : AbstractModel
    {
        
        /// <summary>
        /// <p>镜像地址</p>
        /// </summary>
        [JsonProperty("Image")]
        public string Image{ get; set; }

        /// <summary>
        /// <p>镜像仓库类型：<code>enterprise</code>、<code>personal</code>。</p>
        /// </summary>
        [JsonProperty("ImageRegistryType")]
        public string ImageRegistryType{ get; set; }

        /// <summary>
        /// <p>启动命令</p>
        /// </summary>
        [JsonProperty("Command")]
        public string[] Command{ get; set; }

        /// <summary>
        /// <p>启动参数</p>
        /// </summary>
        [JsonProperty("Args")]
        public string[] Args{ get; set; }

        /// <summary>
        /// <p>环境变量</p>
        /// </summary>
        [JsonProperty("Env")]
        public EnvVar[] Env{ get; set; }

        /// <summary>
        /// <p>端口配置</p>
        /// </summary>
        [JsonProperty("Ports")]
        public PortConfiguration[] Ports{ get; set; }

        /// <summary>
        /// <p>资源配置</p>
        /// </summary>
        [JsonProperty("Resources")]
        public ResourceConfiguration Resources{ get; set; }

        /// <summary>
        /// <p>探针配置</p>
        /// </summary>
        [JsonProperty("Probe")]
        public ProbeConfiguration Probe{ get; set; }

        /// <summary>
        /// <p>沙箱 DNS 配置</p>
        /// </summary>
        [JsonProperty("DNSConfig")]
        public DNSConfig DNSConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Image", this.Image);
            this.SetParamSimple(map, prefix + "ImageRegistryType", this.ImageRegistryType);
            this.SetParamArraySimple(map, prefix + "Command.", this.Command);
            this.SetParamArraySimple(map, prefix + "Args.", this.Args);
            this.SetParamArrayObj(map, prefix + "Env.", this.Env);
            this.SetParamArrayObj(map, prefix + "Ports.", this.Ports);
            this.SetParamObj(map, prefix + "Resources.", this.Resources);
            this.SetParamObj(map, prefix + "Probe.", this.Probe);
            this.SetParamObj(map, prefix + "DNSConfig.", this.DNSConfig);
        }
    }
}

