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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LogDeliveryCkafkaConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>接入类型</p>
        /// </summary>
        [JsonProperty("VipType")]
        public long? VipType{ get; set; }

        /// <summary>
        /// <p>实例id</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>实例名称</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>虚拟ip  VipType 为7 有效</p>
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// <p>虚拟端口 VipType 为7有效</p>
        /// </summary>
        [JsonProperty("Vport")]
        public string Vport{ get; set; }

        /// <summary>
        /// <p>域名  VipType 为1有效</p>
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// <p>域名端口 VipType 为1有效</p>
        /// </summary>
        [JsonProperty("DomainPort")]
        public string DomainPort{ get; set; }

        /// <summary>
        /// <p>实例地域</p>
        /// </summary>
        [JsonProperty("RegionId")]
        public string RegionId{ get; set; }

        /// <summary>
        /// <p>实例vpc</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>实例子网</p>
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p>实例健康状态， 1：健康，2：告警，3：异常&#39;, 4: 实例不存在</p>
        /// </summary>
        [JsonProperty("Healthy")]
        public long? Healthy{ get; set; }

        /// <summary>
        /// <p>日志类型</p>
        /// </summary>
        [JsonProperty("LogType")]
        public long? LogType{ get; set; }

        /// <summary>
        /// <p>投递的topicid</p>
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// <p>投递的topicname</p>
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// <p>投递状态</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>状态信息</p>
        /// </summary>
        [JsonProperty("StatusMessages")]
        public string StatusMessages{ get; set; }

        /// <summary>
        /// <p>开启or关闭，投递状态1为开启，0 关闭，默认开启，但是如果没有topic 则关闭</p>
        /// </summary>
        [JsonProperty("IsOpen")]
        public long? IsOpen{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VipType", this.VipType);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "Vport", this.Vport);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "DomainPort", this.DomainPort);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "Healthy", this.Healthy);
            this.SetParamSimple(map, prefix + "LogType", this.LogType);
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StatusMessages", this.StatusMessages);
            this.SetParamSimple(map, prefix + "IsOpen", this.IsOpen);
        }
    }
}

