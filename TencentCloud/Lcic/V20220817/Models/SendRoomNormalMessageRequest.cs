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

    public class SendRoomNormalMessageRequest : AbstractModel
    {
        
        /// <summary>
        /// 低代码互动课堂的SdkAppId。
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// 房间ID。
        /// </summary>
        [JsonProperty("RoomId")]
        public ulong? RoomId{ get; set; }

        /// <summary>
        /// 管理员指定消息发送方账号（若需设置 FromAccount 信息，则该参数取值不能为空）
        /// </summary>
        [JsonProperty("FromAccount")]
        public string FromAccount{ get; set; }

        /// <summary>
        /// 自定义消息
        /// </summary>
        [JsonProperty("MsgBody")]
        public MsgBody[] MsgBody{ get; set; }

        /// <summary>
        /// 消息自定义数据（云端保存，会发送到对端，程序卸载重装后还能拉取到）。
        /// </summary>
        [JsonProperty("CloudCustomData")]
        public string CloudCustomData{ get; set; }

        /// <summary>
        /// 昵称，当FromAccount没有在房间中，需要填写NickName，当FromAccount在房间中，填写NickName无意义
        /// </summary>
        [JsonProperty("NickName")]
        public string NickName{ get; set; }

        /// <summary>
        /// 消息的优先级，默认优先级 Normal。
        /// 可以指定3种优先级，从高到低依次为 High、Normal 和 Low，区分大小写。
        /// </summary>
        [JsonProperty("Priority")]
        public string Priority{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamSimple(map, prefix + "FromAccount", this.FromAccount);
            this.SetParamArrayObj(map, prefix + "MsgBody.", this.MsgBody);
            this.SetParamSimple(map, prefix + "CloudCustomData", this.CloudCustomData);
            this.SetParamSimple(map, prefix + "NickName", this.NickName);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
        }
    }
}

