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

namespace TencentCloud.Tke.V20220501.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RuntimeConfig : AbstractModel
    {
        
        /// <summary>
        /// 运行时类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuntimeType")]
        public string RuntimeType{ get; set; }

        /// <summary>
        /// 运行时版本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuntimeVersion")]
        public string RuntimeVersion{ get; set; }

        /// <summary>
        /// 运行时根目录
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuntimeRootDir")]
        public string RuntimeRootDir{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuntimeType", this.RuntimeType);
            this.SetParamSimple(map, prefix + "RuntimeVersion", this.RuntimeVersion);
            this.SetParamSimple(map, prefix + "RuntimeRootDir", this.RuntimeRootDir);
        }
    }
}

