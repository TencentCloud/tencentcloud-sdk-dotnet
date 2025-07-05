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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyParameterTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// 参数模板ID，用于唯一确认参数模板，不可修改
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// 参数模板名称，长度为1～60个字符，仅支持数字,英文大小写字母、中文以及特殊字符_-./()（）[]+=：:@  注：若该字段为空    ，则保持原参数模板名称
        /// </summary>
        [JsonProperty("TemplateName")]
        public string TemplateName{ get; set; }

        /// <summary>
        /// 参数模板描述，长度为0～60个字符，仅支持数字,英文大小写字母、中文以及特殊字符_-./()（）[]+=：:@  注：若不传入该参数，则保持原参数模板描述
        /// </summary>
        [JsonProperty("TemplateDescription")]
        public string TemplateDescription{ get; set; }

        /// <summary>
        /// 需要修改或添加的参数集合，注：同一参数不能同时出现在修改添加集合和删除集合中
        /// </summary>
        [JsonProperty("ModifyParamEntrySet")]
        public ParamEntry[] ModifyParamEntrySet{ get; set; }

        /// <summary>
        /// 需要从模板中删除的参数集合，注：同一参数不能同时出现在修改添加集合和删除集合中
        /// </summary>
        [JsonProperty("DeleteParamSet")]
        public string[] DeleteParamSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "TemplateName", this.TemplateName);
            this.SetParamSimple(map, prefix + "TemplateDescription", this.TemplateDescription);
            this.SetParamArrayObj(map, prefix + "ModifyParamEntrySet.", this.ModifyParamEntrySet);
            this.SetParamArraySimple(map, prefix + "DeleteParamSet.", this.DeleteParamSet);
        }
    }
}

