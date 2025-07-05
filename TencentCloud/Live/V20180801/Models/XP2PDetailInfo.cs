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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class XP2PDetailInfo : AbstractModel
    {
        
        /// <summary>
        /// CDN流量。
        /// </summary>
        [JsonProperty("CdnBytes")]
        public long? CdnBytes{ get; set; }

        /// <summary>
        /// P2P流量。
        /// </summary>
        [JsonProperty("P2pBytes")]
        public long? P2pBytes{ get; set; }

        /// <summary>
        /// 卡播人数。
        /// </summary>
        [JsonProperty("StuckPeople")]
        public long? StuckPeople{ get; set; }

        /// <summary>
        /// 卡播次数。
        /// </summary>
        [JsonProperty("StuckTimes")]
        public long? StuckTimes{ get; set; }

        /// <summary>
        /// 在线人数。
        /// </summary>
        [JsonProperty("OnlinePeople")]
        public long? OnlinePeople{ get; set; }

        /// <summary>
        /// 起播请求次数
        /// </summary>
        [JsonProperty("Request")]
        public long? Request{ get; set; }

        /// <summary>
        /// 起播成功次数
        /// </summary>
        [JsonProperty("RequestSuccess")]
        public long? RequestSuccess{ get; set; }

        /// <summary>
        /// 时间，一分钟粒度，utc格式：yyyy-mm-ddTHH:MM:SSZ，参考https://cloud.tencent.com/document/product/266/11732#I。。
        /// </summary>
        [JsonProperty("Time")]
        public string Time{ get; set; }

        /// <summary>
        /// 类型，分live和vod两种。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 流ID。
        /// </summary>
        [JsonProperty("StreamName")]
        public string StreamName{ get; set; }

        /// <summary>
        /// AppId。
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CdnBytes", this.CdnBytes);
            this.SetParamSimple(map, prefix + "P2pBytes", this.P2pBytes);
            this.SetParamSimple(map, prefix + "StuckPeople", this.StuckPeople);
            this.SetParamSimple(map, prefix + "StuckTimes", this.StuckTimes);
            this.SetParamSimple(map, prefix + "OnlinePeople", this.OnlinePeople);
            this.SetParamSimple(map, prefix + "Request", this.Request);
            this.SetParamSimple(map, prefix + "RequestSuccess", this.RequestSuccess);
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "StreamName", this.StreamName);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
        }
    }
}

