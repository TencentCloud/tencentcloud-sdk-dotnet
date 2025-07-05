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

namespace TencentCloud.Lowcode.V20210108.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DataSourceQueryOption : AbstractModel
    {
        
        /// <summary>
        /// 数据源标识模糊匹配
        /// </summary>
        [JsonProperty("LikeName")]
        public string LikeName{ get; set; }

        /// <summary>
        /// 数据源名称模糊匹配
        /// </summary>
        [JsonProperty("LikeTitle")]
        public string LikeTitle{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LikeName", this.LikeName);
            this.SetParamSimple(map, prefix + "LikeTitle", this.LikeTitle);
        }
    }
}

