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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OverviewRow : AbstractModel
    {
        
        /// <summary>
        /// 表名字
        /// </summary>
        [JsonProperty("Table")]
        public string Table{ get; set; }

        /// <summary>
        /// 读请求次数
        /// </summary>
        [JsonProperty("ReadRequestCount")]
        public float? ReadRequestCount{ get; set; }

        /// <summary>
        /// 写请求次数
        /// </summary>
        [JsonProperty("WriteRequestCount")]
        public float? WriteRequestCount{ get; set; }

        /// <summary>
        /// 当前memstore的size
        /// </summary>
        [JsonProperty("MemstoreSize")]
        public float? MemstoreSize{ get; set; }

        /// <summary>
        /// 当前region中StroreFile的size
        /// </summary>
        [JsonProperty("StoreFileSize")]
        public float? StoreFileSize{ get; set; }

        /// <summary>
        /// regions，点击可跳转
        /// </summary>
        [JsonProperty("Operation")]
        public string Operation{ get; set; }

        /// <summary>
        /// StoreFile数量
        /// </summary>
        [JsonProperty("StoreFileNum")]
        public float? StoreFileNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Table", this.Table);
            this.SetParamSimple(map, prefix + "ReadRequestCount", this.ReadRequestCount);
            this.SetParamSimple(map, prefix + "WriteRequestCount", this.WriteRequestCount);
            this.SetParamSimple(map, prefix + "MemstoreSize", this.MemstoreSize);
            this.SetParamSimple(map, prefix + "StoreFileSize", this.StoreFileSize);
            this.SetParamSimple(map, prefix + "Operation", this.Operation);
            this.SetParamSimple(map, prefix + "StoreFileNum", this.StoreFileNum);
        }
    }
}

