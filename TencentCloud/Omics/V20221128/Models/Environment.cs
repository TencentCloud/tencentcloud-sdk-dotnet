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

namespace TencentCloud.Omics.V20221128.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Environment : AbstractModel
    {
        
        /// <summary>
        /// 环境ID。
        /// </summary>
        [JsonProperty("EnvironmentId")]
        public string EnvironmentId{ get; set; }

        /// <summary>
        /// 环境名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 环境描述信息。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 环境地域。
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 环境类型，取值范围：
        /// - KUBERNETES：Kubernetes容器集群
        /// - HPC：HPC高性能计算集群
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 环境状态，取值范围：
        /// - INITIALIZING：创建中
        /// - INITIALIZATION_ERROR：创建失败
        /// - RUNNING：运行中
        /// - ERROR：异常
        /// - DELETING：正在删除
        /// - DELETE_ERROR：删除失败
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 环境是否可用。环境需要可用才能投递计算任务。
        /// </summary>
        [JsonProperty("Available")]
        public bool? Available{ get; set; }

        /// <summary>
        /// 环境是否为默认环境。
        /// </summary>
        [JsonProperty("IsDefault")]
        public bool? IsDefault{ get; set; }

        /// <summary>
        /// 环境是否为托管环境。
        /// </summary>
        [JsonProperty("IsManaged")]
        public bool? IsManaged{ get; set; }

        /// <summary>
        /// 环境信息。
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// 云资源ID。
        /// </summary>
        [JsonProperty("ResourceIds")]
        public ResourceIds ResourceIds{ get; set; }

        /// <summary>
        /// 上个工作流UUID。
        /// </summary>
        [JsonProperty("LastWorkflowUuid")]
        public string LastWorkflowUuid{ get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("CreationTime")]
        public string CreationTime{ get; set; }

        /// <summary>
        /// 运行时配置。
        /// </summary>
        [JsonProperty("RuntimeConfig")]
        public EnvironmentRuntimeConfig RuntimeConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvironmentId", this.EnvironmentId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Available", this.Available);
            this.SetParamSimple(map, prefix + "IsDefault", this.IsDefault);
            this.SetParamSimple(map, prefix + "IsManaged", this.IsManaged);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamObj(map, prefix + "ResourceIds.", this.ResourceIds);
            this.SetParamSimple(map, prefix + "LastWorkflowUuid", this.LastWorkflowUuid);
            this.SetParamSimple(map, prefix + "CreationTime", this.CreationTime);
            this.SetParamObj(map, prefix + "RuntimeConfig.", this.RuntimeConfig);
        }
    }
}

