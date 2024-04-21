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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PulsarNetworkAccessPointInfo : AbstractModel
    {
        
        /// <summary>
        /// vpc的id，支撑网和公网接入点，该字段为空
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 子网id，支撑网和公网接入点，该字段为空
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 接入地址
        /// </summary>
        [JsonProperty("Endpoint")]
        public string Endpoint{ get; set; }

        /// <summary>
        /// 实例id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 接入点类型：
        /// 0：支撑网接入点 
        /// 1：VPC接入点 
        /// 2：公网接入点
        /// </summary>
        [JsonProperty("RouteType")]
        public ulong? RouteType{ get; set; }

        /// <summary>
        /// 0：本地域访问，由于并没有配置跨地域容灾，所该类型的接入点，无法进行异地切换、异地访问切回；
        /// 1：本地域访问，由于配置了跨地域容灾，随时可以进行异地切换，该状态用于主集群的接入点
        /// 2：跨地域访问，已经完成了异地切换，该状态用于源集群的接入点，该状态下的接入点不可删除
        /// 3：跨地域访问，随时可以进行异地访问切回，该状态用于目标集群的接入点，该状态下的接入点不可删除
        /// 4:跨地域访问，目标集群已经完成异地切回，等待删除状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OperationType")]
        public ulong? OperationType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "Endpoint", this.Endpoint);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "RouteType", this.RouteType);
            this.SetParamSimple(map, prefix + "OperationType", this.OperationType);
        }
    }
}

