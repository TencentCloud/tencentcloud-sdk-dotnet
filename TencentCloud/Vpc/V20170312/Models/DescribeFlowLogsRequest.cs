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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeFlowLogsRequest : AbstractModel
    {
        
        /// <summary>
        /// 私用网络ID或者统一ID，建议使用统一ID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 流日志唯一ID
        /// </summary>
        [JsonProperty("FlowLogId")]
        public string FlowLogId{ get; set; }

        /// <summary>
        /// 流日志实例名字
        /// </summary>
        [JsonProperty("FlowLogName")]
        public string FlowLogName{ get; set; }

        /// <summary>
        /// 流日志所属资源类型，VPC|SUBNET|NETWORKINTERFACE
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// 资源唯一ID
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 流日志采集类型，ACCEPT|REJECT|ALL
        /// </summary>
        [JsonProperty("TrafficType")]
        public string TrafficType{ get; set; }

        /// <summary>
        /// 流日志存储ID
        /// </summary>
        [JsonProperty("CloudLogId")]
        public string CloudLogId{ get; set; }

        /// <summary>
        /// 流日志存储ID状态
        /// </summary>
        [JsonProperty("CloudLogState")]
        public string CloudLogState{ get; set; }

        /// <summary>
        /// 按某个字段排序,支持字段：flowLogName,createTime，默认按createTime
        /// </summary>
        [JsonProperty("OrderField")]
        public string OrderField{ get; set; }

        /// <summary>
        /// 升序（asc）还是降序（desc）,默认：desc
        /// </summary>
        [JsonProperty("OrderDirection")]
        public string OrderDirection{ get; set; }

        /// <summary>
        /// 偏移量，默认为0。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 每页行数，默认为10
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "FlowLogId", this.FlowLogId);
            this.SetParamSimple(map, prefix + "FlowLogName", this.FlowLogName);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "TrafficType", this.TrafficType);
            this.SetParamSimple(map, prefix + "CloudLogId", this.CloudLogId);
            this.SetParamSimple(map, prefix + "CloudLogState", this.CloudLogState);
            this.SetParamSimple(map, prefix + "OrderField", this.OrderField);
            this.SetParamSimple(map, prefix + "OrderDirection", this.OrderDirection);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

