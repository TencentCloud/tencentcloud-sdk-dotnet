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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyMessageRecordFeedbackRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>需要反馈的消息记录ID</p>
        /// </summary>
        [JsonProperty("RecordId")]
        public string RecordId{ get; set; }

        /// <summary>
        /// <p>消息记录所属应用的授权AppKey</p>
        /// </summary>
        [JsonProperty("AppKey")]
        public string AppKey{ get; set; }

        /// <summary>
        /// <p>反馈分值</p><p>枚举值：</p><ul><li>0： 取消点赞或点踩</li><li>1： 点赞</li><li>2： 点踩</li></ul>
        /// </summary>
        [JsonProperty("Score")]
        public ulong? Score{ get; set; }

        /// <summary>
        /// <p>反馈的原因列表</p>
        /// </summary>
        [JsonProperty("ReasonList")]
        public string[] ReasonList{ get; set; }

        /// <summary>
        /// <p>反馈的补充内容</p>
        /// </summary>
        [JsonProperty("FeedbackContent")]
        public string FeedbackContent{ get; set; }

        /// <summary>
        /// <p>消息记录所属的应用ID</p>
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamSimple(map, prefix + "AppKey", this.AppKey);
            this.SetParamSimple(map, prefix + "Score", this.Score);
            this.SetParamArraySimple(map, prefix + "ReasonList.", this.ReasonList);
            this.SetParamSimple(map, prefix + "FeedbackContent", this.FeedbackContent);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
        }
    }
}

