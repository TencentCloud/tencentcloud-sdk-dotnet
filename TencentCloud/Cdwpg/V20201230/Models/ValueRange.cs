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

namespace TencentCloud.Cdwpg.V20201230.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ValueRange : AbstractModel
    {
        
        /// <summary>
        /// 参数类型，可以为 enum，string，section; 其中enum表示枚举，类似： utf8,latin1,gbk; string表示返回的参数值是字符串; section表示返回的参数值是一个取值范围，类似：[4-8]
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// type 取section的时候，返回的参数值
        /// </summary>
        [JsonProperty("Range")]
        public Range Range{ get; set; }

        /// <summary>
        /// type 取enum的时候，返回参数值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Enum")]
        public string[] Enum{ get; set; }

        /// <summary>
        /// type 取string的时候，返回的参数值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("String")]
        public string String{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "Range.", this.Range);
            this.SetParamArraySimple(map, prefix + "Enum.", this.Enum);
            this.SetParamSimple(map, prefix + "String", this.String);
        }
    }
}

