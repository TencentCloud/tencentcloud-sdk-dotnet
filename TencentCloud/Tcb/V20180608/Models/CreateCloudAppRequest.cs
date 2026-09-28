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
        /// <p>选择 NodeRuntime 版本: 16,18,20,22,24 等</p>
        /// </summary>
        [JsonProperty("NodeJsVersion")]
        public string NodeJsVersion{ get; set; }

        /// <summary>
        /// <p>暂不支持：Webhook 触发器功能尚未对外开放，客户端传入的 Trigger 字段会被平台静默忽略（仅日志告警，不拒绝请求）</p>
        /// </summary>
        [JsonProperty("Trigger")]
        public CloudAppTrigger Trigger{ get; set; }

        /// <summary>
        /// <p>服务列表</p>
        /// </summary>
        [JsonProperty("ServiceList")]
        public CloudAppLinkService[] ServiceList{ get; set; }

        /// <summary>
        /// <p>全局工作目录</p>
        /// </summary>
        [JsonProperty("WorkingDir")]
        public string WorkingDir{ get; set; }

        /// <summary>
        /// <p>路由列表</p>
        /// </summary>
        [JsonProperty("Routes")]
        public CloudAppRoute[] Routes{ get; set; }

        /// <summary>
        /// <p>部署类型</p>
        /// </summary>
        [JsonProperty("PromoteType")]
        public string PromoteType{ get; set; }

        /// <summary>
        /// <p>发布 Token 校验</p>
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// <p>前置执行命令</p>
        /// </summary>
        [JsonProperty("PreDeployCommand")]
        public string PreDeployCommand{ get; set; }

        /// <summary>
        /// <p>后置执行命令</p>
        /// </summary>
        [JsonProperty("PostDeployCommand")]
        public string PostDeployCommand{ get; set; }


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
            this.SetParamSimple(map, prefix + "NodeJsVersion", this.NodeJsVersion);
            this.SetParamObj(map, prefix + "Trigger.", this.Trigger);
            this.SetParamArrayObj(map, prefix + "ServiceList.", this.ServiceList);
            this.SetParamSimple(map, prefix + "WorkingDir", this.WorkingDir);
            this.SetParamArrayObj(map, prefix + "Routes.", this.Routes);
            this.SetParamSimple(map, prefix + "PromoteType", this.PromoteType);
            this.SetParamSimple(map, prefix + "ClientToken", this.ClientToken);
            this.SetParamSimple(map, prefix + "PreDeployCommand", this.PreDeployCommand);
            this.SetParamSimple(map, prefix + "PostDeployCommand", this.PostDeployCommand);
        }
    }
}

