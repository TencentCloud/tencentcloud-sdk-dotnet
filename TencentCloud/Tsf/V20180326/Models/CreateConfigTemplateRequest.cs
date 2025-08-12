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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateConfigTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// 配置模板名称，最多支持60个字符，只能包含字母、数字及分隔符（“-”），且不能以分隔符开头或结尾。
        /// </summary>
        [JsonProperty("ConfigTemplateName")]
        public string ConfigTemplateName{ get; set; }

        /// <summary>
        /// 配置模板对应的微服务框架。
        /// - Ribbon：Ribbon类型配置模板
        /// - Hystrix：Hystrix类型配置模板
        /// - Zuul：Zuul类型配置模板
        /// - customize：自定义类型配置模板
        /// </summary>
        [JsonProperty("ConfigTemplateType")]
        public string ConfigTemplateType{ get; set; }

        /// <summary>
        /// 配置模板数据。
        /// </summary>
        [JsonProperty("ConfigTemplateValue")]
        public string ConfigTemplateValue{ get; set; }

        /// <summary>
        /// 配置模板描述，最多支持200个字符。
        /// </summary>
        [JsonProperty("ConfigTemplateDesc")]
        public string ConfigTemplateDesc{ get; set; }

        /// <summary>
        /// 需要绑定的数据集ID。该参数可以通过调用 [DescribePrograms](https://cloud.tencent.com/document/product/649/73477) 的返回值中的 ProgramId 字段来获取或通过登录[控制台](https://console.cloud.tencent.com/tsf/privilege?tab=program&roleId=role-yrle4doy)查看；也可以调用[CreateProgram](https://cloud.tencent.com/document/product/649/108544)创建新的数据集。
        /// </summary>
        [JsonProperty("ProgramIdList")]
        public string[] ProgramIdList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConfigTemplateName", this.ConfigTemplateName);
            this.SetParamSimple(map, prefix + "ConfigTemplateType", this.ConfigTemplateType);
            this.SetParamSimple(map, prefix + "ConfigTemplateValue", this.ConfigTemplateValue);
            this.SetParamSimple(map, prefix + "ConfigTemplateDesc", this.ConfigTemplateDesc);
            this.SetParamArraySimple(map, prefix + "ProgramIdList.", this.ProgramIdList);
        }
    }
}

