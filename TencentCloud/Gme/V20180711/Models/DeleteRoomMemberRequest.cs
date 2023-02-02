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

namespace TencentCloud.Gme.V20180711.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteRoomMemberRequest : AbstractModel
    {
        
        /// <summary>
        /// 要操作的房间id
        /// </summary>
        [JsonProperty("RoomId")]
        public string RoomId{ get; set; }

        /// <summary>
        /// 剔除类型 1-删除房间 2-剔除用户
        /// </summary>
        [JsonProperty("DeleteType")]
        public ulong? DeleteType{ get; set; }

        /// <summary>
        /// 应用id
        /// </summary>
        [JsonProperty("BizId")]
        public ulong? BizId{ get; set; }

        /// <summary>
        /// 要剔除的用户列表
        /// </summary>
        [JsonProperty("Uids")]
        public string[] Uids{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamSimple(map, prefix + "DeleteType", this.DeleteType);
            this.SetParamSimple(map, prefix + "BizId", this.BizId);
            this.SetParamArraySimple(map, prefix + "Uids.", this.Uids);
        }
    }
}

