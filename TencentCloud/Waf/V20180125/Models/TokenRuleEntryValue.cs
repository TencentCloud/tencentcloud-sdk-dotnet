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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TokenRuleEntryValue : AbstractModel
    {
        
        /// <summary>
        /// 布尔类型值
        /// </summary>
        [JsonProperty("LogicValue")]
        public bool? LogicValue{ get; set; }

        /// <summary>
        /// 数组类型值
        /// 可以存储字符串/数值
        /// 如果只有一个元素，则为长度为1的数组
        /// </summary>
        [JsonProperty("MultiValue")]
        public string[] MultiValue{ get; set; }

        /// <summary>
        /// 指示有效的字段
        /// </summary>
        [JsonProperty("ValidKey")]
        public string ValidKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LogicValue", this.LogicValue);
            this.SetParamArraySimple(map, prefix + "MultiValue.", this.MultiValue);
            this.SetParamSimple(map, prefix + "ValidKey", this.ValidKey);
        }
    }
}

