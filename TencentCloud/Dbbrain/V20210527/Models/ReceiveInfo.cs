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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReceiveInfo : AbstractModel
    {
        
        /// <summary>
        /// 接收组
        /// </summary>
        [JsonProperty("ReceiveGroup")]
        public long?[] ReceiveGroup{ get; set; }

        /// <summary>
        /// 最后接收时间，格式: "HH:mm:ss"
        /// </summary>
        [JsonProperty("EndReceiveTime")]
        public string EndReceiveTime{ get; set; }

        /// <summary>
        /// 接收名
        /// </summary>
        [JsonProperty("ReceiveName")]
        public string ReceiveName{ get; set; }

        /// <summary>
        /// 推送渠道
        /// </summary>
        [JsonProperty("SendChannel")]
        public long?[] SendChannel{ get; set; }

        /// <summary>
        /// 开始时间，格式: "HH:mm:ss"
        /// </summary>
        [JsonProperty("StartReceiveTime")]
        public string StartReceiveTime{ get; set; }

        /// <summary>
        /// 接收用户列表
        /// </summary>
        [JsonProperty("ReceiveUin")]
        public ReceiveUin[] ReceiveUin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ReceiveGroup.", this.ReceiveGroup);
            this.SetParamSimple(map, prefix + "EndReceiveTime", this.EndReceiveTime);
            this.SetParamSimple(map, prefix + "ReceiveName", this.ReceiveName);
            this.SetParamArraySimple(map, prefix + "SendChannel.", this.SendChannel);
            this.SetParamSimple(map, prefix + "StartReceiveTime", this.StartReceiveTime);
            this.SetParamArrayObj(map, prefix + "ReceiveUin.", this.ReceiveUin);
        }
    }
}

