/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RowParam : AbstractModel
    {
        
        /// <summary>
        /// 行内容，KEY_VALUE，VALUE
        /// </summary>
        [JsonProperty("RowContent")]
        public string RowContent{ get; set; }

        /// <summary>
        /// key和value间的分隔符
        /// </summary>
        [JsonProperty("KeyValueDelimiter")]
        public string KeyValueDelimiter{ get; set; }

        /// <summary>
        /// 元素建的分隔符
        /// </summary>
        [JsonProperty("EntryDelimiter")]
        public string EntryDelimiter{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RowContent", this.RowContent);
            this.SetParamSimple(map, prefix + "KeyValueDelimiter", this.KeyValueDelimiter);
            this.SetParamSimple(map, prefix + "EntryDelimiter", this.EntryDelimiter);
        }
    }
}

