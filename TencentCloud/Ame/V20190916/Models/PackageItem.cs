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

namespace TencentCloud.Ame.V20190916.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PackageItem : AbstractModel
    {
        
        /// <summary>
        /// 订单id
        /// </summary>
        [JsonProperty("OrderId")]
        public string OrderId{ get; set; }

        /// <summary>
        /// 歌曲名
        /// </summary>
        [JsonProperty("TrackName")]
        public string TrackName{ get; set; }

        /// <summary>
        /// 歌曲ID
        /// </summary>
        [JsonProperty("ItemID")]
        public string ItemID{ get; set; }

        /// <summary>
        /// 专辑图片
        /// </summary>
        [JsonProperty("Img")]
        public string Img{ get; set; }

        /// <summary>
        /// 歌手名
        /// </summary>
        [JsonProperty("ArtistName")]
        public string ArtistName{ get; set; }

        /// <summary>
        /// 歌曲时长
        /// </summary>
        [JsonProperty("Duration")]
        public string Duration{ get; set; }

        /// <summary>
        /// 授权区域，global: 全球 CN: 中国
        /// </summary>
        [JsonProperty("AuthorizedArea")]
        public string AuthorizedArea{ get; set; }

        /// <summary>
        /// 标签数组
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OrderId", this.OrderId);
            this.SetParamSimple(map, prefix + "TrackName", this.TrackName);
            this.SetParamSimple(map, prefix + "ItemID", this.ItemID);
            this.SetParamSimple(map, prefix + "Img", this.Img);
            this.SetParamSimple(map, prefix + "ArtistName", this.ArtistName);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "AuthorizedArea", this.AuthorizedArea);
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
        }
    }
}

