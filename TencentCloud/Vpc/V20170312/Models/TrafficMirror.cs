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

    public class TrafficMirror : AbstractModel
    {
        
        /// <summary>
        /// VPC实例ID。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 流量镜像实例。
        /// </summary>
        [JsonProperty("TrafficMirrorId")]
        public string TrafficMirrorId{ get; set; }

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
        /// 流量镜像状态。
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// 流量镜像采集方向。
        /// </summary>
        [JsonProperty("Direction")]
        public string Direction{ get; set; }

        /// <summary>
        /// 流量镜像采集对象。
        /// </summary>
        [JsonProperty("CollectorSrcs")]
        public string[] CollectorSrcs{ get; set; }

        /// <summary>
        /// 流量镜像过滤的nat网关实例ID。
        /// </summary>
        [JsonProperty("NatId")]
        public string NatId{ get; set; }

        /// <summary>
        /// 流量镜像过滤的五元组规则。
        /// </summary>
        [JsonProperty("CollectorNormalFilters")]
        public TrafficMirrorFilter[] CollectorNormalFilters{ get; set; }

        /// <summary>
        /// 流量镜接收目标。
        /// </summary>
        [JsonProperty("CollectorTarget")]
        public TrafficMirrorTarget CollectorTarget{ get; set; }

        /// <summary>
        /// 流量镜像创建时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 流量镜像的类型。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 流量镜像所属的子网ID。
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 流量镜接收目标资源信息，当接收目标为ENI和CLB时返回。
        /// </summary>
        [JsonProperty("TargetInfo")]
        public TrafficMirrorTargetResourceInfo[] TargetInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "TrafficMirrorId", this.TrafficMirrorId);
            this.SetParamSimple(map, prefix + "TrafficMirrorName", this.TrafficMirrorName);
            this.SetParamSimple(map, prefix + "TrafficMirrorDescribe", this.TrafficMirrorDescribe);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
            this.SetParamArraySimple(map, prefix + "CollectorSrcs.", this.CollectorSrcs);
            this.SetParamSimple(map, prefix + "NatId", this.NatId);
            this.SetParamArrayObj(map, prefix + "CollectorNormalFilters.", this.CollectorNormalFilters);
            this.SetParamObj(map, prefix + "CollectorTarget.", this.CollectorTarget);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamArrayObj(map, prefix + "TargetInfo.", this.TargetInfo);
        }
    }
}

