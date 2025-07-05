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

namespace TencentCloud.Eb.V20210416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Extraction : AbstractModel
    {
        
        /// <summary>
        /// JsonPath, 不指定则使用默认值$.
        /// </summary>
        [JsonProperty("ExtractionInputPath")]
        public string ExtractionInputPath{ get; set; }

        /// <summary>
        /// 取值: TEXT/JSON
        /// </summary>
        [JsonProperty("Format")]
        public string Format{ get; set; }

        /// <summary>
        /// 仅在Text需要传递
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TextParams")]
        public TextParams TextParams{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ExtractionInputPath", this.ExtractionInputPath);
            this.SetParamSimple(map, prefix + "Format", this.Format);
            this.SetParamObj(map, prefix + "TextParams.", this.TextParams);
        }
    }
}

