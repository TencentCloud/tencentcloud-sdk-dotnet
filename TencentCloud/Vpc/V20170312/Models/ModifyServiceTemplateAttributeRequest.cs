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

    public class ModifyServiceTemplateAttributeRequest : AbstractModel
    {
        
        /// <summary>
        /// 协议端口模板实例ID，例如：ppm-529nwwj8。
        /// </summary>
        [JsonProperty("ServiceTemplateId")]
        public string ServiceTemplateId{ get; set; }

        /// <summary>
        /// 协议端口模板名称。
        /// </summary>
        [JsonProperty("ServiceTemplateName")]
        public string ServiceTemplateName{ get; set; }

        /// <summary>
        /// 支持单个端口、多个端口、连续端口及所有端口，协议支持：TCP、UDP、ICMP、GRE 协议。
        /// </summary>
        [JsonProperty("Services")]
        public string[] Services{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceTemplateId", this.ServiceTemplateId);
            this.SetParamSimple(map, prefix + "ServiceTemplateName", this.ServiceTemplateName);
            this.SetParamArraySimple(map, prefix + "Services.", this.Services);
        }
    }
}

