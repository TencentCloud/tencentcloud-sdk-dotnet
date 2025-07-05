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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TopicDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 返回的主题详情列表
        /// </summary>
        [JsonProperty("TopicList")]
        public TopicDetail[] TopicList{ get; set; }

        /// <summary>
        /// 符合条件的所有主题详情数量
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "TopicList.", this.TopicList);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
        }
    }
}

