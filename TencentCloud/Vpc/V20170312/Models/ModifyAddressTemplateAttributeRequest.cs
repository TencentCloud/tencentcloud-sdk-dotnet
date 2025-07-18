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

    public class ModifyAddressTemplateAttributeRequest : AbstractModel
    {
        
        /// <summary>
        /// IP地址模板实例ID，例如：ipm-mdunqeb6。
        /// </summary>
        [JsonProperty("AddressTemplateId")]
        public string AddressTemplateId{ get; set; }

        /// <summary>
        /// IP地址模板名称。
        /// </summary>
        [JsonProperty("AddressTemplateName")]
        public string AddressTemplateName{ get; set; }

        /// <summary>
        /// 地址信息，支持 IP、CIDR、IP 范围。
        /// </summary>
        [JsonProperty("Addresses")]
        public string[] Addresses{ get; set; }

        /// <summary>
        /// 支持添加备注的地址信息，支持 IP、CIDR、IP 范围。
        /// </summary>
        [JsonProperty("AddressesExtra")]
        public AddressInfo[] AddressesExtra{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AddressTemplateId", this.AddressTemplateId);
            this.SetParamSimple(map, prefix + "AddressTemplateName", this.AddressTemplateName);
            this.SetParamArraySimple(map, prefix + "Addresses.", this.Addresses);
            this.SetParamArrayObj(map, prefix + "AddressesExtra.", this.AddressesExtra);
        }
    }
}

