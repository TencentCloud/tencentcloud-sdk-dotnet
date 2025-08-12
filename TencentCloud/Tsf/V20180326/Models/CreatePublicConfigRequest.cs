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

    public class CreatePublicConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// 配置名称，最长60个字符，只能包含字母、数字及分隔符（“-”、“_”），且不能以分隔符开头或结尾。
        /// </summary>
        [JsonProperty("ConfigName")]
        public string ConfigName{ get; set; }

        /// <summary>
        /// 配置版本，只能包含小写字母、数字及分隔符("-"，".")，且必须以小写字母或数字开头、以小写字母或数字结尾，中间不能有连续的"-"或"."。
        /// </summary>
        [JsonProperty("ConfigVersion")]
        public string ConfigVersion{ get; set; }

        /// <summary>
        /// 配置项值，总是接收yaml格式的内容。
        /// </summary>
        [JsonProperty("ConfigValue")]
        public string ConfigValue{ get; set; }

        /// <summary>
        /// 配置项版本描述，最多支持200个字符。
        /// </summary>
        [JsonProperty("ConfigVersionDesc")]
        public string ConfigVersionDesc{ get; set; }

        /// <summary>
        /// 配置项类型，固定值。
        /// </summary>
        [JsonProperty("ConfigType")]
        public string ConfigType{ get; set; }

        /// <summary>
        /// Base64编码的配置项。
        /// - true：开启
        /// - false：关闭
        /// </summary>
        [JsonProperty("EncodeWithBase64")]
        public bool? EncodeWithBase64{ get; set; }

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
            this.SetParamSimple(map, prefix + "ConfigName", this.ConfigName);
            this.SetParamSimple(map, prefix + "ConfigVersion", this.ConfigVersion);
            this.SetParamSimple(map, prefix + "ConfigValue", this.ConfigValue);
            this.SetParamSimple(map, prefix + "ConfigVersionDesc", this.ConfigVersionDesc);
            this.SetParamSimple(map, prefix + "ConfigType", this.ConfigType);
            this.SetParamSimple(map, prefix + "EncodeWithBase64", this.EncodeWithBase64);
            this.SetParamArraySimple(map, prefix + "ProgramIdList.", this.ProgramIdList);
        }
    }
}

