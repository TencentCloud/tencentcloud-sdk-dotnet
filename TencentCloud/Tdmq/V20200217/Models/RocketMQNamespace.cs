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

    public class RocketMQNamespace : AbstractModel
    {
        
        /// <summary>
        /// 命名空间名称，3-64个字符，只能包含字母、数字、“-”及“_”
        /// </summary>
        [JsonProperty("NamespaceId")]
        public string NamespaceId{ get; set; }

        /// <summary>
        /// 已废弃，未消费消息的保留时间，以毫秒单位，范围60秒到15天
        /// </summary>
        [JsonProperty("Ttl")]
        public ulong? Ttl{ get; set; }

        /// <summary>
        /// 消息持久化后保留的时间，以毫秒单位
        /// </summary>
        [JsonProperty("RetentionTime")]
        public ulong? RetentionTime{ get; set; }

        /// <summary>
        /// 说明
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 公网接入点地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PublicEndpoint")]
        public string PublicEndpoint{ get; set; }

        /// <summary>
        /// VPC接入点地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VpcEndpoint")]
        public string VpcEndpoint{ get; set; }

        /// <summary>
        /// 内部接入点地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InternalEndpoint")]
        public string InternalEndpoint{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NamespaceId", this.NamespaceId);
            this.SetParamSimple(map, prefix + "Ttl", this.Ttl);
            this.SetParamSimple(map, prefix + "RetentionTime", this.RetentionTime);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "PublicEndpoint", this.PublicEndpoint);
            this.SetParamSimple(map, prefix + "VpcEndpoint", this.VpcEndpoint);
            this.SetParamSimple(map, prefix + "InternalEndpoint", this.InternalEndpoint);
        }
    }
}

