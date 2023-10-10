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
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "InstanceNameStyle", this.InstanceNameStyle);
        }
    }
}

