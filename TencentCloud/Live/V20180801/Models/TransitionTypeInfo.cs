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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TransitionTypeInfo : AbstractModel
    {
        
        /// <summary>
        /// 转场名称
        /// </summary>
        [JsonProperty("TransitionType")]
        public string TransitionType{ get; set; }

        /// <summary>
        /// 素材url
        /// </summary>
        [JsonProperty("SourceUrl")]
        public string SourceUrl{ get; set; }

        /// <summary>
        /// 转场的下标，可用来排序，从1开始递增
        /// </summary>
        [JsonProperty("Index")]
        public ulong? Index{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TransitionType", this.TransitionType);
            this.SetParamSimple(map, prefix + "SourceUrl", this.SourceUrl);
            this.SetParamSimple(map, prefix + "Index", this.Index);
        }
    }
}

