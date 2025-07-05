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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StatDimension : AbstractModel
    {
        
        /// <summary>
        /// 维度名称，目前仅支持：SqlTag。
        /// </summary>
        [JsonProperty("Dimension")]
        public string Dimension{ get; set; }

        /// <summary>
        /// SQL 标签过滤与统计信息
        /// 示例：
        /// 
        /// 示例 1：[p=position] 统计包含 p=position 标签的 SQL 会话。
        /// 示例 2：[p] 统计包含 p 标签的 SQL 会话。
        /// 示例 3：[p=position, c=idCard] 统计同时包含 p=position 标签和 c=idCard 标签的 SQL 会话。
        /// </summary>
        [JsonProperty("Data")]
        public string[] Data{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Dimension", this.Dimension);
            this.SetParamArraySimple(map, prefix + "Data.", this.Data);
        }
    }
}

