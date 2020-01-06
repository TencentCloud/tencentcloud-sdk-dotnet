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

namespace TencentCloud.Ame.V20190916.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeMusicRequest : AbstractModel
    {
        
        /// <summary>
        /// 歌曲ID
        /// </summary>
        [JsonProperty("ItemId")]
        public string ItemId{ get; set; }

        /// <summary>
        /// User identity ID，用来唯一标识用户
        /// </summary>
        [JsonProperty("IdentityId")]
        public string IdentityId{ get; set; }

        /// <summary>
        /// 填 MP3-64K-FTD-P 获取歌曲热门片段
        /// </summary>
        [JsonProperty("SubItemType")]
        public string SubItemType{ get; set; }

        /// <summary>
        /// CDN URL Protocol:HTTP or HTTPS/SSL
        /// Values:Y , N(default)
        /// </summary>
        [JsonProperty("Ssl")]
        public string Ssl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ItemId", this.ItemId);
            this.SetParamSimple(map, prefix + "IdentityId", this.IdentityId);
            this.SetParamSimple(map, prefix + "SubItemType", this.SubItemType);
            this.SetParamSimple(map, prefix + "Ssl", this.Ssl);
        }
    }
}

