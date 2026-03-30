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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Filter : AbstractModel
    {
        
        /// <summary>
        /// 1. 项目 ProjectId
        ///     - true = 精确查找
        ///     - false = 模糊匹配
        /// 2. 标签键 TagKey
        ///     - true = 精确查找
        ///     - false = 模糊匹配
        /// 3. 标签 Tag
        ///     - true = 精确查找
        ///     - false = 模糊匹配
        /// 4. 实例名称 InstanceName
        ///     - true = 精确查找
        ///     - false = 模糊匹配
        /// 5. 实例ID InstanceId
        ///     - true = 精确查找
        ///     - false = 模糊匹配
        /// 
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 值
        /// </summary>
        [JsonProperty("Values")]
        public string[] Values{ get; set; }

        /// <summary>
        /// 开关
        /// </summary>
        [JsonProperty("ExactMatch")]
        public bool? ExactMatch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArraySimple(map, prefix + "Values.", this.Values);
            this.SetParamSimple(map, prefix + "ExactMatch", this.ExactMatch);
        }
    }
}

