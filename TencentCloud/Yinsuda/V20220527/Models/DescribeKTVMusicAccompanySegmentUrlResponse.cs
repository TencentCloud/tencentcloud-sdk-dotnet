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

namespace TencentCloud.Yinsuda.V20220527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeKTVMusicAccompanySegmentUrlResponse : AbstractModel
    {
        
        /// <summary>
        /// 歌曲状态。
        /// 0：可用
        /// 1：下线
        /// 2：没权限
        /// 3：没伴奏
        /// 当返回2时，其他参数有可能全部为空
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 伴奏链接
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 伴奏类型，如mkv，mp3等
        /// </summary>
        [JsonProperty("ExtName")]
        public string ExtName{ get; set; }

        /// <summary>
        /// 高潮开始时间
        /// </summary>
        [JsonProperty("SegmentBegin")]
        public long? SegmentBegin{ get; set; }

        /// <summary>
        /// 高潮结束时间
        /// </summary>
        [JsonProperty("SegmentEnd")]
        public long? SegmentEnd{ get; set; }

        /// <summary>
        /// 链接文件大小 单位 字节
        /// </summary>
        [JsonProperty("FileSize")]
        public long? FileSize{ get; set; }

        /// <summary>
        /// 其它片段时间（可用于抢唱）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OtherSegments")]
        public KTVOtherSegments[] OtherSegments{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "ExtName", this.ExtName);
            this.SetParamSimple(map, prefix + "SegmentBegin", this.SegmentBegin);
            this.SetParamSimple(map, prefix + "SegmentEnd", this.SegmentEnd);
            this.SetParamSimple(map, prefix + "FileSize", this.FileSize);
            this.SetParamArrayObj(map, prefix + "OtherSegments.", this.OtherSegments);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

