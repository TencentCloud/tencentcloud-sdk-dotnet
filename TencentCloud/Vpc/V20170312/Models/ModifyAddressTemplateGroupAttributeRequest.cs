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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAddressTemplateGroupAttributeRequest : AbstractModel
    {
        
        /// <summary>
        /// IP地址模板集合实例ID，例如：ipmg-2uw6ujo6。
        /// </summary>
        [JsonProperty("AddressTemplateGroupId")]
        public string AddressTemplateGroupId{ get; set; }

        /// <summary>
        /// IP地址模板集合名称。
        /// </summary>
        [JsonProperty("AddressTemplateGroupName")]
        public string AddressTemplateGroupName{ get; set; }

        /// <summary>
        /// IP地址模板实例ID， 例如：ipm-mdunqeb6。
        /// </summary>
        [JsonProperty("AddressTemplateIds")]
        public string[] AddressTemplateIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AddressTemplateGroupId", this.AddressTemplateGroupId);
            this.SetParamSimple(map, prefix + "AddressTemplateGroupName", this.AddressTemplateGroupName);
            this.SetParamArraySimple(map, prefix + "AddressTemplateIds.", this.AddressTemplateIds);
        }
    }
}

