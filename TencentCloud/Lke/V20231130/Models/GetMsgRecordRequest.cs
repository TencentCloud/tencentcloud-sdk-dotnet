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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetMsgRecordRequest : AbstractModel
    {
        
        /// <summary>
        /// 类型
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// 数量,  数量需大于2, 最大1000
        /// </summary>
        [JsonProperty("Count")]
        public ulong? Count{ get; set; }

        /// <summary>
        /// 会话sessionid
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// 应用AppKey, 当Type=5[API访客]时, 该字段必填  :</br>  获取方式:</br>   1、应用发布后在应用页面[发布管理]-[调用信息]-[API管理]处获取</br>   2、参考 https://cloud.tencent.com/document/product/1759/109469 第二项
        /// </summary>
        [JsonProperty("BotAppKey")]
        public string BotAppKey{ get; set; }

        /// <summary>
        /// 场景, 体验: 1; 正式: 2
        /// </summary>
        [JsonProperty("Scene")]
        public ulong? Scene{ get; set; }

        /// <summary>
        /// 最后一条记录ID， 消息从后往前获取
        /// 
        /// MidRecordId与LastRecordId只能选择一个
        /// </summary>
        [JsonProperty("LastRecordId")]
        public string LastRecordId{ get; set; }

        /// <summary>
        /// 传该值，代表拉取该记录id的前后总共count条消息记录
        /// 
        /// MidRecordId与LastRecordId只能选择一个
        /// </summary>
        [JsonProperty("MidRecordId")]
        public string MidRecordId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "BotAppKey", this.BotAppKey);
            this.SetParamSimple(map, prefix + "Scene", this.Scene);
            this.SetParamSimple(map, prefix + "LastRecordId", this.LastRecordId);
            this.SetParamSimple(map, prefix + "MidRecordId", this.MidRecordId);
        }
    }
}

