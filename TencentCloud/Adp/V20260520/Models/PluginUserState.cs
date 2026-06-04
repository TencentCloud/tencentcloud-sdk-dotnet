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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PluginUserState : AbstractModel
    {
        
        /// <summary>
        /// 是否已收藏该插件
        /// </summary>
        [JsonProperty("IsFavorite")]
        public bool? IsFavorite{ get; set; }

        /// <summary>
        /// 是否在插件白名单内
        /// </summary>
        [JsonProperty("IsInWhiteList")]
        public bool? IsInWhiteList{ get; set; }

        /// <summary>
        /// 白名单类型
        /// 枚举值:
        /// | uint | 描述 |
        /// | --- | --- |
        /// | 0 | 非白名单插件，全量开放 |
        /// | 1 | 在白名单里 |
        /// | 2 | 不在白名单里，需要提交申请 |
        /// </summary>
        [JsonProperty("WhiteListType")]
        public long? WhiteListType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsFavorite", this.IsFavorite);
            this.SetParamSimple(map, prefix + "IsInWhiteList", this.IsInWhiteList);
            this.SetParamSimple(map, prefix + "WhiteListType", this.WhiteListType);
        }
    }
}

