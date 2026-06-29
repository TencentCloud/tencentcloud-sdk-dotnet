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

    public class SkillNotice : AbstractModel
    {
        
        /// <summary>
        /// 通知级别
        /// 
        /// 枚举值:
        /// | uint | 描述 |
        /// | --- | --- |
        /// | 0 | 占位 |
        /// | 1 | 成功，字符串面："success" |
        /// | 2 | 警告，字符串面："warning" |
        /// | 3 | 错误，字符串面："error" |
        /// </summary>
        [JsonProperty("Level")]
        public long? Level{ get; set; }

        /// <summary>
        /// 文案（i18n 后字符串）
        /// </summary>
        [JsonProperty("NoticeContent")]
        public string NoticeContent{ get; set; }

        /// <summary>
        /// 触发本通知的 Skill 版本ID
        /// </summary>
        [JsonProperty("TriggerVersionId")]
        public string TriggerVersionId{ get; set; }

        /// <summary>
        /// 通知类型 
        /// 
        /// 枚举值:
        /// | uint | 描述 |
        /// | --- | --- |
        /// | 0 | 占位 |
        /// | 1 | 发布失败 |
        /// | 2 | 共享审批被拒 |
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "NoticeContent", this.NoticeContent);
            this.SetParamSimple(map, prefix + "TriggerVersionId", this.TriggerVersionId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

