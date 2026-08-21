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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SeeDeleteTaskCondition : AbstractModel
    {
        
        /// <summary>
        /// <p>条件类型。</p><p>枚举值：</p><ul><li>TaskId： 精确匹配任务 ID</li><li>TimeRange： 匹配任务时间范围与指定范围有重合的任务。值的格式为 <code>UnixTimestampStart,UnixTimestampEnd</code>，其中起止时间均为秒级 UNIX 时间戳，且结束时间不早于起始时间</li><li>CreateTimeBefore： 匹配在指定时间前创建的任务。值为秒级 UNIX 时间戳</li><li>COSURI： 精确匹配任务来源 COS URI，值必须以 <code>cos://</code> 开头</li><li>COSURIPrefix： 按前缀匹配任务来源 COS URI，值必须以 <code>cos://</code> 开头</li></ul>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>条件值列表。同一条件内的多个值之间为 OR 关系，至少传入一个非空值。</p>
        /// </summary>
        [JsonProperty("Values")]
        public string[] Values{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArraySimple(map, prefix + "Values.", this.Values);
        }
    }
}

