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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateTRTCSignaturesWithRoomIdRequest : AbstractModel
    {
        
        /// <summary>
        /// TRTC进房间的用户名称数组，数组元素不可重复，最长不超过 10 个。
        /// </summary>
        [JsonProperty("TRTCUserIds")]
        public string[] TRTCUserIds{ get; set; }

        /// <summary>
        /// 房间id
        /// </summary>
        [JsonProperty("RoomId")]
        public string RoomId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "TRTCUserIds.", this.TRTCUserIds);
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
        }
    }
}

