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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCloudModerationRequest : AbstractModel
    {
        
        /// <summary>
        /// TRTC的[SdkAppId](https://cloud.tencent.com/document/product/647/46351#sdkappid)，和TRTC的房间所对应的SdkAppId相同。
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// TRTC的[RoomId](https://cloud.tencent.com/document/product/647/46351#roomid)，为TRTC房间所对应的RoomId。
        /// </summary>
        [JsonProperty("RoomId")]
        public string RoomId{ get; set; }

        /// <summary>
        /// 机器人的UserId，用于进房发起审核任务。【*注意】这个UserId不能与当前房间内的主播观众UserId重复。如果一个房间发起多个切片任务时，机器人的userid也不能相互重复，否则会中断前一个切片任务。建议可以把房间ID作为UserId的标识的一部分，即机器人UserId在房间内唯一。
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 云端审核控制参数。
        /// </summary>
        [JsonProperty("ModerationParams")]
        public ModerationParams ModerationParams{ get; set; }

        /// <summary>
        /// 机器人UserId对应的校验签名，即UserId和UserSig相当于机器人进房的登录密码，具体计算方法请参考TRTC计算UserSig的方案。
        /// </summary>
        [JsonProperty("UserSig")]
        public string UserSig{ get; set; }

        /// <summary>
        /// 云端审核文件上传到云存储的参数。
        /// </summary>
        [JsonProperty("ModerationStorageParams")]
        public ModerationStorageParams ModerationStorageParams{ get; set; }

        /// <summary>
        /// TRTC房间号的类型。 【*注意】必须和录制的房间所对应的RoomId类型相同: 0: 字符串类型的RoomId 1: 32位整型的RoomId（默认） 示例值：1
        /// </summary>
        [JsonProperty("RoomIdType")]
        public ulong? RoomIdType{ get; set; }

        /// <summary>
        /// 任务ID可以调用的时效性，从成功开启任务并获得TaskID后开始计算，超时后无法调用查询、更新和停止等接口，但是切片任务不会停止。 参数的单位是小时，默认24小时（1天），最大可设置72小时（3天），最小设置6小时。举例说明：如果不设置该参数，那么开始切片成功后，查询、更新和停止切片的调用时效为24个小时。
        /// </summary>
        [JsonProperty("ResourceExpiredHour")]
        public ulong? ResourceExpiredHour{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamObj(map, prefix + "ModerationParams.", this.ModerationParams);
            this.SetParamSimple(map, prefix + "UserSig", this.UserSig);
            this.SetParamObj(map, prefix + "ModerationStorageParams.", this.ModerationStorageParams);
            this.SetParamSimple(map, prefix + "RoomIdType", this.RoomIdType);
            this.SetParamSimple(map, prefix + "ResourceExpiredHour", this.ResourceExpiredHour);
        }
    }
}

