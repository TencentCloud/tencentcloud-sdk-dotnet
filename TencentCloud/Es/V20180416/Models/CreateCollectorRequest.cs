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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCollectorRequest : AbstractModel
    {
        
        /// <summary>
        /// 采集器名称（1-50 个英文、汉字、数字、连接线-或下划线_）
        /// </summary>
        [JsonProperty("CollectorName")]
        public string CollectorName{ get; set; }

        /// <summary>
        /// 采集器版本（支持"6.8.15"、"7.10.2"）
        /// </summary>
        [JsonProperty("CollectorVersion")]
        public string CollectorVersion{ get; set; }

        /// <summary>
        /// 采集器类型（支持filebeat、metricbeat、heartbeat、auditbeat、packetbeat）
        /// </summary>
        [JsonProperty("CollectorType")]
        public string CollectorType{ get; set; }

        /// <summary>
        /// 采集器输出的ES实例信息
        /// </summary>
        [JsonProperty("OutputInstance")]
        public CollectorOutputInstance OutputInstance{ get; set; }

        /// <summary>
        /// 采集器配置
        /// </summary>
        [JsonProperty("CollectorConfigs")]
        public CollectorConfigInfo[] CollectorConfigs{ get; set; }

        /// <summary>
        /// 采集器下发的CVM实例ID列表
        /// </summary>
        [JsonProperty("CVMInstanceIds")]
        public string[] CVMInstanceIds{ get; set; }

        /// <summary>
        /// 采集目标类型，CVM或者TKE
        /// </summary>
        [JsonProperty("TargetType")]
        public string TargetType{ get; set; }

        /// <summary>
        /// 容器集群ID，采集目标为TKE时必填
        /// </summary>
        [JsonProperty("ContainerClusterId")]
        public string ContainerClusterId{ get; set; }

        /// <summary>
        /// 采集器配置，采集目标为TKE时必填
        /// </summary>
        [JsonProperty("CollectorTargets")]
        public CollectorTarget[] CollectorTargets{ get; set; }

        /// <summary>
        /// 标签信息
        /// </summary>
        [JsonProperty("TagList")]
        public TagInfo[] TagList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CollectorName", this.CollectorName);
            this.SetParamSimple(map, prefix + "CollectorVersion", this.CollectorVersion);
            this.SetParamSimple(map, prefix + "CollectorType", this.CollectorType);
            this.SetParamObj(map, prefix + "OutputInstance.", this.OutputInstance);
            this.SetParamArrayObj(map, prefix + "CollectorConfigs.", this.CollectorConfigs);
            this.SetParamArraySimple(map, prefix + "CVMInstanceIds.", this.CVMInstanceIds);
            this.SetParamSimple(map, prefix + "TargetType", this.TargetType);
            this.SetParamSimple(map, prefix + "ContainerClusterId", this.ContainerClusterId);
            this.SetParamArrayObj(map, prefix + "CollectorTargets.", this.CollectorTargets);
            this.SetParamArrayObj(map, prefix + "TagList.", this.TagList);
        }
    }
}

