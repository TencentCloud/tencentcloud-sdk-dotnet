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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Namespaces : AbstractModel
    {
        
        /// <summary>
        /// 包含的命名空间的列表，单个命名空间支持小写字母、数字、连接符-、下划线_，最多支持63个字符
        /// </summary>
        [JsonProperty("Include")]
        public string[] Include{ get; set; }

        /// <summary>
        /// 不包含的命名空间列表，单个命名空间支持小写字母、数字、连接符-、下划线_，最多支持63个字符
        /// </summary>
        [JsonProperty("Exclude")]
        public string[] Exclude{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Include.", this.Include);
            this.SetParamArraySimple(map, prefix + "Exclude.", this.Exclude);
        }
    }
}

