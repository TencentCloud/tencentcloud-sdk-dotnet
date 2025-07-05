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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BindingPolicyObjectRequest : AbstractModel
    {
        
        /// <summary>
        /// 必填。固定值"monitor"
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// 策略组id，例如 4739573。逐渐弃用，建议使用 PolicyId 参数
        /// </summary>
        [JsonProperty("GroupId")]
        public long? GroupId{ get; set; }

        /// <summary>
        /// 告警策略ID，例如“policy-gh892hg0”。PolicyId 参数与 GroupId 参数至少要填一个，否则会报参数错误，建议使用该参数。若两者同时存在则以该参数为准
        /// </summary>
        [JsonProperty("PolicyId")]
        public string PolicyId{ get; set; }

        /// <summary>
        /// 实例分组ID
        /// </summary>
        [JsonProperty("InstanceGroupId")]
        public long? InstanceGroupId{ get; set; }

        /// <summary>
        /// 需要绑定的对象维度信息
        /// </summary>
        [JsonProperty("Dimensions")]
        public BindingPolicyObjectDimension[] Dimensions{ get; set; }

        /// <summary>
        /// 事件配置的告警
        /// </summary>
        [JsonProperty("EbSubject")]
        public string EbSubject{ get; set; }

        /// <summary>
        /// 是否配置了事件告警
        /// </summary>
        [JsonProperty("EbEventFlag")]
        public long? EbEventFlag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "InstanceGroupId", this.InstanceGroupId);
            this.SetParamArrayObj(map, prefix + "Dimensions.", this.Dimensions);
            this.SetParamSimple(map, prefix + "EbSubject", this.EbSubject);
            this.SetParamSimple(map, prefix + "EbEventFlag", this.EbEventFlag);
        }
    }
}

