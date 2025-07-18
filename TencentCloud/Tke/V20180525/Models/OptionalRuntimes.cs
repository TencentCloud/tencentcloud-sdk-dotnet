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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OptionalRuntimes : AbstractModel
    {
        
        /// <summary>
        /// 运行时类型
        /// </summary>
        [JsonProperty("RuntimeType")]
        public string RuntimeType{ get; set; }

        /// <summary>
        /// 运行时版本列表
        /// </summary>
        [JsonProperty("RuntimeVersions")]
        public string[] RuntimeVersions{ get; set; }

        /// <summary>
        /// 该类型的默认运行时版本
        /// </summary>
        [JsonProperty("DefaultVersion")]
        public string DefaultVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuntimeType", this.RuntimeType);
            this.SetParamArraySimple(map, prefix + "RuntimeVersions.", this.RuntimeVersions);
            this.SetParamSimple(map, prefix + "DefaultVersion", this.DefaultVersion);
        }
    }
}

