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

namespace TencentCloud.Lcic.V20220817.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QuestionInfo : AbstractModel
    {
        
        /// <summary>
        /// 问题ID
        /// </summary>
        [JsonProperty("QuestionId")]
        public string QuestionId{ get; set; }

        /// <summary>
        /// 问题内容
        /// </summary>
        [JsonProperty("QuestionContent")]
        public string QuestionContent{ get; set; }

        /// <summary>
        /// 倒计时答题设置的秒数（0 表示不计时）
        /// </summary>
        [JsonProperty("Duration")]
        public ulong? Duration{ get; set; }

        /// <summary>
        /// 正确答案（按照位表示是否选择，如0x1表示选择A，0x11表示选择AB）
        /// </summary>
        [JsonProperty("CorrectAnswer")]
        public long? CorrectAnswer{ get; set; }

        /// <summary>
        /// 每个选项答题人数统计
        /// </summary>
        [JsonProperty("AnswerStats")]
        public AnswerStat[] AnswerStats{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "QuestionId", this.QuestionId);
            this.SetParamSimple(map, prefix + "QuestionContent", this.QuestionContent);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "CorrectAnswer", this.CorrectAnswer);
            this.SetParamArrayObj(map, prefix + "AnswerStats.", this.AnswerStats);
        }
    }
}

