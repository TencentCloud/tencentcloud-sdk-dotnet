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

    public class AutoMapRule : AbstractModel
    {
        
        /// <summary>
        /// 源端实例Id
        /// </summary>
        [JsonProperty("SrcInstanceId")]
        public string SrcInstanceId{ get; set; }

        /// <summary>
        /// 源端数据库正则
        /// </summary>
        [JsonProperty("SrcDatabaseRegex")]
        public string SrcDatabaseRegex{ get; set; }

        /// <summary>
        /// 源端表正则
        /// </summary>
        [JsonProperty("SrcTableRegex")]
        public string SrcTableRegex{ get; set; }

        /// <summary>
        /// 目标端数据库正则
        /// </summary>
        [JsonProperty("DstDatabaseRegex")]
        public string DstDatabaseRegex{ get; set; }

        /// <summary>
        /// 目标端表正则
        /// </summary>
        [JsonProperty("DstTableRegex")]
        public string DstTableRegex{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SrcInstanceId", this.SrcInstanceId);
            this.SetParamSimple(map, prefix + "SrcDatabaseRegex", this.SrcDatabaseRegex);
            this.SetParamSimple(map, prefix + "SrcTableRegex", this.SrcTableRegex);
            this.SetParamSimple(map, prefix + "DstDatabaseRegex", this.DstDatabaseRegex);
            this.SetParamSimple(map, prefix + "DstTableRegex", this.DstTableRegex);
        }
    }
}

