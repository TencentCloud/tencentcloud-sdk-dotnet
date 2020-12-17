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

namespace TencentCloud.Ses.V20201002.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TemplatesMetadata : AbstractModel
    {
        
        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreatedTimestamp")]
        public ulong? CreatedTimestamp{ get; set; }

        /// <summary>
        /// 模板名称
        /// </summary>
        [JsonProperty("TemplateName")]
        public string TemplateName{ get; set; }

        /// <summary>
        /// 模板状态。1-审核中|0-已通过|其它-不可用
        /// </summary>
        [JsonProperty("TemplateStatus")]
        public long? TemplateStatus{ get; set; }

        /// <summary>
        /// 模板ID
        /// </summary>
        [JsonProperty("TemplateID")]
        public ulong? TemplateID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CreatedTimestamp", this.CreatedTimestamp);
            this.SetParamSimple(map, prefix + "TemplateName", this.TemplateName);
            this.SetParamSimple(map, prefix + "TemplateStatus", this.TemplateStatus);
            this.SetParamSimple(map, prefix + "TemplateID", this.TemplateID);
        }
    }
}

