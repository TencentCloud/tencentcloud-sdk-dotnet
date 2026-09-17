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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeliverRule : AbstractModel
    {
        
        /// <summary>
        /// <p>数据投递范围。</p><p>枚举值：</p><ul><li>1： 历史+新增数据</li><li>2： 自定义时间范围</li><li>3： 仅新增</li></ul><p>本次仅支持3新增数据。后续支持： 2自定义时间范围和1历史+新增数据</p>
        /// </summary>
        [JsonProperty("DataScope")]
        public ulong? DataScope{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DataScope", this.DataScope);
        }
    }
}

