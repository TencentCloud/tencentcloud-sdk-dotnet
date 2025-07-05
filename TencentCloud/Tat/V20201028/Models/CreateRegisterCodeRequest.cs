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

namespace TencentCloud.Tat.V20201028.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateRegisterCodeRequest : AbstractModel
    {
        
        /// <summary>
        /// 注册码描述。最大长度为 128 字符。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 注册实例名称前缀。最大长度为 32 字符。
        /// </summary>
        [JsonProperty("InstanceNamePrefix")]
        public string InstanceNamePrefix{ get; set; }

        /// <summary>
        /// 该注册码允许注册的实例数目。默认值为 10，最小值为 1，最大值为 10000。
        /// </summary>
        [JsonProperty("RegisterLimit")]
        public long? RegisterLimit{ get; set; }

        /// <summary>
        /// 该注册码的有效时间，单位为小时。默认值为 4。
        /// 
        /// - 若传入值小于等于 99999，则以小时为单位设置有效时间。
        /// - 若传入值大于 99999，则设置为长期有效。
        /// </summary>
        [JsonProperty("EffectiveTime")]
        public long? EffectiveTime{ get; set; }

        /// <summary>
        /// 限制注册码只能从 IpAddressRange 所描述公网出口进行注册。
        /// 
        /// 默认为空，即无任何限制。
        /// 
        /// 取值应为标准 IPv4 或 CIDRv4 格式。例如 192.168.1.1 或 192.168.0.0/16。
        /// </summary>
        [JsonProperty("IpAddressRange")]
        public string IpAddressRange{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "InstanceNamePrefix", this.InstanceNamePrefix);
            this.SetParamSimple(map, prefix + "RegisterLimit", this.RegisterLimit);
            this.SetParamSimple(map, prefix + "EffectiveTime", this.EffectiveTime);
            this.SetParamSimple(map, prefix + "IpAddressRange", this.IpAddressRange);
        }
    }
}

