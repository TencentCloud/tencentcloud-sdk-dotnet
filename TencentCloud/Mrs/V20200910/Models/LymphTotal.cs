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

namespace TencentCloud.Mrs.V20200910.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LymphTotal : AbstractModel
    {
        
        /// <summary>
        /// 项目名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 转移数量
        /// </summary>
        [JsonProperty("TransferNum")]
        public long? TransferNum{ get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        [JsonProperty("Total")]
        public long? Total{ get; set; }

        /// <summary>
        /// 原文
        /// </summary>
        [JsonProperty("Src")]
        public string Src{ get; set; }

        /// <summary>
        /// 索引
        /// </summary>
        [JsonProperty("Index")]
        public long?[] Index{ get; set; }

        /// <summary>
        /// 原文对应坐标
        /// </summary>
        [JsonProperty("Coords")]
        public Coord[] Coords{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "TransferNum", this.TransferNum);
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamSimple(map, prefix + "Src", this.Src);
            this.SetParamArraySimple(map, prefix + "Index.", this.Index);
            this.SetParamArrayObj(map, prefix + "Coords.", this.Coords);
        }
    }
}

