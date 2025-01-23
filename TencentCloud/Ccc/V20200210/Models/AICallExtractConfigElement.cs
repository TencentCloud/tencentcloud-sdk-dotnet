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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AICallExtractConfigElement : AbstractModel
    {
        
        /// <summary>
        /// 配置项类型，包括
        /// Text 文本
        /// Selector 选项
        /// Boolean 布尔值
        /// Number 数字
        /// </summary>
        [JsonProperty("InfoType")]
        public string InfoType{ get; set; }

        /// <summary>
        /// 配置项名称，不可重复
        /// </summary>
        [JsonProperty("InfoName")]
        public string InfoName{ get; set; }

        /// <summary>
        /// 配置项具体内容
        /// </summary>
        [JsonProperty("InfoContent")]
        public string InfoContent{ get; set; }

        /// <summary>
        /// 配置项提取内容示例
        /// </summary>
        [JsonProperty("Examples")]
        public string[] Examples{ get; set; }

        /// <summary>
        /// InfoType 为 Selector，需要配置此字段
        /// </summary>
        [JsonProperty("Choices")]
        public string[] Choices{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InfoType", this.InfoType);
            this.SetParamSimple(map, prefix + "InfoName", this.InfoName);
            this.SetParamSimple(map, prefix + "InfoContent", this.InfoContent);
            this.SetParamArraySimple(map, prefix + "Examples.", this.Examples);
            this.SetParamArraySimple(map, prefix + "Choices.", this.Choices);
        }
    }
}

