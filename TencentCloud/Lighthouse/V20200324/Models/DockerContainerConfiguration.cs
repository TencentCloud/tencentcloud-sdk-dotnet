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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DockerContainerConfiguration : AbstractModel
    {
        
        /// <summary>
        /// 容器镜像地址
        /// </summary>
        [JsonProperty("ContainerImage")]
        public string ContainerImage{ get; set; }

        /// <summary>
        /// 容器名称
        /// </summary>
        [JsonProperty("ContainerName")]
        public string ContainerName{ get; set; }

        /// <summary>
        /// 环境变量列表
        /// </summary>
        [JsonProperty("Envs")]
        public ContainerEnv[] Envs{ get; set; }

        /// <summary>
        /// 容器端口主机端口映射列表
        /// </summary>
        [JsonProperty("PublishPorts")]
        public DockerContainerPublishPort[] PublishPorts{ get; set; }

        /// <summary>
        /// 容器加载本地卷列表
        /// </summary>
        [JsonProperty("Volumes")]
        public DockerContainerVolume[] Volumes{ get; set; }

        /// <summary>
        /// 运行的命令
        /// </summary>
        [JsonProperty("Command")]
        public string Command{ get; set; }

        /// <summary>
        /// 容器重启策略。
        /// - no -默认策略，在容器退出时不重启容器
        /// - on-failure -在容器非正常退出时（退出状态非0），才会重启容器
        /// - on-failure:3 -在容器非正常退出时重启容器，最多重启3次
        /// - always -在容器退出时总是重启容器
        /// </summary>
        [JsonProperty("RestartPolicy")]
        public string RestartPolicy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ContainerImage", this.ContainerImage);
            this.SetParamSimple(map, prefix + "ContainerName", this.ContainerName);
            this.SetParamArrayObj(map, prefix + "Envs.", this.Envs);
            this.SetParamArrayObj(map, prefix + "PublishPorts.", this.PublishPorts);
            this.SetParamArrayObj(map, prefix + "Volumes.", this.Volumes);
            this.SetParamSimple(map, prefix + "Command", this.Command);
            this.SetParamSimple(map, prefix + "RestartPolicy", this.RestartPolicy);
        }
    }
}

