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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IncCompareAbstractInfo : AbstractModel
    {
        
        /// <summary>
        /// 增量起始位点
        /// </summary>
        [JsonProperty("StartPosition")]
        public string StartPosition{ get; set; }

        /// <summary>
        /// 增量当前位点
        /// </summary>
        [JsonProperty("CurrentPosition")]
        public string CurrentPosition{ get; set; }

        /// <summary>
        /// 已校验行数
        /// </summary>
        [JsonProperty("CheckedRecord")]
        public ulong? CheckedRecord{ get; set; }

        /// <summary>
        /// 不一致行数
        /// </summary>
        [JsonProperty("DiffRecord")]
        public ulong? DiffRecord{ get; set; }

        /// <summary>
        /// 不一致表的数量
        /// </summary>
        [JsonProperty("DiffTable")]
        public ulong? DiffTable{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartPosition", this.StartPosition);
            this.SetParamSimple(map, prefix + "CurrentPosition", this.CurrentPosition);
            this.SetParamSimple(map, prefix + "CheckedRecord", this.CheckedRecord);
            this.SetParamSimple(map, prefix + "DiffRecord", this.DiffRecord);
            this.SetParamSimple(map, prefix + "DiffTable", this.DiffTable);
        }
    }
}

