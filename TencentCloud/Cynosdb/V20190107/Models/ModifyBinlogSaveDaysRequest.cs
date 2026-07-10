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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyBinlogSaveDaysRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>集群ID</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>Binlog保留天数</p>
        /// </summary>
        [JsonProperty("BinlogSaveDays")]
        public long? BinlogSaveDays{ get; set; }

        /// <summary>
        /// <p>跨地域备份保留时间</p><p>单位：天</p>
        /// </summary>
        [JsonProperty("BinlogCrossRegionSaveDays")]
        public long? BinlogCrossRegionSaveDays{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "BinlogSaveDays", this.BinlogSaveDays);
            this.SetParamSimple(map, prefix + "BinlogCrossRegionSaveDays", this.BinlogCrossRegionSaveDays);
        }
    }
}

