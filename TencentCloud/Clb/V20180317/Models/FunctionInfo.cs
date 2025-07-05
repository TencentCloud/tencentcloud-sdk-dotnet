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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FunctionInfo : AbstractModel
    {
        
        /// <summary>
        /// 函数命名空间
        /// </summary>
        [JsonProperty("FunctionNamespace")]
        public string FunctionNamespace{ get; set; }

        /// <summary>
        /// 函数名称
        /// </summary>
        [JsonProperty("FunctionName")]
        public string FunctionName{ get; set; }

        /// <summary>
        /// 函数的版本名称或别名
        /// </summary>
        [JsonProperty("FunctionQualifier")]
        public string FunctionQualifier{ get; set; }

        /// <summary>
        /// 标识 FunctionQualifier 参数的类型，可取值： VERSION（版本）、ALIAS（别名）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FunctionQualifierType")]
        public string FunctionQualifierType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FunctionNamespace", this.FunctionNamespace);
            this.SetParamSimple(map, prefix + "FunctionName", this.FunctionName);
            this.SetParamSimple(map, prefix + "FunctionQualifier", this.FunctionQualifier);
            this.SetParamSimple(map, prefix + "FunctionQualifierType", this.FunctionQualifierType);
        }
    }
}

