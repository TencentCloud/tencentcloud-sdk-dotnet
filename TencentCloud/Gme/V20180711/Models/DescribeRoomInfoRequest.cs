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

    public class DescribeRoomInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用ID，登录[控制台 - 服务管理](https://console.cloud.tencent.com/gamegme)创建应用得到的AppID
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// 房间号列表，最大不能超过10个（RoomIds、StrRoomIds必须填一个）
        /// </summary>
        [JsonProperty("RoomIds")]
        public ulong?[] RoomIds{ get; set; }

        /// <summary>
        /// 字符串类型房间号列表，最大不能超过10个（RoomIds、StrRoomIds必须填一个）
        /// </summary>
        [JsonProperty("StrRoomIds")]
        public string[] StrRoomIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamArraySimple(map, prefix + "RoomIds.", this.RoomIds);
            this.SetParamArraySimple(map, prefix + "StrRoomIds.", this.StrRoomIds);
        }
    }
}

