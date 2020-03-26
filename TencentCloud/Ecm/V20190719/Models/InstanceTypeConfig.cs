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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceTypeConfig : AbstractModel
    {
        
        /// <summary>
        /// 机型族配置信息
        /// </summary>
        [JsonProperty("InstanceFamilyConfig")]
        public InstanceFamilyConfig InstanceFamilyConfig{ get; set; }

        /// <summary>
        /// 机型
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// CPU核数
        /// </summary>
        [JsonProperty("Vcpu")]
        public long? Vcpu{ get; set; }

        /// <summary>
        /// 内存大小
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// 主频
        /// </summary>
        [JsonProperty("Frequency")]
        public string Frequency{ get; set; }

        /// <summary>
        /// 处理器型号
        /// </summary>
        [JsonProperty("CpuModelName")]
        public string CpuModelName{ get; set; }

        /// <summary>
        /// 机型族类别配置信息
        /// </summary>
        [JsonProperty("InstanceFamilyTypeConfig")]
        public InstanceFamilyTypeConfig InstanceFamilyTypeConfig{ get; set; }

        /// <summary>
        /// 机型额外信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExtInfo")]
        public string ExtInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "InstanceFamilyConfig.", this.InstanceFamilyConfig);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "Vcpu", this.Vcpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Frequency", this.Frequency);
            this.SetParamSimple(map, prefix + "CpuModelName", this.CpuModelName);
            this.SetParamObj(map, prefix + "InstanceFamilyTypeConfig.", this.InstanceFamilyTypeConfig);
            this.SetParamSimple(map, prefix + "ExtInfo", this.ExtInfo);
        }
    }
}

