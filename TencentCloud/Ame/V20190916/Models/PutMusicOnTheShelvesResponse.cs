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

    public class PutMusicOnTheShelvesResponse : AbstractModel
    {
        
        /// <summary>
        /// 操作成功数量
        /// </summary>
        [JsonProperty("SuccessNum")]
        public long? SuccessNum{ get; set; }

        /// <summary>
        /// 操作失败数量
        /// </summary>
        [JsonProperty("FailedNum")]
        public long? FailedNum{ get; set; }

        /// <summary>
        /// 失败歌曲Id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FailedMusicIds")]
        public string[] FailedMusicIds{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SuccessNum", this.SuccessNum);
            this.SetParamSimple(map, prefix + "FailedNum", this.FailedNum);
            this.SetParamArraySimple(map, prefix + "FailedMusicIds.", this.FailedMusicIds);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

