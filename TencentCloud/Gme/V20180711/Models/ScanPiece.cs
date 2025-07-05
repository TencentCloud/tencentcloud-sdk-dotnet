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

namespace TencentCloud.Gme.V20180711.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScanPiece : AbstractModel
    {
        
        /// <summary>
        /// 流检测时返回，音频转存地址，保留30min
        /// </summary>
        [JsonProperty("DumpUrl")]
        public string DumpUrl{ get; set; }

        /// <summary>
        /// 是否违规
        /// </summary>
        [JsonProperty("HitFlag")]
        public bool? HitFlag{ get; set; }

        /// <summary>
        /// 违规主要类型
        /// </summary>
        [JsonProperty("MainType")]
        public string MainType{ get; set; }

        /// <summary>
        /// 语音检测详情
        /// </summary>
        [JsonProperty("ScanDetail")]
        public ScanDetail[] ScanDetail{ get; set; }

        /// <summary>
        /// gme实时语音房间ID，透传任务传入时的RoomId
        /// </summary>
        [JsonProperty("RoomId")]
        public string RoomId{ get; set; }

        /// <summary>
        /// gme实时语音用户ID，透传任务传入时的OpenId
        /// </summary>
        [JsonProperty("OpenId")]
        public string OpenId{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Info")]
        public string Info{ get; set; }

        /// <summary>
        /// 流检测时分片在流中的偏移时间，单位毫秒
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 流检测时分片时长
        /// </summary>
        [JsonProperty("Duration")]
        public ulong? Duration{ get; set; }

        /// <summary>
        /// 分片开始检测时间
        /// </summary>
        [JsonProperty("PieceStartTime")]
        public ulong? PieceStartTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DumpUrl", this.DumpUrl);
            this.SetParamSimple(map, prefix + "HitFlag", this.HitFlag);
            this.SetParamSimple(map, prefix + "MainType", this.MainType);
            this.SetParamArrayObj(map, prefix + "ScanDetail.", this.ScanDetail);
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamSimple(map, prefix + "OpenId", this.OpenId);
            this.SetParamSimple(map, prefix + "Info", this.Info);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "PieceStartTime", this.PieceStartTime);
        }
    }
}

