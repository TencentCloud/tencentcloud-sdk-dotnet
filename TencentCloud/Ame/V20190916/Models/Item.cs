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

    public class Item : AbstractModel
    {
        
        /// <summary>
        /// Song ID
        /// </summary>
        [JsonProperty("ItemID")]
        public string ItemID{ get; set; }

        /// <summary>
        /// Song info
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataInfo")]
        public DataInfo DataInfo{ get; set; }

        /// <summary>
        /// 专辑信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Album")]
        public Album Album{ get; set; }

        /// <summary>
        /// 多个歌手集合
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Artists")]
        public Artist[] Artists{ get; set; }

        /// <summary>
        /// 歌曲状态，1:添加进购物车；2:核销进曲库包
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ItemID", this.ItemID);
            this.SetParamObj(map, prefix + "DataInfo.", this.DataInfo);
            this.SetParamObj(map, prefix + "Album.", this.Album);
            this.SetParamArrayObj(map, prefix + "Artists.", this.Artists);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

