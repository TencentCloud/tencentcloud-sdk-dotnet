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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExtractionField : AbstractModel
    {
        
        /// <summary>
        /// 用于合同智能提取的字段名称。
        /// 
        /// 注意: `长度不能超过30个字符`
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 指定合同智能提取的字段类型，目前仅支持`TEXT`、`DATE`、`NUMBER`、`OPTION`类型。
        /// 
        /// 类型支持如下：
        /// 1、TEXT（文本）
        /// 2、DATE（日期）
        /// 3、NUMBER（数字）
        /// 4、OPTION（选项值）
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 用于描述字段信息。
        /// 
        /// 注意：
        /// 1、`如果Type值为OPTION时，需要在字段描述中填写选项值，用,分隔`
        /// 2、描述字段不能超过100个字符
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 提取出合同中的字段信息。
        /// </summary>
        [JsonProperty("Values")]
        public string[] Values{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArraySimple(map, prefix + "Values.", this.Values);
        }
    }
}

