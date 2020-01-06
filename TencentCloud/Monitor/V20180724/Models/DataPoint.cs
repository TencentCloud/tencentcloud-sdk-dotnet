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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DataPoint : AbstractModel
    {
        
        /// <summary>
        /// 实例对象维度组合
        /// </summary>
        [JsonProperty("Dimensions")]
        public Dimension[] Dimensions{ get; set; }

        /// <summary>
        /// 时间戳数组，表示那些时间点有数据，缺失的时间戳，没有数据点，可以理解为掉点了
        /// </summary>
        [JsonProperty("Timestamps")]
        public float?[] Timestamps{ get; set; }

        /// <summary>
        /// 监控值数组，该数组和Timestamps一一对应
        /// </summary>
        [JsonProperty("Values")]
        public float?[] Values{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Dimensions.", this.Dimensions);
            this.SetParamArraySimple(map, prefix + "Timestamps.", this.Timestamps);
            this.SetParamArraySimple(map, prefix + "Values.", this.Values);
        }
    }
}

