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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeModelServiceCallInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// 服务调用信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceCallInfo")]
        public ServiceCallInfo ServiceCallInfo{ get; set; }

        /// <summary>
        /// 升级网关调用信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InferGatewayCallInfo")]
        public InferGatewayCallInfo InferGatewayCallInfo{ get; set; }

        /// <summary>
        /// 默认nginx网关的调用信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DefaultNginxGatewayCallInfo")]
        public DefaultNginxGatewayCallInfo DefaultNginxGatewayCallInfo{ get; set; }

        /// <summary>
        /// 太极服务的调用信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TJCallInfo")]
        public TJCallInfo TJCallInfo{ get; set; }

        /// <summary>
        /// 内网调用信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IntranetCallInfo")]
        public IntranetCallInfo IntranetCallInfo{ get; set; }

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
            this.SetParamObj(map, prefix + "ServiceCallInfo.", this.ServiceCallInfo);
            this.SetParamObj(map, prefix + "InferGatewayCallInfo.", this.InferGatewayCallInfo);
            this.SetParamObj(map, prefix + "DefaultNginxGatewayCallInfo.", this.DefaultNginxGatewayCallInfo);
            this.SetParamObj(map, prefix + "TJCallInfo.", this.TJCallInfo);
            this.SetParamObj(map, prefix + "IntranetCallInfo.", this.IntranetCallInfo);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

