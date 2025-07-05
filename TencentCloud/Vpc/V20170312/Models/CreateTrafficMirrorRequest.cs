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

    public class CreateTrafficMirrorRequest : AbstractModel
    {
        
        /// <summary>
        /// VPC实例ID。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 流量镜像名字。
        /// </summary>
        [JsonProperty("TrafficMirrorName")]
        public string TrafficMirrorName{ get; set; }

        /// <summary>
        /// 流量镜像描述。
        /// </summary>
        [JsonProperty("TrafficMirrorDescribe")]
        public string TrafficMirrorDescribe{ get; set; }

        /// <summary>
        /// 流量镜像状态, 支持RUNNING/STOPED（vpc），RUNNING（公网IP），当采集vpc流量镜像时，此参数为必填。
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// 流量镜像采集方向，支持EGRESS/INGRESS/ALL（vpc），ALL（公网IP）。
        /// </summary>
        [JsonProperty("Direction")]
        public string Direction{ get; set; }

        /// <summary>
        /// 流量镜像的采集对象。
        /// </summary>
        [JsonProperty("CollectorSrcs")]
        public string[] CollectorSrcs{ get; set; }

        /// <summary>
        /// 流量镜像过滤的natgw实例。
        /// </summary>
        [JsonProperty("NatId")]
        public string NatId{ get; set; }

        /// <summary>
        /// 需要过滤的五元组规则。
        /// </summary>
        [JsonProperty("CollectorNormalFilters")]
        public TrafficMirrorFilter[] CollectorNormalFilters{ get; set; }

        /// <summary>
        /// 流量镜像的目的地址。
        /// </summary>
        [JsonProperty("CollectorTarget")]
        public TrafficMirrorTarget CollectorTarget{ get; set; }

        /// <summary>
        /// 流量镜像采集流量的发送端所属子网ID。
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 创建的流量镜像的类型，支持VPC/PUBLICIP，默认为VPC类型。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 指定绑定的标签列表，例如：[{"Key": "city", "Value": "shanghai"}]。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "TrafficMirrorName", this.TrafficMirrorName);
            this.SetParamSimple(map, prefix + "TrafficMirrorDescribe", this.TrafficMirrorDescribe);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
            this.SetParamArraySimple(map, prefix + "CollectorSrcs.", this.CollectorSrcs);
            this.SetParamSimple(map, prefix + "NatId", this.NatId);
            this.SetParamArrayObj(map, prefix + "CollectorNormalFilters.", this.CollectorNormalFilters);
            this.SetParamObj(map, prefix + "CollectorTarget.", this.CollectorTarget);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

