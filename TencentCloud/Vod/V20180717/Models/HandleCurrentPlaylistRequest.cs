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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HandleCurrentPlaylistRequest : AbstractModel
    {
        
        /// <summary>
        /// <b>点播[应用](/document/product/266/14574) ID。</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// 轮播播单唯一标识。
        /// </summary>
        [JsonProperty("RoundPlayId")]
        public string RoundPlayId{ get; set; }

        /// <summary>
        /// 操作类型，取值有：<li>Insert：向当前播放列表插入节目。插入的节目在后续轮播过程仍然有效。</li> <li>InsertTemporary：向当前播放列表临时插入节目。临时插入的节目只在本次轮播过程生效。</li><li>Delete：删除播放列表中的节目。不能删除正在播放的节目。</li>
        /// </summary>
        [JsonProperty("Operation")]
        public string Operation{ get; set; }

        /// <summary>
        /// 播单节目 ID。 <li>当 Operation 为 Insert 时，该字段必填，表示插入的节目列表位于该节目之后。</li> <li>当 Operation 为 InsertTemporary 时，该字段选填，不填时表示插入节目到最近的一个插入点上。当该字段填写时，如果同时填写 SegmentIndex，表示节目被插入到 ItemId 对应节目的第 SegmentIndex 分片后面，否则插入到该节目之后。</li> <li>当 Operation 为 Delete 时，该字段必填，表示删除该节目。不能删除正在播放的节目。</li>
        /// </summary>
        [JsonProperty("ItemId")]
        public string ItemId{ get; set; }

        /// <summary>
        /// M3U8 文件分片的索引号。M3U8 文件第一个分片的 SegmentIndex 为0。当 Operation 为 InsertTemporary 且 ItemId 有值时该参数有效。
        /// </summary>
        [JsonProperty("SegmentIndex")]
        public long? SegmentIndex{ get; set; }

        /// <summary>
        /// 节目列表。当 Operation 为 Insert、InsertTemporary、Delete 时必填，表示要操作的节目列表。列表长度最大为10。
        /// </summary>
        [JsonProperty("RoundPlaylist")]
        public RoundPlayListItemInfo[] RoundPlaylist{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "RoundPlayId", this.RoundPlayId);
            this.SetParamSimple(map, prefix + "Operation", this.Operation);
            this.SetParamSimple(map, prefix + "ItemId", this.ItemId);
            this.SetParamSimple(map, prefix + "SegmentIndex", this.SegmentIndex);
            this.SetParamArrayObj(map, prefix + "RoundPlaylist.", this.RoundPlaylist);
        }
    }
}

