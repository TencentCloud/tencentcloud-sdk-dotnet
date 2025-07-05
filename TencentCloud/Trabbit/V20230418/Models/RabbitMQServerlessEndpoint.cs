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

namespace TencentCloud.Trabbit.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RabbitMQServerlessEndpoint : AbstractModel
    {
        
        /// <summary>
        /// vpc id
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// subnet id
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 接入地址
        /// </summary>
        [JsonProperty("VpcEndpoint")]
        public string VpcEndpoint{ get; set; }

        /// <summary>
        /// 接入地址状态
        /// </summary>
        [JsonProperty("VpcDataStreamEndpointStatus")]
        public string VpcDataStreamEndpointStatus{ get; set; }

        /// <summary>
        /// 是否是公网
        /// </summary>
        [JsonProperty("PublicNetwork")]
        public bool? PublicNetwork{ get; set; }

        /// <summary>
        /// 访问策略
        /// </summary>
        [JsonProperty("AccessStrategy")]
        public string AccessStrategy{ get; set; }

        /// <summary>
        /// 带宽
        /// </summary>
        [JsonProperty("Bandwidth")]
        public long? Bandwidth{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "VpcEndpoint", this.VpcEndpoint);
            this.SetParamSimple(map, prefix + "VpcDataStreamEndpointStatus", this.VpcDataStreamEndpointStatus);
            this.SetParamSimple(map, prefix + "PublicNetwork", this.PublicNetwork);
            this.SetParamSimple(map, prefix + "AccessStrategy", this.AccessStrategy);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
        }
    }
}

