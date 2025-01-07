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

namespace TencentCloud.Lcic.V20220817.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BindDocumentToRoomRequest : AbstractModel
    {
        
        /// <summary>
        /// 房间ID。
        /// </summary>
        [JsonProperty("RoomId")]
        public ulong? RoomId{ get; set; }

        /// <summary>
        /// 文档ID。
        /// </summary>
        [JsonProperty("DocumentId")]
        public string DocumentId{ get; set; }

        /// <summary>
        /// 绑定类型。后台可透传到客户端，默认为0。除以下例值外支持自定义该字段，并在前端实现相应业务逻辑，示例参考：
        /// 示例值：0，仅绑定课件到房间
        /// 示例值：1，绑定课件到房间后，默认展示课件
        /// </summary>
        [JsonProperty("BindType")]
        public ulong? BindType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamSimple(map, prefix + "DocumentId", this.DocumentId);
            this.SetParamSimple(map, prefix + "BindType", this.BindType);
        }
    }
}

