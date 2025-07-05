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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CKafkaInstanceInfo : AbstractModel
    {
        
        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [JsonProperty("KafkaVersion")]
        public string KafkaVersion{ get; set; }

        /// <summary>
        /// 主题列表
        /// </summary>
        [JsonProperty("TopicList")]
        public CKafkaTopicInfo[] TopicList{ get; set; }

        /// <summary>
        /// 路由列表
        /// </summary>
        [JsonProperty("RouteList")]
        public CKafkaRouteInfo[] RouteList{ get; set; }

        /// <summary>
        /// 磁盘容量，单位GB
        /// </summary>
        [JsonProperty("DiskSize")]
        public long? DiskSize{ get; set; }

        /// <summary>
        /// vpcId，如果为空，说明是基础网络
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 子网id
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 状态，1表示健康，2表示告警，3 表示实例状态异常
        /// </summary>
        [JsonProperty("Healthy")]
        public long? Healthy{ get; set; }

        /// <summary>
        /// 可用区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 地域
        /// </summary>
        [JsonProperty("Az")]
        public string Az{ get; set; }

        /// <summary>
        /// 实例带宽，单位Mbps
        /// </summary>
        [JsonProperty("Bandwidth")]
        public long? Bandwidth{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "KafkaVersion", this.KafkaVersion);
            this.SetParamArrayObj(map, prefix + "TopicList.", this.TopicList);
            this.SetParamArrayObj(map, prefix + "RouteList.", this.RouteList);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "Healthy", this.Healthy);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "Az", this.Az);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
        }
    }
}

