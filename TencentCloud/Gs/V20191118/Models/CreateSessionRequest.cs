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

namespace TencentCloud.Gs.V20191118.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateSessionRequest : AbstractModel
    {
        
        /// <summary>
        /// 客户端session信息，从JSSDK请求中获得
        /// </summary>
        [JsonProperty("ClientSession")]
        public string ClientSession{ get; set; }

        /// <summary>
        /// 唯一用户身份标识，由业务方自定义，平台不予理解。（可根据业务需要决定使用用户的唯一身份标识或是使用时间戳随机生成；在用户重连时应保持UserId不变）
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 游戏ID
        /// </summary>
        [JsonProperty("GameId")]
        public string GameId{ get; set; }

        /// <summary>
        /// 【已废弃】只在TrylockWorker时生效
        /// </summary>
        [JsonProperty("GameRegion")]
        public string GameRegion{ get; set; }

        /// <summary>
        /// 游戏参数
        /// </summary>
        [JsonProperty("GameParas")]
        public string GameParas{ get; set; }

        /// <summary>
        /// 分辨率,，可设置为1080p或720p或1920x1080格式
        /// </summary>
        [JsonProperty("Resolution")]
        public string Resolution{ get; set; }

        /// <summary>
        /// 背景图url，格式为png或jpeg，宽高1920*1080
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// 【已废弃】
        /// </summary>
        [JsonProperty("SetNo")]
        public ulong? SetNo{ get; set; }

        /// <summary>
        /// 单位Mbps，固定码率建议值，有一定浮动范围，后端不动态调整(MaxBitrate和MinBitrate将无效)
        /// </summary>
        [JsonProperty("Bitrate")]
        public ulong? Bitrate{ get; set; }

        /// <summary>
        /// 单位Mbps，动态调整最大码率建议值，会按实际情况调整
        /// </summary>
        [JsonProperty("MaxBitrate")]
        public ulong? MaxBitrate{ get; set; }

        /// <summary>
        /// 单位Mbps，动态调整最小码率建议值，会按实际情况调整
        /// </summary>
        [JsonProperty("MinBitrate")]
        public ulong? MinBitrate{ get; set; }

        /// <summary>
        /// 帧率，可设置为30、45、60、90、120、144
        /// </summary>
        [JsonProperty("Fps")]
        public ulong? Fps{ get; set; }

        /// <summary>
        /// 【已废弃】只在TrylockWorker时生效
        /// </summary>
        [JsonProperty("UserIp")]
        public string UserIp{ get; set; }

        /// <summary>
        /// 【已废弃】优化项，便于客户灰度开启新的优化项，默认为0
        /// </summary>
        [JsonProperty("Optimization")]
        public ulong? Optimization{ get; set; }

        /// <summary>
        /// 【互动云游】游戏主机用户ID
        /// </summary>
        [JsonProperty("HostUserId")]
        public string HostUserId{ get; set; }

        /// <summary>
        /// 【互动云游】角色；Player表示玩家；Viewer表示观察者
        /// </summary>
        [JsonProperty("Role")]
        public string Role{ get; set; }

        /// <summary>
        /// 游戏相关参数
        /// </summary>
        [JsonProperty("GameContext")]
        public string GameContext{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClientSession", this.ClientSession);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "GameId", this.GameId);
            this.SetParamSimple(map, prefix + "GameRegion", this.GameRegion);
            this.SetParamSimple(map, prefix + "GameParas", this.GameParas);
            this.SetParamSimple(map, prefix + "Resolution", this.Resolution);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "SetNo", this.SetNo);
            this.SetParamSimple(map, prefix + "Bitrate", this.Bitrate);
            this.SetParamSimple(map, prefix + "MaxBitrate", this.MaxBitrate);
            this.SetParamSimple(map, prefix + "MinBitrate", this.MinBitrate);
            this.SetParamSimple(map, prefix + "Fps", this.Fps);
            this.SetParamSimple(map, prefix + "UserIp", this.UserIp);
            this.SetParamSimple(map, prefix + "Optimization", this.Optimization);
            this.SetParamSimple(map, prefix + "HostUserId", this.HostUserId);
            this.SetParamSimple(map, prefix + "Role", this.Role);
            this.SetParamSimple(map, prefix + "GameContext", this.GameContext);
        }
    }
}

