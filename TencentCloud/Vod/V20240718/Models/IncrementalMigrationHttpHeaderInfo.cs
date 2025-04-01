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

namespace TencentCloud.Vod.V20240718.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IncrementalMigrationHttpHeaderInfo : AbstractModel
    {
        
        /// <summary>
        /// Http Header 透传模式。取值有：
        /// <li>FOLLOW_ALL：透传所有头部信息；</li>
        /// <li>FOLLOW_PART：透传部分头部信息；</li>
        /// <li>IGNORE_PART：忽略部分头部信息。</li>参数必填。
        /// </summary>
        [JsonProperty("HeaderFollowMode")]
        public string HeaderFollowMode{ get; set; }

        /// <summary>
        /// 需透传 Header Key 集合，仅当 HeaderFollowMode 取值 `FOLLOW_PART` 时需要填充。
        /// </summary>
        [JsonProperty("FollowHttpHeaderKeySet")]
        public string[] FollowHttpHeaderKeySet{ get; set; }

        /// <summary>
        /// 新增 Header 键值对集合。
        /// </summary>
        [JsonProperty("NewHttpHeaderSet")]
        public IncrementalMigrationHttpHeader[] NewHttpHeaderSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HeaderFollowMode", this.HeaderFollowMode);
            this.SetParamArraySimple(map, prefix + "FollowHttpHeaderKeySet.", this.FollowHttpHeaderKeySet);
            this.SetParamArrayObj(map, prefix + "NewHttpHeaderSet.", this.NewHttpHeaderSet);
        }
    }
}

