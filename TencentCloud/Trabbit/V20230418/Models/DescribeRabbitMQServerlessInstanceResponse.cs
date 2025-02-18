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

namespace TencentCloud.Trabbit.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeRabbitMQServerlessInstanceResponse : AbstractModel
    {
        
        /// <summary>
        /// 集群信息
        /// </summary>
        [JsonProperty("ClusterInfo")]
        public RabbitMQClusterInfo ClusterInfo{ get; set; }

        /// <summary>
        /// 集群规格信息
        /// </summary>
        [JsonProperty("ClusterSpecInfo")]
        public RabbitMQClusterSpecInfo ClusterSpecInfo{ get; set; }

        /// <summary>
        /// vhost配额信息
        /// </summary>
        [JsonProperty("VirtualHostQuota")]
        public VirtualHostQuota VirtualHostQuota{ get; set; }

        /// <summary>
        /// exchange配额信息
        /// </summary>
        [JsonProperty("ExchangeQuota")]
        public ExchangeQuota ExchangeQuota{ get; set; }

        /// <summary>
        /// queue配额信息
        /// </summary>
        [JsonProperty("QueueQuota")]
        public QueueQuota QueueQuota{ get; set; }

        /// <summary>
        /// 网络信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterNetInfo")]
        public RabbitMQServerlessAccessInfo ClusterNetInfo{ get; set; }

        /// <summary>
        /// 公网白名单信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterWhiteListInfo")]
        public RabbitMQServerlessWhiteListInfo ClusterWhiteListInfo{ get; set; }

        /// <summary>
        /// user配额信息
        /// </summary>
        [JsonProperty("UserQuota")]
        public UserQuota UserQuota{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ClusterInfo.", this.ClusterInfo);
            this.SetParamObj(map, prefix + "ClusterSpecInfo.", this.ClusterSpecInfo);
            this.SetParamObj(map, prefix + "VirtualHostQuota.", this.VirtualHostQuota);
            this.SetParamObj(map, prefix + "ExchangeQuota.", this.ExchangeQuota);
            this.SetParamObj(map, prefix + "QueueQuota.", this.QueueQuota);
            this.SetParamObj(map, prefix + "ClusterNetInfo.", this.ClusterNetInfo);
            this.SetParamObj(map, prefix + "ClusterWhiteListInfo.", this.ClusterWhiteListInfo);
            this.SetParamObj(map, prefix + "UserQuota.", this.UserQuota);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

