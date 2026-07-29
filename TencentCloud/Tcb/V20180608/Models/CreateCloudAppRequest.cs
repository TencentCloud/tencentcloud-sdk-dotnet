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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCloudAppRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>环境ID</p>
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// <p>服务名</p>
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// <p>部署类型</p>
        /// </summary>
        [JsonProperty("DeployType")]
        public string DeployType{ get; set; }

        /// <summary>
        /// <p>构建类型</p>
        /// </summary>
        [JsonProperty("BuildType")]
        public string BuildType{ get; set; }

        /// <summary>
        /// <p>静态应用创建配置信息</p>
        /// </summary>
        [JsonProperty("StaticConfig")]
        public StaticConfig StaticConfig{ get; set; }

        /// <summary>
        /// <p>源码定义</p>
        /// </summary>
        [JsonProperty("Source")]
        public BuildSource Source{ get; set; }

        /// <summary>
        /// <p>Commands 与 CustomSteps 至少填一个</p>
        /// </summary>
        [JsonProperty("Commands")]
        public BuildCommands Commands{ get; set; }

        /// <summary>
        /// <p>Commands 与 CustomSteps 至少填一个，docker 镜像构建场景强烈建议用 CustomSteps</p>
        /// </summary>
        [JsonProperty("Env")]
        public Variable[] Env{ get; set; }

        /// <summary>
        /// <p>非敏感环境变量，构建容器中以 $KEY 引用</p>
        /// </summary>
        [JsonProperty("CustomSteps")]
        public BuildStep[] CustomSteps{ get; set; }

        /// <summary>
        /// <p>敏感凭证（AES 加密落库），构建容器中以 $SECRET_NAME 引用</p>
        /// </summary>
        [JsonProperty("Secrets")]
        public BuildSecret[] Secrets{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
            this.SetParamSimple(map, prefix + "DeployType", this.DeployType);
            this.SetParamSimple(map, prefix + "BuildType", this.BuildType);
            this.SetParamObj(map, prefix + "StaticConfig.", this.StaticConfig);
            this.SetParamObj(map, prefix + "Source.", this.Source);
            this.SetParamObj(map, prefix + "Commands.", this.Commands);
            this.SetParamArrayObj(map, prefix + "Env.", this.Env);
            this.SetParamArrayObj(map, prefix + "CustomSteps.", this.CustomSteps);
            this.SetParamArrayObj(map, prefix + "Secrets.", this.Secrets);
        }
    }
}

