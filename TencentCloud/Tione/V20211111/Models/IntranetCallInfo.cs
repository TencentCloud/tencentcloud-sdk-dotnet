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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IntranetCallInfo : AbstractModel
    {
        
        /// <summary>
        /// 私有连接通道信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IngressPrivateLinkInfo")]
        public IngressPrivateLinkInfo IngressPrivateLinkInfo{ get; set; }

        /// <summary>
        /// 共享弹性网卡信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceEIPInfo")]
        public ServiceEIPInfo[] ServiceEIPInfo{ get; set; }

        /// <summary>
        /// 默认内网调用信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DefaultInnerCallInfos")]
        public DefaultInnerCallInfo[] DefaultInnerCallInfos{ get; set; }

        /// <summary>
        /// 私有连接信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PrivateLinkInfos")]
        public PrivateLinkInfo[] PrivateLinkInfos{ get; set; }

        /// <summary>
        /// 基于新网关的私有连接信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PrivateLinkInfosV2")]
        public PrivateLinkInfo[] PrivateLinkInfosV2{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "IngressPrivateLinkInfo.", this.IngressPrivateLinkInfo);
            this.SetParamArrayObj(map, prefix + "ServiceEIPInfo.", this.ServiceEIPInfo);
            this.SetParamArrayObj(map, prefix + "DefaultInnerCallInfos.", this.DefaultInnerCallInfos);
            this.SetParamArrayObj(map, prefix + "PrivateLinkInfos.", this.PrivateLinkInfos);
            this.SetParamArrayObj(map, prefix + "PrivateLinkInfosV2.", this.PrivateLinkInfosV2);
        }
    }
}

