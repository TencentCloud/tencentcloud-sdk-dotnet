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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddNetworkFirewallPolicyDetailRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群Id
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 策略名
        /// </summary>
        [JsonProperty("PolicyName")]
        public string PolicyName{ get; set; }

        /// <summary>
        /// 入站规则
        /// 
        /// 全部允许：1
        /// 
        /// 全部拒绝 ：2
        /// 
        /// 自定义：3
        /// </summary>
        [JsonProperty("FromPolicyRule")]
        public long? FromPolicyRule{ get; set; }

        /// <summary>
        /// 出站规则
        /// 
        /// 全部允许：1
        /// 
        /// 全部拒绝 ：2
        /// 
        /// 自定义：3
        /// </summary>
        [JsonProperty("ToPolicyRule")]
        public long? ToPolicyRule{ get; set; }

        /// <summary>
        /// pod选择器
        /// </summary>
        [JsonProperty("PodSelector")]
        public string PodSelector{ get; set; }

        /// <summary>
        /// 命名空间
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// 策略描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 自定义规则
        /// </summary>
        [JsonProperty("CustomPolicy")]
        public NetworkCustomPolicy[] CustomPolicy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "PolicyName", this.PolicyName);
            this.SetParamSimple(map, prefix + "FromPolicyRule", this.FromPolicyRule);
            this.SetParamSimple(map, prefix + "ToPolicyRule", this.ToPolicyRule);
            this.SetParamSimple(map, prefix + "PodSelector", this.PodSelector);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArrayObj(map, prefix + "CustomPolicy.", this.CustomPolicy);
        }
    }
}

