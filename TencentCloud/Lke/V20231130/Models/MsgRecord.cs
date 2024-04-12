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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MsgRecord : AbstractModel
    {
        
        /// <summary>
        /// 内容
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// 记录ID
        /// </summary>
        [JsonProperty("RecordId")]
        public string RecordId{ get; set; }

        /// <summary>
        /// 关联记录ID
        /// </summary>
        [JsonProperty("RelatedRecordId")]
        public string RelatedRecordId{ get; set; }

        /// <summary>
        /// 是否来自自己
        /// </summary>
        [JsonProperty("IsFromSelf")]
        public bool? IsFromSelf{ get; set; }

        /// <summary>
        /// 发送者名称
        /// </summary>
        [JsonProperty("FromName")]
        public string FromName{ get; set; }

        /// <summary>
        /// 发送者头像
        /// </summary>
        [JsonProperty("FromAvatar")]
        public string FromAvatar{ get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        [JsonProperty("Timestamp")]
        public string Timestamp{ get; set; }

        /// <summary>
        /// 是否已读
        /// </summary>
        [JsonProperty("HasRead")]
        public bool? HasRead{ get; set; }

        /// <summary>
        /// 评价
        /// </summary>
        [JsonProperty("Score")]
        public ulong? Score{ get; set; }

        /// <summary>
        /// 是否评分
        /// </summary>
        [JsonProperty("CanRating")]
        public bool? CanRating{ get; set; }

        /// <summary>
        /// 记录类型
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// 引用来源
        /// </summary>
        [JsonProperty("References")]
        public MsgRecordReference[] References{ get; set; }

        /// <summary>
        /// 评价原因
        /// </summary>
        [JsonProperty("Reasons")]
        public string[] Reasons{ get; set; }

        /// <summary>
        /// 是否大模型
        /// </summary>
        [JsonProperty("IsLlmGenerated")]
        public bool? IsLlmGenerated{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamSimple(map, prefix + "RelatedRecordId", this.RelatedRecordId);
            this.SetParamSimple(map, prefix + "IsFromSelf", this.IsFromSelf);
            this.SetParamSimple(map, prefix + "FromName", this.FromName);
            this.SetParamSimple(map, prefix + "FromAvatar", this.FromAvatar);
            this.SetParamSimple(map, prefix + "Timestamp", this.Timestamp);
            this.SetParamSimple(map, prefix + "HasRead", this.HasRead);
            this.SetParamSimple(map, prefix + "Score", this.Score);
            this.SetParamSimple(map, prefix + "CanRating", this.CanRating);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "References.", this.References);
            this.SetParamArraySimple(map, prefix + "Reasons.", this.Reasons);
            this.SetParamSimple(map, prefix + "IsLlmGenerated", this.IsLlmGenerated);
        }
    }
}

