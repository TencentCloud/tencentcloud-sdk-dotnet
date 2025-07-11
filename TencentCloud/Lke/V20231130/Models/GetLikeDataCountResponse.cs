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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetLikeDataCountResponse : AbstractModel
    {
        
        /// <summary>
        /// 可评价消息数
        /// </summary>
        [JsonProperty("Total")]
        public ulong? Total{ get; set; }

        /// <summary>
        /// 评价数
        /// </summary>
        [JsonProperty("AppraisalTotal")]
        public ulong? AppraisalTotal{ get; set; }

        /// <summary>
        /// 参评率
        /// </summary>
        [JsonProperty("ParticipationRate")]
        public float? ParticipationRate{ get; set; }

        /// <summary>
        /// 点赞数
        /// </summary>
        [JsonProperty("LikeTotal")]
        public ulong? LikeTotal{ get; set; }

        /// <summary>
        /// 点赞率
        /// </summary>
        [JsonProperty("LikeRate")]
        public float? LikeRate{ get; set; }

        /// <summary>
        /// 点踩数
        /// </summary>
        [JsonProperty("DislikeTotal")]
        public ulong? DislikeTotal{ get; set; }

        /// <summary>
        /// 点踩率
        /// </summary>
        [JsonProperty("DislikeRate")]
        public float? DislikeRate{ get; set; }

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
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamSimple(map, prefix + "AppraisalTotal", this.AppraisalTotal);
            this.SetParamSimple(map, prefix + "ParticipationRate", this.ParticipationRate);
            this.SetParamSimple(map, prefix + "LikeTotal", this.LikeTotal);
            this.SetParamSimple(map, prefix + "LikeRate", this.LikeRate);
            this.SetParamSimple(map, prefix + "DislikeTotal", this.DislikeTotal);
            this.SetParamSimple(map, prefix + "DislikeRate", this.DislikeRate);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

