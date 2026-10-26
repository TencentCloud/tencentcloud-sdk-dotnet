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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class KafkaConnectParam : AbstractModel
    {
        
        /// <summary>
        /// <p>Kafka连接源的实例资源, 非自建时必填，NetworkType=VPC时传clb实例id</p>
        /// </summary>
        [JsonProperty("Resource")]
        public string Resource{ get; set; }

        /// <summary>
        /// <p>是否为自建集群</p>
        /// </summary>
        [JsonProperty("SelfBuilt")]
        public bool? SelfBuilt{ get; set; }

        /// <summary>
        /// <p>是否更新到关联的Dip任务</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsUpdate")]
        public bool? IsUpdate{ get; set; }

        /// <summary>
        /// <p>Kafka连接的broker地址, NetworkType=PUBLIC公网时必填</p>
        /// </summary>
        [JsonProperty("BrokerAddress")]
        public string BrokerAddress{ get; set; }

        /// <summary>
        /// <p>CKafka连接源的实例资源地域, 跨地域时必填</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>网络类型：PUBLIC公网；VPC</p>
        /// </summary>
        [JsonProperty("NetworkType")]
        public string NetworkType{ get; set; }

        /// <summary>
        /// <p>vpcId，NetworkType=VPC时必传</p>
        /// </summary>
        [JsonProperty("UniqVpcId")]
        public string UniqVpcId{ get; set; }

        /// <summary>
        /// <p>vip，NetworkType=VPC时必传</p>
        /// </summary>
        [JsonProperty("ServiceVip")]
        public string ServiceVip{ get; set; }

        /// <summary>
        /// <p>端口，NetworkType=VPC时必传</p>
        /// </summary>
        [JsonProperty("Port")]
        public long? Port{ get; set; }

        /// <summary>
        /// <p>跨云同步下需要客户传递唯一Id标志一组资源</p>
        /// </summary>
        [JsonProperty("CrossNetResourceUniqueId")]
        public string CrossNetResourceUniqueId{ get; set; }

        /// <summary>
        /// <p>跨云子网ID</p>
        /// </summary>
        [JsonProperty("CrossNetVpcSubNetId")]
        public string CrossNetVpcSubNetId{ get; set; }

        /// <summary>
        /// <p>用户输入原始broker接入点地址</p>
        /// </summary>
        [JsonProperty("OriginalBrokerAddresses")]
        public string OriginalBrokerAddresses{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Resource", this.Resource);
            this.SetParamSimple(map, prefix + "SelfBuilt", this.SelfBuilt);
            this.SetParamSimple(map, prefix + "IsUpdate", this.IsUpdate);
            this.SetParamSimple(map, prefix + "BrokerAddress", this.BrokerAddress);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "NetworkType", this.NetworkType);
            this.SetParamSimple(map, prefix + "UniqVpcId", this.UniqVpcId);
            this.SetParamSimple(map, prefix + "ServiceVip", this.ServiceVip);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "CrossNetResourceUniqueId", this.CrossNetResourceUniqueId);
            this.SetParamSimple(map, prefix + "CrossNetVpcSubNetId", this.CrossNetVpcSubNetId);
            this.SetParamSimple(map, prefix + "OriginalBrokerAddresses", this.OriginalBrokerAddresses);
        }
    }
}

