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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CacheConfigFollowOrigin : AbstractModel
    {
        
        /// <summary>
        /// 路径缓存遵循源站配置开关，取值有：
        /// on：开启
        /// off：关闭
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// 启发式缓存配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HeuristicCache")]
        public HeuristicCache HeuristicCache{ get; set; }

        /// <summary>
        /// 当缓存过期后，是否开启源站 mtime 校验，配置值为equal、since、none 和 null。默认配置值为equal，会校验源站文件的mtime与长度。2024-09-12 18:00 之前创建的域名默认值 null，行为保持不变。
        /// equal：源站响应mtime必须和缓存mtime一致，若mtime值不一致，清除缓存。
        /// since：若源站响应mtime大于缓存mtime，清除缓存。
        /// none： 缓存过期回源重新获取文件mtime和长度后，不会校验源站响应mtime，若源站响应携带Content-Length头部，只有文件大小改变时才会更新缓存；若源站响应不携带Content-Length头部，会更新缓存。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OriginMtimeCheckType")]
        public string OriginMtimeCheckType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamObj(map, prefix + "HeuristicCache.", this.HeuristicCache);
            this.SetParamSimple(map, prefix + "OriginMtimeCheckType", this.OriginMtimeCheckType);
        }
    }
}

