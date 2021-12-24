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

namespace TencentCloud.Iecp.V20210914.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateEdgeUnitApplicationVisualizationRequest : AbstractModel
    {
        
        /// <summary>
        /// 基本信息
        /// </summary>
        [JsonProperty("BasicInfo")]
        public ApplicationBasicInfo BasicInfo{ get; set; }

        /// <summary>
        /// 基本配置
        /// </summary>
        [JsonProperty("BasicConfig")]
        public ApplicationBasicConfig BasicConfig{ get; set; }

        /// <summary>
        /// 单元ID
        /// </summary>
        [JsonProperty("EdgeUnitId")]
        public ulong? EdgeUnitId{ get; set; }

        /// <summary>
        /// 卷列表
        /// </summary>
        [JsonProperty("Volumes")]
        public Volume[] Volumes{ get; set; }

        /// <summary>
        /// 服务配置
        /// </summary>
        [JsonProperty("Service")]
        public Service Service{ get; set; }

        /// <summary>
        /// 模版ID
        /// </summary>
        [JsonProperty("TemplateID")]
        public ulong? TemplateID{ get; set; }

        /// <summary>
        /// Job配置
        /// </summary>
        [JsonProperty("Job")]
        public Job Job{ get; set; }

        /// <summary>
        /// CronJob配置
        /// </summary>
        [JsonProperty("CronJob")]
        public CronJob CronJob{ get; set; }

        /// <summary>
        /// 重新运行策略
        /// </summary>
        [JsonProperty("RestartPolicy")]
        public string RestartPolicy{ get; set; }

        /// <summary>
        /// 镜像拉取密钥
        /// </summary>
        [JsonProperty("ImagePullSecrets")]
        public string[] ImagePullSecrets{ get; set; }

        /// <summary>
        /// HPA配置
        /// </summary>
        [JsonProperty("HorizontalPodAutoscaler")]
        public HorizontalPodAutoscaler HorizontalPodAutoscaler{ get; set; }

        /// <summary>
        /// 初始化容器列表
        /// </summary>
        [JsonProperty("InitContainers")]
        public Container[] InitContainers{ get; set; }

        /// <summary>
        /// 容器列表
        /// </summary>
        [JsonProperty("Containers")]
        public Container[] Containers{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "BasicInfo.", this.BasicInfo);
            this.SetParamObj(map, prefix + "BasicConfig.", this.BasicConfig);
            this.SetParamSimple(map, prefix + "EdgeUnitId", this.EdgeUnitId);
            this.SetParamArrayObj(map, prefix + "Volumes.", this.Volumes);
            this.SetParamObj(map, prefix + "Service.", this.Service);
            this.SetParamSimple(map, prefix + "TemplateID", this.TemplateID);
            this.SetParamObj(map, prefix + "Job.", this.Job);
            this.SetParamObj(map, prefix + "CronJob.", this.CronJob);
            this.SetParamSimple(map, prefix + "RestartPolicy", this.RestartPolicy);
            this.SetParamArraySimple(map, prefix + "ImagePullSecrets.", this.ImagePullSecrets);
            this.SetParamObj(map, prefix + "HorizontalPodAutoscaler.", this.HorizontalPodAutoscaler);
            this.SetParamArrayObj(map, prefix + "InitContainers.", this.InitContainers);
            this.SetParamArrayObj(map, prefix + "Containers.", this.Containers);
        }
    }
}

