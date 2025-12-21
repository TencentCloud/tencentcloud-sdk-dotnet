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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceNameSettings : AbstractModel
    {
        
        /// <summary>
        /// 云服务器的实例名。字符长度为[2, 108]。
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 云服务器实例名的风格，取值范围包括 ORIGINAL 和 UNIQUE，默认为 ORIGINAL。
        /// 
        /// ORIGINAL，AS 直接将入参中所填的 InstanceName 传递给 CVM，CVM 可能会对 InstanceName 追加序列号，伸缩组中实例的 InstanceName 会出现冲突的情况。
        /// 
        /// UNIQUE，入参所填的 InstanceName 相当于实例名前缀，AS 和 CVM 会对其进行拓展，伸缩组中实例的 InstanceName 可以保证唯一。
        /// </summary>
        [JsonProperty("InstanceNameStyle")]
        public string InstanceNameStyle{ get; set; }

        /// <summary>
        /// 云服务器实例名后缀。字符长度为[1,105]，且与 InstanceName 的长度和不能超过107。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceNameSuffix")]
        public string InstanceNameSuffix{ get; set; }

        /// <summary>
        /// 云服务器的实例名分隔符。默认的分隔符是点号（.），可选短横线（-）或空字符串。
        /// 分隔符用于拼接实例名，递增序号，后缀。假设实例名为 testGpu4090 ，递增序号为 0007，后缀为 server：
        /// - 分隔符为英文点号（.），最终拼接为 testGpu4090.007.server
        /// - 分隔符为短横线（-），最终拼接为 testGpu4090-007-server
        /// - 分隔符为空字符串，最终拼接为 testGpu4090007server
        /// </summary>
        [JsonProperty("InstanceNameDelimiter")]
        public string InstanceNameDelimiter{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "InstanceNameStyle", this.InstanceNameStyle);
            this.SetParamSimple(map, prefix + "InstanceNameSuffix", this.InstanceNameSuffix);
            this.SetParamSimple(map, prefix + "InstanceNameDelimiter", this.InstanceNameDelimiter);
        }
    }
}

