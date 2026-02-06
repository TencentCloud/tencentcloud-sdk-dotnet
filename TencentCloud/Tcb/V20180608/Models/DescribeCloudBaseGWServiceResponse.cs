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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCloudBaseGWServiceResponse : AbstractModel
    {
        
        /// <summary>
        /// 服务列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceSet")]
        public CloudBaseGWService[] ServiceSet{ get; set; }

        /// <summary>
        /// 是否开启服务
        /// </summary>
        [JsonProperty("EnableService")]
        public bool? EnableService{ get; set; }

        /// <summary>
        /// 默认域名信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DefaultDomain")]
        public string DefaultDomain{ get; set; }

        /// <summary>
        /// 是否开启CDN迁移
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableUnion")]
        public bool? EnableUnion{ get; set; }

        /// <summary>
        /// 是否开启跨域校验，默认开启 true
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableCheckAcrossDomain")]
        public bool? EnableCheckAcrossDomain{ get; set; }

        /// <summary>
        /// 自定义路由规则
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CustomRoutingRules")]
        public string CustomRoutingRules{ get; set; }

        /// <summary>
        /// 默认域名绑定类型，1绑定TCB-CDN，2绑定tcbingres（不经过cdn）
        /// </summary>
        [JsonProperty("AccessFlag")]
        public ulong? AccessFlag{ get; set; }

        /// <summary>
        /// 云接入源站域名
        /// </summary>
        [JsonProperty("OriginDomain")]
        public string OriginDomain{ get; set; }

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
            this.SetParamArrayObj(map, prefix + "ServiceSet.", this.ServiceSet);
            this.SetParamSimple(map, prefix + "EnableService", this.EnableService);
            this.SetParamSimple(map, prefix + "DefaultDomain", this.DefaultDomain);
            this.SetParamSimple(map, prefix + "EnableUnion", this.EnableUnion);
            this.SetParamSimple(map, prefix + "EnableCheckAcrossDomain", this.EnableCheckAcrossDomain);
            this.SetParamSimple(map, prefix + "CustomRoutingRules", this.CustomRoutingRules);
            this.SetParamSimple(map, prefix + "AccessFlag", this.AccessFlag);
            this.SetParamSimple(map, prefix + "OriginDomain", this.OriginDomain);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

