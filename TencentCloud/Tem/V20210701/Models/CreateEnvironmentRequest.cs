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

namespace TencentCloud.Tem.V20210701.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateEnvironmentRequest : AbstractModel
    {
        
        /// <summary>
        /// 环境名称
        /// </summary>
        [JsonProperty("EnvironmentName")]
        public string EnvironmentName{ get; set; }

        /// <summary>
        /// 环境描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 私有网络名称
        /// </summary>
        [JsonProperty("Vpc")]
        public string Vpc{ get; set; }

        /// <summary>
        /// 子网列表
        /// </summary>
        [JsonProperty("SubnetIds")]
        public string[] SubnetIds{ get; set; }

        /// <summary>
        /// K8s version
        /// </summary>
        [JsonProperty("K8sVersion")]
        public string K8sVersion{ get; set; }

        /// <summary>
        /// 来源渠道
        /// </summary>
        [JsonProperty("SourceChannel")]
        public long? SourceChannel{ get; set; }

        /// <summary>
        /// 是否开启tsw服务。默认值：false
        /// </summary>
        [JsonProperty("EnableTswTraceService")]
        public bool? EnableTswTraceService{ get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 环境类型：test、pre、prod。默认值：prod
        /// </summary>
        [JsonProperty("EnvType")]
        public string EnvType{ get; set; }

        /// <summary>
        /// 创建环境的region
        /// </summary>
        [JsonProperty("CreateRegion")]
        public string CreateRegion{ get; set; }

        /// <summary>
        /// 是否创建私有网络.默认值:true
        /// </summary>
        [JsonProperty("SetupVpc")]
        public bool? SetupVpc{ get; set; }

        /// <summary>
        /// 是否创建 Prometheus 实例。默认值：false
        /// </summary>
        [JsonProperty("SetupPrometheus")]
        public bool? SetupPrometheus{ get; set; }

        /// <summary>
        /// prometheus 实例 id
        /// </summary>
        [JsonProperty("PrometheusId")]
        public string PrometheusId{ get; set; }

        /// <summary>
        /// apm id
        /// </summary>
        [JsonProperty("ApmId")]
        public string ApmId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvironmentName", this.EnvironmentName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Vpc", this.Vpc);
            this.SetParamArraySimple(map, prefix + "SubnetIds.", this.SubnetIds);
            this.SetParamSimple(map, prefix + "K8sVersion", this.K8sVersion);
            this.SetParamSimple(map, prefix + "SourceChannel", this.SourceChannel);
            this.SetParamSimple(map, prefix + "EnableTswTraceService", this.EnableTswTraceService);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "EnvType", this.EnvType);
            this.SetParamSimple(map, prefix + "CreateRegion", this.CreateRegion);
            this.SetParamSimple(map, prefix + "SetupVpc", this.SetupVpc);
            this.SetParamSimple(map, prefix + "SetupPrometheus", this.SetupPrometheus);
            this.SetParamSimple(map, prefix + "PrometheusId", this.PrometheusId);
            this.SetParamSimple(map, prefix + "ApmId", this.ApmId);
        }
    }
}

