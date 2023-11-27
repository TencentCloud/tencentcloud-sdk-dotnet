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

namespace TencentCloud.Tat.V20201028.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateRegisterCodeRequest : AbstractModel
    {
        
        /// <summary>
        /// 注册码描述。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 注册实例名称前缀。
        /// </summary>
        [JsonProperty("InstanceNamePrefix")]
        public string InstanceNamePrefix{ get; set; }

        /// <summary>
        /// 该注册码允许注册的实例数目。默认限制为10个。
        /// </summary>
        [JsonProperty("RegisterLimit")]
        public long? RegisterLimit{ get; set; }

        /// <summary>
        /// 该注册码的有效时间，单位为小时。默认为4小时。
        /// </summary>
        [JsonProperty("EffectiveTime")]
        public long? EffectiveTime{ get; set; }

        /// <summary>
        /// 该注册码限制tat_agent只能从IpAddressRange所描述公网出口进行注册。默认不做限制。
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

