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

    public class DifferenceData : AbstractModel
    {
        
        /// <summary>
        /// 数据库名
        /// </summary>
        [JsonProperty("Db")]
        public string Db{ get; set; }

        /// <summary>
        /// 集合
        /// </summary>
        [JsonProperty("Table")]
        public string Table{ get; set; }

        /// <summary>
        /// 源端ID
        /// </summary>
        [JsonProperty("SrcChunk")]
        public string SrcChunk{ get; set; }

        /// <summary>
        /// 目标端ID
        /// </summary>
        [JsonProperty("DstChunk")]
        public string DstChunk{ get; set; }

        /// <summary>
        /// 源端值
        /// </summary>
        [JsonProperty("SrcItem")]
        public string SrcItem{ get; set; }

        /// <summary>
        /// 目标端值
        /// </summary>
        [JsonProperty("DstItem")]
        public string DstItem{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdatedAt")]
        public string UpdatedAt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Db", this.Db);
            this.SetParamSimple(map, prefix + "Table", this.Table);
            this.SetParamSimple(map, prefix + "SrcChunk", this.SrcChunk);
            this.SetParamSimple(map, prefix + "DstChunk", this.DstChunk);
            this.SetParamSimple(map, prefix + "SrcItem", this.SrcItem);
            this.SetParamSimple(map, prefix + "DstItem", this.DstItem);
            this.SetParamSimple(map, prefix + "UpdatedAt", this.UpdatedAt);
        }
    }
}

