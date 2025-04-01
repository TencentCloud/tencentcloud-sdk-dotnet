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

namespace TencentCloud.Controlcenter.V20230110.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AccountFactoryItem : AbstractModel
    {
        
        /// <summary>
        /// 账号工厂基线项唯一标识，只能包含英文字母、数字和@、,._[]-:()（）【】+=，。，长度2-128个字符。
        /// </summary>
        [JsonProperty("Identifier")]
        public string Identifier{ get; set; }

        /// <summary>
        /// 基线项名称，功能项名字唯一，仅支持英文字母、数宇、汉字、符号@、＆_[]-的组合，1-25个中文或英文字符。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 基线项英文名称，基线项名字唯一，仅支持英文字母、数字、空格、符号@、＆_[]-的组合，1-64个英文字符。
        /// </summary>
        [JsonProperty("NameEn")]
        public string NameEn{ get; set; }

        /// <summary>
        /// 基线项权重，数值小权重越高，取值范围大于等于0。
        /// </summary>
        [JsonProperty("Weight")]
        public long? Weight{ get; set; }

        /// <summary>
        /// 基线项是否必填，1必填，0非必填
        /// </summary>
        [JsonProperty("Required")]
        public long? Required{ get; set; }

        /// <summary>
        /// 基线项依赖项，N的取值范围与该基线项依赖的其它基线项个数有关。
        /// </summary>
        [JsonProperty("DependsOn")]
        public DependsOnItem[] DependsOn{ get; set; }

        /// <summary>
        /// 基线描述，长度为2~256个英文或中文字符，默认值为空。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 基线项英文描述，长度为2~1024个英文字符，默认值为空。
        /// </summary>
        [JsonProperty("DescriptionEn")]
        public string DescriptionEn{ get; set; }

        /// <summary>
        /// 基线分类，长度为2~32个英文或中文字符，不能为空。
        /// </summary>
        [JsonProperty("Classify")]
        public string Classify{ get; set; }

        /// <summary>
        /// 基线英文分类，长度为2~64个英文字符，不能为空。
        /// </summary>
        [JsonProperty("ClassifyEn")]
        public string ClassifyEn{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Identifier", this.Identifier);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "NameEn", this.NameEn);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamSimple(map, prefix + "Required", this.Required);
            this.SetParamArrayObj(map, prefix + "DependsOn.", this.DependsOn);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "DescriptionEn", this.DescriptionEn);
            this.SetParamSimple(map, prefix + "Classify", this.Classify);
            this.SetParamSimple(map, prefix + "ClassifyEn", this.ClassifyEn);
        }
    }
}

