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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MemoryPicture : AbstractModel
    {
        
        /// <summary>
        /// 内存最大值
        /// </summary>
        [JsonProperty("Max")]
        public CurvePoint[] Max{ get; set; }

        /// <summary>
        /// 已用内存大小
        /// </summary>
        [JsonProperty("Used")]
        public CurvePoint[] Used{ get; set; }

        /// <summary>
        /// 系统分配内存大小
        /// </summary>
        [JsonProperty("Committed")]
        public CurvePoint[] Committed{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Max.", this.Max);
            this.SetParamArrayObj(map, prefix + "Used.", this.Used);
            this.SetParamArrayObj(map, prefix + "Committed.", this.Committed);
        }
    }
}

