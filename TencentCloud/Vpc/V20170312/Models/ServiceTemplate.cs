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

    public class ServiceTemplate : AbstractModel
    {
        
        /// <summary>
        /// 协议端口实例ID，例如：ppm-f5n1f8da。
        /// </summary>
        [JsonProperty("ServiceTemplateId")]
        public string ServiceTemplateId{ get; set; }

        /// <summary>
        /// 模板名称。
        /// </summary>
        [JsonProperty("ServiceTemplateName")]
        public string ServiceTemplateName{ get; set; }

        /// <summary>
        /// 协议端口信息。
        /// </summary>
        [JsonProperty("ServiceSet")]
        public string[] ServiceSet{ get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceTemplateId", this.ServiceTemplateId);
            this.SetParamSimple(map, prefix + "ServiceTemplateName", this.ServiceTemplateName);
            this.SetParamArraySimple(map, prefix + "ServiceSet.", this.ServiceSet);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
        }
    }
}

