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

namespace TencentCloud.Config.V20220802.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Annotation : AbstractModel
    {
        
        /// <summary>
        /// 资源当前实际配置。长度为0~256位字符，即资源不合规配置
        /// </summary>
        [JsonProperty("Configuration")]
        public string Configuration{ get; set; }

        /// <summary>
        /// 资源期望配置。长度为0~256位字符，即资源合规配置
        /// </summary>
        [JsonProperty("DesiredValue")]
        public string DesiredValue{ get; set; }

        /// <summary>
        /// 资源当前配置和期望配置之间的比较运算符。长度为0~16位字符，自定义规则上报评估结果此字段可能为空
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// 当前配置在资源属性结构体中的JSON路径。长度为0~256位字符，自定义规则上报评估结果此字段可能为空
        /// </summary>
        [JsonProperty("Property")]
        public string Property{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Configuration", this.Configuration);
            this.SetParamSimple(map, prefix + "DesiredValue", this.DesiredValue);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "Property", this.Property);
        }
    }
}

