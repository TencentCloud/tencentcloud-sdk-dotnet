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

    public class AddressTemplateItem : AbstractModel
    {
        
        /// <summary>
        /// IP地址模板ID
        /// </summary>
        [JsonProperty("AddressTemplateId")]
        public string AddressTemplateId{ get; set; }

        /// <summary>
        /// IP模板名称，废弃字段。
        /// </summary>
        [JsonProperty("AddressTemplateName")]
        public string AddressTemplateName{ get; set; }

        /// <summary>
        /// 废弃字段。
        /// </summary>
        [JsonProperty("From")]
        public string From{ get; set; }

        /// <summary>
        /// 废弃字段
        /// </summary>
        [JsonProperty("To")]
        public string To{ get; set; }

        /// <summary>
        /// 备注。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 最后更新时间。
        /// </summary>
        [JsonProperty("UpdatedTime")]
        public string UpdatedTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AddressTemplateId", this.AddressTemplateId);
            this.SetParamSimple(map, prefix + "AddressTemplateName", this.AddressTemplateName);
            this.SetParamSimple(map, prefix + "From", this.From);
            this.SetParamSimple(map, prefix + "To", this.To);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "UpdatedTime", this.UpdatedTime);
        }
    }
}

