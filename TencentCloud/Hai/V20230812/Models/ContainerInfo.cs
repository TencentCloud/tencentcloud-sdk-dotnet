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

namespace TencentCloud.Hai.V20230812.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ContainerInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>镜像相关信息</p>
        /// </summary>
        [JsonProperty("Image")]
        public ImageInfo Image{ get; set; }

        /// <summary>
        /// <p>服务监听端口</p>
        /// </summary>
        [JsonProperty("Port")]
        public string Port{ get; set; }

        /// <summary>
        /// <p>启动命令</p>
        /// </summary>
        [JsonProperty("Scripts")]
        public string[] Scripts{ get; set; }

        /// <summary>
        /// <p>环境变量列表</p>
        /// </summary>
        [JsonProperty("Envs")]
        public EnvParam[] Envs{ get; set; }

        /// <summary>
        /// <p>存储挂载配置</p>
        /// </summary>
        [JsonProperty("Storages")]
        public StorageInfo[] Storages{ get; set; }

        /// <summary>
        /// <p>探针信息</p>
        /// </summary>
        [JsonProperty("Probe")]
        public ProbeInfo Probe{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Image.", this.Image);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamArraySimple(map, prefix + "Scripts.", this.Scripts);
            this.SetParamArrayObj(map, prefix + "Envs.", this.Envs);
            this.SetParamArrayObj(map, prefix + "Storages.", this.Storages);
            this.SetParamObj(map, prefix + "Probe.", this.Probe);
        }
    }
}

