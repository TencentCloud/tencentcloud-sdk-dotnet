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

namespace TencentCloud.Hasim.V20210716.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeLinksRequest : AbstractModel
    {
        
        /// <summary>
        /// 云兔卡ID
        /// </summary>
        [JsonProperty("LinkID")]
        public long? LinkID{ get; set; }

        /// <summary>
        /// 运营商ICCID
        /// </summary>
        [JsonProperty("ICCID")]
        public string ICCID{ get; set; }

        /// <summary>
        /// 设备码
        /// </summary>
        [JsonProperty("IMEI")]
        public string IMEI{ get; set; }

        /// <summary>
        /// 卡片状态
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 运营商 1移动 2联通 3电信
        /// </summary>
        [JsonProperty("TeleOperator")]
        public ulong? TeleOperator{ get; set; }

        /// <summary>
        /// 标签ID
        /// </summary>
        [JsonProperty("TagID")]
        public ulong? TagID{ get; set; }

        /// <summary>
        /// 策略ID
        /// </summary>
        [JsonProperty("TacticID")]
        public ulong? TacticID{ get; set; }

        /// <summary>
        /// 设备在线状态 0 未激活 1 在线 2 离线
        /// </summary>
        [JsonProperty("LinkedState")]
        public long? LinkedState{ get; set; }

        /// <summary>
        /// 标签ID 集合
        /// </summary>
        [JsonProperty("TagIDs")]
        public long?[] TagIDs{ get; set; }

        /// <summary>
        /// 翻页大小, 默认翻页大小为10，最大数量为500
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 翻页起始
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LinkID", this.LinkID);
            this.SetParamSimple(map, prefix + "ICCID", this.ICCID);
            this.SetParamSimple(map, prefix + "IMEI", this.IMEI);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "TeleOperator", this.TeleOperator);
            this.SetParamSimple(map, prefix + "TagID", this.TagID);
            this.SetParamSimple(map, prefix + "TacticID", this.TacticID);
            this.SetParamSimple(map, prefix + "LinkedState", this.LinkedState);
            this.SetParamArraySimple(map, prefix + "TagIDs.", this.TagIDs);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
        }
    }
}

