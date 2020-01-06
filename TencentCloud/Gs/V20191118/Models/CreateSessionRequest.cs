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
        /// 游戏用户ID
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 游戏ID
        /// </summary>
        [JsonProperty("GameId")]
        public string GameId{ get; set; }

        /// <summary>
        /// 游戏区域
        /// </summary>
        [JsonProperty("GameRegion")]
        public string GameRegion{ get; set; }

        /// <summary>
        /// 游戏参数
        /// </summary>
        [JsonProperty("GameParas")]
        public string GameParas{ get; set; }

        /// <summary>
        /// 分辨率
        /// </summary>
        [JsonProperty("Resolution")]
        public string Resolution{ get; set; }

        /// <summary>
        /// 背景图url
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// 资源池编号
        /// </summary>
        [JsonProperty("SetNo")]
        public ulong? SetNo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClientSession", this.ClientSession);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "GameId", this.GameId);
            this.SetParamSimple(map, prefix + "GameRegion", this.GameRegion);
            this.SetParamSimple(map, prefix + "GameParas", this.GameParas);
            this.SetParamSimple(map, prefix + "Resolution", this.Resolution);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "SetNo", this.SetNo);
        }
    }
}

