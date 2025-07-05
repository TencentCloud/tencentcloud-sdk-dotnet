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

    public class TrafficMirrorTarget : AbstractModel
    {
        
        /// <summary>
        /// 流量镜像的接收IP
        /// </summary>
        [JsonProperty("TargetIps")]
        public string[] TargetIps{ get; set; }

        /// <summary>
        /// 流量镜像接收IP组，均衡规则，支持ENI/FIVE_TUPLE_FLOW（vpc），FIVE_TUPLE_FLOW（公网IP）
        /// </summary>
        [JsonProperty("AlgHash")]
        public string AlgHash{ get; set; }

        /// <summary>
        /// 流量镜像的接收endpoint（公网IP）
        /// </summary>
        [JsonProperty("TargetEndPoints")]
        public string[] TargetEndPoints{ get; set; }

        /// <summary>
        /// 流量镜像的接收类型，分别为：IP/ENI/CLB
        /// </summary>
        [JsonProperty("TargetType")]
        public string TargetType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "TargetIps.", this.TargetIps);
            this.SetParamSimple(map, prefix + "AlgHash", this.AlgHash);
            this.SetParamArraySimple(map, prefix + "TargetEndPoints.", this.TargetEndPoints);
            this.SetParamSimple(map, prefix + "TargetType", this.TargetType);
        }
    }
}

