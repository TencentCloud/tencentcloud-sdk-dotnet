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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateFlowLogRequest : AbstractModel
    {
        
        /// <summary>
        /// 流日志实例名称。长度为不超过60个字符。
        /// </summary>
        [JsonProperty("FlowLogName")]
        public string FlowLogName{ get; set; }

        /// <summary>
        /// 流日志所属资源类型，VPC（私有网络），SUBNET（子网），NETWORKINTERFACE（网卡），CCN（云联网），NAT（网络地址转化），DCG（专线网关）。当选择VPC，SUBNET，CCN，DCG时，请通过工单加入白名单。
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// 资源唯一ID。
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 流日志采集类型，ACCEPT（允许），REJECT（拒绝），ALL（全部）。
        /// </summary>
        [JsonProperty("TrafficType")]
        public string TrafficType{ get; set; }

        /// <summary>
        /// 私用网络唯一ID。当ResourceType为CCN时不填，其他类型必填。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 流日志实例描述。长度不超过512个字符。
        /// </summary>
        [JsonProperty("FlowLogDescription")]
        public string FlowLogDescription{ get; set; }

        /// <summary>
        /// 流日志存储ID（cls的日志主题ID，
        /// 可通过[DescribeTopics](https://cloud.tencent.com/document/product/614/56454)接口获取）。当StorageType为cls时，CloudLogId为必选。
        /// </summary>
        [JsonProperty("CloudLogId")]
        public string CloudLogId{ get; set; }

        /// <summary>
        /// 指定绑定的标签列表，例如：[{"Key": "city", "Value": "shanghai"}]。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 消费端类型：cls、ckafka。默认值cls。当选择ckafka时，请通过工单加入白名单。
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// 流日志消费端信息，当消费端类型为ckafka时，必填。
        /// </summary>
        [JsonProperty("FlowLogStorage")]
        public FlowLogStorage FlowLogStorage{ get; set; }

        /// <summary>
        /// 流日志存储ID对应的地域，不传递默认为本地域。
        /// </summary>
        [JsonProperty("CloudLogRegion")]
        public string CloudLogRegion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FlowLogName", this.FlowLogName);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "TrafficType", this.TrafficType);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "FlowLogDescription", this.FlowLogDescription);
            this.SetParamSimple(map, prefix + "CloudLogId", this.CloudLogId);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamObj(map, prefix + "FlowLogStorage.", this.FlowLogStorage);
            this.SetParamSimple(map, prefix + "CloudLogRegion", this.CloudLogRegion);
        }
    }
}

