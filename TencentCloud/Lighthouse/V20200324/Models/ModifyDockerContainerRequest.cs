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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDockerContainerRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例ID。可通过[DescribeInstances](https://cloud.tencent.com/document/product/1207/47573)接口返回值中的InstanceId获取。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 容器ID。可通过[DescribeDockerContainers](https://cloud.tencent.com/document/product/1207/95473)接口返回值中的ContainerId获取。
        /// </summary>
        [JsonProperty("ContainerId")]
        public string ContainerId{ get; set; }

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
        /// 容器重启策略，对应docker "--restart"参数。
        /// 
        /// 枚举值:
        /// no: 不自动重启。默认策略。
        /// on-failure[:max-retries]: 当容器退出码非0时重启容器。使用max-retries限制重启次数，比如on-failure:10，限制最多重启10次。
        /// always: 只要容器退出就重启。
        /// unless-stopped: 始终重新启动容器，包括在守护进程启动时，除非容器在 Docker 守护进程停止之前进入停止状态。
        /// </summary>
        [JsonProperty("RestartPolicy")]
        public string RestartPolicy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ContainerId", this.ContainerId);
            this.SetParamArrayObj(map, prefix + "Envs.", this.Envs);
            this.SetParamArrayObj(map, prefix + "PublishPorts.", this.PublishPorts);
            this.SetParamArrayObj(map, prefix + "Volumes.", this.Volumes);
            this.SetParamSimple(map, prefix + "Command", this.Command);
            this.SetParamSimple(map, prefix + "RestartPolicy", this.RestartPolicy);
        }
    }
}

